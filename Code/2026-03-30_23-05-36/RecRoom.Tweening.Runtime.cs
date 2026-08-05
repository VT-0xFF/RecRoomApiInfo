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
		[Cpp2IlInjected.Address(RVA = "0x906EB80", Offset = "0x906D980", VA = "0x18906EB80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27B5590", Offset = "0x27B4390", VA = "0x1827B5590")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class PFTYEONYDUR
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
		public static class BVJMDMXCNLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x284CA00", Offset = "0x284B800", VA = "0x18284CA00")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9068110", Offset = "0x9066F10", VA = "0x189068110")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x90680C0", Offset = "0x9066EC0", VA = "0x1890680C0")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class CAJXEFRVGXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9068600", Offset = "0x9067400", VA = "0x189068600")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9068660", Offset = "0x9067460", VA = "0x189068660")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9068610", Offset = "0x9067410", VA = "0x189068610")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class KZBTTOAATZF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9069260", Offset = "0x9068060", VA = "0x189069260")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x90692D0", Offset = "0x90680D0", VA = "0x1890692D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9069270", Offset = "0x9068070", VA = "0x189069270")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class FZTNEKDRPIT
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9068AE0", Offset = "0x90678E0", VA = "0x189068AE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9068B60", Offset = "0x9067960", VA = "0x189068B60")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9068B00", Offset = "0x9067900", VA = "0x189068B00")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x906C2A0", Offset = "0x906B0A0", VA = "0x18906C2A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x906C300", Offset = "0x906B100", VA = "0x18906C300")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x906C2D0", Offset = "0x906B0D0", VA = "0x18906C2D0")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9068970", Offset = "0x9067770", VA = "0x189068970")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9068A80", Offset = "0x9067880", VA = "0x189068A80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x90689C0", Offset = "0x90677C0", VA = "0x1890689C0")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class DOBTMYECPUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9068830", Offset = "0x9067630", VA = "0x189068830")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9068940", Offset = "0x9067740", VA = "0x189068940")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9068890", Offset = "0x9067690", VA = "0x189068890")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class LDIXQBXGTDR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9069400", Offset = "0x9068200", VA = "0x189069400")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9069580", Offset = "0x9068380", VA = "0x189069580")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x90694B0", Offset = "0x90682B0", VA = "0x1890694B0")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float ODXFRGQBPGB;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float KHSQFGNZBBT;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9068130", Offset = "0x9066F30", VA = "0x189068130")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9068290", Offset = "0x9067090", VA = "0x189068290")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x90681B0", Offset = "0x9066FB0", VA = "0x1890681B0")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9068370", Offset = "0x9067170", VA = "0x189068370")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9068560", Offset = "0x9067360", VA = "0x189068560")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9068440", Offset = "0x9067240", VA = "0x189068440")]
			public static float OUPURLQAEFH(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9069750", Offset = "0x9068550", VA = "0x189069750")]
		public static float KXBZDZQOWUC(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class HXROGSQFIEI : BAFDXSNLNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9068E10", Offset = "0x9067C10", VA = "0x189068E10")]
		public HXROGSQFIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "13")]
		public override bool YPRWBCWJESO(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB17E70", Offset = "0xB16C70", VA = "0x180B17E70", Slot = "14")]
		public override float CPVOIDULSJG()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class GYWPCFWUVHB : SQXTSZCRBDN<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9068C80", Offset = "0x9067A80", VA = "0x189068C80")]
		public GYWPCFWUVHB(Func<Color> a, Action<Color> b, Color c, float d, PFTYEONYDUR.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCFE3C0", Offset = "0xCFD1C0", VA = "0x180CFE3C0", Slot = "15")]
		protected override Color NRJHQUBXHXI()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84E2EB0", Offset = "0x84E1CB0", VA = "0x1884E2EB0", Slot = "16")]
		protected override Color ZLGHXKKSPTN(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ZUDSORYCYQG : SQXTSZCRBDN<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x906EB10", Offset = "0x906D910", VA = "0x18906EB10")]
		public ZUDSORYCYQG(Func<float> a, Action<float> b, float c, float d, PFTYEONYDUR.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x906EAA0", Offset = "0x906D8A0", VA = "0x18906EAA0", Slot = "15")]
		protected override float NRJHQUBXHXI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x906EAF0", Offset = "0x906D8F0", VA = "0x18906EAF0", Slot = "16")]
		protected override float ZLGHXKKSPTN(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class JSAFAWKIJAI : SQXTSZCRBDN<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x90691C0", Offset = "0x9067FC0", VA = "0x1890691C0")]
		public JSAFAWKIJAI(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, PFTYEONYDUR.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9068FB0", Offset = "0x9067DB0", VA = "0x189068FB0", Slot = "15")]
		protected override Quaternion NRJHQUBXHXI()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9069170", Offset = "0x9067F70", VA = "0x189069170", Slot = "16")]
		protected override Quaternion ZLGHXKKSPTN(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class UQZRQHHGHUM : SQXTSZCRBDN<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x906E980", Offset = "0x906D780", VA = "0x18906E980")]
		public UQZRQHHGHUM(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, PFTYEONYDUR.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x906E8E0", Offset = "0x906D6E0", VA = "0x18906E8E0", Slot = "15")]
		protected override Vector3 NRJHQUBXHXI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x905CD50", Offset = "0x905BB50", VA = "0x18905CD50", Slot = "16")]
		protected override Vector3 ZLGHXKKSPTN(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface XEAMISJFUBB
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action MUAAINALNBL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XEAMISJFUBB DGGYLNOBZKM(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		XEAMISJFUBB MSECUBWTDSW(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		XEAMISJFUBB VSERWIFUOFF(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ILWLFVTHXJS UVLTJEXJNYV();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool YPRWBCWJESO(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float CPVOIDULSJG();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface FTHNPGPRBRT : XEAMISJFUBB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface YIGALDFRVFB : XEAMISJFUBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YIGALDFRVFB TPBOALDYJIC(XEAMISJFUBB a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YIGALDFRVFB TPBOALDYJIC(Func<XEAMISJFUBB> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		YIGALDFRVFB FPZFGYFRFJZ(IEnumerable<XEAMISJFUBB> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		YIGALDFRVFB FPZFGYFRFJZ(params XEAMISJFUBB[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		YIGALDFRVFB UWFNQYMZDWK(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface JVAMDJCXNSV
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FTHNPGPRBRT TMUNWFRQVHZ(Func<float> a, Action<float> b, float c, float d, PFTYEONYDUR.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FTHNPGPRBRT HERTFKOAHON(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, PFTYEONYDUR.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FTHNPGPRBRT UZTAIKAGGYO(Func<Color> a, Action<Color> b, Color c, float d, PFTYEONYDUR.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		FTHNPGPRBRT NOGZLIUZWUM(Transform a, Vector3 b, float c, PFTYEONYDUR.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		FTHNPGPRBRT XCSPSTREODG(Transform a, Quaternion b, float c, PFTYEONYDUR.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		FTHNPGPRBRT DIUAJQEIXTX(Transform a, Vector3 b, float c, PFTYEONYDUR.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		YIGALDFRVFB Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OOQPPFUKRDX(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class QNURYVAQLQL
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static XEAMISJFUBB HXROGSQFIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x906B3E0", Offset = "0x906A1E0", VA = "0x18906B3E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x906BCA0", Offset = "0x906AAA0", VA = "0x18906BCA0")]
		internal static JVAMDJCXNSV ZOAAZBVUTVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x906B900", Offset = "0x906A700", VA = "0x18906B900")]
		public static FTHNPGPRBRT TMUNWFRQVHZ(Func<float> a, Action<float> b, float c, float d, PFTYEONYDUR.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x906B500", Offset = "0x906A300", VA = "0x18906B500")]
		public static FTHNPGPRBRT HERTFKOAHON(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, PFTYEONYDUR.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x906BA30", Offset = "0x906A830", VA = "0x18906BA30")]
		public static FTHNPGPRBRT UZTAIKAGGYO(Func<Color> a, Action<Color> b, Color c, float d, PFTYEONYDUR.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x906B660", Offset = "0x906A460", VA = "0x18906B660")]
		public static FTHNPGPRBRT NOGZLIUZWUM(Transform a, Vector3 b, float c, PFTYEONYDUR.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x906BB70", Offset = "0x906A970", VA = "0x18906BB70")]
		public static FTHNPGPRBRT XCSPSTREODG(Transform a, Quaternion b, float c, PFTYEONYDUR.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x906B430", Offset = "0x906A230", VA = "0x18906B430")]
		public static FTHNPGPRBRT DIUAJQEIXTX(Transform a, Vector3 b, float c, PFTYEONYDUR.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x906B810", Offset = "0x906A610", VA = "0x18906B810")]
		public static YIGALDFRVFB Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x906B730", Offset = "0x906A530", VA = "0x18906B730")]
		public static void OOQPPFUKRDX(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class UAOKULHEQJA : XEAMISJFUBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action LSECXDOTGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action RQNAWGBHWPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> XMUPMHUVWWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> YWBTDPBGOHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> SULDCOZRMQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected QLPFPLZGVKP OHONQDGFHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object RYPJJNRECKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool WZVOLVLFQDY;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool DYBFGGWDVLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x906D030", Offset = "0x906BE30", VA = "0x18906D030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool UWJBLFXKALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x906CF80", Offset = "0x906BD80", VA = "0x18906CF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MUAAINALNBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x906C840", Offset = "0x906B640", VA = "0x18906C840", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x906CCB0", Offset = "0x906BAB0", VA = "0x18906CCB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0", Slot = "9")]
		public ILWLFVTHXJS UVLTJEXJNYV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x906CA80", Offset = "0x906B880", VA = "0x18906CA80", Slot = "6")]
		public XEAMISJFUBB DGGYLNOBZKM(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x906CD50", Offset = "0x906BB50", VA = "0x18906CD50", Slot = "7")]
		public XEAMISJFUBB MSECUBWTDSW(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x906CFA0", Offset = "0x906BDA0", VA = "0x18906CFA0", Slot = "8")]
		public XEAMISJFUBB VSERWIFUOFF(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool YPRWBCWJESO(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float CPVOIDULSJG();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x906C8E0", Offset = "0x906B6E0", VA = "0x18906C8E0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x906CE50", Offset = "0x906BC50", VA = "0x18906CE50")]
		protected void SLMJTGNCELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x906CB40", Offset = "0x906B940", VA = "0x18906CB40")]
		protected void DJGKMXPSQNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x906D050", Offset = "0x906BE50", VA = "0x18906D050")]
		protected UAOKULHEQJA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class GPXNYYYCUUB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9068B90", Offset = "0x9067990", VA = "0x189068B90")]
		public static FTHNPGPRBRT DIUAJQEIXTX(this Behaviour a, Vector3 b, float c, PFTYEONYDUR.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class BAFDXSNLNPC : UAOKULHEQJA, FTHNPGPRBRT, XEAMISJFUBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool HJOJKHVCLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float FGWCLNFWBFS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected PFTYEONYDUR.Functions WDQDVMLGQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xDF3220", Offset = "0xDF2020", VA = "0x180DF3220")]
			[CompilerGenerated]
			get
			{
				return default(PFTYEONYDUR.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9067F00", Offset = "0x9066D00", VA = "0x189067F00")]
		protected BAFDXSNLNPC(float a, PFTYEONYDUR.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2723E20", Offset = "0x2722C20", VA = "0x182723E20")]
		[CompilerGenerated]
		private void OSJQIEXMXJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9067EE0", Offset = "0x9066CE0", VA = "0x189067EE0")]
		[CompilerGenerated]
		private void OSOXFLRKGUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class SQXTSZCRBDN<a> : BAFDXSNLNPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> MJSPYVGWSUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> HUSPLLTVVKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a MPTNXFAXFYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float HMHUNSPINOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a HZXUMNMNAIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a TSBQENQTCJI;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60254E0", Offset = "0x60242E0", VA = "0x1860254E0")]
		protected SQXTSZCRBDN(Func<a> a, Action<a> b, a c, float d, PFTYEONYDUR.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a NRJHQUBXHXI();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a ZLGHXKKSPTN(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6024850", Offset = "0x6023650", VA = "0x186024850", Slot = "13")]
		public override bool YPRWBCWJESO(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6024200", Offset = "0x6023000", VA = "0x186024200", Slot = "14")]
		public override float CPVOIDULSJG()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class QLOKPINNTWO : UAOKULHEQJA, YIGALDFRVFB, XEAMISJFUBB
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
			private XEAMISJFUBB tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<XEAMISJFUBB> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x906C440", Offset = "0x906B240", VA = "0x18906C440")]
			public TweenEntry(XEAMISJFUBB tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1B4D600", Offset = "0x1B4C400", VA = "0x181B4D600")]
			public TweenEntry(Func<XEAMISJFUBB> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x906C320", Offset = "0x906B120", VA = "0x18906C320")]
			public XEAMISJFUBB ADUUMESEBZF()
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
		private readonly List<Step> WRIAHCSGIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int VGSMWLVSYLZ;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x906B200", Offset = "0x906A000", VA = "0x18906B200")]
		public QLOKPINNTWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x906ADD0", Offset = "0x9069BD0", VA = "0x18906ADD0", Slot = "15")]
		public YIGALDFRVFB TPBOALDYJIC(XEAMISJFUBB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x906AD10", Offset = "0x9069B10", VA = "0x18906AD10", Slot = "16")]
		public YIGALDFRVFB TPBOALDYJIC(Func<XEAMISJFUBB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x906A320", Offset = "0x9069120", VA = "0x18906A320", Slot = "17")]
		public YIGALDFRVFB FPZFGYFRFJZ(IEnumerable<XEAMISJFUBB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x906A470", Offset = "0x9069270", VA = "0x18906A470", Slot = "18")]
		public YIGALDFRVFB FPZFGYFRFJZ(params XEAMISJFUBB[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x906AFE0", Offset = "0x9069DE0", VA = "0x18906AFE0", Slot = "19")]
		public YIGALDFRVFB UWFNQYMZDWK(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x906B0F0", Offset = "0x9069EF0", VA = "0x18906B0F0", Slot = "13")]
		public override bool YPRWBCWJESO(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x906A200", Offset = "0x9069000", VA = "0x18906A200", Slot = "14")]
		public override float CPVOIDULSJG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x906A710", Offset = "0x9069510", VA = "0x18906A710")]
		private bool PZSFZGSQRBJ(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x906A5F0", Offset = "0x90693F0", VA = "0x18906A5F0")]
		private YIGALDFRVFB FPZFGYFRFJZ(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2723E20", Offset = "0x2722C20", VA = "0x182723E20")]
		[CompilerGenerated]
		private void OSJQIEXMXJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9067EE0", Offset = "0x9066CE0", VA = "0x189067EE0")]
		[CompilerGenerated]
		private void OSOXFLRKGUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class UMANAGXEINY : JVAMDJCXNSV
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public UAOKULHEQJA Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class HAZBHBNYXNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform KGRKXIUXULL;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HAZBHBNYXNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9068D20", Offset = "0x9067B20", VA = "0x189068D20")]
			internal Vector3 QFSGMLCVAOW()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9068D60", Offset = "0x9067B60", VA = "0x189068D60")]
			internal void QFXNJRWSKAF(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class HENKAPLGKWX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform KGRKXIUXULL;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HENKAPLGKWX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9068DA0", Offset = "0x9067BA0", VA = "0x189068DA0")]
			internal Quaternion CXBDOKOHCGG()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9068DE0", Offset = "0x9067BE0", VA = "0x189068DE0")]
			internal void CXGKLRIELRP(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class WKUGAISCSBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform KGRKXIUXULL;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public WKUGAISCSBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x906EA60", Offset = "0x906D860", VA = "0x18906EA60")]
			internal Vector3 VBUTFNMPJKV()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x906EA20", Offset = "0x906D820", VA = "0x18906EA20")]
			internal void VBPMIGSRZZM(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class LAWFTANWYHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public UAOKULHEQJA KZLHXVYJEUX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public UMANAGXEINY FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour XXDCRZIVRTB;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public LAWFTANWYHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9069300", Offset = "0x9068100", VA = "0x189069300")]
			internal void AHZYPSQUPFZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class CVEHTNHYEQO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public UMANAGXEINY FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public UAOKULHEQJA KIDICILIXNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public JHHJDZQKJVL KZYXZROMHKR;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public CVEHTNHYEQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9068720", Offset = "0x9067520", VA = "0x189068720")]
			internal void BYYIQUJHFPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x90686D0", Offset = "0x90674D0", VA = "0x1890686D0")]
			internal void BYTBTNPJWDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9068680", Offset = "0x9067480", VA = "0x189068680")]
			internal void BYNUWGVMMSP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class OTXHNBXWHRB : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public XEAMISJFUBB KZLHXVYJEUX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public UMANAGXEINY FNBWZDPUGEI;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public OTXHNBXWHRB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9069640", Offset = "0x9068440", VA = "0x189069640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9069710", Offset = "0x9068510", VA = "0x189069710", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class QWXLHPGEWKH : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public UMANAGXEINY FNBWZDPUGEI;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public QWXLHPGEWKH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x906BF10", Offset = "0x906AD10", VA = "0x18906BF10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x906C260", Offset = "0x906B060", VA = "0x18906C260", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly SPRKFJGZVXG YYJGUBRGQVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly YGPMNQYCYVH NMSSYCJEURI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> XWDMHJGLIQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> LKGWFUGIMES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<UAOKULHEQJA> GWUCFWCFXSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<UAOKULHEQJA>> CAWOBQJNFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool HRWRXRLDKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private JHHJDZQKJVL FKKVFLSOEVP;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x906E3D0", Offset = "0x906D1D0", VA = "0x18906E3D0")]
		[AUEAKLYJEMA.Root]
		internal static void UUQSMFQOYUN(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x906E770", Offset = "0x906D570", VA = "0x18906E770")]
		[UnityEngine.Scripting.Preserve]
		internal UMANAGXEINY([Inject(null)] SPRKFJGZVXG scheduler, [Inject(null)] YGPMNQYCYVH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x906E190", Offset = "0x906CF90", VA = "0x18906E190", Slot = "4")]
		public FTHNPGPRBRT TMUNWFRQVHZ(Func<float> a, Action<float> b, float c, float d, PFTYEONYDUR.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x906D390", Offset = "0x906C190", VA = "0x18906D390", Slot = "5")]
		public FTHNPGPRBRT HERTFKOAHON(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, PFTYEONYDUR.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x906E4C0", Offset = "0x906D2C0", VA = "0x18906E4C0", Slot = "6")]
		public FTHNPGPRBRT UZTAIKAGGYO(Func<Color> a, Action<Color> b, Color c, float d, PFTYEONYDUR.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x906DA00", Offset = "0x906C800", VA = "0x18906DA00", Slot = "7")]
		public FTHNPGPRBRT NOGZLIUZWUM(Transform a, Vector3 b, float c, PFTYEONYDUR.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x906E5B0", Offset = "0x906D3B0", VA = "0x18906E5B0", Slot = "8")]
		public FTHNPGPRBRT XCSPSTREODG(Transform a, Quaternion b, float c, PFTYEONYDUR.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x906D1C0", Offset = "0x906BFC0", VA = "0x18906D1C0", Slot = "9")]
		public FTHNPGPRBRT DIUAJQEIXTX(Transform a, Vector3 b, float c, PFTYEONYDUR.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x906E120", Offset = "0x906CF20", VA = "0x18906E120", Slot = "10")]
		public YIGALDFRVFB Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x906DBD0", Offset = "0x906C9D0", VA = "0x18906DBD0", Slot = "11")]
		public void OOQPPFUKRDX(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x906D480", Offset = "0x906C280", VA = "0x18906D480", Slot = "12")]
		public void OOQPPFUKRDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x906D6C0", Offset = "0x906C4C0", VA = "0x18906D6C0")]
		private void JPGGZSSUQGL(Behaviour a, UAOKULHEQJA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x906D990", Offset = "0x906C790", VA = "0x18906D990")]
		[IteratorStateMachine(typeof(QWXLHPGEWKH))]
		private IEnumerator<NCPAWUBDFGC> LZRRLFIDHSA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x906DD70", Offset = "0x906CB70", VA = "0x18906DD70")]
		private void Run(Behaviour context, UAOKULHEQJA sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x906D130", Offset = "0x906BF30", VA = "0x18906D130")]
		[IteratorStateMachine(typeof(OTXHNBXWHRB))]
		private IEnumerator<NCPAWUBDFGC> BMOUOSQVXQO(XEAMISJFUBB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x906E270", Offset = "0x906D070", VA = "0x18906E270")]
		private void TPBOALDYJIC(UAOKULHEQJA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x906D5D0", Offset = "0x906C3D0", VA = "0x18906D5D0")]
		private void IHJKVAPPXIL(UAOKULHEQJA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x906D480", Offset = "0x906C280", VA = "0x18906D480")]
		private void HIXCOXQLWXQ(Scene a, LoadSceneMode b)
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
