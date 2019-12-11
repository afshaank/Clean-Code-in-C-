using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCodeBadCode.CH03.Cohesion
{
    public class LowCohesion
    {
        public void ConnectToDatasource() { }
        public void ExtractDataFromDataSource() { }
        public void TransformDataForReport() { }
        public void AssignDataAndGenerateReport() { }
        public void PrintReport() { }
        public void CloseConnectionToDataSource() { }
    }
}
