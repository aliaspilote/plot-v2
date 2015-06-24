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

 
        /// <summary>
        /// calcul of Pressure of gas : p(MPa)
        /// </summary>
        /// <param name="X1">Coefficient of variation of the pressure (dimensionless)</param>
        /// <param name="Tmax">Maximum temperature (�C)</param>
        /// <param name="p0">Pressure of a liquid gas at 15�C (MPa)</param>
        /// <returns></returns>
        static double equation1(double X1, double Tmax, double p0)
        {
            
            double p;
            p = X1 * (Math.Pow(Tmax - 15, 2)) + p0;
            return p;
        }

        /// <summary>
        /// calcul ofPressure of a liquid gas at 15�C (MPa)
        /// </summary>
        /// <param name="X1">Coefficient of variation of the pressure (dimensionless)</param>
        /// <param name="Tmax">Maximum temperature (�C)</param>
        /// <param name="p">Pressure of gas (MPa)</param>
        /// <returns></returns>
 
        static double equation23(double X1, double Tmax, double p)
        { 
            double p0;
            p0 = p - (X1 * (Math.Pow(Tmax - 15, 2))) ;
            return p0;
        }

        /// <summary>
        /// calcul of (MPa)Coefficient of variation of the pressure (dimensionless)
        /// </summary>
        /// <param name="p"> Pressure of gas (Mpa)</param>
        /// <param name="Tmax">Maximum temperature (�C)</param>
        /// <param name="p0">Pressure of a liquid gas at 15�C (MPa)</param>
        /// <returns></returns>
 
        static double equation24(double p, double Tmax, double p0)
        {
            double X1;
            if (Tmax != 15)
                X1 = (p - p0) / (Math.Pow(Tmax - 15, 2));
            else
                X1 = -1;
            return X1;
        }

        /// <summary>
        /// calcul of Maximum temperature (�C)
        /// </summary>
        /// <param name="X1"> Coefficient of variation of the pressure (dimensionless)</param>
        /// <param name="p">  Pressure of gas (MPa)</param>
        /// <param name="p0"> Pressure of a liquid gas at 15�C (MPa)</param>
        /// <returns></returns>
 
        static double equation25(double X1, double p, double p0)
        {
            double Tmax;
            if (X1 != 0)
                Tmax = Math.Sqrt((p - p0) / X1) + 15;
            else 
                Tmax = -1;
            return Tmax;
        }


        /// <summary>
        /// calcul of Expansion of gas 
        /// </summary>
        /// <param name="alpha_gas">  Volumetric gaz expansion coefficient (% / �C)</param>
        /// <param name="Tmax">       Maximum temperature (�C)</param>
        /// <returns></returns>
 
        static double equation2(double alpha_gas, double Tmax)
        {
             
            double dV;
            dV = alpha_gas * (Tmax - 15);
            return dV;
        }


        /// <summary>
        /// calcul of Maximum temperature (�C) 
        /// </summary>
        /// <param name="alpha_gas"> Volumetric gaz expansion coefficient (% / �C)</param>
        /// <param name="dV">        Expansion of gas</param>
        /// <returns></returns>
 
        static double equation26(double alpha_gas, double dV)
        {
           
            double Tmax;
            if (alpha_gas != 0)
                Tmax = (dV / alpha_gas) + 15;
            else
                Tmax = -1;
            return Tmax;
        }

        /// <summary>
        /// calcul of  Volumetric gaz expansion coefficient (% / �C)
        /// </summary>
        /// <param name="Tmax"> Maximum temperature (�C)</param>
        /// <param name="dV">   Expansion of gas</param>
        /// <returns></returns>
 
        static double equation27(double Tmax, double dV)
        {
            
            double alpha_gas;
            if (Tmax != 15)
                alpha_gas = (dV / (Tmax-15));
            else
                alpha_gas = -1;
            return alpha_gas;
        }


        /// <summary>
        ///  calcul of Applied strass (Mpa)
        /// </summary>
        /// <param name="p"> Pressure of gas (Mpa)</param>
        /// <param name="R"> Radius (mm)</param>
        /// <param name="t"> Thickness (mm)</param>
        /// <returns></returns>

        static double equation3(double p, double R, double t)
        {
            
            double sigma;
            if (t != 0)
                sigma = (p * R) / t;
            else
                sigma = -1;
            return sigma;

        }

        /// <summary>
        ///  calcul of Pressure of gas (Mpa)
        /// </summary>
        /// <param name="sigma"> Applied strass (Mpa)</param>
        /// <param name="R"> Radius (mm)</param>
        /// <param name="t"> Thickness (mm)</param>
        /// <returns></returns>

        static double equation28(double sigma, double R, double t)
        {
             
            double p;
            if (R != 0)
                p = (sigma * t) / R;
            else
                p = -1;
            return p;

        }

        /// <summary>
        /// calcul of Radius (mm)
        /// </summary>
        /// <param name="sigma"> Applied strass (Mpa)</param>
        /// <param name="p"> Pressure of gas (Mpa)</param>
        /// <param name="t"> Thickness (mm)</param>
        /// <returns></returns>
 
        static double equation29(double sigma, double p, double t)
        {
            
            double R;
            if (p != 0)
                R = (sigma * t) / p;
            else
                R = -1;
            return R;
        }


        /// <summary>
        /// calcul of Thickness (mm)
        /// </summary>
        /// <param name="sigma"> sigma : Applied strass (Mpa)</param>
        /// <param name="p"> Pressure of gas (Mpa)</param>
        /// <param name="R"> Radius (mm)</param>
        /// <returns></returns>
 
        static double equation30(double sigma, double p, double R)
        {
           
            double t;
            if (sigma != 0)
                t = (p * R) / sigma;
            else
                t = -1;
            return t;

        }

        /// <summary>
        ///  calcul of Useful thichness (mm)
        /// </summary>
        /// <param name="p"> Pressure of gas (Mpa)</param>
        /// <param name="R"> Radius (mm)</param>
        /// <param name="sigma_y"> Yield strenght (Mpa)</param>
        /// <returns></returns>

        static double equation4(double p, double R, double sigma_y)
        {
            
            double tu;
            if (sigma_y != 0)
                tu = (p * R) / sigma_y;
            else
                tu = -1;
            return tu;
        }



        /// <summary>
        /// calcul of Pressure of gas (Mpa)
        /// </summary>
        /// <param name="tu"> Useful thichness (mm)</param>
        /// <param name="R"> Radius (mm)</param>
        /// <param name="sigma_y"> Yield strenght (Mpa)</param>
        /// <returns></returns>
 
        static double equation31(double tu, double R, double sigma_y)
        {
            
            double p;
            if (R != 0)
                p = (tu * sigma_y) / R;
            else
                p = -1;
            return p;
        }

        /// <summary>
        ///  calcul of Radius (mm)
        /// </summary>
        /// <param name="tu">Useful thichness (mm)</param>
        /// <param name="p">Pressure of gas (Mpa)</param>
        /// <param name="sigma_y">Yield strenght (Mpa)</param>
        /// <returns></returns>

        static double equation32(double tu, double p, double sigma_y)
        {
            
            double R;
            if (p != 0)
                R = (tu * sigma_y) / p;
            else
                R
                    = -1;
            return R;
        }

        /// <summary>
        /// calcul of Yield strenght (Mpa)
        /// </summary>
        /// <param name="tu">Useful thichness (mm)</param>
        /// <param name="p">Pressure of gas (Mpa)</param>
        /// <param name="R">Radius (mm)</param>
        /// <returns></returns>
 
        static double equation33(double tu, double p, double R)
        {
            
            double sigma_y;
            if (tu != 0)
                sigma_y = (p * R) / tu;
            else
                sigma_y
                    = -1;
            return sigma_y;
        }

        /// <summary>
        ///  calcul of Excess thickness
        /// </summary>
        /// <param name="t">Thickness (mm)</param>
        /// <param name="tu">Useful thichness (mm)</param>
        /// <returns></returns>

        static double equation5(double t, double tu)
        {
            
            double delta_t = t - tu;
            return delta_t;
        }

        /// <summary>
        ///  calcul of Thickness (mm)
        /// </summary>
        /// <param name="delta_t">Excess thickness</param>
        /// <param name="tu">Useful thichness (mm)</param>
        /// <returns></returns>

        static double equation34(double delta_t, double tu)
        {
           
            double t = delta_t + tu;
            return t;
        }

        /// <summary>
        /// calcul of  Useful thichness (mm)
        /// </summary>
        /// <param name="delta_t"> Excess thickness</param>
        /// <param name="t"> Thickness (mm)</param>
        /// <returns></returns>
 
        static double equation35(double delta_t, double t)
        {
           
            double tu = t - delta_t;
            return tu;
        }


        /// <summary>
        ///  calcul of Lifespan (year)
        /// </summary>
        /// <param name="t"> Thickness (mm)</param>
        /// <param name="tu"> Useful thichness (mm)</param>
        /// <param name="C">Thickness loss (mm/year)</param>
        /// <returns></returns>

        static double equation6(double t, double tu, double C)
        {
          
            double lifespan;
            if (C != 0)
                lifespan = (t - tu) / C;
            else
                lifespan = -1;
            return lifespan;
        }


        /// <summary>
        ///  calcul of Thickness (mm)
        /// </summary>
        /// <param name="lifespan">  Lifespan (year)</param>
        /// <param name="tu"> Useful thichness (mm)</param>
        /// <param name="C"> Thickness loss (mm/year)</param>
        /// <returns></returns>

        static double equation36(double lifespan, double tu, double C)
        {
            
            double t;
            t = (lifespan * C) + tu;
            return t;
        }

        /// <summary>
        /// calcul of Useful thichness (mm)
        /// </summary>
        /// <param name="lifespan">Lifespan (year)</param>
        /// <param name="t">Thickness (mm)</param>
        /// <param name="C"> Thickness loss (mm/year)</param>
        /// <returns></returns>
 
        static double equation37(double lifespan, double t, double C)
        {
           
            double tu;
            tu = t - (lifespan * C);
            return t;
        }

        /// <summary>
        /// calcul of Thickness loss (mm/year)
        /// </summary>
        /// <param name="t">Thickness (mm)</param>
        /// <param name="tu">Useful thichness (mm)</param>
        /// <param name="lifespan">Lifespan (year)</param>
        /// <returns></returns>
 
        static double equation38(double t, double tu, double lifespan)
        {
            
            double C;
            if (lifespan != 0)
                C = (t - tu) / lifespan;
            else
                C = -1;
            return C;
        }

        /// <summary>
        ///  calcul of Stress intensity factor for flaw size to useful thickness (Mpa racine(m))
        /// </summary>
        /// <param name="alpha">Correction factor (dimensionless)</param>
        /// <param name="sigma_y">Yield strenght (Mpa)</param>
        /// <param name="tu">Useful thichness (mm)</param>
        /// <returns></returns>

        static double equation7(double alpha, double sigma_y, double tu)
        {
            
            double KI = alpha * sigma_y * Math.Sqrt(tu);
            return KI;
        }


        /// <summary>
        /// calcul of Correction factor (dimensionless)
        /// </summary>
        /// <param name="KI">KI : Stress intensity factor for flaw size to useful thickness (Mpa racine(m)�</param>
        /// <param name="sigma_y"> Yield strenght (Mpa)</param>
        /// <param name="tu">Useful thichness (mm)</param>
        /// <returns></returns>
 
        static double equation39(double KI, double sigma_y, double tu)
        {
           
            double alpha;
            if (sigma_y != 0 && tu != 0)
                alpha = KI / (sigma_y * Math.Sqrt(tu));
            else
                alpha = -1;
            return alpha;
        }

        /// <summary>
        /// calcul of  Yield strenght (Mpa)
        /// </summary>
        /// <param name="KI">KI : Stress intensity factor for flaw size to useful thickness (Mpa racine(m))</param>
        /// <param name="alpha">alpha : Correction factor (dimensionless)</param>
        /// <param name="tu">tu : Useful thichness (mm)</param>
        /// <returns></returns>
 
        static double equation40(double KI, double alpha, double tu)
        {
            
            double sigma_y;
            if (alpha != 0 && tu != 0)
                sigma_y = KI / (alpha * Math.Sqrt(tu));
            else
                sigma_y = -1;
            return sigma_y;
        }

        // calcul of  Useful thichness (mm)
        static double equation41(double KI, double alpha, double sigma_y)
        {
            // KI : Stress intensity factor for flaw size to useful thickness (Mpa racine(m))
            // alpha : Correction factor (dimensionless)
            // sigma_y : Yield strenght (Mpa)
            double tu;
            if (alpha != 0 && sigma_y!= 0)
                tu = Math.Pow(KI / (alpha * sigma_y),2);
            else
                tu = -1;
            return tu;
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


        // calcul of Radius of punching hole (m)
        static double equation42(double Fp, double t, double sigma_y)
        {
            // t : Thickness (mm)
            // sigma_y : Yield strenght (Mpa)
            // Fp : Force of punching (N)
            double nu;
            if (t != 0 && sigma_y != 0)
                nu = Fp / (2 * Math.PI * t * sigma_y);
            else
                nu = -1;
            return nu;
        }

        // calcul of Thickness (mm)
        static double equation43(double Fp, double nu, double sigma_y)
        {
            // nu : Radius of punching hole (m)
            // sigma_y : Yield strenght (Mpa)
            // Fp : Force of punching (N)
            double t;
            if (nu != 0 && sigma_y != 0)
                t = Fp / (2 * Math.PI * nu * sigma_y);
            else
                t = -1;
            return t;
        }

        // calcul of Yield strenght (Mpa)
        static double equation44(double Fp, double nu, double t)
        {
            // nu : Radius of punching hole (m)
            // t : Thickness (mm)
            // Fp : Force of punching (N)
            double sigma_y;
            if (nu != 0 && t != 0)
                sigma_y = Fp / (2 * Math.PI * nu * t);
            else
                sigma_y = -1;
            return sigma_y;
        }


        // calcul of Volume (mm3)
        static double equation9(double R, double h)
        {
            // R : Radius (mm)
            // h : Height (mm)
            double V = (Math.PI * Math.Pow(R, 2) * h);
            return V;
        }


        // calcul of Height (mm)
        static double equation45(double V, double R)
        {
            // R : Radius (mm)
            // V : Volume (mm3)
            double h;
            if (R != 0)
                h = V / (Math.PI * Math.Pow(R, 2));
            else
                h = -1;
            return h;
        }

        // calcul of Radius (mm)
        static double equation46(double V, double h)
        {
            // h : Height (mm)
            // V : Volume (mm3)
            double R;
            if (h != 0)
                R = Math.Sqrt( V / (Math.PI * h));
            else
                R = -1;
            return R;
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

        // calcul of Volume (mm3)
        static double equation47(double Mu, double dV, double pg)
        {
            // Mu : Usuful mass (Kg)
            // dV : Expansion of gas 
            // pg : density of gaz (kg/m3)
            double V;
            if (pg != 0 && dV != 1)
                V = Mu / ((1 - dV) * pg);
            else
                V = -1;
            return V;
        }

        // calcul of density of gaz (kg/m3)
        static double equation48(double Mu, double dV, double V)
        {
            // Mu : Usuful mass (Kg)
            // dV : Expansion of gas 
            // V : Volume (mm3)
            double pg;
            if (V!= 0 && dV != 1)
                pg = Mu / ((1 - dV) * V);
            else
                pg = -1;
            return pg;
        }

        // calcul ofExpansion of gas 
        static double equation49(double Mu, double pg, double V)
        {
            // Mu : Usuful mass (Kg)
            // pg :  density of gaz (kg/m3)
            // V : Volume (mm3)
            double dV;
            if (V != 0 && pg != 0)
                dV = 1 - (Mu / (pg * V));
            else
                dV = -1;
            return dV;
        }

        // calcul of Surface (mm2)
        static double equation11(double R, double h)
        {
            // R : Radius (mm)
            // h : Height (mm)
            double S = (2 * Math.PI * R * h) + (2 * Math.PI * Math.Pow(R, 2));
            return S;
        }

        // calcul of Height (mm)
        static double equation50(double R, double S)
        {
            // R : Radius (mm)
            // S : Surface (mm2)
            double h ;
            if (R != 0)
                h = (S - (2 * Math.PI * Math.Pow(R, 2))) / (2 * Math.PI * R);
            else
                h = -1;
            return h; 
        }

        // calcul of Radius (mm)
        static double equation51(double h, double S)
        {
            // h : Height (mm)
            // S : Surface (mm2)
            double R=-1;
            
            return R;
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


        // calcul of Surface (mm2)
        static double equation52(double Mv, double t, double ro)
        {
            // Mv : Empty mass (Kg)
            // t : Thickness (mm)
            // ro : Density of material (kg/m3)
            double S;
            if(t!=0 && ro!=0)
                S=Mv / (t * ro);
            else
                S=-1;
            return S;
        }

        // calcul of Thickness (mm)
        static double equation53(double Mv, double S, double ro)
        {
            // Mv : Empty mass (Kg)
            // S : Surface (mm2)
            // ro : Density of material (kg/m3)
            double t;
            if (S != 0 && ro != 0)
                t = Mv / (S * ro);
            else
                t = -1;
            return t;
        }

        // calcul of  Density of material (kg/m3)
        static double equation54(double Mv, double S, double t)
        {
            // Mv : Empty mass (Kg)
            // S : Surface (mm2)
            // t :Thickness (mm)
            double ro;
            if (S != 0 && t != 0)
                ro = Mv / (S * t);
            else
                ro = -1;
            return ro;
        }

        // calcul of Total mass (Kg)
        static double equation13(double Mv, double Mg)
        {
            // Mv : Empty mass (Kg)
            // Mg : ...
            double Mt = Mv + Mg;
            return Mt;
        }

        // calcul of Empty mass (Kg)
        static double equation55(double Mt, double Mg)
        {
            // Mt : Total mass (Kg)
            // Mg : ...
            double Mv = Mt - Mg;
            return Mv;
        }

        // calcul of Mg
        static double equation56(double Mt, double Mv)
        {
            // Mt : Total mass (Kg)
            // Mv : Empty mass (Kg)
            double Mg = Mt - Mv;
            return Mg;
        }

        // calcul of Perimeter (mm)
        static double equation14(double R)
        {
            // R : Radius (mm)
            double P = 2 * Math.PI * R;
            return P;
        }

        // calcul of Radius (mm)
        static double equation57(double P)
        {
            // P : Perimeter (mm)
            double R = P /(2 * Math.PI);
            return R;
        }

        // calcul of cost crimping (�)
        static double esuation15(double P, double cs)
        {
            // P : Perimeter (mm)
            // cs : cost/m (�/m)
            double Cs = P * cs;
            return Cs;
        }

        // calcul of Perimeter (mm)
        static double esuation58(double Cs, double cs)
        {
            // Cs : cost crimping (�)
            // cs : cost/m (�/m)
            double P;
            if(cs!=0)
                P=Cs/cs;
            else
                P=-1;  
            return P;
        }

        // calcul of cost/m (�/m)
        static double esuation59(double Cs, double P)
        {
            // Cs : cost crimping (�)
            // P : Perimeter (mm)
            double cs;
            if (P != 0)
                cs = Cs / P;
            else
                cs = -1;
            return cs;
        }


        // calcul of cost of material (�)
        static double equation16(double Mv, double cm)
        {
            // Mv : Empty mass (Kg)
            // cm : cost/m (�/kg)
            double Cm = Mv * cm;
            return Cm;
        }

        // calcul of Empty mass (Kg)
        static double equation60(double Cm, double cm)
        {
            // Cm : cost of material (�)
            // cm : cost/m (�/kg)
            double Mv;
            if(cm!=0)
                Mv=Cm/cm;
            else
                Mv=-1;
            return Mv;
        }

        // calcul of cost/m (�/kg)
        static double equation61(double Cm, double Mv)
        {
            // Cm : cost of material (�)
            // cm : Empty mass (Kg)
            double cm;
            if (Mv != 0)
                cm = Cm / Mv;
            else
                cm = -1;
            return cm;
        }

        // calcul of Coast of coating (�)
        static double equation17(double S, double cr)
        {
            // S : Surface (mm2)
            // cr : cost/m2 (�/m2)
            double Cr = S * cr;
            return Cr;
        }

        // calcul of Surface (mm2)
        static double equation62(double Cr, double cr)
        {
            // Cr : Coast of coating (�)
            // cr : cost/m2 (�/m2)
            double S;
            if(cr!=0)
                S=Cr/cr;
            else
                S=-1;
            return S;
        }

        // calcul ofcost/m2 (�/m2)
        static double equation63(double Cr, double S)
        {
            // Cr : Coast of coating (�)
            // S : Surface (mm2)
            double cr;
            if (S != 0)
                cr = Cr / S;
            else
                cr = -1;
            return cr;
        }

        // calcul of Cost of deep drawing
        static double equation18()
        {
            return 0;
        }

        // calcul of sigma_y
        static double equation64()
        {
            return 0;
        }

        // calcul of t
        static double equation65()
        {
            return 0;
        }

        // calcul of R
        static double equation66()
        {
            return 0;
        }

         // calcul of Series
        static double equation67()
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


        // calcul of cost of material (�)
        static double equation68(double Ct, double Cs, double Cr, double Ce)
        {
            // Ct : total coast (�)
            // Cs : cost crimping (�)
            // Cr : Coast of coating (�)
            // Ce : Cost of deep drawing
            Ce = 0;
            double Cm = Ct - Cs - Cr - Ce;
            return Cm;
        }

        // calcul of cost crimping (�)
        static double equation69(double Ct, double Cm, double Cr, double Ce)
        {
            // Ct : total coast (�)
            // Cm : cost of material (�)
            // Cr : Coast of coating (�)
            // Ce : Cost of deep drawing
            Ce = 0;
            double Cs = Ct - Cm - Cr - Ce;
            return Cs;
        }

        // calcul of Coast of coating (�)
        static double equation70(double Ct, double Cs, double Cm, double Ce)
        {
            // Ct : total coast (�)
            // Cs : cost crimping (�)
            // Cm : cost of material (�)
            // Ce : Cost of deep drawing
            Ce = 0;
            double Cr = Ct - Cs - Cm - Ce;
            return Cr;
        }

        // calcul of Cost of deep drawing
        static double equation71(double Ct, double Cs, double Cr, double Cm)
        {
            // Ct : total coast (�)
            // Cs : cost crimping (�)
            // Cr : Coast of coating (�)
            // Cm : cost of material (�)
            
            double Ce = Ct - Cs - Cr - Cm;
            Ce = 0;
            return Ce;
        }


        // calcul of Rate of heat flow (W)
        static double equation20(double Tmin, double T0, double lambda, double t, double S)
        {
            // Lambda : Coefficient of thermal conductivity ( W.m-1.K-1)
            // Tmin : Minimum temperature (�C)
            // T0 : Boiling point : (�C)
            // S : Surface (mm2)
            // t : Thickness (mm)
            double Q;
            if(t!=0)
             Q= lambda * ((Tmin - T0) / t) * S;
            else
                Q = -1;
            return Q;
        }



        // calcul of Coefficient of thermal conductivity ( W.m-1.K-1)
        static double equation72(double Tmin, double T0, double Q, double t, double S)
        {
            // Q : Rate of heat flow (W)
            // Tmin : Minimum temperature (�C)
            // T0 : Boiling point : (�C)
            // S : Surface (mm2)
            // t : Thickness (mm)
            double lambda;
            if (S != 0 && Tmin != T0)
                lambda = Q * t / (S * (Tmin - T0));
            else
                lambda = -1;
            return lambda;
        }

        // calcul of Surface (mm2)
        static double equation73(double Tmin, double T0, double Q, double t, double lambda)
        {
            // Q : Rate of heat flow (W)
            // Tmin : Minimum temperature (�C)
            // T0 : Boiling point : (�C)
            // lambda : Coefficient of thermal conductivity ( W.m-1.K-1)
            // t : Thickness (mm)
            double S;
            if (lambda != 0 && Tmin != T0)
                S = Q * t / (lambda * (Tmin - T0));
            else
                S = -1;
            return S;
        }

        // calcul of Thickness (mm)
        static double equation74(double Tmin, double T0, double lambda, double Q, double S)
        {
            // Lambda : Coefficient of thermal conductivity ( W.m-1.K-1)
            // Tmin : Minimum temperature (�C)
            // T0 : Boiling point : (�C)
            // S : Surface (mm2)
            // Q : Rate of heat flow (W)
            double t;
            if (Q != 0)
                t = lambda * ((Tmin - T0) / Q) * S;
            else
                t = -1;
            return t;
        }

        // calcul of Minimum temperature (�C)
        static double equation75(double t, double T0, double lambda, double Q, double S)
        {
            // Lambda : Coefficient of thermal conductivity ( W.m-1.K-1)
            // t : Thickness (mm)
            // T0 : Boiling point : (�C)
            // S : Surface (mm2)
            // Q : Rate of heat flow (W)
            double Tmin;
            if (lambda != 0 && S!=0)
                Tmin = (Q * t) / ( lambda * S) + T0;
            else
                Tmin=-1;
            return Tmin;
        }


        // calcul of Boiling point : (�C)
        static double equation76(double t, double Tmin, double lambda, double Q, double S)
        {
            // Lambda : Coefficient of thermal conductivity ( W.m-1.K-1)
            // t : Thickness (mm)
            // Tmin : Minimum temperature (�C)
            // S : Surface (mm2)
            // Q : Rate of heat flow (W)
            double T0;
            if (lambda != 0 && S != 0)
                T0 = Tmin - (Q * t) / (lambda * S);
            else
                T0 = -1;
            return T0;
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

        // calcul of Rate of heat flow (W)
        static double equation77(double D, double Cl)
        {
            // D : Volumetric flow rate of gaz (Kg/s)
            //Cl : Latent heat of vaporization of gaz (J/Kg)
            double Q;
                Q = D * Cl;
            return Q;
        }

        // calcul of Latent heat of vaporization of gaz (J/Kg)
        static double equation78(double Q, double D)
        {
            // Q : Rate of heat flow (W)
            // D : Volumetric flow rate of gaz (Kg/s)
            double Cl;
            if (D != 0)
                Cl = Q / D;
            else
                Cl = -1;
            return Cl;
        }
        

        // calcul of Power (W)
        static double equation22(double D, double PCI)
        {
            // D : Volumetric flow rate of gaz (Kg/s)
            // PCI : Lower heating value (J/Kg)
            double P = D * PCI;
            return P;
        }

        // calcul of Volumetric flow rate of gaz (Kg/s)
        static double equation79(double P, double PCI)
        {
            // P : Power (W)
            // PCI : Lower heating value (J/Kg)
            double D;
            if (PCI != 0)
                D = P * PCI;
            else
                D = -1;
            return D;
        }

        // calcul of Lower heating value (J/Kg)
        static double equation80(double P, double D)
        {
            // P : Power (W)
            // D : Volumetric flow rate of gaz (Kg/s)
            double PCI;
            if (D != 0)
                PCI = P * D;
            else
                PCI = -1;
            return PCI;
        }





	}//end Equation

}//end namespace Modelisator.Model