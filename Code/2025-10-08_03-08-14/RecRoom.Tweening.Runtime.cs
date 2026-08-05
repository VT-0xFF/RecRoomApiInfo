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
		[Cpp2IlInjected.Address(RVA = "0x90B9B90", Offset = "0x90B8990", VA = "0x1890B9B90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class DDZCIZKYTZY
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
		public static class REHNYLGEVBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x29FA660", Offset = "0x29F9460", VA = "0x1829FA660")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x90B6560", Offset = "0x90B5360", VA = "0x1890B6560")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x90B6510", Offset = "0x90B5310", VA = "0x1890B6510")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class PJFKIOFAKXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x90B6490", Offset = "0x90B5290", VA = "0x1890B6490")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x90B64F0", Offset = "0x90B52F0", VA = "0x1890B64F0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x90B64A0", Offset = "0x90B52A0", VA = "0x1890B64A0")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class NRUFTHMJYHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x90B6210", Offset = "0x90B5010", VA = "0x1890B6210")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x90B6280", Offset = "0x90B5080", VA = "0x1890B6280")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x90B6220", Offset = "0x90B5020", VA = "0x1890B6220")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class WEXCXKNYARY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x90B8E60", Offset = "0x90B7C60", VA = "0x1890B8E60")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x90B8EE0", Offset = "0x90B7CE0", VA = "0x1890B8EE0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x90B8E80", Offset = "0x90B7C80", VA = "0x1890B8E80")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x90B7600", Offset = "0x90B6400", VA = "0x1890B7600")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x90B7660", Offset = "0x90B6460", VA = "0x1890B7660")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x90B7630", Offset = "0x90B6430", VA = "0x1890B7630")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x90B3E70", Offset = "0x90B2C70", VA = "0x1890B3E70")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x90B3F80", Offset = "0x90B2D80", VA = "0x1890B3F80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x90B3EC0", Offset = "0x90B2CC0", VA = "0x1890B3EC0")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class IEJJRBXUKLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x90B41B0", Offset = "0x90B2FB0", VA = "0x1890B41B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x90B42C0", Offset = "0x90B30C0", VA = "0x1890B42C0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x90B4210", Offset = "0x90B3010", VA = "0x1890B4210")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class RFBYLEGXRQC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x90B6580", Offset = "0x90B5380", VA = "0x1890B6580")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x90B6700", Offset = "0x90B5500", VA = "0x1890B6700")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x90B6630", Offset = "0x90B5430", VA = "0x1890B6630")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float OXXXDJBNSUE;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float NNFNHVPPEGG;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x90B2F20", Offset = "0x90B1D20", VA = "0x1890B2F20")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x90B3070", Offset = "0x90B1E70", VA = "0x1890B3070")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x90B2F90", Offset = "0x90B1D90", VA = "0x1890B2F90")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x90B3140", Offset = "0x90B1F40", VA = "0x1890B3140")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x90B3330", Offset = "0x90B2130", VA = "0x1890B3330")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x90B3210", Offset = "0x90B2010", VA = "0x1890B3210")]
			public static float JKLUDTFXFOY(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x90B33D0", Offset = "0x90B21D0", VA = "0x1890B33D0")]
		public static float UYDSUKHRMGR(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class JRIFGAJCJIL : OHSUGRJSDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x90B4360", Offset = "0x90B3160", VA = "0x1890B4360")]
		public JRIFGAJCJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "13")]
		public override bool EUCALFTVQHJ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB0DD50", Offset = "0xB0CB50", VA = "0x180B0DD50", Slot = "14")]
		public override float NDYGKFIDBGD()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class SRKXAQLYEZW : FCTDCFXKIZI<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x90B69F0", Offset = "0x90B57F0", VA = "0x1890B69F0")]
		public SRKXAQLYEZW(Func<Color> a, Action<Color> b, Color c, float d, DDZCIZKYTZY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF49840", Offset = "0xF48640", VA = "0x180F49840", Slot = "15")]
		protected override Color OYQKZWQRTXD()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x854F520", Offset = "0x854E320", VA = "0x18854F520", Slot = "16")]
		protected override Color RJYHFKIQOXM(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class HWHPEMXNXQJ : FCTDCFXKIZI<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x90B4140", Offset = "0x90B2F40", VA = "0x1890B4140")]
		public HWHPEMXNXQJ(Func<float> a, Action<float> b, float c, float d, DDZCIZKYTZY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x90B40D0", Offset = "0x90B2ED0", VA = "0x1890B40D0", Slot = "15")]
		protected override float OYQKZWQRTXD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x90B4120", Offset = "0x90B2F20", VA = "0x1890B4120", Slot = "16")]
		protected override float RJYHFKIQOXM(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class LLZMUSWCOOB : FCTDCFXKIZI<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x90B5FC0", Offset = "0x90B4DC0", VA = "0x1890B5FC0")]
		public LLZMUSWCOOB(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, DDZCIZKYTZY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x90B5DB0", Offset = "0x90B4BB0", VA = "0x1890B5DB0", Slot = "15")]
		protected override Quaternion OYQKZWQRTXD()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x90B5F70", Offset = "0x90B4D70", VA = "0x1890B5F70", Slot = "16")]
		protected override Quaternion RJYHFKIQOXM(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class SDKSOWASFTZ : FCTDCFXKIZI<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x90B6950", Offset = "0x90B5750", VA = "0x1890B6950")]
		public SDKSOWASFTZ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, DDZCIZKYTZY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x90B6840", Offset = "0x90B5640", VA = "0x1890B6840", Slot = "15")]
		protected override Vector3 OYQKZWQRTXD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x90B68E0", Offset = "0x90B56E0", VA = "0x1890B68E0", Slot = "16")]
		protected override Vector3 RJYHFKIQOXM(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface MOTEZCKPDVC
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action RIZFXUOMOTK;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MOTEZCKPDVC SPYTURWTNBB(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		MOTEZCKPDVC QYHNHPZAWLZ(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MOTEZCKPDVC MOONPHDBKKO(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		WGVXBSAEBCD QDSVPNAHZWY();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EUCALFTVQHJ(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float NDYGKFIDBGD();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface VUQVEPKYEQS : MOTEZCKPDVC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ZLCEFWVIQIY : MOTEZCKPDVC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZLCEFWVIQIY TODQJMKKTUZ(MOTEZCKPDVC a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ZLCEFWVIQIY TODQJMKKTUZ(Func<MOTEZCKPDVC> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ZLCEFWVIQIY KSXHAQAMGWW(IEnumerable<MOTEZCKPDVC> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ZLCEFWVIQIY KSXHAQAMGWW(params MOTEZCKPDVC[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZLCEFWVIQIY BRTLPDDAGAN(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface PCREJSGELQI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		VUQVEPKYEQS QVBEYQLJSGU(Func<float> a, Action<float> b, float c, float d, DDZCIZKYTZY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		VUQVEPKYEQS DNPASXKYASK(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, DDZCIZKYTZY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VUQVEPKYEQS PUSMQVCPQOB(Func<Color> a, Action<Color> b, Color c, float d, DDZCIZKYTZY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		VUQVEPKYEQS SUTEOUOWGVT(Transform a, Vector3 b, float c, DDZCIZKYTZY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		VUQVEPKYEQS XGRIRYYMDZV(Transform a, Quaternion b, float c, DDZCIZKYTZY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		VUQVEPKYEQS IGEVBKAJPMC(Transform a, Vector3 b, float c, DDZCIZKYTZY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ZLCEFWVIQIY Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void TINANVRPHLG(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class SSIOFTWEUWG
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MOTEZCKPDVC JRIFGAJCJIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x90B7270", Offset = "0x90B6070", VA = "0x1890B7270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x90B6CC0", Offset = "0x90B5AC0", VA = "0x1890B6CC0")]
		internal static PCREJSGELQI LOFHGKCSUIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x90B6E80", Offset = "0x90B5C80", VA = "0x1890B6E80")]
		public static VUQVEPKYEQS QVBEYQLJSGU(Func<float> a, Action<float> b, float c, float d, DDZCIZKYTZY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x90B6A90", Offset = "0x90B5890", VA = "0x1890B6A90")]
		public static VUQVEPKYEQS DNPASXKYASK(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, DDZCIZKYTZY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x90B6D30", Offset = "0x90B5B30", VA = "0x1890B6D30")]
		public static VUQVEPKYEQS PUSMQVCPQOB(Func<Color> a, Action<Color> b, Color c, float d, DDZCIZKYTZY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x90B6FC0", Offset = "0x90B5DC0", VA = "0x1890B6FC0")]
		public static VUQVEPKYEQS SUTEOUOWGVT(Transform a, Vector3 b, float c, DDZCIZKYTZY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x90B72C0", Offset = "0x90B60C0", VA = "0x1890B72C0")]
		public static VUQVEPKYEQS XGRIRYYMDZV(Transform a, Quaternion b, float c, DDZCIZKYTZY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x90B6BF0", Offset = "0x90B59F0", VA = "0x1890B6BF0")]
		public static VUQVEPKYEQS IGEVBKAJPMC(Transform a, Vector3 b, float c, DDZCIZKYTZY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x90B7090", Offset = "0x90B5E90", VA = "0x1890B7090")]
		public static ZLCEFWVIQIY Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x90B7180", Offset = "0x90B5F80", VA = "0x1890B7180")]
		public static void TINANVRPHLG(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class YRFFJRVAZZR : MOTEZCKPDVC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action FZEKOWFXUZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action WTNYJIIAAVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> AZSYQLAWIVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> JWAMMUXQNPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> XMSMHWFEFWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected JJHUMDULGGC YPTUROBCDWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object DKPUVTGBHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool FTEXGGMLCWF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool GRWSSKTFSVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x90B9280", Offset = "0x90B8080", VA = "0x1890B9280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool ZGWVPPYLWBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x90B9660", Offset = "0x90B8460", VA = "0x1890B9660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action RIZFXUOMOTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x90B9680", Offset = "0x90B8480", VA = "0x1890B9680", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x90B8F10", Offset = "0x90B7D10", VA = "0x1890B8F10", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120", Slot = "9")]
		public WGVXBSAEBCD QDSVPNAHZWY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x90B95A0", Offset = "0x90B83A0", VA = "0x1890B95A0", Slot = "6")]
		public MOTEZCKPDVC SPYTURWTNBB(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x90B94A0", Offset = "0x90B82A0", VA = "0x1890B94A0", Slot = "7")]
		public MOTEZCKPDVC QYHNHPZAWLZ(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x90B92A0", Offset = "0x90B80A0", VA = "0x1890B92A0", Slot = "8")]
		public MOTEZCKPDVC MOONPHDBKKO(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool EUCALFTVQHJ(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float NDYGKFIDBGD();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x90B8FB0", Offset = "0x90B7DB0", VA = "0x1890B8FB0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x90B9150", Offset = "0x90B7F50", VA = "0x1890B9150")]
		protected void EMWUSQLOWGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x90B9330", Offset = "0x90B8130", VA = "0x1890B9330")]
		protected void OIVTLUZOMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x90B9720", Offset = "0x90B8520", VA = "0x1890B9720")]
		protected YRFFJRVAZZR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class FABZZCEADQE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x90B3FE0", Offset = "0x90B2DE0", VA = "0x1890B3FE0")]
		public static VUQVEPKYEQS IGEVBKAJPMC(this Behaviour a, Vector3 b, float c, DDZCIZKYTZY.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class OHSUGRJSDHL : YRFFJRVAZZR, VUQVEPKYEQS, MOTEZCKPDVC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool VQIVPWGPVVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float YYGNXSGPDCL;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected DDZCIZKYTZY.Functions GGAEQZIIVSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xC4F9C0", Offset = "0xC4E7C0", VA = "0x180C4F9C0")]
			[CompilerGenerated]
			get
			{
				return default(DDZCIZKYTZY.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x90B62D0", Offset = "0x90B50D0", VA = "0x1890B62D0")]
		protected OHSUGRJSDHL(float a, DDZCIZKYTZY.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC12ED0", Offset = "0xC11CD0", VA = "0x180C12ED0")]
		[CompilerGenerated]
		private void AHSIGQACKJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x90B62B0", Offset = "0x90B50B0", VA = "0x1890B62B0")]
		[CompilerGenerated]
		private void AHNBJJGFAYI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class FCTDCFXKIZI<a> : OHSUGRJSDHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> XYAMPFUQSGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> NKHKUDTQEAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a HMCVCWUIEWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float OVNDZAPGBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a XIFJSOKVDLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a BYHVXSJLXVX;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x503B430", Offset = "0x503A230", VA = "0x18503B430")]
		protected FCTDCFXKIZI(Func<a> a, Action<a> b, a c, float d, DDZCIZKYTZY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a OYQKZWQRTXD();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a RJYHFKIQOXM(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x503AF50", Offset = "0x5039D50", VA = "0x18503AF50", Slot = "13")]
		public override bool EUCALFTVQHJ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x503B290", Offset = "0x503A090", VA = "0x18503B290", Slot = "14")]
		public override float NDYGKFIDBGD()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class VQQHEQENUXN : YRFFJRVAZZR, ZLCEFWVIQIY, MOTEZCKPDVC
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
			private MOTEZCKPDVC tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<MOTEZCKPDVC> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x90B78B0", Offset = "0x90B66B0", VA = "0x1890B78B0")]
			public TweenEntry(MOTEZCKPDVC tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D0AC90", Offset = "0x1D09A90", VA = "0x181D0AC90")]
			public TweenEntry(Func<MOTEZCKPDVC> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x90B7790", Offset = "0x90B6590", VA = "0x1890B7790")]
			public MOTEZCKPDVC IWURTIASNAE()
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
		private readonly List<Step> JJTQKJKGWVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int KEAMZNRWRPA;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x90B8C80", Offset = "0x90B7A80", VA = "0x1890B8C80")]
		public VQQHEQENUXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x90B83B0", Offset = "0x90B71B0", VA = "0x1890B83B0", Slot = "15")]
		public ZLCEFWVIQIY TODQJMKKTUZ(MOTEZCKPDVC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x90B85B0", Offset = "0x90B73B0", VA = "0x1890B85B0", Slot = "16")]
		public ZLCEFWVIQIY TODQJMKKTUZ(Func<MOTEZCKPDVC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x90B8150", Offset = "0x90B6F50", VA = "0x1890B8150", Slot = "17")]
		public ZLCEFWVIQIY KSXHAQAMGWW(IEnumerable<MOTEZCKPDVC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x90B7EC0", Offset = "0x90B6CC0", VA = "0x1890B7EC0", Slot = "18")]
		public ZLCEFWVIQIY KSXHAQAMGWW(params MOTEZCKPDVC[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x90B7CA0", Offset = "0x90B6AA0", VA = "0x1890B7CA0", Slot = "19")]
		public ZLCEFWVIQIY BRTLPDDAGAN(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x90B7DB0", Offset = "0x90B6BB0", VA = "0x1890B7DB0", Slot = "13")]
		public override bool EUCALFTVQHJ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x90B82A0", Offset = "0x90B70A0", VA = "0x1890B82A0", Slot = "14")]
		public override float NDYGKFIDBGD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x90B8670", Offset = "0x90B7470", VA = "0x1890B8670")]
		private bool TWGRKSFMUWW(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x90B8030", Offset = "0x90B6E30", VA = "0x1890B8030")]
		private ZLCEFWVIQIY KSXHAQAMGWW(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC12ED0", Offset = "0xC11CD0", VA = "0x180C12ED0")]
		[CompilerGenerated]
		private void AHSIGQACKJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x90B62B0", Offset = "0x90B50B0", VA = "0x1890B62B0")]
		[CompilerGenerated]
		private void AHNBJJGFAYI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class KWZGRTKGVWZ : PCREJSGELQI
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public YRFFJRVAZZR Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class RVDZJLMSLEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform HAAZRAGVUFA;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public RVDZJLMSLEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x90B6800", Offset = "0x90B5600", VA = "0x1890B6800")]
			internal Vector3 USLHYZWANXF()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x90B67C0", Offset = "0x90B55C0", VA = "0x1890B67C0")]
			internal void USGBBTCDELW(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class IJGUSUENVJY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform HAAZRAGVUFA;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public IJGUSUENVJY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x90B4320", Offset = "0x90B3120", VA = "0x1890B4320")]
			internal Quaternion TZXSORKIQFL()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x90B42F0", Offset = "0x90B30F0", VA = "0x1890B42F0")]
			internal void TZSLRKQLGUC(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class BEYJMNWUOVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform HAAZRAGVUFA;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BEYJMNWUOVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x90B2EA0", Offset = "0x90B1CA0", VA = "0x1890B2EA0")]
			internal Vector3 VFFVSLFKUES()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x90B2EE0", Offset = "0x90B1CE0", VA = "0x1890B2EE0")]
			internal void VFLCPRZIDQB(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class KPWYJSNCUCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public YRFFJRVAZZR EUHABQXPXZE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public KWZGRTKGVWZ WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour ADKEKNLASFE;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public KPWYJSNCUCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x90B4500", Offset = "0x90B3300", VA = "0x1890B4500")]
			internal void YEQFZWSHYRE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class MALXDQDZUBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public KWZGRTKGVWZ WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public YRFFJRVAZZR PWRFFDKJPZA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public DLHIAPQRHVO VVXTPEZYXEA;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MALXDQDZUBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x90B6060", Offset = "0x90B4E60", VA = "0x1890B6060")]
			internal void OXCHGMIOZZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x90B6170", Offset = "0x90B4F70", VA = "0x1890B6170")]
			internal void OXHODTCMJLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x90B61C0", Offset = "0x90B4FC0", VA = "0x1890B61C0")]
			internal void OXMVAZWJSWO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class TVEVFVEQCLI : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public MOTEZCKPDVC EUHABQXPXZE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public KWZGRTKGVWZ WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public TVEVFVEQCLI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x90B76C0", Offset = "0x90B64C0", VA = "0x1890B76C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x90B7680", Offset = "0x90B6480", VA = "0x1890B7680", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class ZHAMHGDHLZW : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public KWZGRTKGVWZ WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public ZHAMHGDHLZW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x90B9840", Offset = "0x90B8640", VA = "0x1890B9840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x90B9800", Offset = "0x90B8600", VA = "0x1890B9800", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly TQPUKRRDZNZ LDPTRROTLSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly BHTOMZEUOYU TKZRNOFRIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> VBQJJVLRIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> DOOUKGITRBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<YRFFJRVAZZR> JWFBKBKFOZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<YRFFJRVAZZR>> MCCATRAPGWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool GNADAOGCUOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private DLHIAPQRHVO DCZOMXGQWQG;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x90B4DD0", Offset = "0x90B3BD0", VA = "0x1890B4DD0")]
		[FDNTPBIGLET.Root]
		internal static void NHOBNFBSGEC(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x90B5C40", Offset = "0x90B4A40", VA = "0x1890B5C40")]
		[UnityEngine.Scripting.Preserve]
		internal KWZGRTKGVWZ([Inject(null)] TQPUKRRDZNZ scheduler, [Inject(null)] BHTOMZEUOYU schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x90B4FB0", Offset = "0x90B3DB0", VA = "0x1890B4FB0", Slot = "4")]
		public VUQVEPKYEQS QVBEYQLJSGU(Func<float> a, Action<float> b, float c, float d, DDZCIZKYTZY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x90B4600", Offset = "0x90B3400", VA = "0x1890B4600", Slot = "5")]
		public VUQVEPKYEQS DNPASXKYASK(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, DDZCIZKYTZY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x90B4EC0", Offset = "0x90B3CC0", VA = "0x1890B4EC0", Slot = "6")]
		public VUQVEPKYEQS PUSMQVCPQOB(Func<Color> a, Action<Color> b, Color c, float d, DDZCIZKYTZY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x90B5440", Offset = "0x90B4240", VA = "0x1890B5440", Slot = "7")]
		public VUQVEPKYEQS SUTEOUOWGVT(Transform a, Vector3 b, float c, DDZCIZKYTZY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x90B59F0", Offset = "0x90B47F0", VA = "0x1890B59F0", Slot = "8")]
		public VUQVEPKYEQS XGRIRYYMDZV(Transform a, Quaternion b, float c, DDZCIZKYTZY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x90B47E0", Offset = "0x90B35E0", VA = "0x1890B47E0", Slot = "9")]
		public VUQVEPKYEQS IGEVBKAJPMC(Transform a, Vector3 b, float c, DDZCIZKYTZY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x90B5610", Offset = "0x90B4410", VA = "0x1890B5610", Slot = "10")]
		public ZLCEFWVIQIY Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x90B5680", Offset = "0x90B4480", VA = "0x1890B5680", Slot = "11")]
		public void TINANVRPHLG(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x90B4C80", Offset = "0x90B3A80", VA = "0x1890B4C80", Slot = "12")]
		public void TINANVRPHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x90B49B0", Offset = "0x90B37B0", VA = "0x1890B49B0")]
		private void IHLVWRQKHAS(Behaviour a, YRFFJRVAZZR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x90B5980", Offset = "0x90B4780", VA = "0x1890B5980")]
		[IteratorStateMachine(typeof(ZHAMHGDHLZW))]
		private IEnumerator<IMKAVQMVTAL> UUWBBZOUDYF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x90B5090", Offset = "0x90B3E90", VA = "0x1890B5090")]
		private void Run(Behaviour context, YRFFJRVAZZR sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x90B5BB0", Offset = "0x90B49B0", VA = "0x1890B5BB0")]
		[IteratorStateMachine(typeof(TVEVFVEQCLI))]
		private IEnumerator<IMKAVQMVTAL> ZARCULWYXCV(MOTEZCKPDVC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x90B5820", Offset = "0x90B4620", VA = "0x1890B5820")]
		private void TODQJMKKTUZ(YRFFJRVAZZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x90B46F0", Offset = "0x90B34F0", VA = "0x1890B46F0")]
		private void GIQWFPNOYBM(YRFFJRVAZZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x90B4C80", Offset = "0x90B3A80", VA = "0x1890B4C80")]
		private void MLTXSHTOGZJ(Scene a, LoadSceneMode b)
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
