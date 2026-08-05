using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Async;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UJect.Injection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Tweening_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDE00", Offset = "0x8CFCA00", VA = "0x188CFDE00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2721D10", Offset = "0x2720910", VA = "0x182721D10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class BBFCZVKGTOW
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum Functions
		{
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			Linear,
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			QuadraticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			QuadraticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			QuadraticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			CubicEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			CubicEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			CubicEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			QuarticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			QuarticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			QuarticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			QuinticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			QuinticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			QuinticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			SineEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			SineEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			SineEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			CircularEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			CircularEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			CircularEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			ExponentialEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			ExponentialEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			ExponentialEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			ElasticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			ElasticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			ElasticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			BackEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			BackEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			BackEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			BounceEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			BounceEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			BounceEaseInOut
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public static class VXDISLXLJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x27B8DE0", Offset = "0x27B79E0", VA = "0x1827B8DE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD070", Offset = "0x8CFBC70", VA = "0x188CFD070")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD090", Offset = "0x8CFBC90", VA = "0x188CFD090")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class IESALBHAULR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9DB0", Offset = "0x8CF89B0", VA = "0x188CF9DB0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9DC0", Offset = "0x8CF89C0", VA = "0x188CF9DC0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9DE0", Offset = "0x8CF89E0", VA = "0x188CF9DE0")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class ZYQUVFLCOLI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDD60", Offset = "0x8CFC960", VA = "0x188CFDD60")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDD70", Offset = "0x8CFC970", VA = "0x188CFDD70")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDDA0", Offset = "0x8CFC9A0", VA = "0x188CFDDA0")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class GJJKTIEZNIG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8CF96C0", Offset = "0x8CF82C0", VA = "0x188CF96C0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8CF96E0", Offset = "0x8CF82E0", VA = "0x188CF96E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9710", Offset = "0x8CF8310", VA = "0x188CF9710")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAE20", Offset = "0x8CF9A20", VA = "0x188CFAE20")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAE50", Offset = "0x8CF9A50", VA = "0x188CFAE50")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAE70", Offset = "0x8CF9A70", VA = "0x188CFAE70")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9550", Offset = "0x8CF8150", VA = "0x188CF9550")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8CF95A0", Offset = "0x8CF81A0", VA = "0x188CF95A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9600", Offset = "0x8CF8200", VA = "0x188CF9600")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class WNUSKAXXJKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD0E0", Offset = "0x8CFBCE0", VA = "0x188CFD0E0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD140", Offset = "0x8CFBD40", VA = "0x188CFD140")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD170", Offset = "0x8CFBD70", VA = "0x188CFD170")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class TNYWOKZDPLM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAEA0", Offset = "0x8CF9AA0", VA = "0x188CFAEA0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAF50", Offset = "0x8CF9B50", VA = "0x188CFAF50")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB010", Offset = "0x8CF9C10", VA = "0x188CFB010")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float JHZZGGJGAEU;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float NXBTXFAMZKC;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7D90", Offset = "0x8CF6990", VA = "0x188CF7D90")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7E10", Offset = "0x8CF6A10", VA = "0x188CF7E10")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7EA0", Offset = "0x8CF6AA0", VA = "0x188CF7EA0")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7FD0", Offset = "0x8CF6BD0", VA = "0x188CF7FD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8CF80A0", Offset = "0x8CF6CA0", VA = "0x188CF80A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8140", Offset = "0x8CF6D40", VA = "0x188CF8140")]
			public static float VVAWGFJUWXS(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8CF71D0", Offset = "0x8CF5DD0", VA = "0x188CF71D0")]
		public static float ASAJZAVCZZX(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class BMFSCUEPGWD : ECAPCMILPSV
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8CF7C80", Offset = "0x8CF6880", VA = "0x188CF7C80")]
		public BMFSCUEPGWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "13")]
		public override bool SQTENXDFCBN(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAE4E80", Offset = "0xAE3A80", VA = "0x180AE4E80", Slot = "14")]
		public override float WXZQTOTVIKP()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class IGCNNPCQBHW : PGUWLSOYSKW<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9E30", Offset = "0x8CF8A30", VA = "0x188CF9E30")]
		public IGCNNPCQBHW(Func<Color> a, Action<Color> b, Color c, float d, BBFCZVKGTOW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xC1C890", Offset = "0xC1B490", VA = "0x180C1C890", Slot = "15")]
		protected override Color QVISFNTSWLH()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x818B4C0", Offset = "0x818A0C0", VA = "0x18818B4C0", Slot = "16")]
		protected override Color JEJFQGXCJVE(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class HWTDZUSGCAV : PGUWLSOYSKW<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9B90", Offset = "0x8CF8790", VA = "0x188CF9B90")]
		public HWTDZUSGCAV(Func<float> a, Action<float> b, float c, float d, BBFCZVKGTOW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9B40", Offset = "0x8CF8740", VA = "0x188CF9B40", Slot = "15")]
		protected override float QVISFNTSWLH()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9B20", Offset = "0x8CF8720", VA = "0x188CF9B20", Slot = "16")]
		protected override float JEJFQGXCJVE(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class HQSINVHHYZT : PGUWLSOYSKW<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9980", Offset = "0x8CF8580", VA = "0x188CF9980")]
		public HQSINVHHYZT(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, BBFCZVKGTOW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8CF97C0", Offset = "0x8CF83C0", VA = "0x188CF97C0", Slot = "15")]
		protected override Quaternion QVISFNTSWLH()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9770", Offset = "0x8CF8370", VA = "0x188CF9770", Slot = "16")]
		protected override Quaternion JEJFQGXCJVE(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class VPTPXHCNYZJ : PGUWLSOYSKW<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCFD0", Offset = "0x8CFBBD0", VA = "0x188CFCFD0")]
		public VPTPXHCNYZJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, BBFCZVKGTOW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCF30", Offset = "0x8CFBB30", VA = "0x188CFCF30", Slot = "15")]
		protected override Vector3 QVISFNTSWLH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCEC0", Offset = "0x8CFBAC0", VA = "0x188CFCEC0", Slot = "16")]
		protected override Vector3 JEJFQGXCJVE(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface GIDMVWCTTWY
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action NDTOFJBDKBW;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GIDMVWCTTWY HCVTPAVGWPZ(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GIDMVWCTTWY YWSBKBTNPNJ(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GIDMVWCTTWY QVBKZUOHLHI(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		MRIYACRIYFZ EDZGLISCVWA();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool SQTENXDFCBN(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float WXZQTOTVIKP();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface OOULMMSAMVA : GIDMVWCTTWY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface QSMJBFLEKGU : GIDMVWCTTWY
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		QSMJBFLEKGU GUVFMCSSIDP(GIDMVWCTTWY a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		QSMJBFLEKGU GUVFMCSSIDP(Func<GIDMVWCTTWY> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QSMJBFLEKGU MEYCIOCAZSC(IEnumerable<GIDMVWCTTWY> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		QSMJBFLEKGU MEYCIOCAZSC(params GIDMVWCTTWY[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		QSMJBFLEKGU PSFQNIPQEWJ(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MCAIRLYLSCQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OOULMMSAMVA ANIEYEIHLTO(Func<float> a, Action<float> b, float c, float d, BBFCZVKGTOW.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OOULMMSAMVA HWZEFEYRVTE(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, BBFCZVKGTOW.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OOULMMSAMVA CDNLNPARZAJ(Func<Color> a, Action<Color> b, Color c, float d, BBFCZVKGTOW.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		OOULMMSAMVA CNLGVFBISFT(Transform a, Vector3 b, float c, BBFCZVKGTOW.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		OOULMMSAMVA JWUCYTPMIGP(Transform a, Quaternion b, float c, BBFCZVKGTOW.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		OOULMMSAMVA YQZLUTKUABU(Transform a, Vector3 b, float c, BBFCZVKGTOW.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		QSMJBFLEKGU Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OURGWADZUZG(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class XZDWFCHFFXA
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GIDMVWCTTWY BMFSCUEPGWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD600", Offset = "0x8CFC200", VA = "0x188CFD600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD7B0", Offset = "0x8CFC3B0", VA = "0x188CFD7B0")]
		internal static MCAIRLYLSCQ JHYQSUZXNRK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD2A0", Offset = "0x8CFBEA0", VA = "0x188CFD2A0")]
		public static OOULMMSAMVA ANIEYEIHLTO(Func<float> a, Action<float> b, float c, float d, BBFCZVKGTOW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD650", Offset = "0x8CFC250", VA = "0x188CFD650")]
		public static OOULMMSAMVA HWZEFEYRVTE(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, BBFCZVKGTOW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD3E0", Offset = "0x8CFBFE0", VA = "0x188CFD3E0")]
		public static OOULMMSAMVA CDNLNPARZAJ(Func<Color> a, Action<Color> b, Color c, float d, BBFCZVKGTOW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD530", Offset = "0x8CFC130", VA = "0x188CFD530")]
		public static OOULMMSAMVA CNLGVFBISFT(Transform a, Vector3 b, float c, BBFCZVKGTOW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD820", Offset = "0x8CFC420", VA = "0x188CFD820")]
		public static OOULMMSAMVA JWUCYTPMIGP(Transform a, Quaternion b, float c, BBFCZVKGTOW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDB30", Offset = "0x8CFC730", VA = "0x188CFDB30")]
		public static OOULMMSAMVA YQZLUTKUABU(Transform a, Vector3 b, float c, BBFCZVKGTOW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDA40", Offset = "0x8CFC640", VA = "0x188CFDA40")]
		public static QSMJBFLEKGU Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD960", Offset = "0x8CFC560", VA = "0x188CFD960")]
		public static void OURGWADZUZG(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class NESLEOOATLV : GIDMVWCTTWY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action EGKAAOBWCXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action YHJEXJKXZYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> FABHPNMWXRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> RATCYRZRBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> BXTTHARUBKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected OLUBYDSFSTA NJJRGFITQLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object FPMHARYHOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool AQBOQALPSYR;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool ICGECIGHCCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA350", Offset = "0x8CF8F50", VA = "0x188CFA350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool NKEZNUYAGGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA5D0", Offset = "0x8CF91D0", VA = "0x188CFA5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NDTOFJBDKBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA2B0", Offset = "0x8CF8EB0", VA = "0x188CFA2B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA160", Offset = "0x8CF8D60", VA = "0x188CFA160", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9F800", VA = "0x180AA0C00", Slot = "9")]
		public MRIYACRIYFZ EDZGLISCVWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA200", Offset = "0x8CF8E00", VA = "0x188CFA200", Slot = "6")]
		public GIDMVWCTTWY HCVTPAVGWPZ(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA720", Offset = "0x8CF9320", VA = "0x188CFA720", Slot = "7")]
		public GIDMVWCTTWY YWSBKBTNPNJ(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA370", Offset = "0x8CF8F70", VA = "0x188CFA370", Slot = "8")]
		public GIDMVWCTTWY QVBKZUOHLHI(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool SQTENXDFCBN(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float WXZQTOTVIKP();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9FC0", Offset = "0x8CF8BC0", VA = "0x188CF9FC0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA5F0", Offset = "0x8CF91F0", VA = "0x188CFA5F0")]
		protected void UDQODBQJYXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA460", Offset = "0x8CF9060", VA = "0x188CFA460")]
		protected void STORDPBLSHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA830", Offset = "0x8CF9430", VA = "0x188CFA830")]
		protected NESLEOOATLV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class KROJQXPFNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9ED0", Offset = "0x8CF8AD0", VA = "0x188CF9ED0")]
		public static OOULMMSAMVA YQZLUTKUABU(this Behaviour a, Vector3 b, float c, BBFCZVKGTOW.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class ECAPCMILPSV : NESLEOOATLV, OOULMMSAMVA, GIDMVWCTTWY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool JOZSFVSHDTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float GHINZMYADCT;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected BBFCZVKGTOW.Functions RMDGABDVSNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD1EAF0", Offset = "0xD1D6F0", VA = "0x180D1EAF0")]
			[CompilerGenerated]
			get
			{
				return default(BBFCZVKGTOW.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8300", Offset = "0x8CF6F00", VA = "0x188CF8300")]
		protected ECAPCMILPSV(float a, BBFCZVKGTOW.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2600DE0", Offset = "0x25FF9E0", VA = "0x182600DE0")]
		[CompilerGenerated]
		private void AJHITITZCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8CF82E0", Offset = "0x8CF6EE0", VA = "0x188CF82E0")]
		[CompilerGenerated]
		private void AJCBWCABTBC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class PGUWLSOYSKW<a> : ECAPCMILPSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> TRYMKINRNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> VDXGKJOEJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a ASYYJVEGYZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float UYKHZAUADBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a LFAUZVZAWBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a UXSZKLQVMAV;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x59C65C0", Offset = "0x59C51C0", VA = "0x1859C65C0")]
		protected PGUWLSOYSKW(Func<a> a, Action<a> b, a c, float d, BBFCZVKGTOW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a QVISFNTSWLH();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a JEJFQGXCJVE(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x59C55F0", Offset = "0x59C41F0", VA = "0x1859C55F0", Slot = "13")]
		public override bool SQTENXDFCBN(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x59C62C0", Offset = "0x59C4EC0", VA = "0x1859C62C0", Slot = "14")]
		public override float WXZQTOTVIKP()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class EHLNWHUFQJZ : NESLEOOATLV, QSMJBFLEKGU, GIDMVWCTTWY
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private enum StepTypes
		{
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			Tween,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			Delay,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			Callback
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct TweenEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private GIDMVWCTTWY tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<GIDMVWCTTWY> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB200", Offset = "0x8CF9E00", VA = "0x188CFB200")]
			public TweenEntry(GIDMVWCTTWY tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1A55580", Offset = "0x1A54180", VA = "0x181A55580")]
			public TweenEntry(Func<GIDMVWCTTWY> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB0E0", Offset = "0x8CF9CE0", VA = "0x188CFB0E0")]
			public GIDMVWCTTWY KPISDQZCSWU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private struct Step
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public StepTypes StepType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public IEnumerable<TweenEntry> Tweens;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public Action Callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public float DelaySeconds;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<Step> GOBULXRNPRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int PQDLKWRWBNE;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9410", Offset = "0x8CF8010", VA = "0x188CF9410")]
		public EHLNWHUFQJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8410", Offset = "0x8CF7010", VA = "0x188CF8410", Slot = "15")]
		public QSMJBFLEKGU GUVFMCSSIDP(GIDMVWCTTWY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8620", Offset = "0x8CF7220", VA = "0x188CF8620", Slot = "16")]
		public QSMJBFLEKGU GUVFMCSSIDP(Func<GIDMVWCTTWY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8970", Offset = "0x8CF7570", VA = "0x188CF8970", Slot = "17")]
		public QSMJBFLEKGU MEYCIOCAZSC(IEnumerable<GIDMVWCTTWY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8CF86E0", Offset = "0x8CF72E0", VA = "0x188CF86E0", Slot = "18")]
		public QSMJBFLEKGU MEYCIOCAZSC(params GIDMVWCTTWY[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8AC0", Offset = "0x8CF76C0", VA = "0x188CF8AC0", Slot = "19")]
		public QSMJBFLEKGU PSFQNIPQEWJ(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8BD0", Offset = "0x8CF77D0", VA = "0x188CF8BD0", Slot = "13")]
		public override bool SQTENXDFCBN(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8CF92F0", Offset = "0x8CF7EF0", VA = "0x188CF92F0", Slot = "14")]
		public override float WXZQTOTVIKP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8CE0", Offset = "0x8CF78E0", VA = "0x188CF8CE0")]
		private bool VQKPXQXDCWW(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8860", Offset = "0x8CF7460", VA = "0x188CF8860")]
		private QSMJBFLEKGU MEYCIOCAZSC(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2600DE0", Offset = "0x25FF9E0", VA = "0x182600DE0")]
		[CompilerGenerated]
		private void AJHITITZCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8CF82E0", Offset = "0x8CF6EE0", VA = "0x188CF82E0")]
		[CompilerGenerated]
		private void AJCBWCABTBC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class UIDRBYENMWV : MCAIRLYLSCQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public NESLEOOATLV Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WYITCQAWRUI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform XXOIONCBGHU;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WYITCQAWRUI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD260", Offset = "0x8CFBE60", VA = "0x188CFD260")]
			internal Vector3 DHEBVREXMDJ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD220", Offset = "0x8CFBE20", VA = "0x188CFD220")]
			internal void DGYUYKLACSA(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class NLQFCTBILOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform XXOIONCBGHU;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NLQFCTBILOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA940", Offset = "0x8CF9540", VA = "0x188CFA940")]
			internal Quaternion WYCCSWCYYOR()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA910", Offset = "0x8CF9510", VA = "0x188CFA910")]
			internal void WXWVVPJBPDI(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class DKHGUFSJRQE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform XXOIONCBGHU;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public DKHGUFSJRQE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8260", Offset = "0x8CF6E60", VA = "0x188CF8260")]
			internal Vector3 WFZNTUCCFIG()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8CF82A0", Offset = "0x8CF6EA0", VA = "0x188CF82A0")]
			internal void WGEURAVZOTP(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class HSAGEGZXRUB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public NESLEOOATLV AIVRGHEEJNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public UIDRBYENMWV BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour CKDYJTAIIFM;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HSAGEGZXRUB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9A20", Offset = "0x8CF8620", VA = "0x188CF9A20")]
			internal void XEXQRYLXOSS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class IBVXBRAKPLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public UIDRBYENMWV BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public NESLEOOATLV EZNINDVBRIS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ZOKTFPQAJUY YGDRZMPGYGI;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public IBVXBRAKPLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9C00", Offset = "0x8CF8800", VA = "0x188CF9C00")]
			internal void KKLJDLEVDTC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9D10", Offset = "0x8CF8910", VA = "0x188CF9D10")]
			internal void KKQQARYSNEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9D60", Offset = "0x8CF8960", VA = "0x188CF9D60")]
			internal void KKVWXYSPWPU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class PSGKHMNNMHA : IEnumerator<YRPRUNTVYNF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private YRPRUNTVYNF VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public GIDMVWCTTWY AIVRGHEEJNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public UIDRBYENMWV BIVSZSMQJUR;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private YRPRUNTVYNF AYWYUYDOKDY
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public PSGKHMNNMHA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA980", Offset = "0x8CF9580", VA = "0x188CFA980", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAA50", Offset = "0x8CF9650", VA = "0x188CFAA50", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class QNQJEFZCTYI : IEnumerator<YRPRUNTVYNF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private YRPRUNTVYNF VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public UIDRBYENMWV BIVSZSMQJUR;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private YRPRUNTVYNF AYWYUYDOKDY
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public QNQJEFZCTYI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAA90", Offset = "0x8CF9690", VA = "0x188CFAA90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8CFADE0", Offset = "0x8CF99E0", VA = "0x188CFADE0", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly WTRHWJWHRVJ GBVSZXEDWSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly DAKAQELGOPO TZNIDRISPQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> OGNDPNHIJYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> VMTEMBSFNSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<NESLEOOATLV> QJCLCIQIFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<NESLEOOATLV>> THUIDJUDYQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool CDCGATQZZIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private ZOKTFPQAJUY EHBHNLDOZWO;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBBF0", Offset = "0x8CFA7F0", VA = "0x188CFBBF0")]
		[YLZSHGPPZTN.Root]
		internal static void IGQDZAZABEW(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCD50", Offset = "0x8CFB950", VA = "0x188CFCD50")]
		[UnityEngine.Scripting.Preserve]
		internal UIDRBYENMWV([Inject(null)] WTRHWJWHRVJ scheduler, [Inject(null)] DAKAQELGOPO schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB600", Offset = "0x8CFA200", VA = "0x188CFB600", Slot = "4")]
		public OOULMMSAMVA ANIEYEIHLTO(Func<float> a, Action<float> b, float c, float d, BBFCZVKGTOW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBB00", Offset = "0x8CFA700", VA = "0x188CFBB00", Slot = "5")]
		public OOULMMSAMVA HWZEFEYRVTE(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, BBFCZVKGTOW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB6E0", Offset = "0x8CFA2E0", VA = "0x188CFB6E0", Slot = "6")]
		public OOULMMSAMVA CDNLNPARZAJ(Func<Color> a, Action<Color> b, Color c, float d, BBFCZVKGTOW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB7D0", Offset = "0x8CFA3D0", VA = "0x188CFB7D0", Slot = "7")]
		public OOULMMSAMVA CNLGVFBISFT(Transform a, Vector3 b, float c, BBFCZVKGTOW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBCE0", Offset = "0x8CFA8E0", VA = "0x188CFBCE0", Slot = "8")]
		public OOULMMSAMVA JWUCYTPMIGP(Transform a, Quaternion b, float c, BBFCZVKGTOW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCB80", Offset = "0x8CFB780", VA = "0x188CFCB80", Slot = "9")]
		public OOULMMSAMVA YQZLUTKUABU(Transform a, Vector3 b, float c, BBFCZVKGTOW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC9F0", Offset = "0x8CFB5F0", VA = "0x188CFC9F0", Slot = "10")]
		public QSMJBFLEKGU Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC1E0", Offset = "0x8CFADE0", VA = "0x188CFC1E0", Slot = "11")]
		public void OURGWADZUZG(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC090", Offset = "0x8CFAC90", VA = "0x188CFC090", Slot = "12")]
		public void OURGWADZUZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC380", Offset = "0x8CFAF80", VA = "0x188CFC380")]
		private void QBUNSIETDPE(Behaviour a, NESLEOOATLV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC020", Offset = "0x8CFAC20", VA = "0x188CFC020")]
		[IteratorStateMachine(typeof(QNQJEFZCTYI))]
		private IEnumerator<YRPRUNTVYNF> OJSFFIOZQFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC640", Offset = "0x8CFB240", VA = "0x188CFC640")]
		private void Run(Behaviour context, NESLEOOATLV sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBEA0", Offset = "0x8CFAAA0", VA = "0x188CFBEA0")]
		[IteratorStateMachine(typeof(PSGKHMNNMHA))]
		private IEnumerator<YRPRUNTVYNF> MRYKUWDVBON(GIDMVWCTTWY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB9A0", Offset = "0x8CFA5A0", VA = "0x188CFB9A0")]
		private void GUVFMCSSIDP(NESLEOOATLV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBF30", Offset = "0x8CFAB30", VA = "0x188CFBF30")]
		private void OARXUYBSKBU(NESLEOOATLV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC090", Offset = "0x8CFAC90", VA = "0x188CFC090")]
		private void ZDVLNUVYNVV(Scene a, LoadSceneMode b)
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
