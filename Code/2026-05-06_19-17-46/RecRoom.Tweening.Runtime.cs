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
		[Cpp2IlInjected.Address(RVA = "0xA3B6EF0", Offset = "0xA3B58F0", VA = "0x18A3B6EF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class XTGEFLIBUOL
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
		public static class HJTNFUMVUEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2A92270", Offset = "0x2A90C70", VA = "0x182A92270")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA3B2E20", Offset = "0xA3B1820", VA = "0x18A3B2E20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA3B2DD0", Offset = "0xA3B17D0", VA = "0x18A3B2DD0")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class QEGXJVGPXCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3DE0", Offset = "0xA3B27E0", VA = "0x18A3B3DE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3DF0", Offset = "0xA3B27F0", VA = "0x18A3B3DF0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3D90", Offset = "0xA3B2790", VA = "0x18A3B3D90")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class KUUBPTBNTQR
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3A30", Offset = "0xA3B2430", VA = "0x18A3B3A30")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3A40", Offset = "0xA3B2440", VA = "0x18A3B3A40")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA3B39D0", Offset = "0xA3B23D0", VA = "0x18A3B39D0")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class XYWJTAXATQF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA3B6BE0", Offset = "0xA3B55E0", VA = "0x18A3B6BE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA3B6C00", Offset = "0xA3B5600", VA = "0x18A3B6C00")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA3B6B80", Offset = "0xA3B5580", VA = "0x18A3B6B80")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3EE0", Offset = "0xA3B28E0", VA = "0x18A3B3EE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3F10", Offset = "0xA3B2910", VA = "0x18A3B3F10")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3EB0", Offset = "0xA3B28B0", VA = "0x18A3B3EB0")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA3B1F30", Offset = "0xA3B0930", VA = "0x18A3B1F30")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA3B1F80", Offset = "0xA3B0980", VA = "0x18A3B1F80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA3B1E70", Offset = "0xA3B0870", VA = "0x18A3B1E70")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class EFAJTHRAUGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA3B1D00", Offset = "0xA3B0700", VA = "0x18A3B1D00")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA3B1D60", Offset = "0xA3B0760", VA = "0x18A3B1D60")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA3B1C50", Offset = "0xA3B0650", VA = "0x18A3B1C50")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class AMQFENFBCYN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA3B0440", Offset = "0xA3AEE40", VA = "0x18A3B0440")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA3B04F0", Offset = "0xA3AEEF0", VA = "0x18A3B04F0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA3B0370", Offset = "0xA3AED70", VA = "0x18A3B0370")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float OFOCPGTXMDZ;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float GVFKVTHGZVR;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA3B0690", Offset = "0xA3AF090", VA = "0x18A3B0690")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA3B0710", Offset = "0xA3AF110", VA = "0x18A3B0710")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA3B05B0", Offset = "0xA3AEFB0", VA = "0x18A3B05B0")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA3B0910", Offset = "0xA3AF310", VA = "0x18A3B0910")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA3B09E0", Offset = "0xA3AF3E0", VA = "0x18A3B09E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA3B07F0", Offset = "0xA3AF1F0", VA = "0x18A3B07F0")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3B60D0", Offset = "0xA3B4AD0", VA = "0x18A3B60D0")]
		public static float MDKGXMZWRFW(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class GJCKLNGDKHA : UOTYZKWGOSC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA3B2CC0", Offset = "0xA3B16C0", VA = "0x18A3B2CC0")]
		public GJCKLNGDKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "13")]
		public override bool HMLEOQVJRRS(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD26890", Offset = "0xD25290", VA = "0x180D26890", Slot = "14")]
		public override float YBKCMTDELCO()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class SHJBXUTTAAZ : LJZWNPLHQEB<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E10", Offset = "0xA3B2810", VA = "0x18A3B3E10")]
		public SHJBXUTTAAZ(Func<Color> a, Action<Color> b, Color c, float d, XTGEFLIBUOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF21A80", Offset = "0xF20480", VA = "0x180F21A80", Slot = "15")]
		protected override Color XPDSUSEAZPG()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9814840", Offset = "0x9813240", VA = "0x189814840", Slot = "16")]
		protected override Color FKRJLQIJMRT(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ELIJJJUFKMM : LJZWNPLHQEB<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3B1E00", Offset = "0xA3B0800", VA = "0x18A3B1E00")]
		public ELIJJJUFKMM(Func<float> a, Action<float> b, float c, float d, XTGEFLIBUOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3B1DB0", Offset = "0xA3B07B0", VA = "0x18A3B1DB0", Slot = "15")]
		protected override float XPDSUSEAZPG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3B1D90", Offset = "0xA3B0790", VA = "0x18A3B1D90", Slot = "16")]
		protected override float FKRJLQIJMRT(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class VXVIARYTSLI : LJZWNPLHQEB<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4770", Offset = "0xA3B3170", VA = "0x18A3B4770")]
		public VXVIARYTSLI(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, XTGEFLIBUOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B45B0", Offset = "0xA3B2FB0", VA = "0x18A3B45B0", Slot = "15")]
		protected override Quaternion XPDSUSEAZPG()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4560", Offset = "0xA3B2F60", VA = "0x18A3B4560", Slot = "16")]
		protected override Quaternion FKRJLQIJMRT(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class NDBJHXNQTJM : LJZWNPLHQEB<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3CF0", Offset = "0xA3B26F0", VA = "0x18A3B3CF0")]
		public NDBJHXNQTJM(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XTGEFLIBUOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3C50", Offset = "0xA3B2650", VA = "0x18A3B3C50", Slot = "15")]
		protected override Vector3 XPDSUSEAZPG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6760", Offset = "0xA3A5160", VA = "0x18A3A6760", Slot = "16")]
		protected override Vector3 FKRJLQIJMRT(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface RRWBBRWONRT
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action IVBRHTSJJDR;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRWBBRWONRT EPUUUKNQJNQ(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RRWBBRWONRT BXRVAQYOWXG(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RRWBBRWONRT CILFOQKTUXD(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		NKOSDRYVRPY CMDRIOQHVGL();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HMLEOQVJRRS(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float YBKCMTDELCO();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface VPMANMSAXWH : RRWBBRWONRT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface WCACYCGINDX : RRWBBRWONRT
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WCACYCGINDX UFHZPVBUQEE(RRWBBRWONRT a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WCACYCGINDX UFHZPVBUQEE(Func<RRWBBRWONRT> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		WCACYCGINDX ABBIYHLZLHD(IEnumerable<RRWBBRWONRT> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		WCACYCGINDX ABBIYHLZLHD(params RRWBBRWONRT[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		WCACYCGINDX HBZOYYSEZYE(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface CQVLFRABHZJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		VPMANMSAXWH SBDTKWDPOQZ(Func<float> a, Action<float> b, float c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		VPMANMSAXWH UTNMGKFSTFJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VPMANMSAXWH LTJRZRGENKM(Func<Color> a, Action<Color> b, Color c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		VPMANMSAXWH OXCTGWYQLMK(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		VPMANMSAXWH AVOJYXHDRDY(Transform a, Quaternion b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		VPMANMSAXWH QKYLULKDKPB(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		WCACYCGINDX Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void FEAYTHYCROX(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class JMZJGBCQOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static RRWBBRWONRT GJCKLNGDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA3B31C0", Offset = "0xA3B1BC0", VA = "0x18A3B31C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3150", Offset = "0xA3B1B50", VA = "0x18A3B3150")]
		internal static CQVLFRABHZJ GVQIZUZFCSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA3B34F0", Offset = "0xA3B1EF0", VA = "0x18A3B34F0")]
		public static VPMANMSAXWH SBDTKWDPOQZ(Func<float> a, Action<float> b, float c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3710", Offset = "0xA3B2110", VA = "0x18A3B3710")]
		public static VPMANMSAXWH UTNMGKFSTFJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3210", Offset = "0xA3B1C10", VA = "0x18A3B3210")]
		public static VPMANMSAXWH LTJRZRGENKM(Func<Color> a, Action<Color> b, Color c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3350", Offset = "0xA3B1D50", VA = "0x18A3B3350")]
		public static VPMANMSAXWH OXCTGWYQLMK(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B2F40", Offset = "0xA3B1940", VA = "0x18A3B2F40")]
		public static VPMANMSAXWH AVOJYXHDRDY(Transform a, Quaternion b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3420", Offset = "0xA3B1E20", VA = "0x18A3B3420")]
		public static VPMANMSAXWH QKYLULKDKPB(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3620", Offset = "0xA3B2020", VA = "0x18A3B3620")]
		public static WCACYCGINDX Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3070", Offset = "0xA3B1A70", VA = "0x18A3B3070")]
		public static void FEAYTHYCROX(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class FFYTJSHEBAY : RRWBBRWONRT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action GFYGNKFOOVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action UWVPNUCPNAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> CZSZTASDPRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> JQSKTSIKFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> DAGYTPJUELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected DMQSFVKWVUR WEHJUYPLKYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object GGCNVAVUSGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool CKURQWVILTK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool FYHYOMGKAFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA3B2810", Offset = "0xA3B1210", VA = "0x18A3B2810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool FCMKGLSMPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA3B2830", Offset = "0xA3B1230", VA = "0x18A3B2830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action IVBRHTSJJDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA3B1FE0", Offset = "0xA3B09E0", VA = "0x18A3B1FE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA3B2770", Offset = "0xA3B1170", VA = "0x18A3B2770", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0", Slot = "9")]
		public NKOSDRYVRPY CMDRIOQHVGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA3B2420", Offset = "0xA3B0E20", VA = "0x18A3B2420", Slot = "6")]
		public RRWBBRWONRT EPUUUKNQJNQ(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA3B2080", Offset = "0xA3B0A80", VA = "0x18A3B2080", Slot = "7")]
		public RRWBBRWONRT BXRVAQYOWXG(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA3B2190", Offset = "0xA3B0B90", VA = "0x18A3B2190", Slot = "8")]
		public RRWBBRWONRT CILFOQKTUXD(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool HMLEOQVJRRS(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float YBKCMTDELCO();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B2280", Offset = "0xA3B0C80", VA = "0x18A3B2280", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B2640", Offset = "0xA3B1040", VA = "0x18A3B2640")]
		protected void NWHXZEXMJYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA3B24D0", Offset = "0xA3B0ED0", VA = "0x18A3B24D0")]
		protected void KSRYDQJTEQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA3B2850", Offset = "0xA3B1250", VA = "0x18A3B2850")]
		protected FFYTJSHEBAY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class MDEOMIOLKYX
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3B60", Offset = "0xA3B2560", VA = "0x18A3B3B60")]
		public static VPMANMSAXWH QKYLULKDKPB(this Behaviour a, Vector3 b, float c, XTGEFLIBUOL.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class UOTYZKWGOSC : FFYTJSHEBAY, VPMANMSAXWH, RRWBBRWONRT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool HNNEYWFQCNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float JENZUWEOWAS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected XTGEFLIBUOL.Functions EAZKERMCFSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1006CA0", Offset = "0x10056A0", VA = "0x181006CA0")]
			[CompilerGenerated]
			get
			{
				return default(XTGEFLIBUOL.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4450", Offset = "0xA3B2E50", VA = "0x18A3B4450")]
		protected UOTYZKWGOSC(float a, XTGEFLIBUOL.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2969000", Offset = "0x2967A00", VA = "0x182969000")]
		[CompilerGenerated]
		private void DYFVJMKGWLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA3B0EE0", Offset = "0xA3AF8E0", VA = "0x18A3B0EE0")]
		[CompilerGenerated]
		private void DYLCGTEEFWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class LJZWNPLHQEB<a> : UOTYZKWGOSC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> XNGFNIRFMJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> JDCNMFZHFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a KCEWIXOVTXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float JFAOPFDFIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a AZYHHRKTGVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a NOWYNBDMMZG;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x692C510", Offset = "0x692AF10", VA = "0x18692C510")]
		protected LJZWNPLHQEB(Func<a> a, Action<a> b, a c, float d, XTGEFLIBUOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a XPDSUSEAZPG();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a FKRJLQIJMRT(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x692B570", Offset = "0x6929F70", VA = "0x18692B570", Slot = "13")]
		public override bool HMLEOQVJRRS(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x692C1B0", Offset = "0x692ABB0", VA = "0x18692C1B0", Slot = "14")]
		public override float YBKCMTDELCO()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class EDHPPOCMCXO : FFYTJSHEBAY, WCACYCGINDX, RRWBBRWONRT
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
			private RRWBBRWONRT tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<RRWBBRWONRT> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA3B4050", Offset = "0xA3B2A50", VA = "0x18A3B4050")]
			public TweenEntry(RRWBBRWONRT tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D75330", Offset = "0x1D73D30", VA = "0x181D75330")]
			public TweenEntry(Func<RRWBBRWONRT> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3F30", Offset = "0xA3B2930", VA = "0x18A3B3F30")]
			public RRWBBRWONRT LOYHCSRJFXL()
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
		private readonly List<Step> DQKIFBOATWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int FYZTNHWEHIR;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA3B1B10", Offset = "0xA3B0510", VA = "0x18A3B1B10")]
		public EDHPPOCMCXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B17E0", Offset = "0xA3B01E0", VA = "0x18A3B17E0", Slot = "15")]
		public WCACYCGINDX UFHZPVBUQEE(RRWBBRWONRT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B1720", Offset = "0xA3B0120", VA = "0x18A3B1720", Slot = "16")]
		public WCACYCGINDX UFHZPVBUQEE(Func<RRWBBRWONRT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B0B00", Offset = "0xA3AF500", VA = "0x18A3B0B00", Slot = "17")]
		public WCACYCGINDX ABBIYHLZLHD(IEnumerable<RRWBBRWONRT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA3B0C50", Offset = "0xA3AF650", VA = "0x18A3B0C50", Slot = "18")]
		public WCACYCGINDX ABBIYHLZLHD(params RRWBBRWONRT[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA3B0F00", Offset = "0xA3AF900", VA = "0x18A3B0F00", Slot = "19")]
		public WCACYCGINDX HBZOYYSEZYE(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA3B1010", Offset = "0xA3AFA10", VA = "0x18A3B1010", Slot = "13")]
		public override bool HMLEOQVJRRS(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA3B19F0", Offset = "0xA3B03F0", VA = "0x18A3B19F0", Slot = "14")]
		public override float YBKCMTDELCO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA3B1120", Offset = "0xA3AFB20", VA = "0x18A3B1120")]
		private bool IHKUKOEWETP(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3B0DD0", Offset = "0xA3AF7D0", VA = "0x18A3B0DD0")]
		private WCACYCGINDX ABBIYHLZLHD(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2969000", Offset = "0x2967A00", VA = "0x182969000")]
		[CompilerGenerated]
		private void DYFVJMKGWLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA3B0EE0", Offset = "0xA3AF8E0", VA = "0x18A3B0EE0")]
		[CompilerGenerated]
		private void DYLCGTEEFWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class WDHIJBAPSDC : CQVLFRABHZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public FFYTJSHEBAY Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class DMEPAFIWFSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform PVTTUSWNKCD;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public DMEPAFIWFSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA3B0A80", Offset = "0xA3AF480", VA = "0x18A3B0A80")]
			internal Vector3 BHYLXDLSAPG()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA3B0AC0", Offset = "0xA3AF4C0", VA = "0x18A3B0AC0")]
			internal void BIDSUKFPKAP(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class LRWMZSOUZIR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform PVTTUSWNKCD;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LRWMZSOUZIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3AF0", Offset = "0xA3B24F0", VA = "0x18A3B3AF0")]
			internal Quaternion MGIFXAKNZJK()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3B30", Offset = "0xA3B2530", VA = "0x18A3B3B30")]
			internal void MGNMUHELIUT(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class LOIEGERNLZB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform PVTTUSWNKCD;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LOIEGERNLZB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3AB0", Offset = "0xA3B24B0", VA = "0x18A3B3AB0")]
			internal Vector3 RVAKZGUNDYP()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3A70", Offset = "0xA3B2470", VA = "0x18A3B3A70")]
			internal void RUVECAAPUNG(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class JLGJIUGGAQO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public FFYTJSHEBAY ZKWUKTZGIQB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public WDHIJBAPSDC IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour DGWPTYIAQJX;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public JLGJIUGGAQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA3B2E40", Offset = "0xA3B1840", VA = "0x18A3B2E40")]
			internal void KOZTWCCUNAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class ZYNVIXGRUKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public WDHIJBAPSDC IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public FFYTJSHEBAY LLFMIZRQGDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public NDLSPIRTFEP KRDTMVFEGYP;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ZYNVIXGRUKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA3B6D90", Offset = "0xA3B5790", VA = "0x18A3B6D90")]
			internal void HZKFFBMTDTZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA3B6D40", Offset = "0xA3B5740", VA = "0x18A3B6D40")]
			internal void HZEYHUSVUIQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA3B6EA0", Offset = "0xA3B58A0", VA = "0x18A3B6EA0")]
			internal void HZUSZPANWQR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class YFHOOICGFRX : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public RRWBBRWONRT ZKWUKTZGIQB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public WDHIJBAPSDC IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public YFHOOICGFRX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA3B6C30", Offset = "0xA3B5630", VA = "0x18A3B6C30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA3B6D00", Offset = "0xA3B5700", VA = "0x18A3B6D00", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class GCDWTKYWFLX : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public WDHIJBAPSDC IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public GCDWTKYWFLX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA3B2930", Offset = "0xA3B1330", VA = "0x18A3B2930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA3B2C80", Offset = "0xA3B1680", VA = "0x18A3B2C80", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly GUZFZPTTQMS TIZXXEFOSPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly IZYCAHMLASH AXBVZNQJOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> DXGATRUERZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> EMRMKAOFVAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<FFYTJSHEBAY> CAQZWFGIRJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<FFYTJSHEBAY>> ETJXWPNHDSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool IMNVEEZSMTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private NDLSPIRTFEP SRZJDRMGFLV;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5C20", Offset = "0xA3B4620", VA = "0x18A3B5C20")]
		[BQDQKYYGTTM.Root]
		internal static void TDUDTGPDFOH(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5F60", Offset = "0xA3B4960", VA = "0x18A3B5F60")]
		[UnityEngine.Scripting.Preserve]
		internal WDHIJBAPSDC([Inject(null)] GUZFZPTTQMS scheduler, [Inject(null)] IZYCAHMLASH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA3B59B0", Offset = "0xA3B43B0", VA = "0x18A3B59B0", Slot = "4")]
		public VPMANMSAXWH SBDTKWDPOQZ(Func<float> a, Action<float> b, float c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5E70", Offset = "0xA3B4870", VA = "0x18A3B5E70", Slot = "5")]
		public VPMANMSAXWH UTNMGKFSTFJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4EB0", Offset = "0xA3B38B0", VA = "0x18A3B4EB0", Slot = "6")]
		public VPMANMSAXWH LTJRZRGENKM(Func<Color> a, Action<Color> b, Color c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5260", Offset = "0xA3B3C60", VA = "0x18A3B5260", Slot = "7")]
		public VPMANMSAXWH OXCTGWYQLMK(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4810", Offset = "0xA3B3210", VA = "0x18A3B4810", Slot = "8")]
		public VPMANMSAXWH AVOJYXHDRDY(Transform a, Quaternion b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5430", Offset = "0xA3B3E30", VA = "0x18A3B5430", Slot = "9")]
		public VPMANMSAXWH QKYLULKDKPB(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5A90", Offset = "0xA3B4490", VA = "0x18A3B5A90", Slot = "10")]
		public WCACYCGINDX Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4B90", Offset = "0xA3B3590", VA = "0x18A3B4B90", Slot = "11")]
		public void FEAYTHYCROX(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA3B49D0", Offset = "0xA3B33D0", VA = "0x18A3B49D0", Slot = "12")]
		public void FEAYTHYCROX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4FA0", Offset = "0xA3B39A0", VA = "0x18A3B4FA0")]
		private void MBWBJANWPWZ(Behaviour a, FFYTJSHEBAY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4B20", Offset = "0xA3B3520", VA = "0x18A3B4B20")]
		[IteratorStateMachine(typeof(GCDWTKYWFLX))]
		private IEnumerator<KHZACSYKHRO> FBKEQSLGTIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5600", Offset = "0xA3B4000", VA = "0x18A3B5600")]
		private void Run(Behaviour context, FFYTJSHEBAY sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4D30", Offset = "0xA3B3730", VA = "0x18A3B4D30")]
		[IteratorStateMachine(typeof(YFHOOICGFRX))]
		private IEnumerator<KHZACSYKHRO> JDQBWKGQVLK(RRWBBRWONRT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5D10", Offset = "0xA3B4710", VA = "0x18A3B5D10")]
		private void UFHZPVBUQEE(FFYTJSHEBAY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA3B4DC0", Offset = "0xA3B37C0", VA = "0x18A3B4DC0")]
		private void LDCKHABPRQB(FFYTJSHEBAY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA3B49D0", Offset = "0xA3B33D0", VA = "0x18A3B49D0")]
		private void ENJAVFGUXAM(Scene a, LoadSceneMode b)
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
