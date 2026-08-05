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
		[Cpp2IlInjected.Address(RVA = "0x8D367B0", Offset = "0x8D35BB0", VA = "0x188D367B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x273A690", VA = "0x18273B290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class SXBLIGZOSBB
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
		public static class NCFEFHILDEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x27D19B0", Offset = "0x27D0DB0", VA = "0x1827D19B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8D33290", Offset = "0x8D32690", VA = "0x188D33290")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8D332B0", Offset = "0x8D326B0", VA = "0x188D332B0")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class YTZQYMAOQBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8D36730", Offset = "0x8D35B30", VA = "0x188D36730")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8D36740", Offset = "0x8D35B40", VA = "0x188D36740")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8D36760", Offset = "0x8D35B60", VA = "0x188D36760")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class ENGEUPTZRPH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8D31030", Offset = "0x8D30430", VA = "0x188D31030")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8D31040", Offset = "0x8D30440", VA = "0x188D31040")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8D31070", Offset = "0x8D30470", VA = "0x188D31070")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class IJXFZHYCHJX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8D313F0", Offset = "0x8D307F0", VA = "0x188D313F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8D31410", Offset = "0x8D30810", VA = "0x188D31410")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8D31440", Offset = "0x8D30840", VA = "0x188D31440")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D34320", Offset = "0x8D33720", VA = "0x188D34320")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D34350", Offset = "0x8D33750", VA = "0x188D34350")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8D34370", Offset = "0x8D33770", VA = "0x188D34370")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8D310D0", Offset = "0x8D304D0", VA = "0x188D310D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D31120", Offset = "0x8D30520", VA = "0x188D31120")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D31180", Offset = "0x8D30580", VA = "0x188D31180")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class LZXJVTGUKXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8D33150", Offset = "0x8D32550", VA = "0x188D33150")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D331B0", Offset = "0x8D325B0", VA = "0x188D331B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D331E0", Offset = "0x8D325E0", VA = "0x188D331E0")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class AAPRWXQALOB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D2FC10", Offset = "0x8D2F010", VA = "0x188D2FC10")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8D2FCC0", Offset = "0x8D2F0C0", VA = "0x188D2FCC0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D2FD80", Offset = "0x8D2F180", VA = "0x188D2FD80")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float PAUMMAKNHXZ;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float AHROLMRFWNR;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8D30040", Offset = "0x8D2F440", VA = "0x188D30040")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8D300B0", Offset = "0x8D2F4B0", VA = "0x188D300B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8D30130", Offset = "0x8D2F530", VA = "0x188D30130")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8D30260", Offset = "0x8D2F660", VA = "0x188D30260")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8D30330", Offset = "0x8D2F730", VA = "0x188D30330")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D303D0", Offset = "0x8D2F7D0", VA = "0x188D303D0")]
			public static float XCOPWAJYJBJ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D33880", Offset = "0x8D32C80", VA = "0x188D33880")]
		public static float OIMGGYWHZJC(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class BJGAXPXTKYC : YIMKKEQORAW
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FE50", Offset = "0x8D2F250", VA = "0x188D2FE50")]
		public BJGAXPXTKYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "13")]
		public override bool WMLZDCCYQSI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAF2370", Offset = "0xAF1770", VA = "0x180AF2370", Slot = "14")]
		public override float XNYLYIVFBPQ()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class DXDVPIQQXYR : CXPGWHPSPHL<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D30F90", Offset = "0x8D30390", VA = "0x188D30F90")]
		public DXDVPIQQXYR(Func<Color> a, Action<Color> b, Color c, float d, SXBLIGZOSBB.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xC6E790", Offset = "0xC6DB90", VA = "0x180C6E790", Slot = "15")]
		protected override Color FKURQNMDPUI()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81D30A0", Offset = "0x81D24A0", VA = "0x1881D30A0", Slot = "16")]
		protected override Color ZTETWSZHTQN(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class BKBGGOLVCEQ : CXPGWHPSPHL<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FFD0", Offset = "0x8D2F3D0", VA = "0x188D2FFD0")]
		public BKBGGOLVCEQ(Func<float> a, Action<float> b, float c, float d, SXBLIGZOSBB.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FF60", Offset = "0x8D2F360", VA = "0x188D2FF60", Slot = "15")]
		protected override float FKURQNMDPUI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FFB0", Offset = "0x8D2F3B0", VA = "0x188D2FFB0", Slot = "16")]
		protected override float ZTETWSZHTQN(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class VIUEFKCJMDM : CXPGWHPSPHL<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D34BD0", Offset = "0x8D33FD0", VA = "0x188D34BD0")]
		public VIUEFKCJMDM(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, SXBLIGZOSBB.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D349C0", Offset = "0x8D33DC0", VA = "0x188D349C0", Slot = "15")]
		protected override Quaternion FKURQNMDPUI()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D34B80", Offset = "0x8D33F80", VA = "0x188D34B80", Slot = "16")]
		protected override Quaternion ZTETWSZHTQN(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ICIBXGXCFBI : CXPGWHPSPHL<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D31350", Offset = "0x8D30750", VA = "0x188D31350")]
		public ICIBXGXCFBI(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, SXBLIGZOSBB.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D31240", Offset = "0x8D30640", VA = "0x188D31240", Slot = "15")]
		protected override Vector3 FKURQNMDPUI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D312E0", Offset = "0x8D306E0", VA = "0x188D312E0", Slot = "16")]
		protected override Vector3 ZTETWSZHTQN(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface SUVVTDZGSFD
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action BNSQNDNCMPR;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		SUVVTDZGSFD VASFPXKCRFE(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SUVVTDZGSFD ZLPUKKBMIQY(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		SUVVTDZGSFD MEUKFCEXBEZ(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		SKSLBBUJUBM KMWCFARLBFR();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool WMLZDCCYQSI(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float XNYLYIVFBPQ();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KRBYSCUTGLF : SUVVTDZGSFD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ADKDAGVCWIN : SUVVTDZGSFD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ADKDAGVCWIN ARLOTELQMYA(SUVVTDZGSFD a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ADKDAGVCWIN ARLOTELQMYA(Func<SUVVTDZGSFD> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ADKDAGVCWIN FVTAAHBFULT(IEnumerable<SUVVTDZGSFD> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ADKDAGVCWIN FVTAAHBFULT(params SUVVTDZGSFD[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ADKDAGVCWIN XCZAAJPXBEY(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface FCVQBKCDRHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KRBYSCUTGLF KDNDOZRUSMN(Func<float> a, Action<float> b, float c, float d, SXBLIGZOSBB.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KRBYSCUTGLF WBABDOWHEYT(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, SXBLIGZOSBB.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		KRBYSCUTGLF DTWGOYIPZYU(Func<Color> a, Action<Color> b, Color c, float d, SXBLIGZOSBB.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		KRBYSCUTGLF JULGUYKGNEG(Transform a, Vector3 b, float c, SXBLIGZOSBB.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		KRBYSCUTGLF GQZAOCZWHTM(Transform a, Quaternion b, float c, SXBLIGZOSBB.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		KRBYSCUTGLF QFHELGWIXZN(Transform a, Vector3 b, float c, SXBLIGZOSBB.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ADKDAGVCWIN Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NBTDRNVXOVR(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class CDGITEBQNCV
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static SUVVTDZGSFD BJGAXPXTKYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8D30760", Offset = "0x8D2FB60", VA = "0x188D30760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D30DC0", Offset = "0x8D301C0", VA = "0x188D30DC0")]
		internal static FCVQBKCDRHJ XTQHVDXSZOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8D30880", Offset = "0x8D2FC80", VA = "0x188D30880")]
		public static KRBYSCUTGLF KDNDOZRUSMN(Func<float> a, Action<float> b, float c, float d, SXBLIGZOSBB.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D30C60", Offset = "0x8D30060", VA = "0x188D30C60")]
		public static KRBYSCUTGLF WBABDOWHEYT(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, SXBLIGZOSBB.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D304F0", Offset = "0x8D2F8F0", VA = "0x188D304F0")]
		public static KRBYSCUTGLF DTWGOYIPZYU(Func<Color> a, Action<Color> b, Color c, float d, SXBLIGZOSBB.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D307B0", Offset = "0x8D2FBB0", VA = "0x188D307B0")]
		public static KRBYSCUTGLF JULGUYKGNEG(Transform a, Vector3 b, float c, SXBLIGZOSBB.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8D30630", Offset = "0x8D2FA30", VA = "0x188D30630")]
		public static KRBYSCUTGLF GQZAOCZWHTM(Transform a, Quaternion b, float c, SXBLIGZOSBB.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8D30AA0", Offset = "0x8D2FEA0", VA = "0x188D30AA0")]
		public static KRBYSCUTGLF QFHELGWIXZN(Transform a, Vector3 b, float c, SXBLIGZOSBB.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D30B70", Offset = "0x8D2FF70", VA = "0x188D30B70")]
		public static ADKDAGVCWIN Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D309B0", Offset = "0x8D2FDB0", VA = "0x188D309B0")]
		public static void NBTDRNVXOVR(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class KETTSMXWQSM : SUVVTDZGSFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action ENCPVPYGLDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action UDQUQIYHUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> MKYRQOIMVDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> PFKYDVAAOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> KNHNMWNYBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected EPKZRSREZBD VVQOLOWDTTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object ZOBXWVHJMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool YKIWXELYYSM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool ZHAVYOLZIIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8D319E0", Offset = "0x8D30DE0", VA = "0x188D319E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool MTEWKTUNLIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8D31A00", Offset = "0x8D30E00", VA = "0x188D31A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action BNSQNDNCMPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8D316E0", Offset = "0x8D30AE0", VA = "0x188D316E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8D31640", Offset = "0x8D30A40", VA = "0x188D31640", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0", Slot = "9")]
		public SKSLBBUJUBM KMWCFARLBFR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D31B50", Offset = "0x8D30F50", VA = "0x188D31B50", Slot = "6")]
		public SUVVTDZGSFD VASFPXKCRFE(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D31C00", Offset = "0x8D31000", VA = "0x188D31C00", Slot = "7")]
		public SUVVTDZGSFD ZLPUKKBMIQY(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D318F0", Offset = "0x8D30CF0", VA = "0x188D318F0", Slot = "8")]
		public SUVVTDZGSFD MEUKFCEXBEZ(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool WMLZDCCYQSI(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float XNYLYIVFBPQ();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D314A0", Offset = "0x8D308A0", VA = "0x188D314A0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D31A20", Offset = "0x8D30E20", VA = "0x188D31A20")]
		protected void VAPOQUCXGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D31780", Offset = "0x8D30B80", VA = "0x188D31780")]
		protected void JONIGSSTGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D31D10", Offset = "0x8D31110", VA = "0x188D31D10")]
		protected KETTSMXWQSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class QHRLFVVZTZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D33690", Offset = "0x8D32A90", VA = "0x188D33690")]
		public static KRBYSCUTGLF QFHELGWIXZN(this Behaviour a, Vector3 b, float c, SXBLIGZOSBB.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class YIMKKEQORAW : KETTSMXWQSM, KRBYSCUTGLF, SUVVTDZGSFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool LZPTMIAUHZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float FTVJVMPZYOK;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected SXBLIGZOSBB.Functions RNGDHFDFHOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD3CBC0", Offset = "0xD3BFC0", VA = "0x180D3CBC0")]
			[CompilerGenerated]
			get
			{
				return default(SXBLIGZOSBB.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D36620", Offset = "0x8D35A20", VA = "0x188D36620")]
		protected YIMKKEQORAW(float a, SXBLIGZOSBB.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2641E50", Offset = "0x2641250", VA = "0x182641E50")]
		[CompilerGenerated]
		private void SUGEXFIFPPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D32A90", Offset = "0x8D31E90", VA = "0x188D32A90")]
		[CompilerGenerated]
		private void SULLUMCCZAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class CXPGWHPSPHL<a> : YIMKKEQORAW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> SUEJZCCDZOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> XYBCBLAYNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a NPTEMZILRVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float EQTFCNUCDBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a VYJUXEYWFHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a FJSWABZZTMY;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3CFE270", Offset = "0x3CFD670", VA = "0x183CFE270")]
		protected CXPGWHPSPHL(Func<a> a, Action<a> b, a c, float d, SXBLIGZOSBB.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a FKURQNMDPUI();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a ZTETWSZHTQN(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3CFD760", Offset = "0x3CFCB60", VA = "0x183CFD760", Slot = "13")]
		public override bool WMLZDCCYQSI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDF60", Offset = "0x3CFD360", VA = "0x183CFDF60", Slot = "14")]
		public override float XNYLYIVFBPQ()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class KHJHTLQTWMY : KETTSMXWQSM, ADKDAGVCWIN, SUVVTDZGSFD
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
			private SUVVTDZGSFD tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<SUVVTDZGSFD> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8D344C0", Offset = "0x8D338C0", VA = "0x188D344C0")]
			public TweenEntry(SUVVTDZGSFD tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1A9D4F0", Offset = "0x1A9C8F0", VA = "0x181A9D4F0")]
			public TweenEntry(Func<SUVVTDZGSFD> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8D343A0", Offset = "0x8D337A0", VA = "0x188D343A0")]
			public SUVVTDZGSFD EVKFHVSWACF()
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
		private readonly List<Step> AUCGDVVRQJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int GCYIZDNYCAZ;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D32DE0", Offset = "0x8D321E0", VA = "0x188D32DE0")]
		public KHJHTLQTWMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D31EB0", Offset = "0x8D312B0", VA = "0x188D31EB0", Slot = "15")]
		public ADKDAGVCWIN ARLOTELQMYA(SUVVTDZGSFD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8D31DF0", Offset = "0x8D311F0", VA = "0x188D31DF0", Slot = "16")]
		public ADKDAGVCWIN ARLOTELQMYA(Func<SUVVTDZGSFD> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D327D0", Offset = "0x8D31BD0", VA = "0x188D327D0", Slot = "17")]
		public ADKDAGVCWIN FVTAAHBFULT(IEnumerable<SUVVTDZGSFD> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D32920", Offset = "0x8D31D20", VA = "0x188D32920", Slot = "18")]
		public ADKDAGVCWIN FVTAAHBFULT(params SUVVTDZGSFD[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8D32BC0", Offset = "0x8D31FC0", VA = "0x188D32BC0", Slot = "19")]
		public ADKDAGVCWIN XCZAAJPXBEY(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8D32AB0", Offset = "0x8D31EB0", VA = "0x188D32AB0", Slot = "13")]
		public override bool WMLZDCCYQSI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8D32CD0", Offset = "0x8D320D0", VA = "0x188D32CD0", Slot = "14")]
		public override float XNYLYIVFBPQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D320B0", Offset = "0x8D314B0", VA = "0x188D320B0")]
		private bool EYMWQXCUTHP(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D326C0", Offset = "0x8D31AC0", VA = "0x188D326C0")]
		private ADKDAGVCWIN FVTAAHBFULT(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2641E50", Offset = "0x2641250", VA = "0x182641E50")]
		[CompilerGenerated]
		private void SUGEXFIFPPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D32A90", Offset = "0x8D31E90", VA = "0x188D32A90")]
		[CompilerGenerated]
		private void SULLUMCCZAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class WFLMDHBBGGA : FCVQBKCDRHJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public KETTSMXWQSM Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WOYNMATPKOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform DRBMVQNABSL;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public WOYNMATPKOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8D365A0", Offset = "0x8D359A0", VA = "0x188D365A0")]
			internal Vector3 MOGKHGOZIIY()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8D365E0", Offset = "0x8D359E0", VA = "0x188D365E0")]
			internal void MOLRENIWRUH(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class VLMGFEXHLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform DRBMVQNABSL;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VLMGFEXHLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8D34C70", Offset = "0x8D34070", VA = "0x188D34C70")]
			internal Quaternion QBVZWSJLGLG()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8D34CB0", Offset = "0x8D340B0", VA = "0x188D34CB0")]
			internal void QCBGTZDIPWP(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class LLJSOJZYUBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform DRBMVQNABSL;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public LLJSOJZYUBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8D33110", Offset = "0x8D32510", VA = "0x188D33110")]
			internal Vector3 SSRKZYLKZZR()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8D330D0", Offset = "0x8D324D0", VA = "0x188D330D0")]
			internal void SSMECRRNQOI(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class RIOAGJYRBFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public KETTSMXWQSM PEDGVPXAUJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public WFLMDHBBGGA ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour OELTKTIMQDP;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public RIOAGJYRBFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8D33780", Offset = "0x8D32B80", VA = "0x188D33780")]
			internal void VVEEKENYZWN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KKSBQMDRKPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public WFLMDHBBGGA ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public KETTSMXWQSM ATVIODJBJDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ARAECGCQSWT KYWNSHPQLYH;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public KKSBQMDRKPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8D32F70", Offset = "0x8D32370", VA = "0x188D32F70")]
			internal void LTCJOWMVUXB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8D32F20", Offset = "0x8D32320", VA = "0x188D32F20")]
			internal void LSXCRPSYLLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8D33080", Offset = "0x8D32480", VA = "0x188D33080")]
			internal void LTMXJKAQNTT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class UPCUSOSCVIV : IEnumerator<QAEGIZFUAOU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private QAEGIZFUAOU FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public SUVVTDZGSFD PEDGVPXAUJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public WFLMDHBBGGA ZFLSXXSLHFA;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private QAEGIZFUAOU NPJDJONMYRN
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public UPCUSOSCVIV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8D348F0", Offset = "0x8D33CF0", VA = "0x188D348F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8D348B0", Offset = "0x8D33CB0", VA = "0x188D348B0", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class NXBIMWKUZIZ : IEnumerator<QAEGIZFUAOU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private QAEGIZFUAOU FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public WFLMDHBBGGA ZFLSXXSLHFA;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private QAEGIZFUAOU NPJDJONMYRN
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public NXBIMWKUZIZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8D33340", Offset = "0x8D32740", VA = "0x188D33340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8D33300", Offset = "0x8D32700", VA = "0x188D33300", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly TLYLZRCRVJA ARUZMIMYWWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly IUZMKIKQTUD VJPNHIYZBQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> YJSYGZSNYTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> YOTRWTKAHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<KETTSMXWQSM> BZLRRHOOIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<KETTSMXWQSM>> DENZPPSVQHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool LHYXHKNSNQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private ARAECGCQSWT SAZAUCVOBGL;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D35250", Offset = "0x8D34650", VA = "0x188D35250")]
		[JKCTBFVRGVY.Root]
		internal static void ICBJJQORUJZ(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8D36430", Offset = "0x8D35830", VA = "0x188D36430")]
		[UnityEngine.Scripting.Preserve]
		internal WFLMDHBBGGA([Inject(null)] TLYLZRCRVJA scheduler, [Inject(null)] IUZMKIKQTUD schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8D35510", Offset = "0x8D34910", VA = "0x188D35510", Slot = "4")]
		public KRBYSCUTGLF KDNDOZRUSMN(Func<float> a, Action<float> b, float c, float d, SXBLIGZOSBB.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8D36080", Offset = "0x8D35480", VA = "0x188D36080", Slot = "5")]
		public KRBYSCUTGLF WBABDOWHEYT(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, SXBLIGZOSBB.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8D34E40", Offset = "0x8D34240", VA = "0x188D34E40", Slot = "6")]
		public KRBYSCUTGLF DTWGOYIPZYU(Func<Color> a, Action<Color> b, Color c, float d, SXBLIGZOSBB.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8D35340", Offset = "0x8D34740", VA = "0x188D35340", Slot = "7")]
		public KRBYSCUTGLF JULGUYKGNEG(Transform a, Vector3 b, float c, SXBLIGZOSBB.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8D34FA0", Offset = "0x8D343A0", VA = "0x188D34FA0", Slot = "8")]
		public KRBYSCUTGLF GQZAOCZWHTM(Transform a, Quaternion b, float c, SXBLIGZOSBB.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8D358E0", Offset = "0x8D34CE0", VA = "0x188D358E0", Slot = "9")]
		public KRBYSCUTGLF QFHELGWIXZN(Transform a, Vector3 b, float c, SXBLIGZOSBB.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8D35EF0", Offset = "0x8D352F0", VA = "0x188D35EF0", Slot = "10")]
		public ADKDAGVCWIN Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8D35740", Offset = "0x8D34B40", VA = "0x188D35740", Slot = "11")]
		public void NBTDRNVXOVR(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8D355F0", Offset = "0x8D349F0", VA = "0x188D355F0", Slot = "12")]
		public void NBTDRNVXOVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8D36170", Offset = "0x8D35570", VA = "0x188D36170")]
		private void YYFNFUEZWGZ(Behaviour a, KETTSMXWQSM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8D34F30", Offset = "0x8D34330", VA = "0x188D34F30")]
		[IteratorStateMachine(typeof(NXBIMWKUZIZ))]
		private IEnumerator<QAEGIZFUAOU> EHRRKHJWBYW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D35B40", Offset = "0x8D34F40", VA = "0x188D35B40")]
		private void Run(Behaviour context, KETTSMXWQSM sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D35AB0", Offset = "0x8D34EB0", VA = "0x188D35AB0")]
		[IteratorStateMachine(typeof(UPCUSOSCVIV))]
		private IEnumerator<QAEGIZFUAOU> RHNGYBDXBZC(SUVVTDZGSFD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8D34CE0", Offset = "0x8D340E0", VA = "0x188D34CE0")]
		private void ARLOTELQMYA(KETTSMXWQSM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8D35160", Offset = "0x8D34560", VA = "0x188D35160")]
		private void HCOADFIBSUJ(KETTSMXWQSM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8D355F0", Offset = "0x8D349F0", VA = "0x188D355F0")]
		private void WVBIKHFQAKY(Scene a, LoadSceneMode b)
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
