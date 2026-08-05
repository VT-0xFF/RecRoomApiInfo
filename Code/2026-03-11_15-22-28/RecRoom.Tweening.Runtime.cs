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
		[Cpp2IlInjected.Address(RVA = "0x8FD6DD0", Offset = "0x8FD5DD0", VA = "0x188FD6DD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x279CA70", Offset = "0x279BA70", VA = "0x18279CA70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CQVHLUTLNGW
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
		public static class KRASEQHQUUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2833220", Offset = "0x2832220", VA = "0x182833220")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8FD35D0", Offset = "0x8FD25D0", VA = "0x188FD35D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8FD3580", Offset = "0x8FD2580", VA = "0x188FD3580")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class QLKFKDHSMTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5370", Offset = "0x8FD4370", VA = "0x188FD5370")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8FD53D0", Offset = "0x8FD43D0", VA = "0x188FD53D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5380", Offset = "0x8FD4380", VA = "0x188FD5380")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class RVZAYXKEAQO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5630", Offset = "0x8FD4630", VA = "0x188FD5630")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8FD56A0", Offset = "0x8FD46A0", VA = "0x188FD56A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5640", Offset = "0x8FD4640", VA = "0x188FD5640")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class VYKVRZRLCDE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5F00", Offset = "0x8FD4F00", VA = "0x188FD5F00")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5F80", Offset = "0x8FD4F80", VA = "0x188FD5F80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5F20", Offset = "0x8FD4F20", VA = "0x188FD5F20")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5870", Offset = "0x8FD4870", VA = "0x188FD5870")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8FD58D0", Offset = "0x8FD48D0", VA = "0x188FD58D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8FD58A0", Offset = "0x8FD48A0", VA = "0x188FD58A0")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8FD2DF0", Offset = "0x8FD1DF0", VA = "0x188FD2DF0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8FD2F00", Offset = "0x8FD1F00", VA = "0x188FD2F00")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8FD2E40", Offset = "0x8FD1E40", VA = "0x188FD2E40")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class YUXWUSVAKTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6AD0", Offset = "0x8FD5AD0", VA = "0x188FD6AD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6BE0", Offset = "0x8FD5BE0", VA = "0x188FD6BE0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6B30", Offset = "0x8FD5B30", VA = "0x188FD6B30")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class QYPRFTKKTBI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8FD53F0", Offset = "0x8FD43F0", VA = "0x188FD53F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5570", Offset = "0x8FD4570", VA = "0x188FD5570")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8FD54A0", Offset = "0x8FD44A0", VA = "0x188FD54A0")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float WMRXJCUGIXG;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float JEHIOMWPKIK;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8FD0CC0", Offset = "0x8FCFCC0", VA = "0x188FD0CC0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8FD0E10", Offset = "0x8FCFE10", VA = "0x188FD0E10")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8FD0D30", Offset = "0x8FCFD30", VA = "0x188FD0D30")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8FD0EE0", Offset = "0x8FCFEE0", VA = "0x188FD0EE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8FD10D0", Offset = "0x8FD00D0", VA = "0x188FD10D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8FD0FB0", Offset = "0x8FCFFB0", VA = "0x188FD0FB0")]
			public static float NSAODOHWUVO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8FD2350", Offset = "0x8FD1350", VA = "0x188FD2350")]
		public static float IJXRLKCRBBP(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class SVUHBESUDGX : YYQSZFFWWUN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8FD56D0", Offset = "0x8FD46D0", VA = "0x188FD56D0")]
		public SVUHBESUDGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "13")]
		public override bool NOWNTUDBCIH(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB1C760", Offset = "0xB1B760", VA = "0x180B1C760", Slot = "14")]
		public override float KBDUJZTRYVB()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class XMCTFOQZGMI : KTTQHWJZEJA<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6030", Offset = "0x8FD5030", VA = "0x188FD6030")]
		public XMCTFOQZGMI(Func<Color> a, Action<Color> b, Color c, float d, CQVHLUTLNGW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCBF4A0", Offset = "0xCBE4A0", VA = "0x180CBF4A0", Slot = "15")]
		protected override Color HJLCWHOWFGN()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x845AFB0", Offset = "0x8459FB0", VA = "0x18845AFB0", Slot = "16")]
		protected override Color DNRDNOBKZUO(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class OQVIKBAPWVL : KTTQHWJZEJA<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5290", Offset = "0x8FD4290", VA = "0x188FD5290")]
		public OQVIKBAPWVL(Func<float> a, Action<float> b, float c, float d, CQVHLUTLNGW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5240", Offset = "0x8FD4240", VA = "0x188FD5240", Slot = "15")]
		protected override float HJLCWHOWFGN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5220", Offset = "0x8FD4220", VA = "0x188FD5220", Slot = "16")]
		protected override float DNRDNOBKZUO(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class JPLLFWKDXSN : KTTQHWJZEJA<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8FD34E0", Offset = "0x8FD24E0", VA = "0x188FD34E0")]
		public JPLLFWKDXSN(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, CQVHLUTLNGW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3320", Offset = "0x8FD2320", VA = "0x188FD3320", Slot = "15")]
		protected override Quaternion HJLCWHOWFGN()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD32D0", Offset = "0x8FD22D0", VA = "0x188FD32D0", Slot = "16")]
		protected override Quaternion DNRDNOBKZUO(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class HULXWQSZUID : KTTQHWJZEJA<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3080", Offset = "0x8FD2080", VA = "0x188FD3080")]
		public HULXWQSZUID(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, CQVHLUTLNGW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8FD2FE0", Offset = "0x8FD1FE0", VA = "0x188FD2FE0", Slot = "15")]
		protected override Vector3 HJLCWHOWFGN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4FA0", Offset = "0x8FC3FA0", VA = "0x188FC4FA0", Slot = "16")]
		protected override Vector3 DNRDNOBKZUO(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface LHWCGBMRRYM
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action JLJKXLKNVAU;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LHWCGBMRRYM ACYZQSDCBXN(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		LHWCGBMRRYM KTNAAKLULRJ(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		LHWCGBMRRYM HKIUEQUHHJU(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		YTAUUGIQSDF OZCJBREFLTO();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NOWNTUDBCIH(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float KBDUJZTRYVB();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface HTISFPOUAMK : LHWCGBMRRYM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface OGUOJEAJZOA : LHWCGBMRRYM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OGUOJEAJZOA FRWTNASQNQJ(LHWCGBMRRYM a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OGUOJEAJZOA FRWTNASQNQJ(Func<LHWCGBMRRYM> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OGUOJEAJZOA YLZMAYCDEOW(IEnumerable<LHWCGBMRRYM> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		OGUOJEAJZOA YLZMAYCDEOW(params LHWCGBMRRYM[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		OGUOJEAJZOA GIZARESCZLD(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface NHXTOCGOTAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HTISFPOUAMK XWPKWCMFWFO(Func<float> a, Action<float> b, float c, float d, CQVHLUTLNGW.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HTISFPOUAMK POECDMEJHIK(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, CQVHLUTLNGW.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		HTISFPOUAMK WWGSOHDLUMV(Func<Color> a, Action<Color> b, Color c, float d, CQVHLUTLNGW.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		HTISFPOUAMK BZEMNOAJQZL(Transform a, Vector3 b, float c, CQVHLUTLNGW.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		HTISFPOUAMK ZYWCPSEASML(Transform a, Quaternion b, float c, CQVHLUTLNGW.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		HTISFPOUAMK XULYTBPOITQ(Transform a, Vector3 b, float c, CQVHLUTLNGW.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		OGUOJEAJZOA Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void XDXMIVUTLGI(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class AQRHTZOGAXM
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static LHWCGBMRRYM SVUHBESUDGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8FD03B0", Offset = "0x8FCF3B0", VA = "0x188FD03B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0920", Offset = "0x8FCF920", VA = "0x188FD0920")]
		internal static NHXTOCGOTAY ZWEPNJTRTUE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8FD07F0", Offset = "0x8FCF7F0", VA = "0x188FD07F0")]
		public static HTISFPOUAMK XWPKWCMFWFO(Func<float> a, Action<float> b, float c, float d, CQVHLUTLNGW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0250", Offset = "0x8FCF250", VA = "0x188FD0250")]
		public static HTISFPOUAMK POECDMEJHIK(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, CQVHLUTLNGW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8FD04F0", Offset = "0x8FCF4F0", VA = "0x188FD04F0")]
		public static HTISFPOUAMK WWGSOHDLUMV(Func<Color> a, Action<Color> b, Color c, float d, CQVHLUTLNGW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0180", Offset = "0x8FCF180", VA = "0x188FD0180")]
		public static HTISFPOUAMK BZEMNOAJQZL(Transform a, Vector3 b, float c, CQVHLUTLNGW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0990", Offset = "0x8FCF990", VA = "0x188FD0990")]
		public static HTISFPOUAMK ZYWCPSEASML(Transform a, Quaternion b, float c, CQVHLUTLNGW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0720", Offset = "0x8FCF720", VA = "0x188FD0720")]
		public static HTISFPOUAMK XULYTBPOITQ(Transform a, Vector3 b, float c, CQVHLUTLNGW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0400", Offset = "0x8FCF400", VA = "0x188FD0400")]
		public static OGUOJEAJZOA Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8FD0630", Offset = "0x8FCF630", VA = "0x188FD0630")]
		public static void XDXMIVUTLGI(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class YTNLXJGJILJ : LHWCGBMRRYM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action IGEGTVKVFNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action QTOKKCYRQQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> ZUUUMVCQLCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> GJKYFMLRFEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> BBGZJGZKZGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected MAMNDJOCSXA ZMNCXYLBFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object WBIBLXZEWPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool JUEMXOCYFHX;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool UKWDHBBOXHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8FD62A0", Offset = "0x8FD52A0", VA = "0x188FD62A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool GJOEZEWWJNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6730", Offset = "0x8FD5730", VA = "0x188FD6730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action JLJKXLKNVAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8FD64F0", Offset = "0x8FD54F0", VA = "0x188FD64F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6590", Offset = "0x8FD5590", VA = "0x188FD6590", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0", Slot = "9")]
		public YTAUUGIQSDF OZCJBREFLTO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8FD61E0", Offset = "0x8FD51E0", VA = "0x188FD61E0", Slot = "6")]
		public LHWCGBMRRYM ACYZQSDCBXN(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6630", Offset = "0x8FD5630", VA = "0x188FD6630", Slot = "7")]
		public LHWCGBMRRYM KTNAAKLULRJ(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6460", Offset = "0x8FD5460", VA = "0x188FD6460", Slot = "8")]
		public LHWCGBMRRYM HKIUEQUHHJU(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool NOWNTUDBCIH(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float KBDUJZTRYVB();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD62C0", Offset = "0x8FD52C0", VA = "0x188FD62C0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD68C0", Offset = "0x8FD58C0", VA = "0x188FD68C0")]
		protected void UJNQAGDVHUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6750", Offset = "0x8FD5750", VA = "0x188FD6750")]
		protected void SRYOFWGHDSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8FD69F0", Offset = "0x8FD59F0", VA = "0x188FD69F0")]
		protected YTNLXJGJILJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class MSDEUFZTFZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5130", Offset = "0x8FD4130", VA = "0x188FD5130")]
		public static HTISFPOUAMK XULYTBPOITQ(this Behaviour a, Vector3 b, float c, CQVHLUTLNGW.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class YYQSZFFWWUN : YTNLXJGJILJ, HTISFPOUAMK, LHWCGBMRRYM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool MHMVLQBKQDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float ULFLDUTKNEH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected CQVHLUTLNGW.Functions TMLBUMAUDMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD9C630", Offset = "0xD9B630", VA = "0x180D9C630")]
			[CompilerGenerated]
			get
			{
				return default(CQVHLUTLNGW.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6C10", Offset = "0x8FD5C10", VA = "0x188FD6C10")]
		protected YYQSZFFWWUN(float a, CQVHLUTLNGW.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x26C9FE0", Offset = "0x26C8FE0", VA = "0x1826C9FE0")]
		[CompilerGenerated]
		private void LKLUIEKGJWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1C60", Offset = "0x8FD0C60", VA = "0x188FD1C60")]
		[CompilerGenerated]
		private void LKGNKXQJAKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class KTTQHWJZEJA<a> : YYQSZFFWWUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> HTMYBPLJHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> MXDPWZCCXHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a VZJSJJIHEVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float CEFCJWKJIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a KYMLCCJOXDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a RLUASJFLVEZ;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5464A10", Offset = "0x5463A10", VA = "0x185464A10")]
		protected KTTQHWJZEJA(Func<a> a, Action<a> b, a c, float d, CQVHLUTLNGW.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a HJLCWHOWFGN();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a DNRDNOBKZUO(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5464580", Offset = "0x5463580", VA = "0x185464580", Slot = "13")]
		public override bool NOWNTUDBCIH(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x54636A0", Offset = "0x54626A0", VA = "0x1854636A0", Slot = "14")]
		public override float KBDUJZTRYVB()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class CEIQAZFJYDV : YTNLXJGJILJ, OGUOJEAJZOA, LHWCGBMRRYM
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
			private LHWCGBMRRYM tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<LHWCGBMRRYM> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5A10", Offset = "0x8FD4A10", VA = "0x188FD5A10")]
			public TweenEntry(LHWCGBMRRYM tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1B020E0", Offset = "0x1B010E0", VA = "0x181B020E0")]
			public TweenEntry(Func<LHWCGBMRRYM> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8FD58F0", Offset = "0x8FD48F0", VA = "0x188FD58F0")]
			public LHWCGBMRRYM TNBRPSFTJEU()
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
		private readonly List<Step> VPPAICDQELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int FCUQBWBKEYK;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD2170", Offset = "0x8FD1170", VA = "0x188FD2170")]
		public CEIQAZFJYDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1230", Offset = "0x8FD0230", VA = "0x188FD1230", Slot = "15")]
		public OGUOJEAJZOA FRWTNASQNQJ(LHWCGBMRRYM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1170", Offset = "0x8FD0170", VA = "0x188FD1170", Slot = "16")]
		public OGUOJEAJZOA FRWTNASQNQJ(Func<LHWCGBMRRYM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD2020", Offset = "0x8FD1020", VA = "0x188FD2020", Slot = "17")]
		public OGUOJEAJZOA YLZMAYCDEOW(IEnumerable<LHWCGBMRRYM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1D90", Offset = "0x8FD0D90", VA = "0x188FD1D90", Slot = "18")]
		public OGUOJEAJZOA YLZMAYCDEOW(params LHWCGBMRRYM[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1430", Offset = "0x8FD0430", VA = "0x188FD1430", Slot = "19")]
		public OGUOJEAJZOA GIZARESCZLD(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1C80", Offset = "0x8FD0C80", VA = "0x188FD1C80", Slot = "13")]
		public override bool NOWNTUDBCIH(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1B50", Offset = "0x8FD0B50", VA = "0x188FD1B50", Slot = "14")]
		public override float KBDUJZTRYVB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1540", Offset = "0x8FD0540", VA = "0x188FD1540")]
		private bool ISRPAKWKVAO(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1F00", Offset = "0x8FD0F00", VA = "0x188FD1F00")]
		private OGUOJEAJZOA YLZMAYCDEOW(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x26C9FE0", Offset = "0x26C8FE0", VA = "0x1826C9FE0")]
		[CompilerGenerated]
		private void LKLUIEKGJWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8FD1C60", Offset = "0x8FD0C60", VA = "0x188FD1C60")]
		[CompilerGenerated]
		private void LKGNKXQJAKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class KUFJICOQBND : NHXTOCGOTAY
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public YTNLXJGJILJ Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class XHAMZMOSVBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform NXYCNRSDGFI;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public XHAMZMOSVBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5FF0", Offset = "0x8FD4FF0", VA = "0x188FD5FF0")]
			internal Vector3 PQRIPXIRCEX()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5FB0", Offset = "0x8FD4FB0", VA = "0x188FD5FB0")]
			internal void PQMBSQOTSTO(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class OVBGWDFORDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform NXYCNRSDGFI;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public OVBGWDFORDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5330", Offset = "0x8FD4330", VA = "0x188FD5330")]
			internal Quaternion ODEBAZDEXJX()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5300", Offset = "0x8FD4300", VA = "0x188FD5300")]
			internal void OCYUDSJHNYO(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class HQSVPWXVKOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform NXYCNRSDGFI;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public HQSVPWXVKOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8FD2F60", Offset = "0x8FD1F60", VA = "0x188FD2F60")]
			internal Vector3 RVMHVUZHOPE()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8FD2FA0", Offset = "0x8FD1FA0", VA = "0x188FD2FA0")]
			internal void RVROTBTEYAN(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class UGWSJTRGBHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public YTNLXJGJILJ GFARUYQNHTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public KUFJICOQBND SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour LMGFUTIDBOW;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public UGWSJTRGBHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5E00", Offset = "0x8FD4E00", VA = "0x188FD5E00")]
			internal void BAHYDDLTRFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class JLGYVBEQVAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public KUFJICOQBND SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public YTNLXJGJILJ JKWXXMVIJNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ALZORZCQSFK ZXCFMDBOSGQ;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public JLGYVBEQVAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8FD3120", Offset = "0x8FD2120", VA = "0x188FD3120")]
			internal void AHTRBSORMYM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8FD3230", Offset = "0x8FD2230", VA = "0x188FD3230")]
			internal void AHYXYZIOWJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8FD3280", Offset = "0x8FD2280", VA = "0x188FD3280")]
			internal void AIEEWGCMFVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class YRIZUGDIVPE : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public LHWCGBMRRYM GFARUYQNHTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public KUFJICOQBND SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public YRIZUGDIVPE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8FD60D0", Offset = "0x8FD50D0", VA = "0x188FD60D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8FD61A0", Offset = "0x8FD51A0", VA = "0x188FD61A0", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class MPESLBTYFIA : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public KUFJICOQBND SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public MPESLBTYFIA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8FD4DA0", Offset = "0x8FD3DA0", VA = "0x188FD4DA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8FD50F0", Offset = "0x8FD40F0", VA = "0x188FD50F0", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly GUCSXSLGSZF JNSPOQFQAOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly XLLSGHESENK HFTULGOQGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> UPIRFTMYQNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> PRMAILIJNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<YTNLXJGJILJ> EPFGMSCCHCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<YTNLXJGJILJ>> KIAEZSFSSUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool JFUVVRMNRUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private ALZORZCQSFK GGXCCYMSAMW;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8FD39B0", Offset = "0x8FD29B0", VA = "0x188FD39B0")]
		[WUCJGMLKEDZ.Root]
		internal static void KFLXSIGFXCK(KTJKRWFMICD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4C30", Offset = "0x8FD3C30", VA = "0x188FD4C30")]
		[UnityEngine.Scripting.Preserve]
		internal KUFJICOQBND([Inject(null)] GUCSXSLGSZF scheduler, [Inject(null)] XLLSGHESENK schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4990", Offset = "0x8FD3990", VA = "0x188FD4990", Slot = "4")]
		public HTISFPOUAMK XWPKWCMFWFO(Func<float> a, Action<float> b, float c, float d, CQVHLUTLNGW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3BF0", Offset = "0x8FD2BF0", VA = "0x188FD3BF0", Slot = "5")]
		public HTISFPOUAMK POECDMEJHIK(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, CQVHLUTLNGW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4440", Offset = "0x8FD3440", VA = "0x188FD4440", Slot = "6")]
		public HTISFPOUAMK WWGSOHDLUMV(Func<Color> a, Action<Color> b, Color c, float d, CQVHLUTLNGW.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8FD35F0", Offset = "0x8FD25F0", VA = "0x188FD35F0", Slot = "7")]
		public HTISFPOUAMK BZEMNOAJQZL(Transform a, Vector3 b, float c, CQVHLUTLNGW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4A70", Offset = "0x8FD3A70", VA = "0x188FD4A70", Slot = "8")]
		public HTISFPOUAMK ZYWCPSEASML(Transform a, Quaternion b, float c, CQVHLUTLNGW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8FD47C0", Offset = "0x8FD37C0", VA = "0x188FD47C0", Slot = "9")]
		public HTISFPOUAMK XULYTBPOITQ(Transform a, Vector3 b, float c, CQVHLUTLNGW.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4090", Offset = "0x8FD3090", VA = "0x188FD4090", Slot = "10")]
		public OGUOJEAJZOA Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4620", Offset = "0x8FD3620", VA = "0x188FD4620", Slot = "11")]
		public void XDXMIVUTLGI(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3AA0", Offset = "0x8FD2AA0", VA = "0x188FD3AA0", Slot = "12")]
		public void XDXMIVUTLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4170", Offset = "0x8FD3170", VA = "0x188FD4170")]
		private void WQFFEHOQJZQ(Behaviour a, YTNLXJGJILJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4100", Offset = "0x8FD3100", VA = "0x188FD4100")]
		[IteratorStateMachine(typeof(MPESLBTYFIA))]
		private IEnumerator<ADJUPIXYSVF> VUVNGMBMQTD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3CE0", Offset = "0x8FD2CE0", VA = "0x188FD3CE0")]
		private void Run(Behaviour context, YTNLXJGJILJ sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3920", Offset = "0x8FD2920", VA = "0x188FD3920")]
		[IteratorStateMachine(typeof(YRIZUGDIVPE))]
		private IEnumerator<ADJUPIXYSVF> ISYHWOKHFTL(LHWCGBMRRYM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8FD37C0", Offset = "0x8FD27C0", VA = "0x188FD37C0")]
		private void FRWTNASQNQJ(YTNLXJGJILJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4530", Offset = "0x8FD3530", VA = "0x188FD4530")]
		private void XARNDMVAPZQ(YTNLXJGJILJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3AA0", Offset = "0x8FD2AA0", VA = "0x188FD3AA0")]
		private void MVIONTFMCYD(Scene a, LoadSceneMode b)
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
