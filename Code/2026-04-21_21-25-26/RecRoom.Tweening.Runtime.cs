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
		[Cpp2IlInjected.Address(RVA = "0xA514E80", Offset = "0xA513880", VA = "0x18A514E80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class VYOUUJPNPMY
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
		public static class JYBALTBCFOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2AC41E0", Offset = "0x2AC2BE0", VA = "0x182AC41E0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA510980", Offset = "0xA50F380", VA = "0x18A510980")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA5109A0", Offset = "0xA50F3A0", VA = "0x18A5109A0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class KKQIYEEPUIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA5109F0", Offset = "0xA50F3F0", VA = "0x18A5109F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA510A00", Offset = "0xA50F400", VA = "0x18A510A00")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA510A20", Offset = "0xA50F420", VA = "0x18A510A20")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class QQSSPOVPAGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA513800", Offset = "0xA512200", VA = "0x18A513800")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA513810", Offset = "0xA512210", VA = "0x18A513810")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA513840", Offset = "0xA512240", VA = "0x18A513840")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class BXOKRGFYCIY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA50E1A0", Offset = "0xA50CBA0", VA = "0x18A50E1A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA50E1C0", Offset = "0xA50CBC0", VA = "0x18A50E1C0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA50E1F0", Offset = "0xA50CBF0", VA = "0x18A50E1F0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA5138A0", Offset = "0xA5122A0", VA = "0x18A5138A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA5138D0", Offset = "0xA5122D0", VA = "0x18A5138D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA5138F0", Offset = "0xA5122F0", VA = "0x18A5138F0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA510400", Offset = "0xA50EE00", VA = "0x18A510400")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA510450", Offset = "0xA50EE50", VA = "0x18A510450")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA5104B0", Offset = "0xA50EEB0", VA = "0x18A5104B0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class MECMAATMNMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA511710", Offset = "0xA510110", VA = "0x18A511710")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA511770", Offset = "0xA510170", VA = "0x18A511770")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA5117A0", Offset = "0xA5101A0", VA = "0x18A5117A0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class CHRWIOSFWBS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA50E720", Offset = "0xA50D120", VA = "0x18A50E720")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA50E7D0", Offset = "0xA50D1D0", VA = "0x18A50E7D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA50E890", Offset = "0xA50D290", VA = "0x18A50E890")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float ACZXTAXMEIO;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float EAPWWIKQGLO;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA50E250", Offset = "0xA50CC50", VA = "0x18A50E250")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA50E2D0", Offset = "0xA50CCD0", VA = "0x18A50E2D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA50E360", Offset = "0xA50CD60", VA = "0x18A50E360")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA50E490", Offset = "0xA50CE90", VA = "0x18A50E490")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA50E560", Offset = "0xA50CF60", VA = "0x18A50E560")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA50E600", Offset = "0xA50D000", VA = "0x18A50E600")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA513F30", Offset = "0xA512930", VA = "0x18A513F30")]
		public static float BDXUQDZIJRV(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class OQIWQNCMLYV : EWKJDNNYWFR
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA513410", Offset = "0xA511E10", VA = "0x18A513410")]
		public OQIWQNCMLYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "13")]
		public override bool DCLHECOUQFX(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD60D00", Offset = "0xD5F700", VA = "0x180D60D00", Slot = "14")]
		public override float OWVMSSQIWFD()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class PPTOKLFPQKO : LYWPCAPUFHW<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA513760", Offset = "0xA512160", VA = "0x18A513760")]
		public PPTOKLFPQKO(Func<Color> a, Action<Color> b, Color c, float d, VYOUUJPNPMY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF59110", Offset = "0xF57B10", VA = "0x180F59110", Slot = "15")]
		protected override Color TIXKVHLJNDF()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9973840", Offset = "0x9972240", VA = "0x189973840", Slot = "16")]
		protected override Color GDPFALQFRVG(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class NRZZBNMYRHV : LYWPCAPUFHW<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA512AB0", Offset = "0xA5114B0", VA = "0x18A512AB0")]
		public NRZZBNMYRHV(Func<float> a, Action<float> b, float c, float d, VYOUUJPNPMY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA512A60", Offset = "0xA511460", VA = "0x18A512A60", Slot = "15")]
		protected override float TIXKVHLJNDF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA512A40", Offset = "0xA511440", VA = "0x18A512A40", Slot = "16")]
		protected override float GDPFALQFRVG(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class YRIBYBUMDJV : LYWPCAPUFHW<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA514CE0", Offset = "0xA5136E0", VA = "0x18A514CE0")]
		public YRIBYBUMDJV(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, VYOUUJPNPMY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA514B20", Offset = "0xA513520", VA = "0x18A514B20", Slot = "15")]
		protected override Quaternion TIXKVHLJNDF()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA514AD0", Offset = "0xA5134D0", VA = "0x18A514AD0", Slot = "16")]
		protected override Quaternion GDPFALQFRVG(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class KNEMZXEIEEJ : LYWPCAPUFHW<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA510B10", Offset = "0xA50F510", VA = "0x18A510B10")]
		public KNEMZXEIEEJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, VYOUUJPNPMY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA510A70", Offset = "0xA50F470", VA = "0x18A510A70", Slot = "15")]
		protected override Vector3 TIXKVHLJNDF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA503720", Offset = "0xA502120", VA = "0x18A503720", Slot = "16")]
		protected override Vector3 GDPFALQFRVG(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface CNYJSIHTUUC
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action FHWQORMJUPI;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CNYJSIHTUUC HWVYMKHNYQN(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CNYJSIHTUUC TIEFVKKMROR(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CNYJSIHTUUC QTNOMBHHKLK(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		NFPDGBDVXFD HDFVMRYNJNA();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DCLHECOUQFX(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float OWVMSSQIWFD();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface XALJEQUPEEM : CNYJSIHTUUC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface AOHRZGHGXHU : CNYJSIHTUUC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AOHRZGHGXHU QDDKSHSSOGL(CNYJSIHTUUC a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AOHRZGHGXHU QDDKSHSSOGL(Func<CNYJSIHTUUC> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AOHRZGHGXHU RGCLDHBMKZS(IEnumerable<CNYJSIHTUUC> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		AOHRZGHGXHU RGCLDHBMKZS(params CNYJSIHTUUC[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AOHRZGHGXHU IAYFYLGVVWX(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface NVAHTIXVGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		XALJEQUPEEM JRLQZWYHKHE(Func<float> a, Action<float> b, float c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		XALJEQUPEEM PEQFFPHUPUA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XALJEQUPEEM QVXTHPPDJGP(Func<Color> a, Action<Color> b, Color c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		XALJEQUPEEM JEGPYDIBTRF(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		XALJEQUPEEM LQZIFFIMGCJ(Transform a, Quaternion b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		XALJEQUPEEM NZRSLJFQPWQ(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		AOHRZGHGXHU Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AZLZXBOTCNA(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class KNKXLGHRPGQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CNYJSIHTUUC OQIWQNCMLYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA5113D0", Offset = "0xA50FDD0", VA = "0x18A5113D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA510FE0", Offset = "0xA50F9E0", VA = "0x18A510FE0")]
		internal static NVAHTIXVGIC NKAHUPVSFVI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA510D60", Offset = "0xA50F760", VA = "0x18A510D60")]
		public static XALJEQUPEEM JRLQZWYHKHE(Func<float> a, Action<float> b, float c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA511120", Offset = "0xA50FB20", VA = "0x18A511120")]
		public static XALJEQUPEEM PEQFFPHUPUA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA511280", Offset = "0xA50FC80", VA = "0x18A511280")]
		public static XALJEQUPEEM QVXTHPPDJGP(Func<Color> a, Action<Color> b, Color c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA510C90", Offset = "0xA50F690", VA = "0x18A510C90")]
		public static XALJEQUPEEM JEGPYDIBTRF(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA510EA0", Offset = "0xA50F8A0", VA = "0x18A510EA0")]
		public static XALJEQUPEEM LQZIFFIMGCJ(Transform a, Quaternion b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA511050", Offset = "0xA50FA50", VA = "0x18A511050")]
		public static XALJEQUPEEM NZRSLJFQPWQ(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA511420", Offset = "0xA50FE20", VA = "0x18A511420")]
		public static AOHRZGHGXHU Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA510BB0", Offset = "0xA50F5B0", VA = "0x18A510BB0")]
		public static void AZLZXBOTCNA(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class OBXJOCCEBBH : CNYJSIHTUUC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action ZRYVFEBNGNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action PXBCNRKHXJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> XVYTRQHXPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> DRAPKLMMNLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> HOKWTTJQPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected VBYBPANEUOU WSVTGTOMDSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object YKILMMNATTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool LXDZAUFQJXJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool QSEIBKIDXXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA513310", Offset = "0xA511D10", VA = "0x18A513310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool FZGAKVDAFDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA512EB0", Offset = "0xA5118B0", VA = "0x18A512EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action FHWQORMJUPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA512ED0", Offset = "0xA5118D0", VA = "0x18A512ED0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA512F70", Offset = "0xA511970", VA = "0x18A512F70", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30", Slot = "9")]
		public NFPDGBDVXFD HDFVMRYNJNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA512DF0", Offset = "0xA5117F0", VA = "0x18A512DF0", Slot = "6")]
		public CNYJSIHTUUC HWVYMKHNYQN(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA513210", Offset = "0xA511C10", VA = "0x18A513210", Slot = "7")]
		public CNYJSIHTUUC TIEFVKKMROR(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA513010", Offset = "0xA511A10", VA = "0x18A513010", Slot = "8")]
		public CNYJSIHTUUC QTNOMBHHKLK(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool DCLHECOUQFX(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float OWVMSSQIWFD();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA512C50", Offset = "0xA511650", VA = "0x18A512C50", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA512B20", Offset = "0xA511520", VA = "0x18A512B20")]
		protected void CNPIBPIIBQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA5130A0", Offset = "0xA511AA0", VA = "0x18A5130A0")]
		protected void RFOMKLOCIHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA513330", Offset = "0xA511D30", VA = "0x18A513330")]
		protected OBXJOCCEBBH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class VPMPYLIAZIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA513E40", Offset = "0xA512840", VA = "0x18A513E40")]
		public static XALJEQUPEEM NZRSLJFQPWQ(this Behaviour a, Vector3 b, float c, VYOUUJPNPMY.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class EWKJDNNYWFR : OBXJOCCEBBH, XALJEQUPEEM, CNYJSIHTUUC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool TGNRBXNFSQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float ZJCHXRUTINP;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected VYOUUJPNPMY.Functions KLRRFVCATZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x103DE40", Offset = "0x103C840", VA = "0x18103DE40")]
			[CompilerGenerated]
			get
			{
				return default(VYOUUJPNPMY.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA510240", Offset = "0xA50EC40", VA = "0x18A510240")]
		protected EWKJDNNYWFR(float a, VYOUUJPNPMY.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x299B7C0", Offset = "0x299A1C0", VA = "0x18299B7C0")]
		[CompilerGenerated]
		private void ITFPMKMAIHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA510220", Offset = "0xA50EC20", VA = "0x18A510220")]
		[CompilerGenerated]
		private void ITAIPDSCYWO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class LYWPCAPUFHW<a> : EWKJDNNYWFR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> ZPQLNCMOOHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> LDENGZPOFYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a OSYHVZEQAIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float TXXKENRNIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a ETOTKOYRODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a YOZHUZMVTAL;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69ABDE0", Offset = "0x69AA7E0", VA = "0x1869ABDE0")]
		protected LYWPCAPUFHW(Func<a> a, Action<a> b, a c, float d, VYOUUJPNPMY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a TIXKVHLJNDF();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a GDPFALQFRVG(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69AB060", Offset = "0x69A9A60", VA = "0x1869AB060", Slot = "13")]
		public override bool DCLHECOUQFX(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69ABAC0", Offset = "0x69AA4C0", VA = "0x1869ABAC0", Slot = "14")]
		public override float OWVMSSQIWFD()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class MEODOAUWGUN : OBXJOCCEBBH, AOHRZGHGXHU, CNYJSIHTUUC
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
			private CNYJSIHTUUC tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<CNYJSIHTUUC> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA513A40", Offset = "0xA512440", VA = "0x18A513A40")]
			public TweenEntry(CNYJSIHTUUC tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1DA8620", Offset = "0x1DA7020", VA = "0x181DA8620")]
			public TweenEntry(Func<CNYJSIHTUUC> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA513920", Offset = "0xA512320", VA = "0x18A513920")]
			public CNYJSIHTUUC QNZYQKIZQUW()
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
		private readonly List<Step> CGEKRUUPGOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int RGZIEVYMNPK;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA512860", Offset = "0xA511260", VA = "0x18A512860")]
		public MEODOAUWGUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA511B90", Offset = "0xA510590", VA = "0x18A511B90", Slot = "15")]
		public AOHRZGHGXHU QDDKSHSSOGL(CNYJSIHTUUC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA511DA0", Offset = "0xA5107A0", VA = "0x18A511DA0", Slot = "16")]
		public AOHRZGHGXHU QDDKSHSSOGL(Func<CNYJSIHTUUC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA511E60", Offset = "0xA510860", VA = "0x18A511E60", Slot = "17")]
		public AOHRZGHGXHU RGCLDHBMKZS(IEnumerable<CNYJSIHTUUC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA5120D0", Offset = "0xA510AD0", VA = "0x18A5120D0", Slot = "18")]
		public AOHRZGHGXHU RGCLDHBMKZS(params CNYJSIHTUUC[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA511960", Offset = "0xA510360", VA = "0x18A511960", Slot = "19")]
		public AOHRZGHGXHU IAYFYLGVVWX(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA511850", Offset = "0xA510250", VA = "0x18A511850", Slot = "13")]
		public override bool DCLHECOUQFX(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA511A70", Offset = "0xA510470", VA = "0x18A511A70", Slot = "14")]
		public override float OWVMSSQIWFD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA512250", Offset = "0xA510C50", VA = "0x18A512250")]
		private bool ZKCFHNXITXC(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA511FB0", Offset = "0xA5109B0", VA = "0x18A511FB0")]
		private AOHRZGHGXHU RGCLDHBMKZS(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x299B7C0", Offset = "0x299A1C0", VA = "0x18299B7C0")]
		[CompilerGenerated]
		private void ITFPMKMAIHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA510220", Offset = "0xA50EC20", VA = "0x18A510220")]
		[CompilerGenerated]
		private void ITAIPDSCYWO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class DXRMLQKPTRV : NVAHTIXVGIC
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public OBXJOCCEBBH Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class GHUATSDHYIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform YEYBBUJXMEM;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GHUATSDHYIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA510940", Offset = "0xA50F340", VA = "0x18A510940")]
			internal Vector3 ZRVULEXWRZX()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA510900", Offset = "0xA50F300", VA = "0x18A510900")]
			internal void ZRQNNYDZIOO(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class XCEEGWYISVS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform YEYBBUJXMEM;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public XCEEGWYISVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA514A10", Offset = "0xA513410", VA = "0x18A514A10")]
			internal Quaternion JUIQNWQXSHB()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA5149E0", Offset = "0xA5133E0", VA = "0x18A5149E0")]
			internal void JUDJQPXAIVS(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class YHSFOQXQLDY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform YEYBBUJXMEM;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public YHSFOQXQLDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA514A50", Offset = "0xA513450", VA = "0x18A514A50")]
			internal Vector3 ZGQOYSJWOKQ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA514A90", Offset = "0xA513490", VA = "0x18A514A90")]
			internal void ZGVVVZDTXVZ(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class ZVHFLELJGRV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public OBXJOCCEBBH EZBNKHFKILC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public DXRMLQKPTRV XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour ACLJKNVEUJW;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public ZVHFLELJGRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA514D80", Offset = "0xA513780", VA = "0x18A514D80")]
			internal void SWMOJSCOEPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class PIAOBGEZDVH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public DXRMLQKPTRV XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public OBXJOCCEBBH VTOSIFMQFMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public VOFDHKTSCRY HPPUAAUZLNQ;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PIAOBGEZDVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA513600", Offset = "0xA512000", VA = "0x18A513600")]
			internal void TQKLXGUOHIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA513710", Offset = "0xA512110", VA = "0x18A513710")]
			internal void TQPSUNOLQTP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA5135B0", Offset = "0xA511FB0", VA = "0x18A5135B0")]
			internal void TPZYCTGTOLO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class DZEOILHDFHO : IEnumerator<IUPNMORLIQV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private IUPNMORLIQV OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public CNYJSIHTUUC EZBNKHFKILC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public DXRMLQKPTRV XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private IUPNMORLIQV BIZXNLKFYPO
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public DZEOILHDFHO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA510110", Offset = "0xA50EB10", VA = "0x18A510110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA5101E0", Offset = "0xA50EBE0", VA = "0x18A5101E0", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class FTKNQLRKHLU : IEnumerator<IUPNMORLIQV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private IUPNMORLIQV OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public DXRMLQKPTRV XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private IUPNMORLIQV BIZXNLKFYPO
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public FTKNQLRKHLU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA510570", Offset = "0xA50EF70", VA = "0x18A510570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA5108C0", Offset = "0xA50F2C0", VA = "0x18A5108C0", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly CQCXTJLOHGF AUGRZUFPKEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly KZZDIMMZPLI YRTQVCOYRED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> EJCFZGELNVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> LYEXCTWUFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<OBXJOCCEBBH> TLFUCJQOFMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<OBXJOCCEBBH>> PORCDVLSYVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool NSTODTFPEQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private VOFDHKTSCRY SOKQEBIRQIA;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA50FDC0", Offset = "0xA50E7C0", VA = "0x18A50FDC0")]
		[CXDXQIFYXBD.Root]
		internal static void WESKAKIVYCE(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA50FFA0", Offset = "0xA50E9A0", VA = "0x18A50FFA0")]
		[UnityEngine.Scripting.Preserve]
		internal DXRMLQKPTRV([Inject(null)] CQCXTJLOHGF scheduler, [Inject(null)] KZZDIMMZPLI schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA50EEB0", Offset = "0xA50D8B0", VA = "0x18A50EEB0", Slot = "4")]
		public XALJEQUPEEM JRLQZWYHKHE(Func<float> a, Action<float> b, float c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA50F5F0", Offset = "0xA50DFF0", VA = "0x18A50F5F0", Slot = "5")]
		public XALJEQUPEEM PEQFFPHUPUA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA50F840", Offset = "0xA50E240", VA = "0x18A50F840", Slot = "6")]
		public XALJEQUPEEM QVXTHPPDJGP(Func<Color> a, Action<Color> b, Color c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA50ECE0", Offset = "0xA50D6E0", VA = "0x18A50ECE0", Slot = "7")]
		public XALJEQUPEEM JEGPYDIBTRF(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA50EF90", Offset = "0xA50D990", VA = "0x18A50EF90", Slot = "8")]
		public XALJEQUPEEM LQZIFFIMGCJ(Transform a, Quaternion b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA50F150", Offset = "0xA50DB50", VA = "0x18A50F150", Slot = "9")]
		public XALJEQUPEEM NZRSLJFQPWQ(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA50FCE0", Offset = "0xA50E6E0", VA = "0x18A50FCE0", Slot = "10")]
		public AOHRZGHGXHU Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA50EB40", Offset = "0xA50D540", VA = "0x18A50EB40", Slot = "11")]
		public void AZLZXBOTCNA(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA50E9F0", Offset = "0xA50D3F0", VA = "0x18A50E9F0", Slot = "12")]
		public void AZLZXBOTCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA50F320", Offset = "0xA50DD20", VA = "0x18A50F320")]
		private void OMJHSWRVUUE(Behaviour a, OBXJOCCEBBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA50FD50", Offset = "0xA50E750", VA = "0x18A50FD50")]
		[IteratorStateMachine(typeof(FTKNQLRKHLU))]
		private IEnumerator<IUPNMORLIQV> WCFBJKRVHPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA50F930", Offset = "0xA50E330", VA = "0x18A50F930")]
		private void Run(Behaviour context, OBXJOCCEBBH sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA50E960", Offset = "0xA50D360", VA = "0x18A50E960")]
		[IteratorStateMachine(typeof(DZEOILHDFHO))]
		private IEnumerator<IUPNMORLIQV> ABNERDIBSSX(CNYJSIHTUUC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA50F6E0", Offset = "0xA50E0E0", VA = "0x18A50F6E0")]
		private void QDDKSHSSOGL(OBXJOCCEBBH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA50FEB0", Offset = "0xA50E8B0", VA = "0x18A50FEB0")]
		private void ZHIUQJCMVME(OBXJOCCEBBH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA50E9F0", Offset = "0xA50D3F0", VA = "0x18A50E9F0")]
		private void FGFGRBYMVRT(Scene a, LoadSceneMode b)
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
