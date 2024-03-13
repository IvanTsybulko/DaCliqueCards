Here is the description of the DaCliqueCardsApp Project.

The goal of this project is to make make easier the system of buying and checking cards for dance classes. The program allows the coaches to add their students to a data base and create cards with different amount of attendances for them. They can also create Class sessions and check their students cards when they attend the class. That way it is easy to track which student atended which training.

		CLASSES


	1. Student 

The student class represent a model for each student that is registered in the system.
The Student has the following properties: Id, FirstName, LastName, Age and PhoneNumber. The Id is identical for each student and each new students is created with an id. The names are mainly used for the users facilitation. They make the shearching of the students easier and visualy more recognisable. The Age and the number are additional information that may help the coach if they experience difficulties recognising or contacting the student.
FullInfo is used to get the most important info about the student.

The Class has 4 methods. 
HasActiveCard gets the last student card from the database and checks if it is still usable (has attendances left an has not expired). 
Cards gets all the student cards from the database. 
EndDate returns a the expire date of the card if it is still active.
AtendancesLeft checks and returns how many attendances are left in the card.

////To do: Add verifications for the properties.


	2. Card

The Card class has the following properties Id, cardExampleId, startingDate, endDate, classesLeft, studentId, coachId. CardExampleId shows which type of card has the student bought, they have different amount of attendances and different price. StaringDate shows when the card starts (the coach can decide when the card start based on a range of factors). EndDate is always 40 days after the start and shows the the card expires. classesLeft is how many attendaces has the student before the card is no more usable. StudentId shows whom the card is and the CoachId shows who created the card.

////To do: Add verifications for the properties.


	3.Place

The Place class is used to show in which spot a class is made. That is crucial in order for the classes to not cross with each other. The class has the following properties Id, name, pricePerhour, location. The name is used for the users comfort. The price per hour shows how much the coach has to pay for rent and the loaction is the address of the studio.

////To do: Add verifications for the properties.


	4.Class

Class is the training on which the students go. It can be in multiple places, can be any length over 1 hour and the Coach decides how many attendances to check on the students cards based on the length of the training and additional factors. It has the following properties. ClassDuration showing how long it is, AttendancesCount showing how many attendaces should be checked, PlaceId showing the spot of the class and date showing when it is. The FullInfo gives a report obout the class.

The class Class has 2 methods.
ChoachNameFromId gets the name of the coach who created the class.
PlaceNameFromId gets the name of the place where the training is happening.
