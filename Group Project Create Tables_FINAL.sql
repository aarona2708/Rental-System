DROP FUNCTION IF EXISTS user_allowed_to_rent_another_movie
GO
-- Return 1 if user is allowed to rent another movie. If 0, 
-- user currently has the maximum number of movies rented.
CREATE FUNCTION user_allowed_to_rent_another_movie(@account_number INT)
RETURNS BIT
AS
BEGIN
	DECLARE @outstanding INT
	DECLARE @allowed INT
	DECLARE @result BIT
	SELECT @outstanding = 
		COUNT(customer_id) 
		FROM orders WHERE customer_id = @account_number AND time_in IS NULL
	SELECT @allowed =
		rental_limit
		FROM account_types a JOIN customers c ON a.account_type = c.account_type
		WHERE c.account_number = @account_number
	IF (@outstanding - 1) < @allowed SELECT @result = 1 ELSE SELECT @result = 0

	RETURN @result
END
GO

DROP TABLE IF EXISTS account_types
CREATE TABLE account_types(
	account_type INT NOT NULL,
	monthly_cost INT NOT NULL,
	rental_limit INT NOT NULL,
	PRIMARY KEY(account_type)
)

DROP TABLE IF EXISTS movies 
CREATE TABLE movies(
    id INT IDENTITY(1,1) NOT NULL,
    title VARCHAR(64) NOT NULL,
    genre VARCHAR(7), -- 7 being the length of the longest category
    copies_in_stock INT,
    PRIMARY KEY(id),
    CONSTRAINT check_genre_is_allowed
        CHECK (genre IN ('Comedy', 'Drama', 'Action', 'Foreign')),
    CONSTRAINT check_stock_not_below_zero
        CHECK (copies_in_stock >= 0)
)

DROP TABLE IF EXISTS actors
CREATE TABLE actors(
    id INT IDENTITY(1,1) NOT NULL,
    name VARCHAR(128) NOT NULL,
    age INT NOT NULL,
    PRIMARY KEY(id),
    CONSTRAINT check_actor_age_not_negative
        CHECK (age >= 0) -- actor cannot be negative-years-old
)

DROP TABLE IF EXISTS customers
CREATE TABLE customers(
    account_number INT IDENTITY(1,1) NOT NULL,
    account_type INT NOT NULL, -- account is one of four different types
    account_creation_date SMALLDATETIME CONSTRAINT default_creation_date DEFAULT CURRENT_TIMESTAMP NOT NULL,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(40) NOT NULL,
    address VARCHAR(128) NOT NULL,
    city VARCHAR(64) NOT NULL,
    state CHAR(2) NOT NULL,
    zip_code VARCHAR(6) NOT NULL,
    phone_no CHAR(14) NOT NULL, -- allows storage of phone numbers with area code, country code, and hyphens (e.g. 1-780-555-1234)
    credit_card_no CHAR(16),
	PRIMARY KEY(account_number),
	CONSTRAINT fk_a_account_type FOREIGN KEY (account_type) REFERENCES account_types(account_type) ON DELETE CASCADE,
    CONSTRAINT check_account_type_is_valid
        CHECK (account_type >= 1 AND account_type <= 4)
)

DROP TABLE IF EXISTS employees
CREATE TABLE employees(
    ssn CHAR(11), -- Canadian & American SSNs are 9 digits + 2 hyphens
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(40) NOT NULL,
    address VARCHAR(128) NOT NULL,
    city VARCHAR(64) NOT NULL,
    state CHAR(2) NOT NULL, -- e.g. AB, BC, NY, etc
    zip_code VARCHAR(6) NOT NULL, -- max length of 6 (Canadian postal codes) but allows for 5 (US)
    phone_no CHAR(14) NOT NULL,
    start_date SMALLDATETIME CONSTRAINT default_start_date DEFAULT CURRENT_TIMESTAMP,
    hourly_rate DECIMAL(4,2),
	PRIMARY KEY(ssn),
    CONSTRAINT check_wage_not_negative
        CHECK (hourly_rate >= 0)
)

SELECT account_type, customer_id, COUNT(customer_id) 
FROM orders o JOIN customers c ON o.customer_id = c.account_number
WHERE customer_id = 78 AND time_in IS NULL
GROUP BY account_type, customer_id

INSERT INTO orders(movie_id, customer_id, employee_ssn)
VALUES (3, 78, '117-29-3880')
SELECT COUNT(customer_id) currently_rented, a.account_type, rental_limit 
FROM orders o JOIN customers c ON o.customer_id = c.account_number JOIN account_types a ON c.account_type = a.account_type 
WHERE customer_id = 78 AND time_in IS NULL
GROUP BY a.account_type, rental_limit
IF dbo.user_allowed_to_rent_another_movie(78) = 1 SELECT 'TRUE' ELSE SELECT 'FALSE'

DROP TABLE IF EXISTS orders
CREATE TABLE orders(
    id INT IDENTITY(1,1) NOT NULL,
    movie_id INT NOT NULL,
    customer_id INT NOT NULL,
    time_out SMALLDATETIME CONSTRAINT default_rent_date DEFAULT CURRENT_TIMESTAMP NOT NULL,
    time_in SMALLDATETIME,
    employee_ssn CHAR(11) NOT NULL, -- 9 digits + 2 hyphens
    PRIMARY KEY(id),
    CONSTRAINT fk_o_movie_id FOREIGN KEY(movie_id) REFERENCES movies(id) ON DELETE CASCADE,
    CONSTRAINT fk_o_customer_id FOREIGN KEY(customer_id) REFERENCES customers(account_number) ON DELETE CASCADE,
    CONSTRAINT fk_o_employee_id FOREIGN KEY(employee_ssn) REFERENCES employees(ssn) ON DELETE CASCADE,
    CONSTRAINT check_return_date_not_before_rent_date
        CHECK (time_out < time_in),
	CONSTRAINT check_customer_not_over_limit
		CHECK (dbo.user_allowed_to_rent_another_movie(customer_id)=1)
)

DROP TABLE IF EXISTS movie_ratings
CREATE TABLE movie_ratings(
    customer_account_number INT NOT NULL,
    movie_id INT NOT NULL,
    rating INT NOT NULL,
    PRIMARY KEY(customer_account_number, movie_id),
    CONSTRAINT fk_mr_customer_account_number FOREIGN KEY (customer_account_number) REFERENCES customers(account_number) ON DELETE CASCADE,
    CONSTRAINT fk_mr_movie_id FOREIGN KEY (movie_id) REFERENCES movies(id) ON DELETE CASCADE
)

DROP TABLE IF EXISTS actor_ratings
CREATE TABLE actor_ratings(
    customer_account_number INT NOT NULL,
    actor_id INT NOT NULL,
    rating INT NOT NULL,
    PRIMARY KEY(customer_account_number, actor_id),
    CONSTRAINT fk_ar_customer_account_number FOREIGN KEY (customer_account_number) REFERENCES customers(account_number) ON DELETE CASCADE,
    CONSTRAINT fk_ar_actor_id FOREIGN KEY (actor_id) REFERENCES actors(id) ON DELETE CASCADE
)

DROP TABLE IF EXISTS movie_appearances
CREATE TABLE movie_appearances(
    actor_id INT NOT NULL,
    movie_id INT NOT NULL,
    PRIMARY KEY(actor_id, movie_id),
    CONSTRAINT fk_ma_actor_id FOREIGN KEY(actor_id) REFERENCES actors(id) ON DELETE CASCADE,
    CONSTRAINT fk_ma_movie_id FOREIGN KEY(movie_id) REFERENCES movies(id) ON DELETE CASCADE
)

DROP TABLE IF EXISTS customer_watchlist
CREATE TABLE customer_watchlist(
    customer_id INT NOT NULL,
    movie_id INT NOT NULL,
    PRIMARY KEY(customer_id, movie_id),
    CONSTRAINT fk_cw_customer_id FOREIGN KEY(customer_id) REFERENCES customers(account_number) ON DELETE CASCADE,
    CONSTRAINT fk_cw_movie_id FOREIGN KEY(movie_id) REFERENCES movies(id) ON DELETE CASCADE
)

