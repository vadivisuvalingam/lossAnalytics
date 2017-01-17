# lossAnalytics
Personal Food Diary (current active project)

Currently this is being built on top of the basic application VS2015 creates for you for an standard ASP.NET MVC app.  It is slowly being customized to meet the 1st iteration of the design goal.  Below are listed the data items that will be part of the application

KeyMetricType
	Name

KeyMetric
	Name
	KeyMetricType
	Value	

Meal
	Name
	List<KeyMetrics>

RecentMeals
	List<Meal>

MealType	
	Name
	Order

Meals
	Name
	Date
	MealType
	List<Meal>
  
The first iteration of the application will just be static html forms that are served entirely by the MVC framework.  The backend chosen for this project is the SQLLite database.
