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
		[Cpp2IlInjected.Address(RVA = "0xA2DA380", Offset = "0xA2D9780", VA = "0x18A2DA380", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29FCDD0", Offset = "0x29FC1D0", VA = "0x1829FCDD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A93550", Offset = "0x2A92950", VA = "0x182A93550")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA2D6290", Offset = "0xA2D5690", VA = "0x18A2D6290")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA2D6240", Offset = "0xA2D5640", VA = "0x18A2D6240")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class QEGXJVGPXCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA2D7290", Offset = "0xA2D6690", VA = "0x18A2D7290")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA2D72A0", Offset = "0xA2D66A0", VA = "0x18A2D72A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D7240", Offset = "0xA2D6640", VA = "0x18A2D7240")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class KUUBPTBNTQR
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D6EE0", Offset = "0xA2D62E0", VA = "0x18A2D6EE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D6EF0", Offset = "0xA2D62F0", VA = "0x18A2D6EF0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D6E80", Offset = "0xA2D6280", VA = "0x18A2D6E80")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class XYWJTAXATQF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA2DA070", Offset = "0xA2D9470", VA = "0x18A2DA070")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA2DA090", Offset = "0xA2D9490", VA = "0x18A2DA090")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA2DA010", Offset = "0xA2D9410", VA = "0x18A2DA010")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA2D7390", Offset = "0xA2D6790", VA = "0x18A2D7390")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA2D73C0", Offset = "0xA2D67C0", VA = "0x18A2D73C0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA2D7360", Offset = "0xA2D6760", VA = "0x18A2D7360")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA2D53A0", Offset = "0xA2D47A0", VA = "0x18A2D53A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA2D53F0", Offset = "0xA2D47F0", VA = "0x18A2D53F0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA2D52E0", Offset = "0xA2D46E0", VA = "0x18A2D52E0")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class EFAJTHRAUGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5170", Offset = "0xA2D4570", VA = "0x18A2D5170")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA2D51D0", Offset = "0xA2D45D0", VA = "0x18A2D51D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA2D50C0", Offset = "0xA2D44C0", VA = "0x18A2D50C0")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class AMQFENFBCYN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D38F0", Offset = "0xA2D2CF0", VA = "0x18A2D38F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D39A0", Offset = "0xA2D2DA0", VA = "0x18A2D39A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3820", Offset = "0xA2D2C20", VA = "0x18A2D3820")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D3B40", Offset = "0xA2D2F40", VA = "0x18A2D3B40")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3BB0", Offset = "0xA2D2FB0", VA = "0x18A2D3BB0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3A60", Offset = "0xA2D2E60", VA = "0x18A2D3A60")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3DA0", Offset = "0xA2D31A0", VA = "0x18A2D3DA0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3E70", Offset = "0xA2D3270", VA = "0x18A2D3E70")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3C80", Offset = "0xA2D3080", VA = "0x18A2D3C80")]
			public static float BPHWCBOSYZZ(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2D9570", Offset = "0xA2D8970", VA = "0x18A2D9570")]
		public static float MDKGXMZWRFW(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class GJCKLNGDKHA : UOTYZKWGOSC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA2D6130", Offset = "0xA2D5530", VA = "0x18A2D6130")]
		public GJCKLNGDKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "13")]
		public override bool HMLEOQVJRRS(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD44BF0", Offset = "0xD43FF0", VA = "0x180D44BF0", Slot = "14")]
		public override float YBKCMTDELCO()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class SHJBXUTTAAZ : LJZWNPLHQEB<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA2D72C0", Offset = "0xA2D66C0", VA = "0x18A2D72C0")]
		public SHJBXUTTAAZ(Func<Color> a, Action<Color> b, Color c, float d, XTGEFLIBUOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF38AD0", Offset = "0xF37ED0", VA = "0x180F38AD0", Slot = "15")]
		protected override Color XPDSUSEAZPG()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x974CFD0", Offset = "0x974C3D0", VA = "0x18974CFD0", Slot = "16")]
		protected override Color FKRJLQIJMRT(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ELIJJJUFKMM : LJZWNPLHQEB<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5270", Offset = "0xA2D4670", VA = "0x18A2D5270")]
		public ELIJJJUFKMM(Func<float> a, Action<float> b, float c, float d, XTGEFLIBUOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5220", Offset = "0xA2D4620", VA = "0x18A2D5220", Slot = "15")]
		protected override float XPDSUSEAZPG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5200", Offset = "0xA2D4600", VA = "0x18A2D5200", Slot = "16")]
		protected override float FKRJLQIJMRT(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class VXVIARYTSLI : LJZWNPLHQEB<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D7C10", Offset = "0xA2D7010", VA = "0x18A2D7C10")]
		public VXVIARYTSLI(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, XTGEFLIBUOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D7A50", Offset = "0xA2D6E50", VA = "0x18A2D7A50", Slot = "15")]
		protected override Quaternion XPDSUSEAZPG()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D7A00", Offset = "0xA2D6E00", VA = "0x18A2D7A00", Slot = "16")]
		protected override Quaternion FKRJLQIJMRT(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class NDBJHXNQTJM : LJZWNPLHQEB<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA2D71A0", Offset = "0xA2D65A0", VA = "0x18A2D71A0")]
		public NDBJHXNQTJM(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XTGEFLIBUOL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA2D7100", Offset = "0xA2D6500", VA = "0x18A2D7100", Slot = "15")]
		protected override Vector3 XPDSUSEAZPG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA2C9C40", Offset = "0xA2C9040", VA = "0x18A2C9C40", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D6650", Offset = "0xA2D5A50", VA = "0x18A2D6650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D65E0", Offset = "0xA2D59E0", VA = "0x18A2D65E0")]
		internal static CQVLFRABHZJ GVQIZUZFCSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D6990", Offset = "0xA2D5D90", VA = "0x18A2D6990")]
		public static VPMANMSAXWH SBDTKWDPOQZ(Func<float> a, Action<float> b, float c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D6BC0", Offset = "0xA2D5FC0", VA = "0x18A2D6BC0")]
		public static VPMANMSAXWH UTNMGKFSTFJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D66A0", Offset = "0xA2D5AA0", VA = "0x18A2D66A0")]
		public static VPMANMSAXWH LTJRZRGENKM(Func<Color> a, Action<Color> b, Color c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D67F0", Offset = "0xA2D5BF0", VA = "0x18A2D67F0")]
		public static VPMANMSAXWH OXCTGWYQLMK(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D63B0", Offset = "0xA2D57B0", VA = "0x18A2D63B0")]
		public static VPMANMSAXWH AVOJYXHDRDY(Transform a, Quaternion b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA2D68C0", Offset = "0xA2D5CC0", VA = "0x18A2D68C0")]
		public static VPMANMSAXWH QKYLULKDKPB(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA2D6AD0", Offset = "0xA2D5ED0", VA = "0x18A2D6AD0")]
		public static WCACYCGINDX Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA2D64F0", Offset = "0xA2D58F0", VA = "0x18A2D64F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D5C80", Offset = "0xA2D5080", VA = "0x18A2D5C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool FCMKGLSMPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5CA0", Offset = "0xA2D50A0", VA = "0x18A2D5CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action IVBRHTSJJDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5450", Offset = "0xA2D4850", VA = "0x18A2D5450", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5BE0", Offset = "0xA2D4FE0", VA = "0x18A2D5BE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0", Slot = "9")]
		public NKOSDRYVRPY CMDRIOQHVGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5890", Offset = "0xA2D4C90", VA = "0x18A2D5890", Slot = "6")]
		public RRWBBRWONRT EPUUUKNQJNQ(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D54F0", Offset = "0xA2D48F0", VA = "0x18A2D54F0", Slot = "7")]
		public RRWBBRWONRT BXRVAQYOWXG(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5600", Offset = "0xA2D4A00", VA = "0x18A2D5600", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2D56F0", Offset = "0xA2D4AF0", VA = "0x18A2D56F0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5AB0", Offset = "0xA2D4EB0", VA = "0x18A2D5AB0")]
		protected void NWHXZEXMJYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5940", Offset = "0xA2D4D40", VA = "0x18A2D5940")]
		protected void KSRYDQJTEQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5CC0", Offset = "0xA2D50C0", VA = "0x18A2D5CC0")]
		protected FFYTJSHEBAY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class MDEOMIOLKYX
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA2D7010", Offset = "0xA2D6410", VA = "0x18A2D7010")]
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
			[Cpp2IlInjected.Address(RVA = "0x101CAC0", Offset = "0x101BEC0", VA = "0x18101CAC0")]
			[CompilerGenerated]
			get
			{
				return default(XTGEFLIBUOL.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA2D78F0", Offset = "0xA2D6CF0", VA = "0x18A2D78F0")]
		protected UOTYZKWGOSC(float a, XTGEFLIBUOL.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x296B620", Offset = "0x296AA20", VA = "0x18296B620")]
		[CompilerGenerated]
		private void DYFVJMKGWLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4360", Offset = "0xA2D3760", VA = "0x18A2D4360")]
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
		[Cpp2IlInjected.Address(RVA = "0x689F110", Offset = "0x689E510", VA = "0x18689F110")]
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
		[Cpp2IlInjected.Address(RVA = "0x689E180", Offset = "0x689D580", VA = "0x18689E180", Slot = "13")]
		public override bool HMLEOQVJRRS(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x689EDC0", Offset = "0x689E1C0", VA = "0x18689EDC0", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D7500", Offset = "0xA2D6900", VA = "0x18A2D7500")]
			public TweenEntry(RRWBBRWONRT tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D7F600", Offset = "0x1D7EA00", VA = "0x181D7F600")]
			public TweenEntry(Func<RRWBBRWONRT> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D73E0", Offset = "0xA2D67E0", VA = "0x18A2D73E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2D4F80", Offset = "0xA2D4380", VA = "0x18A2D4F80")]
		public EDHPPOCMCXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4C70", Offset = "0xA2D4070", VA = "0x18A2D4C70", Slot = "15")]
		public WCACYCGINDX UFHZPVBUQEE(RRWBBRWONRT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4BB0", Offset = "0xA2D3FB0", VA = "0x18A2D4BB0", Slot = "16")]
		public WCACYCGINDX UFHZPVBUQEE(Func<RRWBBRWONRT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3F90", Offset = "0xA2D3390", VA = "0x18A2D3F90", Slot = "17")]
		public WCACYCGINDX ABBIYHLZLHD(IEnumerable<RRWBBRWONRT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA2D40E0", Offset = "0xA2D34E0", VA = "0x18A2D40E0", Slot = "18")]
		public WCACYCGINDX ABBIYHLZLHD(params RRWBBRWONRT[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4380", Offset = "0xA2D3780", VA = "0x18A2D4380", Slot = "19")]
		public WCACYCGINDX HBZOYYSEZYE(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4490", Offset = "0xA2D3890", VA = "0x18A2D4490", Slot = "13")]
		public override bool HMLEOQVJRRS(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4E70", Offset = "0xA2D4270", VA = "0x18A2D4E70", Slot = "14")]
		public override float YBKCMTDELCO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA2D45A0", Offset = "0xA2D39A0", VA = "0x18A2D45A0")]
		private bool IHKUKOEWETP(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4250", Offset = "0xA2D3650", VA = "0x18A2D4250")]
		private WCACYCGINDX ABBIYHLZLHD(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x296B620", Offset = "0x296AA20", VA = "0x18296B620")]
		[CompilerGenerated]
		private void DYFVJMKGWLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4360", Offset = "0xA2D3760", VA = "0x18A2D4360")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public DMEPAFIWFSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3F10", Offset = "0xA2D3310", VA = "0x18A2D3F10")]
			internal Vector3 BHYLXDLSAPG()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3F50", Offset = "0xA2D3350", VA = "0x18A2D3F50")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public LRWMZSOUZIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA2D6FA0", Offset = "0xA2D63A0", VA = "0x18A2D6FA0")]
			internal Quaternion MGIFXAKNZJK()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA2D6FE0", Offset = "0xA2D63E0", VA = "0x18A2D6FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public LOIEGERNLZB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D6F60", Offset = "0xA2D6360", VA = "0x18A2D6F60")]
			internal Vector3 RVAKZGUNDYP()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D6F20", Offset = "0xA2D6320", VA = "0x18A2D6F20")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public JLGJIUGGAQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D62B0", Offset = "0xA2D56B0", VA = "0x18A2D62B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public ZYNVIXGRUKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA2DA220", Offset = "0xA2D9620", VA = "0x18A2DA220")]
			internal void HZKFFBMTDTZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA2DA1D0", Offset = "0xA2D95D0", VA = "0x18A2DA1D0")]
			internal void HZEYHUSVUIQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA2DA330", Offset = "0xA2D9730", VA = "0x18A2DA330")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public YFHOOICGFRX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA2DA0C0", Offset = "0xA2D94C0", VA = "0x18A2DA0C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA2DA190", Offset = "0xA2D9590", VA = "0x18A2DA190", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public GCDWTKYWFLX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5DA0", Offset = "0xA2D51A0", VA = "0x18A2D5DA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA2D60F0", Offset = "0xA2D54F0", VA = "0x18A2D60F0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2D90C0", Offset = "0xA2D84C0", VA = "0x18A2D90C0")]
		[BQDQKYYGTTM.Root]
		internal static void TDUDTGPDFOH(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA2D9400", Offset = "0xA2D8800", VA = "0x18A2D9400")]
		[UnityEngine.Scripting.Preserve]
		internal WDHIJBAPSDC([Inject(null)] GUZFZPTTQMS scheduler, [Inject(null)] IZYCAHMLASH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA2D8E50", Offset = "0xA2D8250", VA = "0x18A2D8E50", Slot = "4")]
		public VPMANMSAXWH SBDTKWDPOQZ(Func<float> a, Action<float> b, float c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA2D9310", Offset = "0xA2D8710", VA = "0x18A2D9310", Slot = "5")]
		public VPMANMSAXWH UTNMGKFSTFJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA2D8350", Offset = "0xA2D7750", VA = "0x18A2D8350", Slot = "6")]
		public VPMANMSAXWH LTJRZRGENKM(Func<Color> a, Action<Color> b, Color c, float d, XTGEFLIBUOL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA2D8700", Offset = "0xA2D7B00", VA = "0x18A2D8700", Slot = "7")]
		public VPMANMSAXWH OXCTGWYQLMK(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA2D7CB0", Offset = "0xA2D70B0", VA = "0x18A2D7CB0", Slot = "8")]
		public VPMANMSAXWH AVOJYXHDRDY(Transform a, Quaternion b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA2D88D0", Offset = "0xA2D7CD0", VA = "0x18A2D88D0", Slot = "9")]
		public VPMANMSAXWH QKYLULKDKPB(Transform a, Vector3 b, float c, XTGEFLIBUOL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA2D8F30", Offset = "0xA2D8330", VA = "0x18A2D8F30", Slot = "10")]
		public WCACYCGINDX Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D8030", Offset = "0xA2D7430", VA = "0x18A2D8030", Slot = "11")]
		public void FEAYTHYCROX(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D7E70", Offset = "0xA2D7270", VA = "0x18A2D7E70", Slot = "12")]
		public void FEAYTHYCROX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D8440", Offset = "0xA2D7840", VA = "0x18A2D8440")]
		private void MBWBJANWPWZ(Behaviour a, FFYTJSHEBAY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D7FC0", Offset = "0xA2D73C0", VA = "0x18A2D7FC0")]
		[IteratorStateMachine(typeof(GCDWTKYWFLX))]
		private IEnumerator<KHZACSYKHRO> FBKEQSLGTIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D8AA0", Offset = "0xA2D7EA0", VA = "0x18A2D8AA0")]
		private void Run(Behaviour context, FFYTJSHEBAY sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D81D0", Offset = "0xA2D75D0", VA = "0x18A2D81D0")]
		[IteratorStateMachine(typeof(YFHOOICGFRX))]
		private IEnumerator<KHZACSYKHRO> JDQBWKGQVLK(RRWBBRWONRT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA2D91B0", Offset = "0xA2D85B0", VA = "0x18A2D91B0")]
		private void UFHZPVBUQEE(FFYTJSHEBAY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA2D8260", Offset = "0xA2D7660", VA = "0x18A2D8260")]
		private void LDCKHABPRQB(FFYTJSHEBAY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA2D7E70", Offset = "0xA2D7270", VA = "0x18A2D7E70")]
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
