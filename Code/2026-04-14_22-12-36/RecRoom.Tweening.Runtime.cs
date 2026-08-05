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
		[Cpp2IlInjected.Address(RVA = "0xA3AADD0", Offset = "0xA3A99D0", VA = "0x18A3AADD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F8180", Offset = "0x29F6D80", VA = "0x1829F8180")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class XPZGRJVDVLT
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
		public static class TLBQBEWIWBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2A8F560", Offset = "0x2A8E160", VA = "0x182A8F560")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9BE0", Offset = "0xA3A87E0", VA = "0x18A3A9BE0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9B90", Offset = "0xA3A8790", VA = "0x18A3A9B90")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class YNVSBXCNHZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA3AAC90", Offset = "0xA3A9890", VA = "0x18A3AAC90")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA3AACA0", Offset = "0xA3A98A0", VA = "0x18A3AACA0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA3AAC40", Offset = "0xA3A9840", VA = "0x18A3AAC40")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class CTKUQJDOEQD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4C80", Offset = "0xA3A3880", VA = "0x18A3A4C80")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4C90", Offset = "0xA3A3890", VA = "0x18A3A4C90")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4C20", Offset = "0xA3A3820", VA = "0x18A3A4C20")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class ADCRTIHVRUL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA3A42B0", Offset = "0xA3A2EB0", VA = "0x18A3A42B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA3A42D0", Offset = "0xA3A2ED0", VA = "0x18A3A42D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4250", Offset = "0xA3A2E50", VA = "0x18A3A4250")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9B40", Offset = "0xA3A8740", VA = "0x18A3A9B40")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9B70", Offset = "0xA3A8770", VA = "0x18A3A9B70")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9B10", Offset = "0xA3A8710", VA = "0x18A3A9B10")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA3A6880", Offset = "0xA3A5480", VA = "0x18A3A6880")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA3A68D0", Offset = "0xA3A54D0", VA = "0x18A3A68D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA3A67C0", Offset = "0xA3A53C0", VA = "0x18A3A67C0")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class ECTEIVCMPXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA3A66B0", Offset = "0xA3A52B0", VA = "0x18A3A66B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA3A6710", Offset = "0xA3A5310", VA = "0x18A3A6710")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA3A6600", Offset = "0xA3A5200", VA = "0x18A3A6600")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class BTJMCBJIIYT
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA3A44E0", Offset = "0xA3A30E0", VA = "0x18A3A44E0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4590", Offset = "0xA3A3190", VA = "0x18A3A4590")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4410", Offset = "0xA3A3010", VA = "0x18A3A4410")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float JVPNHGWNWAJ;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float RQWXEESWIPL;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4830", Offset = "0xA3A3430", VA = "0x18A3A4830")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA3A48B0", Offset = "0xA3A34B0", VA = "0x18A3A48B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4750", Offset = "0xA3A3350", VA = "0x18A3A4750")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4AB0", Offset = "0xA3A36B0", VA = "0x18A3A4AB0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4B80", Offset = "0xA3A3780", VA = "0x18A3A4B80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4990", Offset = "0xA3A3590", VA = "0x18A3A4990")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3AA190", Offset = "0xA3A8D90", VA = "0x18A3AA190")]
		public static float GXFEHAZXHNU(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class BRYVDHWLKGU : JRERCMMYZKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4300", Offset = "0xA3A2F00", VA = "0x18A3A4300")]
		public BRYVDHWLKGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "13")]
		public override bool JEOKDWBJGBI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD3F500", Offset = "0xD3E100", VA = "0x180D3F500", Slot = "14")]
		public override float MZIGOYGHHGY()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class IOUEFADWEQD : IMYGGCZYRPV<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7360", Offset = "0xA3A5F60", VA = "0x18A3A7360")]
		public IOUEFADWEQD(Func<Color> a, Action<Color> b, Color c, float d, XPZGRJVDVLT.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF22020", Offset = "0xF20C20", VA = "0x180F22020", Slot = "15")]
		protected override Color OENFZRFUIVY()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x980B950", Offset = "0x980A550", VA = "0x18980B950", Slot = "16")]
		protected override Color KYJQMOTDNZJ(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class FHEGFQRVHMC : IMYGGCZYRPV<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A69A0", Offset = "0xA3A55A0", VA = "0x18A3A69A0")]
		public FHEGFQRVHMC(Func<float> a, Action<float> b, float c, float d, XPZGRJVDVLT.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6950", Offset = "0xA3A5550", VA = "0x18A3A6950", Slot = "15")]
		protected override float OENFZRFUIVY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6930", Offset = "0xA3A5530", VA = "0x18A3A6930", Slot = "16")]
		protected override float KYJQMOTDNZJ(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class ONEWGLNFRQY : IMYGGCZYRPV<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A96E0", Offset = "0xA3A82E0", VA = "0x18A3A96E0")]
		public ONEWGLNFRQY(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, XPZGRJVDVLT.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A9520", Offset = "0xA3A8120", VA = "0x18A3A9520", Slot = "15")]
		protected override Quaternion OENFZRFUIVY()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A94D0", Offset = "0xA3A80D0", VA = "0x18A3A94D0", Slot = "16")]
		protected override Quaternion KYJQMOTDNZJ(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class LMDPGPTVPQE : IMYGGCZYRPV<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA3A9430", Offset = "0xA3A8030", VA = "0x18A3A9430")]
		public LMDPGPTVPQE(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XPZGRJVDVLT.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA3A9390", Offset = "0xA3A7F90", VA = "0x18A3A9390", Slot = "15")]
		protected override Vector3 OENFZRFUIVY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA399C70", Offset = "0xA398870", VA = "0x18A399C70", Slot = "16")]
		protected override Vector3 KYJQMOTDNZJ(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface LFQWSTVHSGP
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action ZXLKWAPTMEJ;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LFQWSTVHSGP QXCJALLWBYA(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		LFQWSTVHSGP IUZIYLIGJZI(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		LFQWSTVHSGP CIBNXBXFBDN(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GMTKWIVSBCA HLQQYYOJUKN();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JEOKDWBJGBI(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float MZIGOYGHHGY();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface BVYHQDHSSVH : LFQWSTVHSGP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface UUKANWITDQT : LFQWSTVHSGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UUKANWITDQT VEAOBANWLIS(LFQWSTVHSGP a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UUKANWITDQT VEAOBANWLIS(Func<LFQWSTVHSGP> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		UUKANWITDQT BCIVFHWZUFN(IEnumerable<LFQWSTVHSGP> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		UUKANWITDQT BCIVFHWZUFN(params LFQWSTVHSGP[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		UUKANWITDQT PHSCOPDNOZY(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface NUDEFLDZQGZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BVYHQDHSSVH AWWHYASOFDJ(Func<float> a, Action<float> b, float c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BVYHQDHSSVH HFKZOFYTJWV(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		BVYHQDHSSVH ZPBLETAWLQC(Func<Color> a, Action<Color> b, Color c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		BVYHQDHSSVH SMYZBOHETWU(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		BVYHQDHSSVH DADKPJFKLKE(Transform a, Quaternion b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		BVYHQDHSSVH RCRXNCGTOPT(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		UUKANWITDQT Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SJHZZALNQKF(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class KLQWFFWZTHF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static LFQWSTVHSGP BRYVDHWLKGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA3A8A20", Offset = "0xA3A7620", VA = "0x18A3A8A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8DE0", Offset = "0xA3A79E0", VA = "0x18A3A8DE0")]
		internal static NUDEFLDZQGZ UTWPBDJNIJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8660", Offset = "0xA3A7260", VA = "0x18A3A8660")]
		public static BVYHQDHSSVH AWWHYASOFDJ(Func<float> a, Action<float> b, float c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A88C0", Offset = "0xA3A74C0", VA = "0x18A3A88C0")]
		public static BVYHQDHSSVH HFKZOFYTJWV(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8E50", Offset = "0xA3A7A50", VA = "0x18A3A8E50")]
		public static BVYHQDHSSVH ZPBLETAWLQC(Func<Color> a, Action<Color> b, Color c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8C20", Offset = "0xA3A7820", VA = "0x18A3A8C20")]
		public static BVYHQDHSSVH SMYZBOHETWU(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8790", Offset = "0xA3A7390", VA = "0x18A3A8790")]
		public static BVYHQDHSSVH DADKPJFKLKE(Transform a, Quaternion b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8A70", Offset = "0xA3A7670", VA = "0x18A3A8A70")]
		public static BVYHQDHSSVH RCRXNCGTOPT(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8CF0", Offset = "0xA3A78F0", VA = "0x18A3A8CF0")]
		public static UUKANWITDQT Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8B40", Offset = "0xA3A7740", VA = "0x18A3A8B40")]
		public static void SJHZZALNQKF(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class HPKVRRLTHZE : LFQWSTVHSGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action VHOGCKIQIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action YKVCEYSQSAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> JDSUSFBBMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> WIDQMRJKQRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> VHMLNNVKYGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected FLVJWJHSBGP YNVUIOBZBUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object AKTBJYBCHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool HRYSJNUFROO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool LKSXBYKJOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA3A6E10", Offset = "0xA3A5A10", VA = "0x18A3A6E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool SQVJFZTNKTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA3A7090", Offset = "0xA3A5C90", VA = "0x18A3A7090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ZXLKWAPTMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA3A71E0", Offset = "0xA3A5DE0", VA = "0x18A3A71E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA3A6F40", Offset = "0xA3A5B40", VA = "0x18A3A6F40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0", Slot = "9")]
		public GMTKWIVSBCA HLQQYYOJUKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6FE0", Offset = "0xA3A5BE0", VA = "0x18A3A6FE0", Slot = "6")]
		public LFQWSTVHSGP QXCJALLWBYA(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6E30", Offset = "0xA3A5A30", VA = "0x18A3A6E30", Slot = "7")]
		public LFQWSTVHSGP IUZIYLIGJZI(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6B80", Offset = "0xA3A5780", VA = "0x18A3A6B80", Slot = "8")]
		public LFQWSTVHSGP CIBNXBXFBDN(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool JEOKDWBJGBI(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float MZIGOYGHHGY();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6C70", Offset = "0xA3A5870", VA = "0x18A3A6C70", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A70B0", Offset = "0xA3A5CB0", VA = "0x18A3A70B0")]
		protected void SCAMOICJUSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6A10", Offset = "0xA3A5610", VA = "0x18A3A6A10")]
		protected void BCOSDPDPNYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7280", Offset = "0xA3A5E80", VA = "0x18A3A7280")]
		protected HPKVRRLTHZE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class LFLGQNKQAWV
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3A90F0", Offset = "0xA3A7CF0", VA = "0x18A3A90F0")]
		public static BVYHQDHSSVH RCRXNCGTOPT(this Behaviour a, Vector3 b, float c, XPZGRJVDVLT.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class JRERCMMYZKE : HPKVRRLTHZE, BVYHQDHSSVH, LFQWSTVHSGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool GRMAMZJHKTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float RIPWOCYENUE;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected XPZGRJVDVLT.Functions ZOMSGQKLWHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x101B930", Offset = "0x101A530", VA = "0x18101B930")]
			[CompilerGenerated]
			get
			{
				return default(XPZGRJVDVLT.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7420", Offset = "0xA3A6020", VA = "0x18A3A7420")]
		protected JRERCMMYZKE(float a, XPZGRJVDVLT.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2966350", Offset = "0x2964F50", VA = "0x182966350")]
		[CompilerGenerated]
		private void RABANQOBNZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7400", Offset = "0xA3A6000", VA = "0x18A3A7400")]
		[CompilerGenerated]
		private void RAGHKXHYXLH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class IMYGGCZYRPV<a> : JRERCMMYZKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> EWVMLGUYDTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> JASAWTDEKNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a ORMNJFZQHNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float KHRACAWOJZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a CEFSGUBUIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a EKRENEBRANA;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x65AF060", Offset = "0x65ADC60", VA = "0x1865AF060")]
		protected IMYGGCZYRPV(Func<a> a, Action<a> b, a c, float d, XPZGRJVDVLT.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a OENFZRFUIVY();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a KYJQMOTDNZJ(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x65AE6B0", Offset = "0x65AD2B0", VA = "0x1865AE6B0", Slot = "13")]
		public override bool JEOKDWBJGBI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x65AEDB0", Offset = "0x65AD9B0", VA = "0x1865AEDB0", Slot = "14")]
		public override float MZIGOYGHHGY()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class KGDMMCIWNQS : HPKVRRLTHZE, UUKANWITDQT, LFQWSTVHSGP
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
			private LFQWSTVHSGP tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<LFQWSTVHSGP> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9D20", Offset = "0xA3A8920", VA = "0x18A3A9D20")]
			public TweenEntry(LFQWSTVHSGP tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D79B10", Offset = "0x1D78710", VA = "0x181D79B10")]
			public TweenEntry(Func<LFQWSTVHSGP> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9C00", Offset = "0xA3A8800", VA = "0x18A3A9C00")]
			public LFQWSTVHSGP YOLEAEKGQNZ()
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
		private readonly List<Step> GWRYAHOXHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int ILCYUTIUMMH;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8520", Offset = "0xA3A7120", VA = "0x18A3A8520")]
		public KGDMMCIWNQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7D10", Offset = "0xA3A6910", VA = "0x18A3A7D10", Slot = "15")]
		public UUKANWITDQT VEAOBANWLIS(LFQWSTVHSGP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7C50", Offset = "0xA3A6850", VA = "0x18A3A7C50", Slot = "16")]
		public UUKANWITDQT VEAOBANWLIS(Func<LFQWSTVHSGP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7530", Offset = "0xA3A6130", VA = "0x18A3A7530", Slot = "17")]
		public UUKANWITDQT BCIVFHWZUFN(IEnumerable<LFQWSTVHSGP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7790", Offset = "0xA3A6390", VA = "0x18A3A7790", Slot = "18")]
		public UUKANWITDQT BCIVFHWZUFN(params LFQWSTVHSGP[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7B40", Offset = "0xA3A6740", VA = "0x18A3A7B40", Slot = "19")]
		public UUKANWITDQT PHSCOPDNOZY(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7910", Offset = "0xA3A6510", VA = "0x18A3A7910", Slot = "13")]
		public override bool JEOKDWBJGBI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7A20", Offset = "0xA3A6620", VA = "0x18A3A7A20", Slot = "14")]
		public override float MZIGOYGHHGY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7F20", Offset = "0xA3A6B20", VA = "0x18A3A7F20")]
		private bool XGMSSCRYXQT(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7680", Offset = "0xA3A6280", VA = "0x18A3A7680")]
		private UUKANWITDQT BCIVFHWZUFN(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2966350", Offset = "0x2964F50", VA = "0x182966350")]
		[CompilerGenerated]
		private void RABANQOBNZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7400", Offset = "0xA3A6000", VA = "0x18A3A7400")]
		[CompilerGenerated]
		private void RAGHKXHYXLH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class DDIAPTJWUVA : NUDEFLDZQGZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public HPKVRRLTHZE Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class EUKHXKXCZPT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform OJSHIYWFHYV;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public EUKHXKXCZPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA3A6740", Offset = "0xA3A5340", VA = "0x18A3A6740")]
			internal Vector3 DEUEKHEOMBI()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA3A6780", Offset = "0xA3A5380", VA = "0x18A3A6780")]
			internal void DEZLHNYLVMR(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class VIHYUHFKEDV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform OJSHIYWFHYV;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public VIHYUHFKEDV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA120", Offset = "0xA3A8D20", VA = "0x18A3AA120")]
			internal Quaternion LVJYVUAYXRE()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA160", Offset = "0xA3A8D60", VA = "0x18A3AA160")]
			internal void LVPFTAUWHCN(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class DLHXWDANTXX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform OJSHIYWFHYV;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public DLHXWDANTXX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA3A65C0", Offset = "0xA3A51C0", VA = "0x18A3A65C0")]
			internal Vector3 JHJVVFFQXGV()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA3A6580", Offset = "0xA3A5180", VA = "0x18A3A6580")]
			internal void JHEOXYLTNVM(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class BYJCWIUQJEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public HPKVRRLTHZE UNTLANAJYRN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public DDIAPTJWUVA DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour SZKFOUDUREX;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public BYJCWIUQJEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4650", Offset = "0xA3A3250", VA = "0x18A3A4650")]
			internal void BQLOYVMYCEP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class LLBQWFUEPKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public DDIAPTJWUVA DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public HPKVRRLTHZE FWJTXLJUZBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public YDHSMJLFZLP MXZXSYNLTDH;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public LLBQWFUEPKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9280", Offset = "0xA3A7E80", VA = "0x18A3A9280")]
			internal void LCVZAAWKUDT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9230", Offset = "0xA3A7E30", VA = "0x18A3A9230")]
			internal void LCQSCUCNKSK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA3A91E0", Offset = "0xA3A7DE0", VA = "0x18A3A91E0")]
			internal void LCLLFNIQBHB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class ZLXGHOBIWAX : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public LFQWSTVHSGP UNTLANAJYRN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public DDIAPTJWUVA DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public ZLXGHOBIWAX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA3AAD00", Offset = "0xA3A9900", VA = "0x18A3AAD00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA3AACC0", Offset = "0xA3A98C0", VA = "0x18A3AACC0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class QYVFACXJTNF : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public DDIAPTJWUVA DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public QYVFACXJTNF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA3A97C0", Offset = "0xA3A83C0", VA = "0x18A3A97C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA3A9780", Offset = "0xA3A8380", VA = "0x18A3A9780", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly EIGPTYHGYCM KWAEVTXZJMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly XOOBCRGRVTH SNXWOZXVAXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> OFMPXEPGGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> SMPDRMLGCZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<HPKVRRLTHZE> EBADCSSGLQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<HPKVRRLTHZE>> MPSEYCTWNXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool OSHBXGJJKGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private YDHSMJLFZLP CHWQQDTVIEZ;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA3A57B0", Offset = "0xA3A43B0", VA = "0x18A3A57B0")]
		[GEPWJNEAFDW.Root]
		internal static void RDUKEQTCCWZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6410", Offset = "0xA3A5010", VA = "0x18A3A6410")]
		[UnityEngine.Scripting.Preserve]
		internal DDIAPTJWUVA([Inject(null)] EIGPTYHGYCM scheduler, [Inject(null)] XOOBCRGRVTH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4CC0", Offset = "0xA3A38C0", VA = "0x18A3A4CC0", Slot = "4")]
		public BVYHQDHSSVH AWWHYASOFDJ(Func<float> a, Action<float> b, float c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA3A50E0", Offset = "0xA3A3CE0", VA = "0x18A3A50E0", Slot = "5")]
		public BVYHQDHSSVH HFKZOFYTJWV(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6320", Offset = "0xA3A4F20", VA = "0x18A3A6320", Slot = "6")]
		public BVYHQDHSSVH ZPBLETAWLQC(Func<Color> a, Action<Color> b, Color c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5E60", Offset = "0xA3A4A60", VA = "0x18A3A5E60", Slot = "7")]
		public BVYHQDHSSVH SMYZBOHETWU(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4E90", Offset = "0xA3A3A90", VA = "0x18A3A4E90", Slot = "8")]
		public BVYHQDHSSVH DADKPJFKLKE(Transform a, Quaternion b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA3A55E0", Offset = "0xA3A41E0", VA = "0x18A3A55E0", Slot = "9")]
		public BVYHQDHSSVH RCRXNCGTOPT(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6030", Offset = "0xA3A4C30", VA = "0x18A3A6030", Slot = "10")]
		public UUKANWITDQT Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5CC0", Offset = "0xA3A48C0", VA = "0x18A3A5CC0", Slot = "11")]
		public void SJHZZALNQKF(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A51D0", Offset = "0xA3A3DD0", VA = "0x18A3A51D0", Slot = "12")]
		public void SJHZZALNQKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5320", Offset = "0xA3A3F20", VA = "0x18A3A5320")]
		private void KSPHNULACNF(Behaviour a, HPKVRRLTHZE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5C50", Offset = "0xA3A4850", VA = "0x18A3A5C50")]
		[IteratorStateMachine(typeof(QYVFACXJTNF))]
		private IEnumerator<NVIJVYVFXPY> SGJLWPQAPDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A58A0", Offset = "0xA3A44A0", VA = "0x18A3A58A0")]
		private void Run(Behaviour context, HPKVRRLTHZE sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5050", Offset = "0xA3A3C50", VA = "0x18A3A5050")]
		[IteratorStateMachine(typeof(ZLXGHOBIWAX))]
		private IEnumerator<NVIJVYVFXPY> HDLPRIZXEOG(LFQWSTVHSGP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA3A61C0", Offset = "0xA3A4DC0", VA = "0x18A3A61C0")]
		private void VEAOBANWLIS(HPKVRRLTHZE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4DA0", Offset = "0xA3A39A0", VA = "0x18A3A4DA0")]
		private void BCFFKTRXSHR(HPKVRRLTHZE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA3A51D0", Offset = "0xA3A3DD0", VA = "0x18A3A51D0")]
		private void IKAPOQHKPTE(Scene a, LoadSceneMode b)
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
