///////////////////////////////////////////////////////////
//  Equation.cs
//  Implementation of the Class Equation
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
//  Original author: Omar and Taha
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Modelisator.Model {
	public class Equation {

		public Equation(){		}

        private int m_NbrGP;

        private int m_NbrGPConnus;
        
		public double Calculer(){

			return 0;
		}

		public int NbrGP{
			get{
                return m_NbrGP;
			}
			set{
                m_NbrGP = value;
			}
		}

		public int NbrGPConnus{
			get{
                return m_NbrGPConnus;
			}
			set{
                m_NbrGPConnus = value;
			}
		}

        // calcul of Pressure of gas : p(MPa)
        static double equation1(double X1, double Tmax, double p0)
        {
            // X1 : Coefficient of variation of the pressure (dimensionless)
            // Tmax : Maximum temperature (�C)
            // p0 : Pressure of a liquid gas at 15�C (MPa)
            double p;
            p = X1 * (Math.Pow(Tmax - 15, 2)) + p0;
            return p;
        }

        // calcul ofPressure of a liquid gas at 15�C (MPa)
        static double equation23(double X1, double Tmax, double p)
        {
            // X1 : Coefficient of variation of the pressure (dimensionless)
            // Tmax : Maximum temperature (�C)
            // p :  Pressure of gas (MPa)
            double p0;
            p0 = p - (X1 * (Math.Pow(Tmax - 15, 2))) ;
            return p0;
        }

        // calcul of (MPa)Coefficient of variation of the pressure (dimensionless)
        static double equation24(double p, double Tmax, double p0)
        {
            // p : Pressure of gas (Mpa)
            // Tmax : Maximum temperature (�C)
            // p0 : Pressure of a liquid gas at 15�C (MPa)
            double X1;
            if (Tmax != 15)
                X1 = (p - p0) / (Math.Pow(Tmax - 15, 2));
            else
                X1 = -1;
            return X1;
        }

        // calcul of Maximum temperature (�C)
        static double equation25(double X1, double p, double p0)
        {
            // X1 : Coefficient of variation of the pressure (dimensionless)
            // p : Pressure of gas (MPa)
            // p0 : Pressure of a liquid gas at 15�C (MPa)
            double Tmax;
            if (X1 != 0)
                Tmax = Math.Sqrt((p - p0) / X1) + 15;
            else 
                Tmax = -1;
            return Tmax;
        }


        // calcul of Expansion of gas 
        static double equation2(double alpha_gas, double Tmax)
        {
            // Tmax : Maximum temperature (�C)
            // alpha_gas : Volumetric gaz expansion coefficient (% / �C)
            double dV;
            dV = alpha_gas * (Tmax - 15);
            return dV;
        }


        // calcul of Maximum temperature (�C) 
        static double equation26(double alpha_gas, double dV)
        {
            // dV : Expansion of gas
            // alpha_gas : Volumetric gaz expansion coefficient (% / �C)
            double Tmax;
            if (alpha_gas != 0)
                Tmax = (dV / alpha_gas) + 15;
            else
                Tmax = -1;
            return Tmax;
        }

        // calcul of  Volumetric gaz expansion coefficient (% / �C)
        static double equation26(double Tmax, double dV)
        {
            // dV : Expansion of gas
            // Tmax : Maximum temperature (�C)
            double alpha_gas;
            if (Tmax != 15)
                alpha_gas = (dV / (Tmax-15));
            else
                alpha_gas = -1;
            return alpha_gas;
        }


        // calcul of Applied strass (Mpa)
        static double equation3(double p, double R, double t)
        {
            // p : Pressure of gas (Mpa)
            // R : Radius (mm)
            // t : Thickness (mm)
            double sigma;
            if (t != 0)
                sigma = (p * R) / t;
            else
                sigma = -1;
            return sigma;

        }

        // calcul of Pressure of gas (Mpa)
        static double equation27(double sigma, double R, double t)
        {
            // sigma : Applied strass (Mpa)
            // R : Radius (mm)
            // t : Thickness (mm)
            double p;
            if (R != 0)
                p = (sigma * t) / R;
            else
                p = -1;
            return p;

        }

        // calcul of Radius (mm)
        static double equation28(double sigma, double p, double t)
        {
            // sigma : Applied strass (Mpa)
            // p : Pressure of gas (Mpa)
            // t : Thickness (mm)
            double R;
            if (p != 0)
                R = (sigma * t) / p;
            else
                R = -1;
            return R;
        }


        // calcul of Thickness (mm)
        static double equation29(double sigma, double p, double R)
        {
            // sigma : Applied strass (Mpa)
            // p : Pressure of gas (Mpa)
            // R : Radius (mm)
            double t;
            if (sigma != 0)
                t = (p * R) / sigma;
            else
                t = -1;
            return t;

        }

        // calcul of Useful thichness (mm)
        static double equation4(double p, double R, double sigma_y)
        {
            // p : Pressure of gas (Mpa)
            // R : Radius (mm)
            // sigma_y : Yield strenght (Mpa)
            double tu;
            if (sigma_y != 0)
                tu = (p * R) / sigma_y;
            else
                tu = -1;
            return tu;
        }



        // calcul of Pressure of gas (Mpa)
        static double equation30(double tu, double R, double sigma_y)
        {
            // tu : Useful thichness (mm)
            // R : Radius (mm)
            // sigma_y : Yield strenght (Mpa)
            double p;
            if (R != 0)
                p = (tu * sigma_y) / R;
            else
                p = -1;
            return p;
        }

        // calcul of Radius (mm)
        static double equation31(double tu, double p, double sigma_y)
        {
            // tu : Useful thichness (mm)
            // p : Pressure of gas (Mpa)
            // sigma_y : Yield strenght (Mpa)
            double R;
            if (p != 0)
                R = (tu * sigma_y) / p;
            else
                R
                    = -1;
            return R;
        }

        // calcul of Yield strenght (Mpa)
        static double equation32(double tu, double p, double R)
        {
            // tu : Useful thichness (mm)
            // p : Pressure of gas (Mpa)
            // R : Radius (mm)
            double sigma_y;
            if (tu != 0)
                sigma_y = (p * R) / tu;
            else
                sigma_y
                    = -1;
            return sigma_y;
        }

        // calcul of Excess thickness
        static double equation5(double t, double tu)
        {
            // t : Thickness (mm)
            // tu : Useful thichness (mm)
            double delta_t = t - tu;
            return delta_t;
        }

        // calcul of Lifespan (year)
        static double equation6(double t, double tu, double C)
        {
            // t : Thickness (mm)
            // tu : Useful thichness (mm)
            // C : Thickness loss (mm/year)
            double lifespan;
            if (C != 0)
                lifespan = (t - tu) / C;
            else
                lifespan = -1;
            return lifespan;
        }

        // calcul of Stress intensity factor for flaw size to useful thickness (Mpa racine(m))
        static double equation7(double alpha, double sigma_y, double tu)
        {
            // alpha : Correction factor (dimensionless)
            // sigma_y : Yield strenght (Mpa)
            // tu : Useful thichness (mm)
            double KI = alpha * sigma_y * Math.Sqrt(tu);
            return KI;
        }

        // calcul of Force of punching (N)
        static double equation8(double nu, double t, double sigma_y)
        {
            // t : Thickness (mm)
            // sigma_y : Yield strenght (Mpa)
            // nu : Radius of punching hole (m)
            double Fp = 2 * Math.PI * t * sigma_y;
            return Fp;
        }

        // calcul of Volume (mm3)
        static double equation9(double R, double h)
        {
            // R : Radius (mm)
            // h : Height (mm)
            double V = (Math.PI * Math.Pow(R, 2) * h);
            return V;
        }

        // calcul of Usuful mass (Kg)
        static double equation10(double V, double dV, double pg)
        {
            // V : Volume (mm3)
            // dV : Expansion of gas 
            // pg : density of gaz (kg/m3)
            double Mu = V * (1 - dV) * pg;
            return Mu;
        }

        // calcul of Surface (mm2)
        static double equation11(double R, double h)
        {
            // R : Radius (mm)
            // h : Height (mm)
            double S = (Math.PI * R * h) + (2 * Math.PI * Math.Pow(R, 2));
            return S;
        }

        // calcul of Empty mass (Kg)
        static double equation12(double S, double t, double ro)
        {
            // S : Surface (mm2)
            // t : Thickness (mm)
            // ro : Density of material (kg/m3)
            double Mv = S * t * ro;
            return Mv;
        }

        // calcul of Total mass (Kg)
        static double equation13(double Mv, double Mg)
        {
            // Mv : Empty mass (Kg)
            // Mg : ...
            double Mt = Mv + Mg;
            return Mt;
        }

        // calcul of Perimeter (mm)
        static double equation14(double R)
        {
            // R : Radius (mm)
            double P = 2 * Math.PI * R;
            return P;
        }

        // calcul of cost crimping (�)
        static double esuation15(double P, double cs)
        {
            // P : Perimeter (mm)
            // cs : cost/m (�/m)
            double Cs = P * cs;
            return Cs;
        }

        // calcul of cost of material (�)
        static double equation16(double Mv, double cm)
        {
            // Mv : Empty mass (Kg)
            // cm : cost/m (�/kg)
            double Cm = Mv * cm;
            return Cm;
        }

        // calcul of Coast of coating (�)
        static double equation17(double S, double cr)
        {
            // S : Surface (mm2)
            // cr : cost/m2 (�/m2)
            double Cr = S * cr;
            return Cr;
        }

        // calcul of Cost of deep drawing
        static double equation18()
        {
            return 0;
        }

        // calcul of total coast (�)
        static double equation19(double Cm, double Cs, double Cr, double Ce)
        {
            // Cm : cost of material (�)
            // Cs : cost crimping (�)
            // Cr : Coast of coating (�)
            // Ce : Cost of deep drawing
            Ce = 0;
            double Ct = Cm + Cs + Cr + Ce;
            return Ct;
        }

        // calcul of Rate of heat flow (W)
        static double equation20(double Tmin, double T0, double lambda, double t, double S)
        {
            // Lambda : Coefficient of thermal conductivity ( W.m-1.K-1)
            // Tmin : Minimum temperature (�C)
            // T0 : Boiling point : (�C)
            // S : Surface (mm2)
            // t : Thickness (mm)
            double Q = lambda * ((Tmin - T0) / t) * S;
            return Q;
        }

        // calcul of Volumetric flow rate of gaz (Kg/s)
        static double equation21(double Q, double Cl)
        {
            // Q : Rate of heat flow (W)
            //Cl : Latent heat of vaporization of gaz (J/Kg)
            double D;
            if (Cl != 0)
                D = Q / Cl;
            else
                D = -1;
            return D;
        }

        // calcul of Power (W)
        static double equation22(double D, double PCI)
        {
            // D : Volumetric flow rate of gaz (Kg/s)
            // PCI : Lower heating value (J/Kg)
            double P = D * PCI;
            return P;
        }

	}//end Equation

}//end namespace Modelisator.Model