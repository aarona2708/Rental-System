ALTER TABLE movies
DROP CONSTRAINT check_genre_is_allowed, check_stock_not_below_zero
ALTER TABLE actors
DROP CONSTRAINT check_actor_age_not_negative
ALTER TABLE customers
DROP CONSTRAINT check_account_type_is_valid, default_creation_date, fk_a_account_type
ALTER TABLE employees
DROP CONSTRAINT check_wage_not_negative, default_start_date
ALTER TABLE orders
DROP CONSTRAINT check_return_date_not_before_rent_date, default_rent_date, fk_o_movie_id, fk_o_customer_id, fk_o_employee_id, check_customer_not_over_limit
ALTER TABLE movie_ratings
DROP CONSTRAINT fk_mr_customer_account_number, fk_mr_movie_id
ALTER TABLE movie_appearances
DROP CONSTRAINT fk_ma_actor_id, fk_ma_movie_id
ALTER TABLE actor_ratings
DROP CONSTRAINT fk_ar_actor_id, fk_ar_customer_account_number
ALTER TABLE customer_watchlist
DROP CONSTRAINT fk_cw_customer_id, fk_cw_movie_id