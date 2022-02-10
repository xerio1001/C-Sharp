CREATE DATABASE `tournament` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

CREATE TABLE `matchups` (
  `id` int NOT NULL AUTO_INCREMENT,
  `WinnerID` int DEFAULT NULL,
  `MatchupRound` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `WinnerFK_idx` (`WinnerID`),
  CONSTRAINT `FK_matchups_teams_WinnerID` FOREIGN KEY (`WinnerID`) REFERENCES `teams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `people` (
  `id` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(45) DEFAULT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `EmailAddress` varchar(45) DEFAULT NULL,
  `CellphoneNumber` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `prizes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `PlaceNumber` int DEFAULT NULL,
  `PlaceName` varchar(45) DEFAULT NULL,
  `PrizeAmount` decimal(20,0) DEFAULT NULL,
  `PrizePercentage` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `teammembers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `TeamId` int DEFAULT NULL,
  `PersonID` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `TeamFK_idx` (`TeamId`),
  KEY `PersonFK_idx` (`PersonID`),
  CONSTRAINT `FK_teammember_people_PersonID` FOREIGN KEY (`PersonID`) REFERENCES `people` (`id`),
  CONSTRAINT `FK_teammember_teams_TeamID` FOREIGN KEY (`TeamId`) REFERENCES `teams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `teams` (
  `id` int NOT NULL AUTO_INCREMENT,
  `TeamName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `tournamententries` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tournamentID` int DEFAULT NULL,
  `TeamID` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `tournamentFK_idx` (`tournamentID`),
  KEY `TeamFK_idx` (`TeamID`),
  CONSTRAINT `FK_tournamententries_teams_TeamID` FOREIGN KEY (`TeamID`) REFERENCES `teams` (`id`),
  CONSTRAINT `FK_tournamententries_tournaments_TournamentID` FOREIGN KEY (`tournamentID`) REFERENCES `tournaments` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `tournamentprizes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `TournamentID` int DEFAULT NULL,
  `PrizeID` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `PrizeFK_idx` (`PrizeID`),
  KEY `TournamentPrizeFK_idx` (`TournamentID`),
  CONSTRAINT `FK_tournamentprizes_prizes_PrizeID` FOREIGN KEY (`PrizeID`) REFERENCES `prizes` (`id`),
  CONSTRAINT `FK_tournamentprizes_tournaments_TournamentID` FOREIGN KEY (`TournamentID`) REFERENCES `tournaments` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `tournaments` (
  `id` int NOT NULL AUTO_INCREMENT,
  `TournamentName` varchar(45) DEFAULT NULL,
  `entryFee` decimal(20,0) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `matchupentries` (
  `id` int NOT NULL AUTO_INCREMENT,
  `MatchupID` int DEFAULT NULL,
  `ParentMatchupID` int DEFAULT NULL,
  `TeamCompetingID` int DEFAULT NULL,
  `Score` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `MatchupID_idx` (`MatchupID`),
  KEY `ParentMatchupFK_idx` (`ParentMatchupID`),
  KEY `TeamCompetingFK_idx` (`TeamCompetingID`),
  CONSTRAINT `FK_matchupentries_matchups_matchupID` FOREIGN KEY (`MatchupID`) REFERENCES `matchups` (`id`),
  CONSTRAINT `FK_matchupentries_matchups_ParentMatchupID` FOREIGN KEY (`ParentMatchupID`) REFERENCES `matchups` (`id`),
  CONSTRAINT `FK_matchupentries_teams_TeamCompetingID` FOREIGN KEY (`TeamCompetingID`) REFERENCES `teams` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
