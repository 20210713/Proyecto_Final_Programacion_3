// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
ITakesScreenshot screenshot = ((ITakesScreenshot)driver);

driver.Navigate().GoToUrl("https://www.saucedemo.com/");
Screenshot p0 = screenshot.GetScreenshot();
p0.SaveAsFile("./SCREENSHOTS DE PRUEBA/Login.png");

IWebElement user = driver.FindElement(By.Id("user-name"));
IWebElement pass = driver.FindElement(By.Id("password"));
IWebElement login = driver.FindElement(By.Id("login-button"));

//Prueba 1: Acceso con campos vacios
login.Click();
Screenshot p1 = screenshot.GetScreenshot();
p1.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 1 - campos vacios.png");

//Prueba 2: Usuario y contraseña correcta
user.SendKeys("standard_user");
pass.SendKeys("secret_sauce");
Screenshot p2 = screenshot.GetScreenshot();
p2.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 2 - Usuario y contraseña correcta.png");
login.Click();
p2 = screenshot.GetScreenshot();
p2.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 2 - Pagina Principal.png");

//Prueba 3: Agregar objetos al Carrito
IWebElement mochila = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
IWebElement luz = driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
IWebElement carrito = driver.FindElement(By.ClassName("shopping_cart_link"));
mochila.Click();
Screenshot p3 = screenshot.GetScreenshot();
p3.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 3 - Seleccionar mochila.png");
luz.Click();
p3 = screenshot.GetScreenshot();
p3.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 3 - Seleccionar luz.png");
carrito.Click();
p3 = screenshot.GetScreenshot();
p3.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 3 - Carrito.png");

//Prueba 4: Checkout con datos vacios
IWebElement checkout = driver.FindElement(By.Id("checkout"));
checkout.Click();
Screenshot p4 = screenshot.GetScreenshot();
p4.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 4 - Checkout.png");
IWebElement nombre = driver.FindElement(By.Id("first-name"));
IWebElement apellido = driver.FindElement(By.Id("last-name"));
IWebElement codigo = driver.FindElement(By.Id("postal-code"));
IWebElement con = driver.FindElement(By.Id("continue"));
con.Click();
p4 = screenshot.GetScreenshot();
p4.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 4 - Checkout Error.png");

//Prueba 5: Checkout con datos validos
nombre.SendKeys("Jorge Miguel");
apellido.SendKeys("Paulino Luciano");
codigo.SendKeys("20210713");
Screenshot p5 = screenshot.GetScreenshot();
p5.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 5 - Checkout con datos.png");
con.Click();
p5 = screenshot.GetScreenshot();
p5.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 5 - Confirmar.png");
IWebElement fin = driver.FindElement(By.Id("finish"));
fin.Click();
p5 = screenshot.GetScreenshot();
p5.SaveAsFile("./SCREENSHOTS DE PRUEBA/Prueba 5 - Checkout completo.png");

driver.Quit();