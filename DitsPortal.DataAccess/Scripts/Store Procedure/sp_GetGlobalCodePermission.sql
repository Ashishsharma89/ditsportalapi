	DELIMITER $$
	CREATE PROCEDURE `sp_GetGlobalCodePermission`(
		IN id INT,
		IN deletedby VARCHAR(50)
	)
	BEGIN
		
	   SELECT * from globalcodecategories as gcc
	
	END$$
	DELIMITER ;
	