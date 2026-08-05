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
		[Cpp2IlInjected.Address(RVA = "0xA54C200", Offset = "0xA54B200", VA = "0x18A54C200", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E020", Offset = "0x2A0D020", VA = "0x182A0E020")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AA5580", Offset = "0x2AA4580", VA = "0x182AA5580")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA54B010", Offset = "0xA54A010", VA = "0x18A54B010")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA54AFC0", Offset = "0xA549FC0", VA = "0x18A54AFC0")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class YNVSBXCNHZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA54C0C0", Offset = "0xA54B0C0", VA = "0x18A54C0C0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA54C0D0", Offset = "0xA54B0D0", VA = "0x18A54C0D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA54C070", Offset = "0xA54B070", VA = "0x18A54C070")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class CTKUQJDOEQD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA546020", Offset = "0xA545020", VA = "0x18A546020")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA546030", Offset = "0xA545030", VA = "0x18A546030")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA545FC0", Offset = "0xA544FC0", VA = "0x18A545FC0")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class ADCRTIHVRUL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA5455C0", Offset = "0xA5445C0", VA = "0x18A5455C0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA5455E0", Offset = "0xA5445E0", VA = "0x18A5455E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA545560", Offset = "0xA544560", VA = "0x18A545560")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA54AF70", Offset = "0xA549F70", VA = "0x18A54AF70")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA54AFA0", Offset = "0xA549FA0", VA = "0x18A54AFA0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA54AF40", Offset = "0xA549F40", VA = "0x18A54AF40")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA547B10", Offset = "0xA546B10", VA = "0x18A547B10")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA547B60", Offset = "0xA546B60", VA = "0x18A547B60")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA547A50", Offset = "0xA546A50", VA = "0x18A547A50")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class ECTEIVCMPXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA547940", Offset = "0xA546940", VA = "0x18A547940")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA5479A0", Offset = "0xA5469A0", VA = "0x18A5479A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA547890", Offset = "0xA546890", VA = "0x18A547890")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class BTJMCBJIIYT
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA545880", Offset = "0xA544880", VA = "0x18A545880")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA545930", Offset = "0xA544930", VA = "0x18A545930")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA5457B0", Offset = "0xA5447B0", VA = "0x18A5457B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA545BD0", Offset = "0xA544BD0", VA = "0x18A545BD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA545C50", Offset = "0xA544C50", VA = "0x18A545C50")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA545AF0", Offset = "0xA544AF0", VA = "0x18A545AF0")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA545E50", Offset = "0xA544E50", VA = "0x18A545E50")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA545F20", Offset = "0xA544F20", VA = "0x18A545F20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA545D30", Offset = "0xA544D30", VA = "0x18A545D30")]
			public static float HFFBJNNGALT(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA54B5C0", Offset = "0xA54A5C0", VA = "0x18A54B5C0")]
		public static float GXFEHAZXHNU(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class BRYVDHWLKGU : JRERCMMYZKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA545610", Offset = "0xA544610", VA = "0x18A545610")]
		public BRYVDHWLKGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "13")]
		public override bool JEOKDWBJGBI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD5A860", Offset = "0xD59860", VA = "0x180D5A860", Slot = "14")]
		public override float MZIGOYGHHGY()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class IOUEFADWEQD : IMYGGCZYRPV<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA548590", Offset = "0xA547590", VA = "0x18A548590")]
		public IOUEFADWEQD(Func<Color> a, Action<Color> b, Color c, float d, XPZGRJVDVLT.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF3D910", Offset = "0xF3C910", VA = "0x180F3D910", Slot = "15")]
		protected override Color OENFZRFUIVY()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99AD150", Offset = "0x99AC150", VA = "0x1899AD150", Slot = "16")]
		protected override Color KYJQMOTDNZJ(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class FHEGFQRVHMC : IMYGGCZYRPV<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA547C30", Offset = "0xA546C30", VA = "0x18A547C30")]
		public FHEGFQRVHMC(Func<float> a, Action<float> b, float c, float d, XPZGRJVDVLT.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA547BE0", Offset = "0xA546BE0", VA = "0x18A547BE0", Slot = "15")]
		protected override float OENFZRFUIVY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA547BC0", Offset = "0xA546BC0", VA = "0x18A547BC0", Slot = "16")]
		protected override float KYJQMOTDNZJ(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class ONEWGLNFRQY : IMYGGCZYRPV<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA54AB10", Offset = "0xA549B10", VA = "0x18A54AB10")]
		public ONEWGLNFRQY(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, XPZGRJVDVLT.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA54A950", Offset = "0xA549950", VA = "0x18A54A950", Slot = "15")]
		protected override Quaternion OENFZRFUIVY()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA54A900", Offset = "0xA549900", VA = "0x18A54A900", Slot = "16")]
		protected override Quaternion KYJQMOTDNZJ(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class LMDPGPTVPQE : IMYGGCZYRPV<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA54A860", Offset = "0xA549860", VA = "0x18A54A860")]
		public LMDPGPTVPQE(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XPZGRJVDVLT.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA54A7C0", Offset = "0xA5497C0", VA = "0x18A54A7C0", Slot = "15")]
		protected override Vector3 OENFZRFUIVY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA53AF80", Offset = "0xA539F80", VA = "0x18A53AF80", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xA549DB0", Offset = "0xA548DB0", VA = "0x18A549DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA54A170", Offset = "0xA549170", VA = "0x18A54A170")]
		internal static NUDEFLDZQGZ UTWPBDJNIJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA5499F0", Offset = "0xA5489F0", VA = "0x18A5499F0")]
		public static BVYHQDHSSVH AWWHYASOFDJ(Func<float> a, Action<float> b, float c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA549C50", Offset = "0xA548C50", VA = "0x18A549C50")]
		public static BVYHQDHSSVH HFKZOFYTJWV(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA54A1E0", Offset = "0xA5491E0", VA = "0x18A54A1E0")]
		public static BVYHQDHSSVH ZPBLETAWLQC(Func<Color> a, Action<Color> b, Color c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA549FB0", Offset = "0xA548FB0", VA = "0x18A549FB0")]
		public static BVYHQDHSSVH SMYZBOHETWU(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA549B20", Offset = "0xA548B20", VA = "0x18A549B20")]
		public static BVYHQDHSSVH DADKPJFKLKE(Transform a, Quaternion b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA549E00", Offset = "0xA548E00", VA = "0x18A549E00")]
		public static BVYHQDHSSVH RCRXNCGTOPT(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA54A080", Offset = "0xA549080", VA = "0x18A54A080")]
		public static UUKANWITDQT Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA549ED0", Offset = "0xA548ED0", VA = "0x18A549ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA548040", Offset = "0xA547040", VA = "0x18A548040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool SQVJFZTNKTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA5482C0", Offset = "0xA5472C0", VA = "0x18A5482C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ZXLKWAPTMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA548410", Offset = "0xA547410", VA = "0x18A548410", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA548160", Offset = "0xA547160", VA = "0x18A548160", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450", Slot = "9")]
		public GMTKWIVSBCA HLQQYYOJUKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA548200", Offset = "0xA547200", VA = "0x18A548200", Slot = "6")]
		public LFQWSTVHSGP QXCJALLWBYA(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA548060", Offset = "0xA547060", VA = "0x18A548060", Slot = "7")]
		public LFQWSTVHSGP IUZIYLIGJZI(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA547E10", Offset = "0xA546E10", VA = "0x18A547E10", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA547EA0", Offset = "0xA546EA0", VA = "0x18A547EA0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA5482E0", Offset = "0xA5472E0", VA = "0x18A5482E0")]
		protected void SCAMOICJUSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA547CA0", Offset = "0xA546CA0", VA = "0x18A547CA0")]
		protected void BCOSDPDPNYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA5484B0", Offset = "0xA5474B0", VA = "0x18A5484B0")]
		protected HPKVRRLTHZE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class LFLGQNKQAWV
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA54A520", Offset = "0xA549520", VA = "0x18A54A520")]
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
			[Cpp2IlInjected.Address(RVA = "0x10374D0", Offset = "0x10364D0", VA = "0x1810374D0")]
			[CompilerGenerated]
			get
			{
				return default(XPZGRJVDVLT.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA548650", Offset = "0xA547650", VA = "0x18A548650")]
		protected JRERCMMYZKE(float a, XPZGRJVDVLT.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x297C7C0", Offset = "0x297B7C0", VA = "0x18297C7C0")]
		[CompilerGenerated]
		private void RABANQOBNZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA548630", Offset = "0xA547630", VA = "0x18A548630")]
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
		[Cpp2IlInjected.Address(RVA = "0x6686070", Offset = "0x6685070", VA = "0x186686070")]
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
		[Cpp2IlInjected.Address(RVA = "0x66856B0", Offset = "0x66846B0", VA = "0x1866856B0", Slot = "13")]
		public override bool JEOKDWBJGBI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6685DB0", Offset = "0x6684DB0", VA = "0x186685DB0", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54B150", Offset = "0xA54A150", VA = "0x18A54B150")]
			public TweenEntry(LFQWSTVHSGP tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D942F0", Offset = "0x1D932F0", VA = "0x181D942F0")]
			public TweenEntry(Func<LFQWSTVHSGP> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA54B030", Offset = "0xA54A030", VA = "0x18A54B030")]
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
		[Cpp2IlInjected.Address(RVA = "0xA549810", Offset = "0xA548810", VA = "0x18A549810")]
		public KGDMMCIWNQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA549000", Offset = "0xA548000", VA = "0x18A549000", Slot = "15")]
		public UUKANWITDQT VEAOBANWLIS(LFQWSTVHSGP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA548F40", Offset = "0xA547F40", VA = "0x18A548F40", Slot = "16")]
		public UUKANWITDQT VEAOBANWLIS(Func<LFQWSTVHSGP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA548810", Offset = "0xA547810", VA = "0x18A548810", Slot = "17")]
		public UUKANWITDQT BCIVFHWZUFN(IEnumerable<LFQWSTVHSGP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA548A80", Offset = "0xA547A80", VA = "0x18A548A80", Slot = "18")]
		public UUKANWITDQT BCIVFHWZUFN(params LFQWSTVHSGP[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA548E30", Offset = "0xA547E30", VA = "0x18A548E30", Slot = "19")]
		public UUKANWITDQT PHSCOPDNOZY(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA548C00", Offset = "0xA547C00", VA = "0x18A548C00", Slot = "13")]
		public override bool JEOKDWBJGBI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA548D10", Offset = "0xA547D10", VA = "0x18A548D10", Slot = "14")]
		public override float MZIGOYGHHGY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA549210", Offset = "0xA548210", VA = "0x18A549210")]
		private bool XGMSSCRYXQT(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA548960", Offset = "0xA547960", VA = "0x18A548960")]
		private UUKANWITDQT BCIVFHWZUFN(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x297C7C0", Offset = "0x297B7C0", VA = "0x18297C7C0")]
		[CompilerGenerated]
		private void RABANQOBNZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA548630", Offset = "0xA547630", VA = "0x18A548630")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public EUKHXKXCZPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA5479D0", Offset = "0xA5469D0", VA = "0x18A5479D0")]
			internal Vector3 DEUEKHEOMBI()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA547A10", Offset = "0xA546A10", VA = "0x18A547A10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VIHYUHFKEDV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA54B550", Offset = "0xA54A550", VA = "0x18A54B550")]
			internal Quaternion LVJYVUAYXRE()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA54B590", Offset = "0xA54A590", VA = "0x18A54B590")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public DLHXWDANTXX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA547850", Offset = "0xA546850", VA = "0x18A547850")]
			internal Vector3 JHJVVFFQXGV()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA547810", Offset = "0xA546810", VA = "0x18A547810")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public BYJCWIUQJEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA5459F0", Offset = "0xA5449F0", VA = "0x18A5459F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LLBQWFUEPKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA54A6B0", Offset = "0xA5496B0", VA = "0x18A54A6B0")]
			internal void LCVZAAWKUDT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA54A660", Offset = "0xA549660", VA = "0x18A54A660")]
			internal void LCQSCUCNKSK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA54A610", Offset = "0xA549610", VA = "0x18A54A610")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public ZLXGHOBIWAX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA54C130", Offset = "0xA54B130", VA = "0x18A54C130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA54C0F0", Offset = "0xA54B0F0", VA = "0x18A54C0F0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public QYVFACXJTNF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA54ABF0", Offset = "0xA549BF0", VA = "0x18A54ABF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA54ABB0", Offset = "0xA549BB0", VA = "0x18A54ABB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA546B60", Offset = "0xA545B60", VA = "0x18A546B60")]
		[GEPWJNEAFDW.Root]
		internal static void RDUKEQTCCWZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA5476A0", Offset = "0xA5466A0", VA = "0x18A5476A0")]
		[UnityEngine.Scripting.Preserve]
		internal DDIAPTJWUVA([Inject(null)] EIGPTYHGYCM scheduler, [Inject(null)] XOOBCRGRVTH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA546060", Offset = "0xA545060", VA = "0x18A546060", Slot = "4")]
		public BVYHQDHSSVH AWWHYASOFDJ(Func<float> a, Action<float> b, float c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA546480", Offset = "0xA545480", VA = "0x18A546480", Slot = "5")]
		public BVYHQDHSSVH HFKZOFYTJWV(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA5475B0", Offset = "0xA5465B0", VA = "0x18A5475B0", Slot = "6")]
		public BVYHQDHSSVH ZPBLETAWLQC(Func<Color> a, Action<Color> b, Color c, float d, XPZGRJVDVLT.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA547210", Offset = "0xA546210", VA = "0x18A547210", Slot = "7")]
		public BVYHQDHSSVH SMYZBOHETWU(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA546230", Offset = "0xA545230", VA = "0x18A546230", Slot = "8")]
		public BVYHQDHSSVH DADKPJFKLKE(Transform a, Quaternion b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA546990", Offset = "0xA545990", VA = "0x18A546990", Slot = "9")]
		public BVYHQDHSSVH RCRXNCGTOPT(Transform a, Vector3 b, float c, XPZGRJVDVLT.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA5473E0", Offset = "0xA5463E0", VA = "0x18A5473E0", Slot = "10")]
		public UUKANWITDQT Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA547070", Offset = "0xA546070", VA = "0x18A547070", Slot = "11")]
		public void SJHZZALNQKF(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA546570", Offset = "0xA545570", VA = "0x18A546570", Slot = "12")]
		public void SJHZZALNQKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA5466C0", Offset = "0xA5456C0", VA = "0x18A5466C0")]
		private void KSPHNULACNF(Behaviour a, HPKVRRLTHZE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA547000", Offset = "0xA546000", VA = "0x18A547000")]
		[IteratorStateMachine(typeof(QYVFACXJTNF))]
		private IEnumerator<NVIJVYVFXPY> SGJLWPQAPDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA546C50", Offset = "0xA545C50", VA = "0x18A546C50")]
		private void Run(Behaviour context, HPKVRRLTHZE sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA5463F0", Offset = "0xA5453F0", VA = "0x18A5463F0")]
		[IteratorStateMachine(typeof(ZLXGHOBIWAX))]
		private IEnumerator<NVIJVYVFXPY> HDLPRIZXEOG(LFQWSTVHSGP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA547450", Offset = "0xA546450", VA = "0x18A547450")]
		private void VEAOBANWLIS(HPKVRRLTHZE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA546140", Offset = "0xA545140", VA = "0x18A546140")]
		private void BCFFKTRXSHR(HPKVRRLTHZE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA546570", Offset = "0xA545570", VA = "0x18A546570")]
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
