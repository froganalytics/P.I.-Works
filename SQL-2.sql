SELECT username, emailaddress
FROM i_users
WHERE UserId =
  (SELECT UserId
    FROM i_user_login_logs
    WHERE UserId !=
      (SELECT UserId
        FROM i_users
        WHERE username = 'Administrator')
    Group by(UserId)
    ORDER BY COUNT(*) DESC
    LIMIT 1)
