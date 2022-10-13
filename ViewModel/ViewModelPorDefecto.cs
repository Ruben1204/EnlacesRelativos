using EnlacesRelativos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnlacesRelativos.ViewModel
{
    public class ViewModelPorDefecto
    {
        public ObservableCollection<Empleado> Employees { get; set; }

         

        public ICommand EliminarCommand { get; set; }
        public ViewModelPorDefecto()
        {
           
            Employees = new ObservableCollection<Empleado>
            {
                new Empleado{nombre = "Ruben",Descripcion = "Programador",estado = true},
                new Empleado{nombre = "Dario",Descripcion = "Developer",estado = true},
                new Empleado{nombre = "Steven",Descripcion = "Developer",estado = true}
            };

            EliminarCommand = new Command(
                execute: () =>
                    {
                        Employees.Remove(Employees[0]);
                    },
                canExecute: () =>
                {
                    return true;


                });
        }
    }
}
