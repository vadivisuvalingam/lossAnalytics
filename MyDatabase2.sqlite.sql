BEGIN TRANSACTION;
CREATE TABLE highscores (name varchar(20), score int);
INSERT INTO `highscores` VALUES ('Me',9001);
CREATE TABLE "MealType" (
	`MealTypeName`	TEXT,
	`Order`	INTEGER
);
INSERT INTO `MealType` VALUES ('Breakfast',1);
INSERT INTO `MealType` VALUES ('asdf',2);
INSERT INTO `MealType` VALUES ('lunch',2);
COMMIT;
