using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using Model;
using ZdravoHospital.Windows;

namespace ZdravoHospital.Validation
{
    public class MinMaxFloorValidationRule : ValidationRule
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public static bool noError;
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            noError = false;
            try
            {
                int floor;
                var floorString = value as string;
                bool converted = int.TryParse(floorString, out floor);
                if (!converted)
                {
                    return new ValidationResult(false, "Enter a valid\ninteger value.");
                }

                if (floor < Min) return new ValidationResult(false, "The lowest\nfloor is 0!");

                if (floor > Max) return new ValidationResult(false, "The highest\nfloor is 3!");

                noError = true;
                return new ValidationResult(true, null);
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }

        }
    }

    public class RoomIdValidationRule : ValidationRule
    {

        public static bool noError;
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            noError = false;
            var s = value as string;
            List<Room> rooms = ManagerWindow.roomController.GetRooms();
            foreach (Room r in rooms)
            {
                if (r.Id == s)
                {
                    return new ValidationResult(false, "Id already exists!");
                }
            }

            if (!Regex.IsMatch(s, @"[A-Z]*[0-9]+"))
            {
                return new ValidationResult(false, "Wrong format");
            }
            else
            {
                noError = true;
                return new ValidationResult(true, null);
            }
        }
    }
}

