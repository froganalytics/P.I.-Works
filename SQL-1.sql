SELECT COUNT(*)
FROM(
	SELECT userId, COUNT(*) as count_t
	FROM [i_user_login_logs]
	Group by(userId)
	HAVING COUNT(*) >3)   
