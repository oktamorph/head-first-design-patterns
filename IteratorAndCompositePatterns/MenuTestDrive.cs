namespace IteratorAndCompositePatterns
{
    public class MenuTestDrive
    {
        public static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            ((Menu)allMenus).Add(pancakeHouseMenu);
            ((Menu)allMenus).Add(dinerMenu);
            ((Menu)allMenus).Add(cafeMenu);
            ((Menu)allMenus).Add(dessertMenu);

            ((Menu)pancakeHouseMenu).Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99));
            ((Menu)pancakeHouseMenu).Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            ((Menu)pancakeHouseMenu).Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            ((Menu)pancakeHouseMenu).Add(new MenuItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59));

            ((Menu)dinerMenu).Add(new MenuItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));
            ((Menu)dinerMenu).Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            ((Menu)dinerMenu).Add(new MenuItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29));
            ((Menu)dinerMenu).Add(new MenuItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05));
            ((Menu)dinerMenu).Add(new MenuItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99));
            ((Menu)dinerMenu).Add(new MenuItem("Pasta", "Spaghetti with marina sauce, and a slice of soudough bread", true, 3.89));

            ((Menu)cafeMenu).Add(new MenuItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69));
            ((Menu)cafeMenu).Add(new MenuItem("Burrito", "A larte buritto, with whole pinto beans, salsa, guacamole", true, 4.29));
            ((Menu)cafeMenu).Add(new MenuItem("Veggie Burger and Air Fries", "Veggie Burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99));

            ((Menu)dessertMenu).Add(new MenuItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla ice cream", true, 1.59));
            ((Menu)dessertMenu).Add(new MenuItem("Cheesecake", "Creamy New York cheesecake, with a chocolate graham crust", true, 1.99));
            ((Menu)dessertMenu).Add(new MenuItem("Sorbet", "A scoop of raspberry and a scoop of lime", true, 1.89));

            ((Menu)dinerMenu).Add(dessertMenu);

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
        }
    }
}
