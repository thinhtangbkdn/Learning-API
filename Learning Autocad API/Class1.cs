using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using AutoCad
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows.Data;
using Application = Autodesk.AutoCAD.ApplicationServices.Application;
using Exception = Autodesk.AutoCAD.Runtime.Exception;

namespace Learning_Autocad_API
{
    public class Class1
    {
        [CommandMethod("HELLO")]
        public void cmdHELLO()
        {
            // Đi tới bản vẽ hiện hành
            Document doc = Application.DocumentManager.MdiActiveDocument;

            // In ra màn hình console Autocad bằng hàm `WriteMessage`
            doc.Editor.WriteMessage("Hello World");
        }
    }
}
