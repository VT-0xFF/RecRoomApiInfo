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
		[Cpp2IlInjected.Address(RVA = "0x9037720", Offset = "0x9035D20", VA = "0x189037720", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class SKZTDPXQOXX
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
		public static class ISDNDVJEHZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2A17640", Offset = "0x2A15C40", VA = "0x182A17640")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9033870", Offset = "0x9031E70", VA = "0x189033870")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9033820", Offset = "0x9031E20", VA = "0x189033820")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class PIDXWVSBLIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9033D30", Offset = "0x9032330", VA = "0x189033D30")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9033D90", Offset = "0x9032390", VA = "0x189033D90")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9033D40", Offset = "0x9032340", VA = "0x189033D40")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class ATMHJRRDPIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9030860", Offset = "0x902EE60", VA = "0x189030860")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x90308D0", Offset = "0x902EED0", VA = "0x1890308D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9030870", Offset = "0x902EE70", VA = "0x189030870")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class YFNOVUYYSLR
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9037030", Offset = "0x9035630", VA = "0x189037030")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x90370B0", Offset = "0x90356B0", VA = "0x1890370B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9037050", Offset = "0x9035650", VA = "0x189037050")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9036600", Offset = "0x9034C00", VA = "0x189036600")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9036660", Offset = "0x9034C60", VA = "0x189036660")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9036630", Offset = "0x9034C30", VA = "0x189036630")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9032510", Offset = "0x9030B10", VA = "0x189032510")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9032620", Offset = "0x9030C20", VA = "0x189032620")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9032560", Offset = "0x9030B60", VA = "0x189032560")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class BYZRWBBWYJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9031CE0", Offset = "0x90302E0", VA = "0x189031CE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9031DF0", Offset = "0x90303F0", VA = "0x189031DF0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9031D40", Offset = "0x9030340", VA = "0x189031D40")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class EDQRJEQOFYX
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x90322D0", Offset = "0x90308D0", VA = "0x1890322D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9032450", Offset = "0x9030A50", VA = "0x189032450")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9032380", Offset = "0x9030980", VA = "0x189032380")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float JVTWJJKIJRD;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float VRCECYZWWIB;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9031E20", Offset = "0x9030420", VA = "0x189031E20")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9031F70", Offset = "0x9030570", VA = "0x189031F70")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9031E90", Offset = "0x9030490", VA = "0x189031E90")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9032040", Offset = "0x9030640", VA = "0x189032040")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9032230", Offset = "0x9030830", VA = "0x189032230")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9032110", Offset = "0x9030710", VA = "0x189032110")]
			public static float MZGXILVQPHX(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9035AF0", Offset = "0x90340F0", VA = "0x189035AF0")]
		public static float PUNCIXKCUQS(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class NQXFSZQTYEY : XPETAYTWPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9033C20", Offset = "0x9032220", VA = "0x189033C20")]
		public NQXFSZQTYEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "13")]
		public override bool OKCJRGNMABQ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAF5360", Offset = "0xAF3960", VA = "0x180AF5360", Slot = "14")]
		public override float LJSAFDSXDQM()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class ZTMFMQVDQDV : OWAPUTYFBOP<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x90374D0", Offset = "0x9035AD0", VA = "0x1890374D0")]
		public ZTMFMQVDQDV(Func<Color> a, Action<Color> b, Color c, float d, SKZTDPXQOXX.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFA0490", Offset = "0xF9EA90", VA = "0x180FA0490", Slot = "15")]
		protected override Color CGHJVCRUYFQ()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84C7A60", Offset = "0x84C6060", VA = "0x1884C7A60", Slot = "16")]
		protected override Color LXHSZKGVJVZ(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class XWPBLUTXKBM : OWAPUTYFBOP<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9036FC0", Offset = "0x90355C0", VA = "0x189036FC0")]
		public XWPBLUTXKBM(Func<float> a, Action<float> b, float c, float d, SKZTDPXQOXX.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9036F50", Offset = "0x9035550", VA = "0x189036F50", Slot = "15")]
		protected override float CGHJVCRUYFQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9036FA0", Offset = "0x90355A0", VA = "0x189036FA0", Slot = "16")]
		protected override float LXHSZKGVJVZ(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class QZRNTDVIERS : OWAPUTYFBOP<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9033FC0", Offset = "0x90325C0", VA = "0x189033FC0")]
		public QZRNTDVIERS(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, SKZTDPXQOXX.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9033DB0", Offset = "0x90323B0", VA = "0x189033DB0", Slot = "15")]
		protected override Quaternion CGHJVCRUYFQ()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9033F70", Offset = "0x9032570", VA = "0x189033F70", Slot = "16")]
		protected override Quaternion LXHSZKGVJVZ(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class VKAKCKNKPQU : OWAPUTYFBOP<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9036D20", Offset = "0x9035320", VA = "0x189036D20")]
		public VKAKCKNKPQU(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, SKZTDPXQOXX.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9036C10", Offset = "0x9035210", VA = "0x189036C10", Slot = "15")]
		protected override Vector3 CGHJVCRUYFQ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9036CB0", Offset = "0x90352B0", VA = "0x189036CB0", Slot = "16")]
		protected override Vector3 LXHSZKGVJVZ(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface EXTMAAWWJAP
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action FPBIZBTLFOJ;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EXTMAAWWJAP WHILQULGKKQ(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		EXTMAAWWJAP XGNEFUYRRBI(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		EXTMAAWWJAP ZJTVPQGPURN(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		VCIEUBMMHTW IQQOVGPMDFT();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool OKCJRGNMABQ(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float LJSAFDSXDQM();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ZALDCARQCDD : EXTMAAWWJAP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface RPJPXXHQVQL : EXTMAAWWJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RPJPXXHQVQL ACHUQYNLYIO(EXTMAAWWJAP a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RPJPXXHQVQL ACHUQYNLYIO(Func<EXTMAAWWJAP> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RPJPXXHQVQL AIBFBJCUGPR(IEnumerable<EXTMAAWWJAP> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RPJPXXHQVQL AIBFBJCUGPR(params EXTMAAWWJAP[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RPJPXXHQVQL MJJLABUPCVY(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface TGHIJKSQVNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZALDCARQCDD QLHKHKXGYPN(Func<float> a, Action<float> b, float c, float d, SKZTDPXQOXX.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ZALDCARQCDD EZXYQZVLUWB(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, SKZTDPXQOXX.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ZALDCARQCDD LNSXHYNOLPU(Func<Color> a, Action<Color> b, Color c, float d, SKZTDPXQOXX.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ZALDCARQCDD UOGBUGWXPDS(Transform a, Vector3 b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZALDCARQCDD FWZUDOXXJBW(Transform a, Quaternion b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ZALDCARQCDD RGHJJANIDVG(Transform a, Vector3 b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ZALDCARQCDD QTQWXJWNCKN(Transform a, Vector3 b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		RPJPXXHQVQL Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void UMYZGUJZFGR(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class BKFEQDWSIHR
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static EXTMAAWWJAP NQXFSZQTYEY
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x90311E0", Offset = "0x902F7E0", VA = "0x1890311E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9030CD0", Offset = "0x902F2D0", VA = "0x189030CD0")]
		internal static TGHIJKSQVNP PPQAZFEPFNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9030D40", Offset = "0x902F340", VA = "0x189030D40")]
		public static ZALDCARQCDD QLHKHKXGYPN(Func<float> a, Action<float> b, float c, float d, SKZTDPXQOXX.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9030900", Offset = "0x902EF00", VA = "0x189030900")]
		public static ZALDCARQCDD EZXYQZVLUWB(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, SKZTDPXQOXX.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9030B90", Offset = "0x902F190", VA = "0x189030B90")]
		public static ZALDCARQCDD LNSXHYNOLPU(Func<Color> a, Action<Color> b, Color c, float d, SKZTDPXQOXX.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9031110", Offset = "0x902F710", VA = "0x189031110")]
		public static ZALDCARQCDD UOGBUGWXPDS(Transform a, Vector3 b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9030A60", Offset = "0x902F060", VA = "0x189030A60")]
		public static ZALDCARQCDD FWZUDOXXJBW(Transform a, Quaternion b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9030E70", Offset = "0x902F470", VA = "0x189030E70")]
		public static ZALDCARQCDD QTQWXJWNCKN(Transform a, Vector3 b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9030F40", Offset = "0x902F540", VA = "0x189030F40")]
		public static RPJPXXHQVQL Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9031030", Offset = "0x902F630", VA = "0x189031030")]
		public static void UMYZGUJZFGR(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class BTIWXVPZEBY : EXTMAAWWJAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action JVIZWFQAZTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action ZCRTTIEUPTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> ZZADJYDEVEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> WDFXTODAILY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> FOTETOOCDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected ONLWDMAXIKL FOBJSUETHEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object HGXANSBOQFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool DLRSFNJOUXY;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool BTZPWHLJIYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9031660", Offset = "0x902FC60", VA = "0x189031660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool WFQPOOLMCWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9031680", Offset = "0x902FC80", VA = "0x189031680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action FPBIZBTLFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9031A70", Offset = "0x9030070", VA = "0x189031A70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x90316A0", Offset = "0x902FCA0", VA = "0x1890316A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0", Slot = "9")]
		public VCIEUBMMHTW IQQOVGPMDFT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x90318B0", Offset = "0x902FEB0", VA = "0x1890318B0", Slot = "6")]
		public EXTMAAWWJAP WHILQULGKKQ(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9031960", Offset = "0x902FF60", VA = "0x189031960", Slot = "7")]
		public EXTMAAWWJAP XGNEFUYRRBI(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9031B10", Offset = "0x9030110", VA = "0x189031B10", Slot = "8")]
		public EXTMAAWWJAP ZJTVPQGPURN(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool OKCJRGNMABQ(float a);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float LJSAFDSXDQM();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9031390", Offset = "0x902F990", VA = "0x189031390", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9031530", Offset = "0x902FB30", VA = "0x189031530")]
		protected void FVYAYNUGGFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9031740", Offset = "0x902FD40", VA = "0x189031740")]
		protected void TJZVXYTFIHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9031C00", Offset = "0x9030200", VA = "0x189031C00")]
		protected BTIWXVPZEBY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ZDFXEBSLAZH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x90372E0", Offset = "0x90358E0", VA = "0x1890372E0")]
		public static ZALDCARQCDD RGHJJANIDVG(this Behaviour a, Vector3 b, float c, SKZTDPXQOXX.Functions d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x90371F0", Offset = "0x90357F0", VA = "0x1890371F0")]
		public static ZALDCARQCDD QTQWXJWNCKN(this Behaviour a, Vector3 b, float c, SKZTDPXQOXX.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class XPETAYTWPPC : BTIWXVPZEBY, ZALDCARQCDD, EXTMAAWWJAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool MBNEFOOFSFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float URCAKTIPEVO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected SKZTDPXQOXX.Functions HQNHZYMBIJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xC4BB90", Offset = "0xC4A190", VA = "0x180C4BB90")]
			[CompilerGenerated]
			get
			{
				return default(SKZTDPXQOXX.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9036E40", Offset = "0x9035440", VA = "0x189036E40")]
		protected XPETAYTWPPC(float a, SKZTDPXQOXX.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC9E300", Offset = "0xC9C900", VA = "0x180C9E300")]
		[CompilerGenerated]
		private void CQAVAFLCJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9032D90", Offset = "0x9031390", VA = "0x189032D90")]
		[CompilerGenerated]
		private void CQGBXMEZSNX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class OWAPUTYFBOP<a> : XPETAYTWPPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> HRNRXTQWKRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> IKJJXCBHDVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a ELEVWPXLNVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float VQYFYNYNMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a NEZBNLPDNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a OHZITKVAYCO;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5BD7F90", Offset = "0x5BD6590", VA = "0x185BD7F90")]
		protected OWAPUTYFBOP(Func<a> a, Action<a> b, a c, float d, SKZTDPXQOXX.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a CGHJVCRUYFQ();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a LXHSZKGVJVZ(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5BD72F0", Offset = "0x5BD58F0", VA = "0x185BD72F0", Slot = "13")]
		public override bool OKCJRGNMABQ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5BD6E90", Offset = "0x5BD5490", VA = "0x185BD6E90", Slot = "14")]
		public override float LJSAFDSXDQM()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class IPWXHNZRUYW : BTIWXVPZEBY, RPJPXXHQVQL, EXTMAAWWJAP
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
			private EXTMAAWWJAP tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<EXTMAAWWJAP> factory;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x90367A0", Offset = "0x9034DA0", VA = "0x1890367A0")]
			public TweenEntry(EXTMAAWWJAP tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1D77210", Offset = "0x1D75810", VA = "0x181D77210")]
			public TweenEntry(Func<EXTMAAWWJAP> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9036680", Offset = "0x9034C80", VA = "0x189036680")]
			public EXTMAAWWJAP AFFVMRTIJEX()
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
		private readonly List<Step> BADLDNPEISX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int TPWIECLNHML;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x90336E0", Offset = "0x9031CE0", VA = "0x1890336E0")]
		public IPWXHNZRUYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x90327C0", Offset = "0x9030DC0", VA = "0x1890327C0", Slot = "15")]
		public RPJPXXHQVQL ACHUQYNLYIO(EXTMAAWWJAP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9032700", Offset = "0x9030D00", VA = "0x189032700", Slot = "16")]
		public RPJPXXHQVQL ACHUQYNLYIO(Func<EXTMAAWWJAP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x90329C0", Offset = "0x9030FC0", VA = "0x1890329C0", Slot = "17")]
		public RPJPXXHQVQL AIBFBJCUGPR(IEnumerable<EXTMAAWWJAP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9032B10", Offset = "0x9031110", VA = "0x189032B10", Slot = "18")]
		public RPJPXXHQVQL AIBFBJCUGPR(params EXTMAAWWJAP[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9032EC0", Offset = "0x90314C0", VA = "0x189032EC0", Slot = "19")]
		public RPJPXXHQVQL MJJLABUPCVY(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9032FD0", Offset = "0x90315D0", VA = "0x189032FD0", Slot = "13")]
		public override bool OKCJRGNMABQ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9032DB0", Offset = "0x90313B0", VA = "0x189032DB0", Slot = "14")]
		public override float LJSAFDSXDQM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x90330E0", Offset = "0x90316E0", VA = "0x1890330E0")]
		private bool PHRJJRWYCMH(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9032C80", Offset = "0x9031280", VA = "0x189032C80")]
		private RPJPXXHQVQL AIBFBJCUGPR(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC9E300", Offset = "0xC9C900", VA = "0x180C9E300")]
		[CompilerGenerated]
		private void CQAVAFLCJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9032D90", Offset = "0x9031390", VA = "0x189032D90")]
		[CompilerGenerated]
		private void CQGBXMEZSNX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class SHGSLWEPVVM : TGHIJKSQVNP
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public BTIWXVPZEBY Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class IKYMTVTNISZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform RVVMCDZALOJ;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public IKYMTVTNISZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9032680", Offset = "0x9030C80", VA = "0x189032680")]
			internal Vector3 UYGJKLCYLGC()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x90326C0", Offset = "0x9030CC0", VA = "0x1890326C0")]
			internal void UYLQHRWVURL(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class SXOZHASCAVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform RVVMCDZALOJ;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SXOZHASCAVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9036590", Offset = "0x9034B90", VA = "0x189036590")]
			internal Quaternion IOTPLZYDXGS()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x90365D0", Offset = "0x9034BD0", VA = "0x1890365D0")]
			internal void IOYWJGSBGSB(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class WJVBAJGMONG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform RVVMCDZALOJ;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public WJVBAJGMONG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9036DC0", Offset = "0x90353C0", VA = "0x189036DC0")]
			internal Vector3 KDYNEARVOVQ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9036E00", Offset = "0x9035400", VA = "0x189036E00")]
			internal void KEDUBHLSYGZ(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class UKANPKCKOFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Transform RVVMCDZALOJ;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UKANPKCKOFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9036BD0", Offset = "0x90351D0", VA = "0x189036BD0")]
			internal Vector3 IPZBWXTKFBH()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9036B90", Offset = "0x9035190", VA = "0x189036B90")]
			internal void IPTUZQZMVPY(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class ZQYIBSVYBOY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public BTIWXVPZEBY GYOORCYZPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public SHGSLWEPVVM CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Behaviour KLMAUBTUXBV;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZQYIBSVYBOY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x90373D0", Offset = "0x90359D0", VA = "0x1890373D0")]
			internal void YNDDUUVWMPB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class ZUMQVGTFOYO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public SHGSLWEPVVM CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public BTIWXVPZEBY ECUKTZIBYUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public RBEAVUYSDOZ IVQZJFWMHJL;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZUMQVGTFOYO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9037610", Offset = "0x9035C10", VA = "0x189037610")]
			internal void BQJEDCMZLND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x90375C0", Offset = "0x9035BC0", VA = "0x1890375C0")]
			internal void BQDXFVTCCBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9037570", Offset = "0x9035B70", VA = "0x189037570")]
			internal void BPYQIOZESQL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class YPFHABBLKYX : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public EXTMAAWWJAP GYOORCYZPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public SHGSLWEPVVM CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public YPFHABBLKYX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x90370E0", Offset = "0x90356E0", VA = "0x1890370E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x90371B0", Offset = "0x90357B0", VA = "0x1890371B0", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class LYIPQVDZYMT : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public SHGSLWEPVVM CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public LYIPQVDZYMT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9033890", Offset = "0x9031E90", VA = "0x189033890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9033BE0", Offset = "0x90321E0", VA = "0x189033BE0", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HYPGBLDUZXO HLSDDDLLWHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly YOSSKFGLYLD UUUDNFLHWSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> SPZPMKLTUGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> LAKGLMJZCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<BTIWXVPZEBY> UMGAEFAEVJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<BTIWXVPZEBY>> JOYQKIJLJBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool WRTFZCYHOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private RBEAVUYSDOZ KEDWRBFWOCF;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x90346E0", Offset = "0x9032CE0", VA = "0x1890346E0")]
		[ZOKCDQOPSGU.Root]
		internal static void LSGYJXLQNAB(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9035980", Offset = "0x9033F80", VA = "0x189035980")]
		[UnityEngine.Scripting.Preserve]
		internal SHGSLWEPVVM([Inject(null)] HYPGBLDUZXO scheduler, [Inject(null)] YOSSKFGLYLD schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9034BE0", Offset = "0x90331E0", VA = "0x189034BE0", Slot = "4")]
		public ZALDCARQCDD QLHKHKXGYPN(Func<float> a, Action<float> b, float c, float d, SKZTDPXQOXX.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9034250", Offset = "0x9032850", VA = "0x189034250", Slot = "5")]
		public ZALDCARQCDD EZXYQZVLUWB(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, SKZTDPXQOXX.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x90345F0", Offset = "0x9032BF0", VA = "0x1890345F0", Slot = "6")]
		public ZALDCARQCDD LNSXHYNOLPU(Func<Color> a, Action<Color> b, Color c, float d, SKZTDPXQOXX.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x90357B0", Offset = "0x9033DB0", VA = "0x1890357B0", Slot = "7")]
		public ZALDCARQCDD UOGBUGWXPDS(Transform a, Vector3 b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9034430", Offset = "0x9032A30", VA = "0x189034430", Slot = "8")]
		public ZALDCARQCDD FWZUDOXXJBW(Transform a, Quaternion b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9034F00", Offset = "0x9033500", VA = "0x189034F00", Slot = "9")]
		public ZALDCARQCDD RGHJJANIDVG(Transform a, Vector3 b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9034CC0", Offset = "0x90332C0", VA = "0x189034CC0", Slot = "10")]
		public ZALDCARQCDD QTQWXJWNCKN(Transform a, Vector3 b, float c, SKZTDPXQOXX.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9035480", Offset = "0x9033A80", VA = "0x189035480", Slot = "11")]
		public RPJPXXHQVQL Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9035610", Offset = "0x9033C10", VA = "0x189035610", Slot = "12")]
		public void UMYZGUJZFGR(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9034A90", Offset = "0x9033090", VA = "0x189034A90", Slot = "13")]
		public void UMYZGUJZFGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x90347D0", Offset = "0x9032DD0", VA = "0x1890347D0")]
		private void MZDFPOVTMMX(Behaviour a, BTIWXVPZEBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9034E90", Offset = "0x9033490", VA = "0x189034E90")]
		[IteratorStateMachine(typeof(LYIPQVDZYMT))]
		private IEnumerator<SGCTHXNJFVM> QWXDKWSRHHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x90350D0", Offset = "0x90336D0", VA = "0x1890350D0")]
		private void Run(Behaviour context, BTIWXVPZEBY sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x90341C0", Offset = "0x90327C0", VA = "0x1890341C0")]
		[IteratorStateMachine(typeof(YPFHABBLKYX))]
		private IEnumerator<SGCTHXNJFVM> BZPUFRRFKLU(EXTMAAWWJAP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9034060", Offset = "0x9032660", VA = "0x189034060")]
		private void ACHUQYNLYIO(BTIWXVPZEBY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9034340", Offset = "0x9032940", VA = "0x189034340")]
		private void FFYDPFJGLFR(BTIWXVPZEBY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9034A90", Offset = "0x9033090", VA = "0x189034A90")]
		private void PQUYDJEMBAS(Scene a, LoadSceneMode b)
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
