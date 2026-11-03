using System.ComponentModel.Design;
using System.Globalization;
using VetClinic.Models;
using VetClinic.Repositories;
using VetClinic.Services;
using VetClinic.UI;

MainMenu mm = new MainMenu();
mm.start();
AdminMenu am = new AdminMenu();
am.show();
StaffMenu sm = new StaffMenu();
sm.show();