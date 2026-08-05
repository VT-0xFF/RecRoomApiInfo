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
		[Cpp2IlInjected.Address(RVA = "0x8F64950", Offset = "0x8F63B50", VA = "0x188F64950", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class LARXKJIDEIJ
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
		public static class HFUCXPCJBPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2818020", Offset = "0x2817220", VA = "0x182818020")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E530", Offset = "0x8F5D730", VA = "0x188F5E530")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E4E0", Offset = "0x8F5D6E0", VA = "0x188F5E4E0")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class THPUARCEPLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8F61DE0", Offset = "0x8F60FE0", VA = "0x188F61DE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F61E40", Offset = "0x8F61040", VA = "0x188F61E40")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8F61DF0", Offset = "0x8F60FF0", VA = "0x188F61DF0")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class OCNMTWHWHBR
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8F5F810", Offset = "0x8F5EA10", VA = "0x188F5F810")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8F5F880", Offset = "0x8F5EA80", VA = "0x188F5F880")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8F5F820", Offset = "0x8F5EA20", VA = "0x188F5F820")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class SGFSYXPBHVF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8F61180", Offset = "0x8F60380", VA = "0x188F61180")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8F61200", Offset = "0x8F60400", VA = "0x188F61200")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8F611A0", Offset = "0x8F603A0", VA = "0x188F611A0")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8F61D60", Offset = "0x8F60F60", VA = "0x188F61D60")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8F61DC0", Offset = "0x8F60FC0", VA = "0x188F61DC0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8F61D90", Offset = "0x8F60F90", VA = "0x188F61D90")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E370", Offset = "0x8F5D570", VA = "0x188F5E370")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E480", Offset = "0x8F5D680", VA = "0x188F5E480")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E3C0", Offset = "0x8F5D5C0", VA = "0x188F5E3C0")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class RCSEJUSLPOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8F5FAF0", Offset = "0x8F5ECF0", VA = "0x188F5FAF0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8F5FC00", Offset = "0x8F5EE00", VA = "0x188F5FC00")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8F5FB50", Offset = "0x8F5ED50", VA = "0x188F5FB50")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class PJTZQVLDBOX
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8F5F8B0", Offset = "0x8F5EAB0", VA = "0x188F5F8B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8F5FA30", Offset = "0x8F5EC30", VA = "0x188F5FA30")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8F5F960", Offset = "0x8F5EB60", VA = "0x188F5F960")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float PONLRAQDBAR;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float WLPWJAJAPAB;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8F5DE20", Offset = "0x8F5D020", VA = "0x188F5DE20")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8F5DF70", Offset = "0x8F5D170", VA = "0x188F5DF70")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8F5DE90", Offset = "0x8F5D090", VA = "0x188F5DE90")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E040", Offset = "0x8F5D240", VA = "0x188F5E040")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E230", Offset = "0x8F5D430", VA = "0x188F5E230")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E110", Offset = "0x8F5D310", VA = "0x188F5E110")]
			public static float NGAOOBMNJGN(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F5E660", Offset = "0x8F5D860", VA = "0x188F5E660")]
		public static float TSRDIJTMPEC(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class MLOHUEQITLS : MGMWRJPOKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8F5F670", Offset = "0x8F5E870", VA = "0x188F5F670")]
		public MLOHUEQITLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "13")]
		public override bool ZQPIYYXMLWO(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB07310", Offset = "0xB06510", VA = "0x180B07310", Slot = "14")]
		public override float HELZPFPFDDK()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class ELRRHPUOFCX : EWYEWEZKRKT<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8F5E2D0", Offset = "0x8F5D4D0", VA = "0x188F5E2D0")]
		public ELRRHPUOFCX(Func<Color> a, Action<Color> b, Color c, float d, LARXKJIDEIJ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCCA3F0", Offset = "0xCC95F0", VA = "0x180CCA3F0", Slot = "15")]
		protected override Color AOLNXIAPXKW()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83F03F0", Offset = "0x83EF5F0", VA = "0x1883F03F0", Slot = "16")]
		protected override Color KTKOGNZFCJR(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class VCUHNBANNGK : EWYEWEZKRKT<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8F63B90", Offset = "0x8F62D90", VA = "0x188F63B90")]
		public VCUHNBANNGK(Func<float> a, Action<float> b, float c, float d, LARXKJIDEIJ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F63B20", Offset = "0x8F62D20", VA = "0x188F63B20", Slot = "15")]
		protected override float AOLNXIAPXKW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8F63B70", Offset = "0x8F62D70", VA = "0x188F63B70", Slot = "16")]
		protected override float KTKOGNZFCJR(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class XIKGTVNGRDO : EWYEWEZKRKT<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F64700", Offset = "0x8F63900", VA = "0x188F64700")]
		public XIKGTVNGRDO(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, LARXKJIDEIJ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F644F0", Offset = "0x8F636F0", VA = "0x188F644F0", Slot = "15")]
		protected override Quaternion AOLNXIAPXKW()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F646B0", Offset = "0x8F638B0", VA = "0x188F646B0", Slot = "16")]
		protected override Quaternion KTKOGNZFCJR(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class RFFOIAHFRGU : EWYEWEZKRKT<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F5FD40", Offset = "0x8F5EF40", VA = "0x188F5FD40")]
		public RFFOIAHFRGU(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, LARXKJIDEIJ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F5FC30", Offset = "0x8F5EE30", VA = "0x188F5FC30", Slot = "15")]
		protected override Vector3 AOLNXIAPXKW()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F5FCD0", Offset = "0x8F5EED0", VA = "0x188F5FCD0", Slot = "16")]
		protected override Vector3 KTKOGNZFCJR(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface UNPKFKIWAYX
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action SWTVNHELKLH;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		UNPKFKIWAYX ZBWNQAOHMGE(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		UNPKFKIWAYX NKQUZLIFEAC(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		UNPKFKIWAYX DLTIYNBYDCT(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		AZBXLTTNREY KEOTPCDFMCZ();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ZQPIYYXMLWO(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float HELZPFPFDDK();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface SBJYVRYMIDX : UNPKFKIWAYX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface SOJGEZCFNZN : UNPKFKIWAYX
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SOJGEZCFNZN UHZPMFWCVJE(UNPKFKIWAYX a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		SOJGEZCFNZN UHZPMFWCVJE(Func<UNPKFKIWAYX> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		SOJGEZCFNZN VYOZWQDGQFR(IEnumerable<UNPKFKIWAYX> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SOJGEZCFNZN VYOZWQDGQFR(params UNPKFKIWAYX[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		SOJGEZCFNZN ZJXPZAMZTOG(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface BPMESRWOMRH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SBJYVRYMIDX OTCHSVZMIRV(Func<float> a, Action<float> b, float c, float d, LARXKJIDEIJ.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		SBJYVRYMIDX ACPERGVXIXT(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, LARXKJIDEIJ.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		SBJYVRYMIDX MNSXDMEOQNI(Func<Color> a, Action<Color> b, Color c, float d, LARXKJIDEIJ.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SBJYVRYMIDX OVAXVSYFEJO(Transform a, Vector3 b, float c, LARXKJIDEIJ.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		SBJYVRYMIDX BOTJHECTBFK(Transform a, Quaternion b, float c, LARXKJIDEIJ.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		SBJYVRYMIDX TDNMLFHOQWJ(Transform a, Vector3 b, float c, LARXKJIDEIJ.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		SOJGEZCFNZN Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void WFWJDELGRFX(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class SWXXISWKIRB
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static UNPKFKIWAYX MLOHUEQITLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8F61390", Offset = "0x8F60590", VA = "0x188F61390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8F61850", Offset = "0x8F60A50", VA = "0x188F61850")]
		internal static BPMESRWOMRH RBBVACIJOAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8F61650", Offset = "0x8F60850", VA = "0x188F61650")]
		public static SBJYVRYMIDX OTCHSVZMIRV(Func<float> a, Action<float> b, float c, float d, LARXKJIDEIJ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8F61230", Offset = "0x8F60430", VA = "0x188F61230")]
		public static SBJYVRYMIDX ACPERGVXIXT(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, LARXKJIDEIJ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8F61510", Offset = "0x8F60710", VA = "0x188F61510")]
		public static SBJYVRYMIDX MNSXDMEOQNI(Func<Color> a, Action<Color> b, Color c, float d, LARXKJIDEIJ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8F61780", Offset = "0x8F60980", VA = "0x188F61780")]
		public static SBJYVRYMIDX OVAXVSYFEJO(Transform a, Vector3 b, float c, LARXKJIDEIJ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8F613E0", Offset = "0x8F605E0", VA = "0x188F613E0")]
		public static SBJYVRYMIDX BOTJHECTBFK(Transform a, Quaternion b, float c, LARXKJIDEIJ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8F619B0", Offset = "0x8F60BB0", VA = "0x188F619B0")]
		public static SBJYVRYMIDX TDNMLFHOQWJ(Transform a, Vector3 b, float c, LARXKJIDEIJ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8F618C0", Offset = "0x8F60AC0", VA = "0x188F618C0")]
		public static SOJGEZCFNZN Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8F61A80", Offset = "0x8F60C80", VA = "0x188F61A80")]
		public static void WFWJDELGRFX(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class WZIAMGBUPWO : UNPKFKIWAYX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action RQJGAYPZKHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action OFVWPHKMCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> FMJVNWWBRUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> GJEZJCUNWBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> TPZHCTSQFGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected MQEKQPMIYOX JIQTMOOBEYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object ICJKLSOJDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool WRJOHFRVLDA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool KTDZHCSHFDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8F63FA0", Offset = "0x8F631A0", VA = "0x188F63FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool LOAQMDJTYTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8F64160", Offset = "0x8F63360", VA = "0x188F64160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action SWTVNHELKLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8F642B0", Offset = "0x8F634B0", VA = "0x188F642B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8F640C0", Offset = "0x8F632C0", VA = "0x188F640C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0", Slot = "9")]
		public AZBXLTTNREY KEOTPCDFMCZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F64350", Offset = "0x8F63550", VA = "0x188F64350", Slot = "6")]
		public UNPKFKIWAYX ZBWNQAOHMGE(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F63FC0", Offset = "0x8F631C0", VA = "0x188F63FC0", Slot = "7")]
		public UNPKFKIWAYX NKQUZLIFEAC(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8F63DA0", Offset = "0x8F62FA0", VA = "0x188F63DA0", Slot = "8")]
		public UNPKFKIWAYX DLTIYNBYDCT(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool ZQPIYYXMLWO(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float HELZPFPFDDK();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8F63C00", Offset = "0x8F62E00", VA = "0x188F63C00", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8F64180", Offset = "0x8F63380", VA = "0x188F64180")]
		protected void TMGAZKRJOLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8F63E30", Offset = "0x8F63030", VA = "0x188F63E30")]
		protected void EVDPLWKILKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8F64410", Offset = "0x8F63610", VA = "0x188F64410")]
		protected WZIAMGBUPWO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class BNUVVMWBJUZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8F5DD30", Offset = "0x8F5CF30", VA = "0x188F5DD30")]
		public static SBJYVRYMIDX TDNMLFHOQWJ(this Behaviour a, Vector3 b, float c, LARXKJIDEIJ.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class MGMWRJPOKKM : WZIAMGBUPWO, SBJYVRYMIDX, UNPKFKIWAYX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool CGZFZXXZSEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float KRWAGKMIHAI;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected LARXKJIDEIJ.Functions MBSKQRHOXVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xDBE750", Offset = "0xDBD950", VA = "0x180DBE750")]
			[CompilerGenerated]
			get
			{
				return default(LARXKJIDEIJ.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8F5F120", Offset = "0x8F5E320", VA = "0x188F5F120")]
		protected MGMWRJPOKKM(float a, LARXKJIDEIJ.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x26D1420", Offset = "0x26D0620", VA = "0x1826D1420")]
		[CompilerGenerated]
		private void VLGWNKAOXVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8F5F100", Offset = "0x8F5E300", VA = "0x188F5F100")]
		[CompilerGenerated]
		private void VLMDKQUMHGV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class EWYEWEZKRKT<a> : MGMWRJPOKKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> SCALJXWATWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> MHSBPLIKHPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a CSPONFPEEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float TGFMCEQNMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a NPXUJXXVUYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a YBXSCXPZSFM;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x47241F0", Offset = "0x47233F0", VA = "0x1847241F0")]
		protected EWYEWEZKRKT(Func<a> a, Action<a> b, a c, float d, LARXKJIDEIJ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a AOLNXIAPXKW();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a KTKOGNZFCJR(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4723DB0", Offset = "0x4722FB0", VA = "0x184723DB0", Slot = "13")]
		public override bool ZQPIYYXMLWO(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4723010", Offset = "0x4722210", VA = "0x184723010", Slot = "14")]
		public override float HELZPFPFDDK()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class ROPJDSDUMLM : WZIAMGBUPWO, SOJGEZCFNZN, UNPKFKIWAYX
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
			private UNPKFKIWAYX tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<UNPKFKIWAYX> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8F63730", Offset = "0x8F62930", VA = "0x188F63730")]
			public TweenEntry(UNPKFKIWAYX tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1B0BD30", Offset = "0x1B0AF30", VA = "0x181B0BD30")]
			public TweenEntry(Func<UNPKFKIWAYX> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8F63610", Offset = "0x8F62810", VA = "0x188F63610")]
			public UNPKFKIWAYX UCIUVLYQYRN()
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
		private readonly List<Step> YICSZQAJPNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int MAYSTALUIWH;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8F60DB0", Offset = "0x8F5FFB0", VA = "0x188F60DB0")]
		public ROPJDSDUMLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8F605B0", Offset = "0x8F5F7B0", VA = "0x188F605B0", Slot = "15")]
		public SOJGEZCFNZN UHZPMFWCVJE(UNPKFKIWAYX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8F604F0", Offset = "0x8F5F6F0", VA = "0x188F604F0", Slot = "16")]
		public SOJGEZCFNZN UHZPMFWCVJE(Func<UNPKFKIWAYX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8F608D0", Offset = "0x8F5FAD0", VA = "0x188F608D0", Slot = "17")]
		public SOJGEZCFNZN VYOZWQDGQFR(IEnumerable<UNPKFKIWAYX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8F60A20", Offset = "0x8F5FC20", VA = "0x188F60A20", Slot = "18")]
		public SOJGEZCFNZN VYOZWQDGQFR(params UNPKFKIWAYX[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8F60B90", Offset = "0x8F5FD90", VA = "0x188F60B90", Slot = "19")]
		public SOJGEZCFNZN ZJXPZAMZTOG(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8F60CA0", Offset = "0x8F5FEA0", VA = "0x188F60CA0", Slot = "13")]
		public override bool ZQPIYYXMLWO(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8F5FDE0", Offset = "0x8F5EFE0", VA = "0x188F5FDE0", Slot = "14")]
		public override float HELZPFPFDDK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8F5FEF0", Offset = "0x8F5F0F0", VA = "0x188F5FEF0")]
		private bool IRTTBIZERTR(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F607B0", Offset = "0x8F5F9B0", VA = "0x188F607B0")]
		private SOJGEZCFNZN VYOZWQDGQFR(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x26D1420", Offset = "0x26D0620", VA = "0x1826D1420")]
		[CompilerGenerated]
		private void VLGWNKAOXVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8F5F100", Offset = "0x8F5E300", VA = "0x188F5F100")]
		[CompilerGenerated]
		private void VLMDKQUMHGV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class TNTQJCCFPRQ : BPMESRWOMRH
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public WZIAMGBUPWO Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class AZPHERFPDAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform VCPTMVUREZT;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public AZPHERFPDAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8F5DCB0", Offset = "0x8F5CEB0", VA = "0x188F5DCB0")]
			internal Vector3 FJSNJDNXESK()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8F5DCF0", Offset = "0x8F5CEF0", VA = "0x188F5DCF0")]
			internal void FJXUGKHUODT(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class RTZKRWAPXNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform VCPTMVUREZT;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public RTZKRWAPXNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8F60F90", Offset = "0x8F60190", VA = "0x188F60F90")]
			internal Quaternion BSAKEVMOSYW()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8F60FD0", Offset = "0x8F601D0", VA = "0x188F60FD0")]
			internal void BSFRCCGMCKF(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class RXNTLJXXKWZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform VCPTMVUREZT;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public RXNTLJXXKWZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8F61040", Offset = "0x8F60240", VA = "0x188F61040")]
			internal Vector3 ZQJOSEMBAEZ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8F61000", Offset = "0x8F60200", VA = "0x188F61000")]
			internal void ZQEHUXSDQTQ(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class RZEEJRFRABC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public WZIAMGBUPWO NIONHTUDBVN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public TNTQJCCFPRQ LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour PHYSJKMZSSL;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public RZEEJRFRABC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8F61080", Offset = "0x8F60280", VA = "0x188F61080")]
			internal void LWNREDFDEMD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class YXACZPAQQQS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public TNTQJCCFPRQ LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public WZIAMGBUPWO JFGSRCEVPVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public IFXEZINOVAZ BQKBLCCBDWF;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public YXACZPAQQQS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8F64840", Offset = "0x8F63A40", VA = "0x188F64840")]
			internal void BPYLIMDWTAZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8F647F0", Offset = "0x8F639F0", VA = "0x188F647F0")]
			internal void BPTELFJZJPQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8F647A0", Offset = "0x8F639A0", VA = "0x188F647A0")]
			internal void BPNXNYQCAEH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class JFHDLYMNAVJ : IEnumerator<GVXKGQILIBM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private GVXKGQILIBM HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public UNPKFKIWAYX NIONHTUDBVN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public TNTQJCCFPRQ LQBDIDDTHZG;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private GVXKGQILIBM FMWFFBPUHSV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
			[DebuggerHidden]
			public JFHDLYMNAVJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E550", Offset = "0x8F5D750", VA = "0x188F5E550", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8F5E620", Offset = "0x8F5D820", VA = "0x188F5E620", Slot = "8")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class MIEVTXQVHYL : IEnumerator<GVXKGQILIBM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private GVXKGQILIBM HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public TNTQJCCFPRQ LQBDIDDTHZG;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private GVXKGQILIBM FMWFFBPUHSV
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
			[DebuggerHidden]
			public MIEVTXQVHYL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8F5F2E0", Offset = "0x8F5E4E0", VA = "0x188F5F2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8F5F630", Offset = "0x8F5E830", VA = "0x188F5F630", Slot = "8")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly GFPWOHIOJAQ LMEFDSOPPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly CVJKYDKTMAN QFBOXDNVKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> XBUOTHEHABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> YFNDIEZYXVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<WZIAMGBUPWO> POTBHYLFMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<WZIAMGBUPWO>> FIIYMZLEFWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool PRXZEUNYRCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private IFXEZINOVAZ XPHVZFAGEYN;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8F633B0", Offset = "0x8F625B0", VA = "0x188F633B0")]
		[OCFGNIRMEEE.Root]
		internal static void XXZSNELNZLP(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8F634A0", Offset = "0x8F626A0", VA = "0x188F634A0")]
		[UnityEngine.Scripting.Preserve]
		internal TNTQJCCFPRQ([Inject(null)] GFPWOHIOJAQ scheduler, [Inject(null)] CVJKYDKTMAN schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8F62380", Offset = "0x8F61580", VA = "0x188F62380", Slot = "4")]
		public SBJYVRYMIDX OTCHSVZMIRV(Func<float> a, Action<float> b, float c, float d, LARXKJIDEIJ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8F61E60", Offset = "0x8F61060", VA = "0x188F61E60", Slot = "5")]
		public SBJYVRYMIDX ACPERGVXIXT(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, LARXKJIDEIJ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8F621A0", Offset = "0x8F613A0", VA = "0x188F621A0", Slot = "6")]
		public SBJYVRYMIDX MNSXDMEOQNI(Func<Color> a, Action<Color> b, Color c, float d, LARXKJIDEIJ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8F62460", Offset = "0x8F61660", VA = "0x188F62460", Slot = "7")]
		public SBJYVRYMIDX OVAXVSYFEJO(Transform a, Vector3 b, float c, LARXKJIDEIJ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8F61F50", Offset = "0x8F61150", VA = "0x188F61F50", Slot = "8")]
		public SBJYVRYMIDX BOTJHECTBFK(Transform a, Quaternion b, float c, LARXKJIDEIJ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8F62E70", Offset = "0x8F62070", VA = "0x188F62E70", Slot = "9")]
		public SBJYVRYMIDX TDNMLFHOQWJ(Transform a, Vector3 b, float c, LARXKJIDEIJ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8F62E00", Offset = "0x8F62000", VA = "0x188F62E00", Slot = "10")]
		public SOJGEZCFNZN Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8F63210", Offset = "0x8F62410", VA = "0x188F63210", Slot = "11")]
		public void WFWJDELGRFX(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8F62630", Offset = "0x8F61830", VA = "0x188F62630", Slot = "12")]
		public void WFWJDELGRFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8F62780", Offset = "0x8F61980", VA = "0x188F62780")]
		private void PYEFPWRRBVF(Behaviour a, WZIAMGBUPWO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8F631A0", Offset = "0x8F623A0", VA = "0x188F631A0")]
		[IteratorStateMachine(typeof(MIEVTXQVHYL))]
		private IEnumerator<GVXKGQILIBM> URQOLFOAGCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8F62A50", Offset = "0x8F61C50", VA = "0x188F62A50")]
		private void Run(Behaviour context, WZIAMGBUPWO sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F62110", Offset = "0x8F61310", VA = "0x188F62110")]
		[IteratorStateMachine(typeof(JFHDLYMNAVJ))]
		private IEnumerator<GVXKGQILIBM> JGMXXTEBCYW(UNPKFKIWAYX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8F63040", Offset = "0x8F62240", VA = "0x188F63040")]
		private void UHZPMFWCVJE(WZIAMGBUPWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8F62290", Offset = "0x8F61490", VA = "0x188F62290")]
		private void OMERURIWDHJ(WZIAMGBUPWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8F62630", Offset = "0x8F61830", VA = "0x188F62630")]
		private void PDHDYAYGYWW(Scene a, LoadSceneMode b)
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
