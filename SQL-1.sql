SELECT COUNT(*)
FROM(
	SELECT userId
	FROM [i_user_login_logs]
	Group by(userId)
	HAVING COUNT(*) >3)   
