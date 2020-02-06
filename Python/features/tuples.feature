Feature: Create a simple list of values to represent a point in 3d space

    Scenario: A tuple with w=1.0 is a point
    Given a = tuple(4.3, -4.2, 1.0)
    Then a.x = 4.3
     And a.y = -4.2
     And a.z = 3.1
     And a.w = 1.0
     And a is a point
     And a is not a vector