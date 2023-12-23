using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using static slau.SlauMethod;

namespace mnk {
  public static class MnkMethods {
    private static string textFunction;
    public static string TextFunction {
      get {
        return textFunction;
      }
      set {
        if (FunctionParser.Expression.IsExpression(value, idsNames)) {
          textFunction = value;
        } else {
          throw new Exception("Функция написана неверно !!!");
        }
      }
    }
    public static string[] idsNames;
    public static double[] idsValues;

    public static double[] LinearRegression(List<double> xValues, List<double> yValues) {
      double[] parametres = new double[2];

      double sumXY = 0;
      double sumX = 0;
      double sumY = 0;
      double sumX2 = 0;

      for (int index = 0; index < xValues.Count; ++index) {
        sumXY += xValues[index] * yValues[index];
        sumX += xValues[index];
        sumY += yValues[index];
        sumX2 += xValues[index] * xValues[index];
      }

      parametres[0] = (xValues.Count * sumXY - sumX * sumY) / (xValues.Count * sumX2 - sumX * sumX);
      parametres[1] = (sumY - parametres[0] * sumX) / xValues.Count;

      return parametres;
    }

    public static double[] ParabolRegression(List<double> xValues, List<double> yValues) {
      double[] parametres;

      double sumXY = 0;
      double sumX = 0;
      double sumY = 0;
      double sumX2 = 0;
      double sumX3 = 0;
      double sumX4 = 0;
      double sumYX2 = 0;

      for (int index = 0; index < xValues.Count; ++index) {
        sumXY += xValues[index] * yValues[index];
        sumX += xValues[index];
        sumY += yValues[index];
        sumX2 += xValues[index] * xValues[index];
        sumX3 += xValues[index] * xValues[index] * xValues[index];
        sumX4 += Math.Pow(xValues[index], 4);
        sumYX2 += yValues[index] * (xValues[index] * xValues[index]);
      }

      double[] resMatrix = new double[] {
        sumY, sumXY, sumYX2
      };

      double[,] matrix = new double[,] {
        { xValues.Count, sumX, sumX2 },
        { sumX, sumX2, sumX3 },
        { sumX2, sumX3, sumX4 }
      };

      parametres = MethodGauss(matrix, resMatrix, 3);

      return parametres;
    }

    public static double[] ParamRegression(List<double> xValues, List<double> yValues) {
      double[] parametres;

      double sumX = 0;
      double sumX2 = 0;
      double sumLnY = 0;
      double sumXLnY = 0;

      for (int index = 0; index < xValues.Count; ++index) {
        sumX += xValues[index];
        sumX2 += xValues[index] * xValues[index];
        sumLnY += Math.Log(yValues[index]);
        sumXLnY += xValues[index] * Math.Log(yValues[index]);
      }

      if (double.IsNaN(sumLnY) || double.IsNaN(sumXLnY)) {
        throw new Exception("Значения Y должны быть больше нуля !!!");
      }

      double[] resMatrix = new double[] {
        sumLnY, sumXLnY
      };

      double[,] matrix = new double[,] {
        { xValues.Count, sumX },
        { sumX, sumX2 }
      };

      parametres = MethodGauss(matrix, resMatrix, 2);

      parametres[0] = Math.Pow(Math.E, parametres[0]);



      return parametres;
    }

    public static double Fun(double x) {
      if (FunctionParser.Expression.IsExpression(TextFunction, idsNames)) {
        FunctionParser.Expression expression = new FunctionParser.Expression(TextFunction, idsNames, null);

        idsValues[0] = x;

        double res = expression.CalculateValue(idsValues);

        return res;
      } else {
        throw new Exception("Функция написана неверно !!!");
      }
    }

    public static double ErrorEstimation(List<double> xValues, List<double> yValues, string textFunc) {
      textFunction = textFunc;

      double errorEstimation = 0;

      for (int index = 0; index < xValues.Count(); ++index) {
        errorEstimation += Math.Pow(yValues[index] - Fun(xValues[index]), 2);
      }

      return errorEstimation;
    }

    public static double KoefDeter(List<double> xValues, List<double> yValues, string textFunc) {
      textFunction = textFunc;

      double ySr = 0;

      for (int index = 0; index < yValues.Count(); ++index) {
        ySr += yValues[index];
      }

      ySr /= yValues.Count();

      double numerator = 0;
      double denominator = 0;

      for (int index = 0; index < xValues.Count(); ++index) {
        numerator += Math.Pow(yValues[index] - Fun(xValues[index]), 2);
      }

      for (int index = 0; index < xValues.Count(); ++index) {
        denominator += Math.Pow(yValues[index] - ySr, 2);
      }

      return 1 - (numerator / denominator);
    }
  }
}
