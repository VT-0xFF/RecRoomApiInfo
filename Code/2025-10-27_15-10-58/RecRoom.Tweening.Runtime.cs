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
		[Cpp2IlInjected.Address(RVA = "0x9260450", Offset = "0x925F450", VA = "0x189260450", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F5B20", Offset = "0x29F4B20", VA = "0x1829F5B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class LSEPQOBOBIY
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
		public static class BFGTMBPFKVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2A8CCC0", Offset = "0x2A8BCC0", VA = "0x182A8CCC0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9259840", Offset = "0x9258840", VA = "0x189259840")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x92597F0", Offset = "0x92587F0", VA = "0x1892597F0")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class LGDFRXNYXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x925D530", Offset = "0x925C530", VA = "0x18925D530")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x925D590", Offset = "0x925C590", VA = "0x18925D590")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x925D540", Offset = "0x925C540", VA = "0x18925D540")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class VLJQDBRMAZC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x925FE60", Offset = "0x925EE60", VA = "0x18925FE60")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x925FED0", Offset = "0x925EED0", VA = "0x18925FED0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x925FE70", Offset = "0x925EE70", VA = "0x18925FE70")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class YGYBGXREOUY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9260020", Offset = "0x925F020", VA = "0x189260020")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x92600A0", Offset = "0x925F0A0", VA = "0x1892600A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9260040", Offset = "0x925F040", VA = "0x189260040")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x925F7E0", Offset = "0x925E7E0", VA = "0x18925F7E0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x925F840", Offset = "0x925E840", VA = "0x18925F840")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x925F810", Offset = "0x925E810", VA = "0x18925F810")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x925AB10", Offset = "0x9259B10", VA = "0x18925AB10")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x925AC20", Offset = "0x9259C20", VA = "0x18925AC20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x925AB60", Offset = "0x9259B60", VA = "0x18925AB60")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class GUTVTWFBAXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x925AC80", Offset = "0x9259C80", VA = "0x18925AC80")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x925AD90", Offset = "0x9259D90", VA = "0x18925AD90")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x925ACE0", Offset = "0x9259CE0", VA = "0x18925ACE0")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class EWMTYGQJCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x925A8D0", Offset = "0x92598D0", VA = "0x18925A8D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x925AA50", Offset = "0x9259A50", VA = "0x18925AA50")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x925A980", Offset = "0x9259980", VA = "0x18925A980")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float UEEBFMBLURE;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float OZWIXQHSGDG;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x925A150", Offset = "0x9259150", VA = "0x18925A150")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x925A2B0", Offset = "0x92592B0", VA = "0x18925A2B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x925A1D0", Offset = "0x92591D0", VA = "0x18925A1D0")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x925A390", Offset = "0x9259390", VA = "0x18925A390")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x925A580", Offset = "0x9259580", VA = "0x18925A580")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x925A460", Offset = "0x9259460", VA = "0x18925A460")]
			public static float LYRNOTOXFZA(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x925D5B0", Offset = "0x925C5B0", VA = "0x18925D5B0")]
		public static float PBDSRJSIBLJ(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class YSBSEWZHRQN : AIZBNFSDBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x92602B0", Offset = "0x925F2B0", VA = "0x1892602B0")]
		public YSBSEWZHRQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "13")]
		public override bool ONMDGUNLBVT(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB1CCE0", Offset = "0xB1BCE0", VA = "0x180B1CCE0", Slot = "14")]
		public override float PKLKKKPAJMZ()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class XEJWAEPWEAC : YLVMZVFPZDO<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x925FF80", Offset = "0x925EF80", VA = "0x18925FF80")]
		public XEJWAEPWEAC(Func<Color> a, Action<Color> b, Color c, float d, LSEPQOBOBIY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFF8940", Offset = "0xFF7940", VA = "0x180FF8940", Slot = "15")]
		protected override Color EYNGTUBAGZF()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86DDB90", Offset = "0x86DCB90", VA = "0x1886DDB90", Slot = "16")]
		protected override Color IABJQLCJTEQ(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class VJYSEPYODJR : YLVMZVFPZDO<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x925FDF0", Offset = "0x925EDF0", VA = "0x18925FDF0")]
		public VJYSEPYODJR(Func<float> a, Action<float> b, float c, float d, LSEPQOBOBIY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x925FD80", Offset = "0x925ED80", VA = "0x18925FD80", Slot = "15")]
		protected override float EYNGTUBAGZF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x925FDD0", Offset = "0x925EDD0", VA = "0x18925FDD0", Slot = "16")]
		protected override float IABJQLCJTEQ(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class CJJHNYKVWML : YLVMZVFPZDO<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x925A830", Offset = "0x9259830", VA = "0x18925A830")]
		public CJJHNYKVWML(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, LSEPQOBOBIY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x925A620", Offset = "0x9259620", VA = "0x18925A620", Slot = "15")]
		protected override Quaternion EYNGTUBAGZF()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x925A7E0", Offset = "0x92597E0", VA = "0x18925A7E0", Slot = "16")]
		protected override Quaternion IABJQLCJTEQ(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class AWWZKFDOCLT : YLVMZVFPZDO<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x92596D0", Offset = "0x92586D0", VA = "0x1892596D0")]
		public AWWZKFDOCLT(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, LSEPQOBOBIY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x92595C0", Offset = "0x92585C0", VA = "0x1892595C0", Slot = "15")]
		protected override Vector3 EYNGTUBAGZF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9259660", Offset = "0x9258660", VA = "0x189259660", Slot = "16")]
		protected override Vector3 IABJQLCJTEQ(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface QLMCBPGELJU
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action GPKZNBYMVHE;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QLMCBPGELJU DJSJIEXNAFT(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		QLMCBPGELJU ABCPZPAKJAV(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		QLMCBPGELJU ZYVWJXLUTCA(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		EMLXNRBUHND KZVXTOYHSXQ();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ONMDGUNLBVT(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float PKLKKKPAJMZ();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface DMVMNAGLMKI : QLMCBPGELJU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface WLDBNQLJPBQ : QLMCBPGELJU
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WLDBNQLJPBQ OSSOCQHICDB(QLMCBPGELJU a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WLDBNQLJPBQ OSSOCQHICDB(Func<QLMCBPGELJU> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		WLDBNQLJPBQ YMTWAXFXFSM(IEnumerable<QLMCBPGELJU> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		WLDBNQLJPBQ YMTWAXFXFSM(params QLMCBPGELJU[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		WLDBNQLJPBQ ROJPUGFBYGD(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ZOOLYIEHXCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DMVMNAGLMKI BIEZZVFPEUS(Func<float> a, Action<float> b, float c, float d, LSEPQOBOBIY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DMVMNAGLMKI ARMTMGAHVOE(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, LSEPQOBOBIY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DMVMNAGLMKI XBRMQYOAACL(Func<Color> a, Action<Color> b, Color c, float d, LSEPQOBOBIY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		DMVMNAGLMKI XUORERGLJGD(Transform a, Vector3 b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		DMVMNAGLMKI KIQLNHMZNRH(Transform a, Quaternion b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DMVMNAGLMKI XYBLHMVNEID(Transform a, Vector3 b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		DMVMNAGLMKI BDXWZQMEEMI(Transform a, Vector3 b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		WLDBNQLJPBQ Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void QXEVTJXKUXE(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class HFYYULROWRW
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static QLMCBPGELJU YSBSEWZHRQN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x925B120", Offset = "0x925A120", VA = "0x18925B120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x925B690", Offset = "0x925A690", VA = "0x18925B690")]
		internal static ZOOLYIEHXCC YFSISNPJFQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x925AFF0", Offset = "0x9259FF0", VA = "0x18925AFF0")]
		public static DMVMNAGLMKI BIEZZVFPEUS(Func<float> a, Action<float> b, float c, float d, LSEPQOBOBIY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x925ADC0", Offset = "0x9259DC0", VA = "0x18925ADC0")]
		public static DMVMNAGLMKI ARMTMGAHVOE(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, LSEPQOBOBIY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x925B480", Offset = "0x925A480", VA = "0x18925B480")]
		public static DMVMNAGLMKI XBRMQYOAACL(Func<Color> a, Action<Color> b, Color c, float d, LSEPQOBOBIY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x925B5C0", Offset = "0x925A5C0", VA = "0x18925B5C0")]
		public static DMVMNAGLMKI XUORERGLJGD(Transform a, Vector3 b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x925B170", Offset = "0x925A170", VA = "0x18925B170")]
		public static DMVMNAGLMKI KIQLNHMZNRH(Transform a, Quaternion b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x925AF20", Offset = "0x9259F20", VA = "0x18925AF20")]
		public static DMVMNAGLMKI BDXWZQMEEMI(Transform a, Vector3 b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x925B390", Offset = "0x925A390", VA = "0x18925B390")]
		public static WLDBNQLJPBQ Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x925B2A0", Offset = "0x925A2A0", VA = "0x18925B2A0")]
		public static void QXEVTJXKUXE(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class BVEAHHMLPJP : QLMCBPGELJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action TGVJDKAVZDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action FRHWDHNLOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> OAVIMQFSJSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> CLYKNNOHGGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> NAVLRDNRFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected DAKLXQLFUQQ AUSTWJIEORM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object DFCLBQLXJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool DQZGXYGDIDF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool XHWDLPECNXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9259960", Offset = "0x9258960", VA = "0x189259960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool NYIDVADDLVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9259FC0", Offset = "0x9258FC0", VA = "0x189259FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action GPKZNBYMVHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9259D10", Offset = "0x9258D10", VA = "0x189259D10", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9259F20", Offset = "0x9258F20", VA = "0x189259F20", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0", Slot = "9")]
		public EMLXNRBUHND KZVXTOYHSXQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9259B20", Offset = "0x9258B20", VA = "0x189259B20", Slot = "6")]
		public QLMCBPGELJU DJSJIEXNAFT(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9259860", Offset = "0x9258860", VA = "0x189259860", Slot = "7")]
		public QLMCBPGELJU ABCPZPAKJAV(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9259FE0", Offset = "0x9258FE0", VA = "0x189259FE0", Slot = "8")]
		public QLMCBPGELJU ZYVWJXLUTCA(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool ONMDGUNLBVT(float a);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float PKLKKKPAJMZ();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9259980", Offset = "0x9258980", VA = "0x189259980", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9259BE0", Offset = "0x9258BE0", VA = "0x189259BE0")]
		protected void GWOECLOSWAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9259DB0", Offset = "0x9258DB0", VA = "0x189259DB0")]
		protected void TOWFDQZBTLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x925A070", Offset = "0x9259070", VA = "0x18925A070")]
		protected BVEAHHMLPJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class YMAPFDUCROS
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x92601C0", Offset = "0x925F1C0", VA = "0x1892601C0")]
		public static DMVMNAGLMKI XYBLHMVNEID(this Behaviour a, Vector3 b, float c, LSEPQOBOBIY.Functions d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x92600D0", Offset = "0x925F0D0", VA = "0x1892600D0")]
		public static DMVMNAGLMKI BDXWZQMEEMI(this Behaviour a, Vector3 b, float c, LSEPQOBOBIY.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class AIZBNFSDBIH : BVEAHHMLPJP, DMVMNAGLMKI, QLMCBPGELJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool BRAYDZEICAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float TOBHYYUQJQN;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected LSEPQOBOBIY.Functions PAKOEMIHMNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xC850D0", Offset = "0xC840D0", VA = "0x180C850D0")]
			[CompilerGenerated]
			get
			{
				return default(LSEPQOBOBIY.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9259400", Offset = "0x9258400", VA = "0x189259400")]
		protected AIZBNFSDBIH(float a, LSEPQOBOBIY.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCED4C0", Offset = "0xCEC4C0", VA = "0x180CED4C0")]
		[CompilerGenerated]
		private void NAILBLURDBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x92593E0", Offset = "0x92583E0", VA = "0x1892593E0")]
		[CompilerGenerated]
		private void NADEEFATTPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class YLVMZVFPZDO<a> : AIZBNFSDBIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> KGHZMQDJHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> FVRNQDXYLIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a GURVIURTOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float AWPATJYLKDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a ESNUAYLFJTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a BZMZSDIIZOX;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x419AD10", Offset = "0x4199D10", VA = "0x18419AD10")]
		protected YLVMZVFPZDO(Func<a> a, Action<a> b, a c, float d, LSEPQOBOBIY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a EYNGTUBAGZF();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a IABJQLCJTEQ(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x419A560", Offset = "0x4199560", VA = "0x18419A560", Slot = "13")]
		public override bool ONMDGUNLBVT(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x419A8B0", Offset = "0x41998B0", VA = "0x18419A8B0", Slot = "14")]
		public override float PKLKKKPAJMZ()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class SSHSXQTSEOZ : BVEAHHMLPJP, WLDBNQLJPBQ, QLMCBPGELJU
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
			private QLMCBPGELJU tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<QLMCBPGELJU> factory;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x925F980", Offset = "0x925E980", VA = "0x18925F980")]
			public TweenEntry(QLMCBPGELJU tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1DEC390", Offset = "0x1DEB390", VA = "0x181DEC390")]
			public TweenEntry(Func<QLMCBPGELJU> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x925F860", Offset = "0x925E860", VA = "0x18925F860")]
			public QLMCBPGELJU EBEYDFDGQBE()
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
		private readonly List<Step> EBRCTEZPUJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int VYBYVZXARZO;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x925F600", Offset = "0x925E600", VA = "0x18925F600")]
		public SSHSXQTSEOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x925E700", Offset = "0x925D700", VA = "0x18925E700", Slot = "15")]
		public WLDBNQLJPBQ OSSOCQHICDB(QLMCBPGELJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x925E910", Offset = "0x925D910", VA = "0x18925E910", Slot = "16")]
		public WLDBNQLJPBQ OSSOCQHICDB(Func<QLMCBPGELJU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x925F4B0", Offset = "0x925E4B0", VA = "0x18925F4B0", Slot = "17")]
		public WLDBNQLJPBQ YMTWAXFXFSM(IEnumerable<QLMCBPGELJU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x925F210", Offset = "0x925E210", VA = "0x18925F210", Slot = "18")]
		public WLDBNQLJPBQ YMTWAXFXFSM(params QLMCBPGELJU[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x925F100", Offset = "0x925E100", VA = "0x18925F100", Slot = "19")]
		public WLDBNQLJPBQ ROJPUGFBYGD(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x925E5F0", Offset = "0x925D5F0", VA = "0x18925E5F0", Slot = "13")]
		public override bool ONMDGUNLBVT(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x925E9D0", Offset = "0x925D9D0", VA = "0x18925E9D0", Slot = "14")]
		public override float PKLKKKPAJMZ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x925EAF0", Offset = "0x925DAF0", VA = "0x18925EAF0")]
		private bool PXCZIAFKXDS(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x925F390", Offset = "0x925E390", VA = "0x18925F390")]
		private WLDBNQLJPBQ YMTWAXFXFSM(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xCED4C0", Offset = "0xCEC4C0", VA = "0x180CED4C0")]
		[CompilerGenerated]
		private void NAILBLURDBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x92593E0", Offset = "0x92583E0", VA = "0x1892593E0")]
		[CompilerGenerated]
		private void NADEEFATTPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class IWZBHKCTOBR : ZOOLYIEHXCC
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public BVEAHHMLPJP Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WLNPPNEKMUG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform REBRARHAJUY;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public WLNPPNEKMUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x925FF40", Offset = "0x925EF40", VA = "0x18925FF40")]
			internal Vector3 PLJCXPKOUXX()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x925FF00", Offset = "0x925EF00", VA = "0x18925FF00")]
			internal void PLDWAIQRLMO(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class NFXTCRZLHHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform REBRARHAJUY;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public NFXTCRZLHHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x925E090", Offset = "0x925D090", VA = "0x18925E090")]
			internal Quaternion QYPRUDNBLXF()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x925E060", Offset = "0x925D060", VA = "0x18925E060")]
			internal void QYKKWWTECLW(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class BEUHJFMKNBR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform REBRARHAJUY;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public BEUHJFMKNBR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x92597B0", Offset = "0x92587B0", VA = "0x1892597B0")]
			internal Vector3 UTKTJYHCBSF()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9259770", Offset = "0x9258770", VA = "0x189259770")]
			internal void UTFMMRNESGW(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class OJKAJNVTGNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Transform REBRARHAJUY;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public OJKAJNVTGNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x925E0D0", Offset = "0x925D0D0", VA = "0x18925E0D0")]
			internal Vector3 OTXOTHDWABK()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x925E110", Offset = "0x925D110", VA = "0x18925E110")]
			internal void OUCVQNXTJMT(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class JJOXKGWUTXF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public BVEAHHMLPJP CDDFUDVKZXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public IWZBHKCTOBR FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Behaviour AGGAWTUHLTW;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public JJOXKGWUTXF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x925D430", Offset = "0x925C430", VA = "0x18925D430")]
			internal void PNLTILFUBMY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class HYZYQJFXTYB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public IWZBHKCTOBR FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public BVEAHHMLPJP BDTHHVLEUQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CRSHLUEXDAO KUIENZLNGVM;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HYZYQJFXTYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x925B950", Offset = "0x925A950", VA = "0x18925B950")]
			internal void HJRCZFDKTBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x925BA60", Offset = "0x925AA60", VA = "0x18925BA60")]
			internal void HJWJWLXICMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x925B900", Offset = "0x925A900", VA = "0x18925B900")]
			internal void HJGPERPQAEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class RSOSIEKZLWI : IEnumerator<UNBASXFCXPD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private UNBASXFCXPD IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public QLMCBPGELJU CDDFUDVKZXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public IWZBHKCTOBR FOYWNDAXKGX;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private UNBASXFCXPD UORWHXRETNW
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public RSOSIEKZLWI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x925E520", Offset = "0x925D520", VA = "0x18925E520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x925E4E0", Offset = "0x925D4E0", VA = "0x18925E4E0", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class QXONRKKKDMC : IEnumerator<UNBASXFCXPD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private UNBASXFCXPD IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public IWZBHKCTOBR FOYWNDAXKGX;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private UNBASXFCXPD UORWHXRETNW
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public QXONRKKKDMC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x925E190", Offset = "0x925D190", VA = "0x18925E190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x925E150", Offset = "0x925D150", VA = "0x18925E150", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly UDOEIWDLMUV SVPPPFJDELQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly VNPKHDSCVRU CQBLJJXIJSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> HKLBVGQUOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> ASHHDCLERYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<BVEAHHMLPJP> BVBIKSWQQTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<BVEAHHMLPJP>> NHNXTJMUZBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool PDGZCEYUWKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private CRSHLUEXDAO AAXKRHEMFWA;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x925BBA0", Offset = "0x925ABA0", VA = "0x18925BBA0")]
		[OKVIBKJHYHD.Root]
		internal static void AUVAYKNAWWE(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x925D2C0", Offset = "0x925C2C0", VA = "0x18925D2C0")]
		[UnityEngine.Scripting.Preserve]
		internal IWZBHKCTOBR([Inject(null)] UDOEIWDLMUV scheduler, [Inject(null)] VNPKHDSCVRU schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x925BE60", Offset = "0x925AE60", VA = "0x18925BE60", Slot = "4")]
		public DMVMNAGLMKI BIEZZVFPEUS(Func<float> a, Action<float> b, float c, float d, LSEPQOBOBIY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x925BAB0", Offset = "0x925AAB0", VA = "0x18925BAB0", Slot = "5")]
		public DMVMNAGLMKI ARMTMGAHVOE(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, LSEPQOBOBIY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x925CE30", Offset = "0x925BE30", VA = "0x18925CE30", Slot = "6")]
		public DMVMNAGLMKI XBRMQYOAACL(Func<Color> a, Action<Color> b, Color c, float d, LSEPQOBOBIY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x925CF20", Offset = "0x925BF20", VA = "0x18925CF20", Slot = "7")]
		public DMVMNAGLMKI XUORERGLJGD(Transform a, Vector3 b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x925C100", Offset = "0x925B100", VA = "0x18925C100", Slot = "8")]
		public DMVMNAGLMKI KIQLNHMZNRH(Transform a, Quaternion b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x925D0F0", Offset = "0x925C0F0", VA = "0x18925D0F0", Slot = "9")]
		public DMVMNAGLMKI XYBLHMVNEID(Transform a, Vector3 b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x925BC90", Offset = "0x925AC90", VA = "0x18925BC90", Slot = "10")]
		public DMVMNAGLMKI BDXWZQMEEMI(Transform a, Vector3 b, float c, LSEPQOBOBIY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x925CD30", Offset = "0x925BD30", VA = "0x18925CD30", Slot = "11")]
		public WLDBNQLJPBQ Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x925C7E0", Offset = "0x925B7E0", VA = "0x18925C7E0", Slot = "12")]
		public void QXEVTJXKUXE(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x925BFB0", Offset = "0x925AFB0", VA = "0x18925BFB0", Slot = "13")]
		public void QXEVTJXKUXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x925C510", Offset = "0x925B510", VA = "0x18925C510")]
		private void QDGMJOVLCSI(Behaviour a, BVEAHHMLPJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x925BF40", Offset = "0x925AF40", VA = "0x18925BF40")]
		[IteratorStateMachine(typeof(QXONRKKKDMC))]
		private IEnumerator<UNBASXFCXPD> DDGUYNTIKUD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x925C980", Offset = "0x925B980", VA = "0x18925C980")]
		private void Run(Behaviour context, BVEAHHMLPJP sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x925CDA0", Offset = "0x925BDA0", VA = "0x18925CDA0")]
		[IteratorStateMachine(typeof(RSOSIEKZLWI))]
		private IEnumerator<UNBASXFCXPD> VKWSQGPJOBZ(QLMCBPGELJU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x925C3B0", Offset = "0x925B3B0", VA = "0x18925C3B0")]
		private void OSSOCQHICDB(BVEAHHMLPJP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x925C2C0", Offset = "0x925B2C0", VA = "0x18925C2C0")]
		private void OOZPXPCJFKY(BVEAHHMLPJP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x925BFB0", Offset = "0x925AFB0", VA = "0x18925BFB0")]
		private void ECVJWVQUJGJ(Scene a, LoadSceneMode b)
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
