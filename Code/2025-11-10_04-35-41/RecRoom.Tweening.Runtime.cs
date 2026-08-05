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
		[Cpp2IlInjected.Address(RVA = "0x8DB8230", Offset = "0x8DB7630", VA = "0x188DB8230", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IYSQKTEEQOL
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
		public static class NLDCADSBNAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2788E50", Offset = "0x2788250", VA = "0x182788E50")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3A30", Offset = "0x8DB2E30", VA = "0x188DB3A30")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8DB39E0", Offset = "0x8DB2DE0", VA = "0x188DB39E0")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class BXPQCNJBWAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1440", Offset = "0x8DB0840", VA = "0x188DB1440")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1450", Offset = "0x8DB0850", VA = "0x188DB1450")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8DB13F0", Offset = "0x8DB07F0", VA = "0x188DB13F0")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class OTVUKELTFQB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3C70", Offset = "0x8DB3070", VA = "0x188DB3C70")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3C80", Offset = "0x8DB3080", VA = "0x188DB3C80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3C10", Offset = "0x8DB3010", VA = "0x188DB3C10")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class UMKSQHMRGVH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8DB5560", Offset = "0x8DB4960", VA = "0x188DB5560")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8DB5580", Offset = "0x8DB4980", VA = "0x188DB5580")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8DB5500", Offset = "0x8DB4900", VA = "0x188DB5500")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4DF0", Offset = "0x8DB41F0", VA = "0x188DB4DF0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4E20", Offset = "0x8DB4220", VA = "0x188DB4E20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4DC0", Offset = "0x8DB41C0", VA = "0x188DB4DC0")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1E50", Offset = "0x8DB1250", VA = "0x188DB1E50")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1EA0", Offset = "0x8DB12A0", VA = "0x188DB1EA0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1D90", Offset = "0x8DB1190", VA = "0x188DB1D90")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class OGPDPOOJLNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3B00", Offset = "0x8DB2F00", VA = "0x188DB3B00")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3B60", Offset = "0x8DB2F60", VA = "0x188DB3B60")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3A50", Offset = "0x8DB2E50", VA = "0x188DB3A50")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class MXPLNPZIVEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3870", Offset = "0x8DB2C70", VA = "0x188DB3870")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3920", Offset = "0x8DB2D20", VA = "0x188DB3920")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8DB37A0", Offset = "0x8DB2BA0", VA = "0x188DB37A0")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float TOUILFJPLRJ;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float QXTMFWYDYKD;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1550", Offset = "0x8DB0950", VA = "0x188DB1550")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8DB15C0", Offset = "0x8DB09C0", VA = "0x188DB15C0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1470", Offset = "0x8DB0870", VA = "0x188DB1470")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8DB17B0", Offset = "0x8DB0BB0", VA = "0x188DB17B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1880", Offset = "0x8DB0C80", VA = "0x188DB1880")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1690", Offset = "0x8DB0A90", VA = "0x188DB1690")]
			public static float AWXTLLQONDJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1F80", Offset = "0x8DB1380", VA = "0x188DB1F80")]
		public static float ZPQRWUEPPPK(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class EYDFSPELFOG : LYPJFPBVEXY
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1C80", Offset = "0x8DB1080", VA = "0x188DB1C80")]
		public EYDFSPELFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "13")]
		public override bool IRSSDFDEICM(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAF3EA0", Offset = "0xAF32A0", VA = "0x180AF3EA0", Slot = "14")]
		public override float CEHFQDVAHHE()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class ATSRDCMTMBX : MBAYNCISZQV<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1350", Offset = "0x8DB0750", VA = "0x188DB1350")]
		public ATSRDCMTMBX(Func<Color> a, Action<Color> b, Color c, float d, IYSQKTEEQOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xC17E20", Offset = "0xC17220", VA = "0x180C17E20", Slot = "15")]
		protected override Color AFQAVXLTNSY()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8246460", Offset = "0x8245860", VA = "0x188246460", Slot = "16")]
		protected override Color QMYTFQULZCN(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class KYUBFLZZMFS : MBAYNCISZQV<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2A90", Offset = "0x8DB1E90", VA = "0x188DB2A90")]
		public KYUBFLZZMFS(Func<float> a, Action<float> b, float c, float d, IYSQKTEEQOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2A20", Offset = "0x8DB1E20", VA = "0x188DB2A20", Slot = "15")]
		protected override float AFQAVXLTNSY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2A70", Offset = "0x8DB1E70", VA = "0x188DB2A70", Slot = "16")]
		protected override float QMYTFQULZCN(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class XRSLUVVYVYK : MBAYNCISZQV<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7E00", Offset = "0x8DB7200", VA = "0x188DB7E00")]
		public XRSLUVVYVYK(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, IYSQKTEEQOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7BF0", Offset = "0x8DB6FF0", VA = "0x188DB7BF0", Slot = "15")]
		protected override Quaternion AFQAVXLTNSY()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7DB0", Offset = "0x8DB71B0", VA = "0x188DB7DB0", Slot = "16")]
		protected override Quaternion QMYTFQULZCN(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class MMZBFFWRQBI : MBAYNCISZQV<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3690", Offset = "0x8DB2A90", VA = "0x188DB3690")]
		public MMZBFFWRQBI(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IYSQKTEEQOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3580", Offset = "0x8DB2980", VA = "0x188DB3580", Slot = "15")]
		protected override Vector3 AFQAVXLTNSY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3620", Offset = "0x8DB2A20", VA = "0x188DB3620", Slot = "16")]
		protected override Vector3 QMYTFQULZCN(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface MHACNHUTYMJ
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action NOSAPOGYSGP;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MHACNHUTYMJ VDLDNNOLOUG(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		MHACNHUTYMJ PZAVUMUHXZO(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MHACNHUTYMJ ALNSVVLSCDD(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		BRWPWCYORRE QCWWWEOTBTR();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IRSSDFDEICM(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float CEHFQDVAHHE();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface MHFRAFIUJOH : MHACNHUTYMJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface UUAGEURLETL : MHACNHUTYMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UUAGEURLETL MSXFBCBZGNS(MHACNHUTYMJ a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UUAGEURLETL MSXFBCBZGNS(Func<MHACNHUTYMJ> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		UUAGEURLETL DAZIXIFNQMV(IEnumerable<MHACNHUTYMJ> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		UUAGEURLETL DAZIXIFNQMV(params MHACNHUTYMJ[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		UUAGEURLETL HYOPLTKLGBW(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface XALXKSHZKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MHFRAFIUJOH HPBQYYBCTOZ(Func<float> a, Action<float> b, float c, float d, IYSQKTEEQOL.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MHFRAFIUJOH IIUGSPMWXGX(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IYSQKTEEQOL.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MHFRAFIUJOH LDZYQYNOMPW(Func<Color> a, Action<Color> b, Color c, float d, IYSQKTEEQOL.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		MHFRAFIUJOH ZTMNRGYAMRM(Transform a, Vector3 b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MHFRAFIUJOH AAVBOTKNZLQ(Transform a, Quaternion b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		MHFRAFIUJOH WKTEUNMXFNA(Transform a, Vector3 b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		MHFRAFIUJOH XKOTJHCOBLN(Transform a, Vector3 b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		UUAGEURLETL Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RNESDQQGCNF(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class WYPWHYVCEJP
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MHACNHUTYMJ EYDFSPELFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8DB7280", Offset = "0x8DB6680", VA = "0x188DB7280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7A20", Offset = "0x8DB6E20", VA = "0x188DB7A20")]
		internal static XALXKSHZKNN ZZPXRUUFRFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8DB72D0", Offset = "0x8DB66D0", VA = "0x188DB72D0")]
		public static MHFRAFIUJOH HPBQYYBCTOZ(Func<float> a, Action<float> b, float c, float d, IYSQKTEEQOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7400", Offset = "0x8DB6800", VA = "0x188DB7400")]
		public static MHFRAFIUJOH IIUGSPMWXGX(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IYSQKTEEQOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7560", Offset = "0x8DB6960", VA = "0x188DB7560")]
		public static MHFRAFIUJOH LDZYQYNOMPW(Func<Color> a, Action<Color> b, Color c, float d, IYSQKTEEQOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7950", Offset = "0x8DB6D50", VA = "0x188DB7950")]
		public static MHFRAFIUJOH ZTMNRGYAMRM(Transform a, Vector3 b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7150", Offset = "0x8DB6550", VA = "0x188DB7150")]
		public static MHFRAFIUJOH AAVBOTKNZLQ(Transform a, Quaternion b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7880", Offset = "0x8DB6C80", VA = "0x188DB7880")]
		public static MHFRAFIUJOH XKOTJHCOBLN(Transform a, Vector3 b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7790", Offset = "0x8DB6B90", VA = "0x188DB7790")]
		public static UUAGEURLETL Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8DB76A0", Offset = "0x8DB6AA0", VA = "0x188DB76A0")]
		public static void RNESDQQGCNF(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class LAGJCWMOZDS : MHACNHUTYMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action UJVOWTYBRVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action RRXIKHMTVTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> THBOEQPWBES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> PEHDBPLGSSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> GHUNAUFIMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected GHKHLLHSCAN UAAAFZPRYNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object XAKJVVUODWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool HWMFDTZQSDG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool LDWJCDOQSIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8DB32A0", Offset = "0x8DB26A0", VA = "0x188DB32A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool NDERTCEYITZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3280", Offset = "0x8DB2680", VA = "0x188DB3280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NOSAPOGYSGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8DB2FA0", Offset = "0x8DB23A0", VA = "0x188DB2FA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8DB2F00", Offset = "0x8DB2300", VA = "0x188DB2F00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810", Slot = "9")]
		public BRWPWCYORRE QCWWWEOTBTR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8DB32C0", Offset = "0x8DB26C0", VA = "0x188DB32C0", Slot = "6")]
		public MHACNHUTYMJ VDLDNNOLOUG(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3170", Offset = "0x8DB2570", VA = "0x188DB3170", Slot = "7")]
		public MHACNHUTYMJ PZAVUMUHXZO(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2B00", Offset = "0x8DB1F00", VA = "0x188DB2B00", Slot = "8")]
		public MHACNHUTYMJ ALNSVVLSCDD(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool IRSSDFDEICM(float a);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float CEHFQDVAHHE();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2D60", Offset = "0x8DB2160", VA = "0x188DB2D60", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3040", Offset = "0x8DB2440", VA = "0x188DB3040")]
		protected void MNCJSWLUWLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2BF0", Offset = "0x8DB1FF0", VA = "0x188DB2BF0")]
		protected void BYPYWYHRJDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3370", Offset = "0x8DB2770", VA = "0x188DB3370")]
		protected LAGJCWMOZDS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class EERKTNHNSUX
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1AA0", Offset = "0x8DB0EA0", VA = "0x188DB1AA0")]
		public static MHFRAFIUJOH WKTEUNMXFNA(this Behaviour a, Vector3 b, float c, IYSQKTEEQOL.Functions d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1B90", Offset = "0x8DB0F90", VA = "0x188DB1B90")]
		public static MHFRAFIUJOH XKOTJHCOBLN(this Behaviour a, Vector3 b, float c, IYSQKTEEQOL.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class LYPJFPBVEXY : LAGJCWMOZDS, MHFRAFIUJOH, MHACNHUTYMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool COKIHBNVHUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float EDEYOXZHUES;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected IYSQKTEEQOL.Functions AESIHGXRZEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xC473A0", Offset = "0xC467A0", VA = "0x180C473A0")]
			[CompilerGenerated]
			get
			{
				return default(IYSQKTEEQOL.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3470", Offset = "0x8DB2870", VA = "0x188DB3470")]
		protected LYPJFPBVEXY(float a, IYSQKTEEQOL.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1194FA0", Offset = "0x11943A0", VA = "0x181194FA0")]
		[CompilerGenerated]
		private void IUENEBZHZTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3450", Offset = "0x8DB2850", VA = "0x188DB3450")]
		[CompilerGenerated]
		private void IUJUBITFJEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class MBAYNCISZQV<a> : LYPJFPBVEXY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> HUJLBGKPPAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> DUZRYJOBBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a FRDGRQPBUUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float ULVRLYDBDTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a QFQAACGXWPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a KGAAKGACOVO;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x57AC760", Offset = "0x57ABB60", VA = "0x1857AC760")]
		protected MBAYNCISZQV(Func<a> a, Action<a> b, a c, float d, IYSQKTEEQOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a AFQAVXLTNSY();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a QMYTFQULZCN(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x57ABB80", Offset = "0x57AAF80", VA = "0x1857ABB80", Slot = "13")]
		public override bool IRSSDFDEICM(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x57AB400", Offset = "0x57AA800", VA = "0x1857AB400", Slot = "14")]
		public override float CEHFQDVAHHE()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class RQSMLNNRBMQ : LAGJCWMOZDS, UUAGEURLETL, MHACNHUTYMJ
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
			private MHACNHUTYMJ tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<MHACNHUTYMJ> factory;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8DB5110", Offset = "0x8DB4510", VA = "0x188DB5110")]
			public TweenEntry(MHACNHUTYMJ tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1A36B20", Offset = "0x1A35F20", VA = "0x181A36B20")]
			public TweenEntry(Func<MHACNHUTYMJ> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4FF0", Offset = "0x8DB43F0", VA = "0x188DB4FF0")]
			public MHACNHUTYMJ HRACXBQQELX()
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
		private readonly List<Step> KATWOWHSXBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int ZLBJSNHSDER;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4C80", Offset = "0x8DB4080", VA = "0x188DB4C80")]
		public RQSMLNNRBMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB43B0", Offset = "0x8DB37B0", VA = "0x188DB43B0", Slot = "15")]
		public UUAGEURLETL MSXFBCBZGNS(MHACNHUTYMJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8DB45B0", Offset = "0x8DB39B0", VA = "0x188DB45B0", Slot = "16")]
		public UUAGEURLETL MSXFBCBZGNS(Func<MHACNHUTYMJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3ED0", Offset = "0x8DB32D0", VA = "0x188DB3ED0", Slot = "17")]
		public UUAGEURLETL DAZIXIFNQMV(IEnumerable<MHACNHUTYMJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4020", Offset = "0x8DB3420", VA = "0x188DB4020", Slot = "18")]
		public UUAGEURLETL DAZIXIFNQMV(params MHACNHUTYMJ[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4190", Offset = "0x8DB3590", VA = "0x188DB4190", Slot = "19")]
		public UUAGEURLETL HYOPLTKLGBW(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8DB42A0", Offset = "0x8DB36A0", VA = "0x188DB42A0", Slot = "13")]
		public override bool IRSSDFDEICM(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3CB0", Offset = "0x8DB30B0", VA = "0x188DB3CB0", Slot = "14")]
		public override float CEHFQDVAHHE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4670", Offset = "0x8DB3A70", VA = "0x188DB4670")]
		private bool TSZYPJMXQLP(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3DC0", Offset = "0x8DB31C0", VA = "0x188DB3DC0")]
		private UUAGEURLETL DAZIXIFNQMV(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1194FA0", Offset = "0x11943A0", VA = "0x181194FA0")]
		[CompilerGenerated]
		private void IUENEBZHZTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3450", Offset = "0x8DB2850", VA = "0x188DB3450")]
		[CompilerGenerated]
		private void IUJUBITFJEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class WDIENDTLUEY : XALXKSHZKNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public LAGJCWMOZDS Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class DGZUGYUZOOX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform DMWBTJWODWX;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DGZUGYUZOOX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1920", Offset = "0x8DB0D20", VA = "0x188DB1920")]
			internal Vector3 ZRXUNZAYJIA()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1960", Offset = "0x8DB0D60", VA = "0x188DB1960")]
			internal void ZSDBLFUVSTJ(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class MTCDKCMSKAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform DMWBTJWODWX;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MTCDKCMSKAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3730", Offset = "0x8DB2B30", VA = "0x188DB3730")]
			internal Quaternion KERLVTUCVQE()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3770", Offset = "0x8DB2B70", VA = "0x188DB3770")]
			internal void KEWSTAOAFBN(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class GWDZXBYWEWG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform DMWBTJWODWX;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public GWDZXBYWEWG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1F00", Offset = "0x8DB1300", VA = "0x188DB1F00")]
			internal Vector3 VHYSMFGHAKQ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1F40", Offset = "0x8DB1340", VA = "0x188DB1F40")]
			internal void VIDZJMAEJVZ(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class OKOPEPOQFBZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Transform DMWBTJWODWX;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OKOPEPOQFBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3BD0", Offset = "0x8DB2FD0", VA = "0x188DB3BD0")]
			internal Vector3 VQYVQWTQFIX()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3B90", Offset = "0x8DB2F90", VA = "0x188DB3B90")]
			internal void VQTOTPZSVXO(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class DJEEUXRFMMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public LAGJCWMOZDS HASLDFYMJTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public WDIENDTLUEY MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Behaviour CNGCLABNYJH;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DJEEUXRFMMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8DB19A0", Offset = "0x8DB0DA0", VA = "0x188DB19A0")]
			internal void RLGPGNPZASF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class TWLQVARRGGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public WDIENDTLUEY MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public LAGJCWMOZDS PKGUTSYLLQL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public VNDHQZCKPIP GWPXZWUGEAP;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public TWLQVARRGGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4E90", Offset = "0x8DB4290", VA = "0x188DB4E90")]
			internal void LXSCDTCFDUX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4E40", Offset = "0x8DB4240", VA = "0x188DB4E40")]
			internal void LXMVGMIHUJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4FA0", Offset = "0x8DB43A0", VA = "0x188DB4FA0")]
			internal void LYCPYGPZWRP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class WRDMVKMPRJH : IEnumerator<EXCEMTVEEEU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private EXCEMTVEEEU JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public MHACNHUTYMJ HASLDFYMJTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public WDIENDTLUEY MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private EXCEMTVEEEU RGLTPZKGWZB
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public WRDMVKMPRJH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8DB7080", Offset = "0x8DB6480", VA = "0x188DB7080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8DB7040", Offset = "0x8DB6440", VA = "0x188DB7040", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class XVIQMICCONH : IEnumerator<EXCEMTVEEEU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private EXCEMTVEEEU JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public WDIENDTLUEY MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private EXCEMTVEEEU RGLTPZKGWZB
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public XVIQMICCONH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8DB7EE0", Offset = "0x8DB72E0", VA = "0x188DB7EE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8DB7EA0", Offset = "0x8DB72A0", VA = "0x188DB7EA0", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly WRIIEUEWQVY WECBNBUUWBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly HAKAJESWXQP UOWZKGZOUWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> IRYIWZUJRST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> QJASQAAVJIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<LAGJCWMOZDS> HTGSMASVSFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<LAGJCWMOZDS>> LOJDDJMSXMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool ZFIWQTWPVEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private VNDHQZCKPIP AAPVMTIOTPN;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6800", Offset = "0x8DB5C00", VA = "0x188DB6800")]
		[CVOOPLRRRUK.Root]
		internal static void UUDUQLMHCPR(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6ED0", Offset = "0x8DB62D0", VA = "0x188DB6ED0")]
		[UnityEngine.Scripting.Preserve]
		internal WDIENDTLUEY([Inject(null)] WRIIEUEWQVY scheduler, [Inject(null)] HAKAJESWXQP schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5950", Offset = "0x8DB4D50", VA = "0x188DB5950", Slot = "4")]
		public MHFRAFIUJOH HPBQYYBCTOZ(Func<float> a, Action<float> b, float c, float d, IYSQKTEEQOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5A30", Offset = "0x8DB4E30", VA = "0x188DB5A30", Slot = "5")]
		public MHFRAFIUJOH IIUGSPMWXGX(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IYSQKTEEQOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5B20", Offset = "0x8DB4F20", VA = "0x188DB5B20", Slot = "6")]
		public MHFRAFIUJOH LDZYQYNOMPW(Func<Color> a, Action<Color> b, Color c, float d, IYSQKTEEQOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6D00", Offset = "0x8DB6100", VA = "0x188DB6D00", Slot = "7")]
		public MHFRAFIUJOH ZTMNRGYAMRM(Transform a, Vector3 b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8DB55B0", Offset = "0x8DB49B0", VA = "0x188DB55B0", Slot = "8")]
		public MHFRAFIUJOH AAVBOTKNZLQ(Transform a, Quaternion b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6960", Offset = "0x8DB5D60", VA = "0x188DB6960", Slot = "9")]
		public MHFRAFIUJOH WKTEUNMXFNA(Transform a, Vector3 b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6B30", Offset = "0x8DB5F30", VA = "0x188DB6B30", Slot = "10")]
		public MHFRAFIUJOH XKOTJHCOBLN(Transform a, Vector3 b, float c, IYSQKTEEQOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6670", Offset = "0x8DB5A70", VA = "0x188DB6670", Slot = "11")]
		public UUAGEURLETL Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6120", Offset = "0x8DB5520", VA = "0x188DB6120", Slot = "12")]
		public void RNESDQQGCNF(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5770", Offset = "0x8DB4B70", VA = "0x188DB5770", Slot = "13")]
		public void RNESDQQGCNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5D70", Offset = "0x8DB5170", VA = "0x188DB5D70")]
		private void MVVFOBOFFRT(Behaviour a, LAGJCWMOZDS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8DB68F0", Offset = "0x8DB5CF0", VA = "0x188DB68F0")]
		[IteratorStateMachine(typeof(XVIQMICCONH))]
		private IEnumerator<EXCEMTVEEEU> VWWQLJIBGXI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8DB62C0", Offset = "0x8DB56C0", VA = "0x188DB62C0")]
		private void Run(Behaviour context, LAGJCWMOZDS sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8DB58C0", Offset = "0x8DB4CC0", VA = "0x188DB58C0")]
		[IteratorStateMachine(typeof(WRDMVKMPRJH))]
		private IEnumerator<EXCEMTVEEEU> EXXBTOEHYMU(MHACNHUTYMJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5C10", Offset = "0x8DB5010", VA = "0x188DB5C10")]
		private void MSXFBCBZGNS(LAGJCWMOZDS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6030", Offset = "0x8DB5430", VA = "0x188DB6030")]
		private void PJLEICZYVEJ(LAGJCWMOZDS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5770", Offset = "0x8DB4B70", VA = "0x188DB5770")]
		private void BATATJWMLKA(Scene a, LoadSceneMode b)
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
