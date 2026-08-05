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
		[Cpp2IlInjected.Address(RVA = "0xA391CF0", Offset = "0xA390AF0", VA = "0x18A391CF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29EF0F0", Offset = "0x29EDEF0", VA = "0x1829EF0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A864D0", Offset = "0x2A852D0", VA = "0x182A864D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA38D9B0", Offset = "0xA38C7B0", VA = "0x18A38D9B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA38D9D0", Offset = "0xA38C7D0", VA = "0x18A38D9D0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class KKQIYEEPUIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA38DA20", Offset = "0xA38C820", VA = "0x18A38DA20")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA38DA30", Offset = "0xA38C830", VA = "0x18A38DA30")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA38DA50", Offset = "0xA38C850", VA = "0x18A38DA50")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class QQSSPOVPAGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA390670", Offset = "0xA38F470", VA = "0x18A390670")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA390680", Offset = "0xA38F480", VA = "0x18A390680")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA3906B0", Offset = "0xA38F4B0", VA = "0x18A3906B0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class BXOKRGFYCIY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA38B170", Offset = "0xA389F70", VA = "0x18A38B170")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA38B190", Offset = "0xA389F90", VA = "0x18A38B190")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA38B1C0", Offset = "0xA389FC0", VA = "0x18A38B1C0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA390710", Offset = "0xA38F510", VA = "0x18A390710")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA390740", Offset = "0xA38F540", VA = "0x18A390740")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA390760", Offset = "0xA38F560", VA = "0x18A390760")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA38D430", Offset = "0xA38C230", VA = "0x18A38D430")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA38D480", Offset = "0xA38C280", VA = "0x18A38D480")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA38D4E0", Offset = "0xA38C2E0", VA = "0x18A38D4E0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class MECMAATMNMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA38E670", Offset = "0xA38D470", VA = "0x18A38E670")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA38E6D0", Offset = "0xA38D4D0", VA = "0x18A38E6D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA38E700", Offset = "0xA38D500", VA = "0x18A38E700")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class CHRWIOSFWBS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA38B6F0", Offset = "0xA38A4F0", VA = "0x18A38B6F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA38B7A0", Offset = "0xA38A5A0", VA = "0x18A38B7A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA38B860", Offset = "0xA38A660", VA = "0x18A38B860")]
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
			[Cpp2IlInjected.Address(RVA = "0xA38B220", Offset = "0xA38A020", VA = "0x18A38B220")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA38B2A0", Offset = "0xA38A0A0", VA = "0x18A38B2A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA38B330", Offset = "0xA38A130", VA = "0x18A38B330")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA38B460", Offset = "0xA38A260", VA = "0x18A38B460")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA38B530", Offset = "0xA38A330", VA = "0x18A38B530")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA38B5D0", Offset = "0xA38A3D0", VA = "0x18A38B5D0")]
			public static float TPSXKNCOPXM(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA390DA0", Offset = "0xA38FBA0", VA = "0x18A390DA0")]
		public static float BDXUQDZIJRV(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class OQIWQNCMLYV : EWKJDNNYWFR
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA390310", Offset = "0xA38F110", VA = "0x18A390310")]
		public OQIWQNCMLYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "13")]
		public override bool DCLHECOUQFX(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD36B20", Offset = "0xD35920", VA = "0x180D36B20", Slot = "14")]
		public override float OWVMSSQIWFD()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class PPTOKLFPQKO : LYWPCAPUFHW<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA3905D0", Offset = "0xA38F3D0", VA = "0x18A3905D0")]
		public PPTOKLFPQKO(Func<Color> a, Action<Color> b, Color c, float d, VYOUUJPNPMY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF19340", Offset = "0xF18140", VA = "0x180F19340", Slot = "15")]
		protected override Color TIXKVHLJNDF()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x97F22A0", Offset = "0x97F10A0", VA = "0x1897F22A0", Slot = "16")]
		protected override Color GDPFALQFRVG(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class NRZZBNMYRHV : LYWPCAPUFHW<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA38F950", Offset = "0xA38E750", VA = "0x18A38F950")]
		public NRZZBNMYRHV(Func<float> a, Action<float> b, float c, float d, VYOUUJPNPMY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA38F900", Offset = "0xA38E700", VA = "0x18A38F900", Slot = "15")]
		protected override float TIXKVHLJNDF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA38F8E0", Offset = "0xA38E6E0", VA = "0x18A38F8E0", Slot = "16")]
		protected override float GDPFALQFRVG(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class YRIBYBUMDJV : LYWPCAPUFHW<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA391B50", Offset = "0xA390950", VA = "0x18A391B50")]
		public YRIBYBUMDJV(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, VYOUUJPNPMY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA391990", Offset = "0xA390790", VA = "0x18A391990", Slot = "15")]
		protected override Quaternion TIXKVHLJNDF()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA391940", Offset = "0xA390740", VA = "0x18A391940", Slot = "16")]
		protected override Quaternion GDPFALQFRVG(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class KNEMZXEIEEJ : LYWPCAPUFHW<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA38DB40", Offset = "0xA38C940", VA = "0x18A38DB40")]
		public KNEMZXEIEEJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, VYOUUJPNPMY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA38DAA0", Offset = "0xA38C8A0", VA = "0x18A38DAA0", Slot = "15")]
		protected override Vector3 TIXKVHLJNDF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA380730", Offset = "0xA37F530", VA = "0x18A380730", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xA38E3D0", Offset = "0xA38D1D0", VA = "0x18A38E3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA38DFF0", Offset = "0xA38CDF0", VA = "0x18A38DFF0")]
		internal static NVAHTIXVGIC NKAHUPVSFVI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA38DD90", Offset = "0xA38CB90", VA = "0x18A38DD90")]
		public static XALJEQUPEEM JRLQZWYHKHE(Func<float> a, Action<float> b, float c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA38E130", Offset = "0xA38CF30", VA = "0x18A38E130")]
		public static XALJEQUPEEM PEQFFPHUPUA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA38E290", Offset = "0xA38D090", VA = "0x18A38E290")]
		public static XALJEQUPEEM QVXTHPPDJGP(Func<Color> a, Action<Color> b, Color c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA38DCC0", Offset = "0xA38CAC0", VA = "0x18A38DCC0")]
		public static XALJEQUPEEM JEGPYDIBTRF(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA38DEC0", Offset = "0xA38CCC0", VA = "0x18A38DEC0")]
		public static XALJEQUPEEM LQZIFFIMGCJ(Transform a, Quaternion b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA38E060", Offset = "0xA38CE60", VA = "0x18A38E060")]
		public static XALJEQUPEEM NZRSLJFQPWQ(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA38E420", Offset = "0xA38D220", VA = "0x18A38E420")]
		public static AOHRZGHGXHU Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA38DBE0", Offset = "0xA38C9E0", VA = "0x18A38DBE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA390210", Offset = "0xA38F010", VA = "0x18A390210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool FZGAKVDAFDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA38FD40", Offset = "0xA38EB40", VA = "0x18A38FD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action FHWQORMJUPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA38FD60", Offset = "0xA38EB60", VA = "0x18A38FD60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA38FE00", Offset = "0xA38EC00", VA = "0x18A38FE00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30", Slot = "9")]
		public NFPDGBDVXFD HDFVMRYNJNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA38FC90", Offset = "0xA38EA90", VA = "0x18A38FC90", Slot = "6")]
		public CNYJSIHTUUC HWVYMKHNYQN(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA390100", Offset = "0xA38EF00", VA = "0x18A390100", Slot = "7")]
		public CNYJSIHTUUC TIEFVKKMROR(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA38FEA0", Offset = "0xA38ECA0", VA = "0x18A38FEA0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA38FAF0", Offset = "0xA38E8F0", VA = "0x18A38FAF0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA38F9C0", Offset = "0xA38E7C0", VA = "0x18A38F9C0")]
		protected void CNPIBPIIBQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA38FF90", Offset = "0xA38ED90", VA = "0x18A38FF90")]
		protected void RFOMKLOCIHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA390230", Offset = "0xA38F030", VA = "0x18A390230")]
		protected OBXJOCCEBBH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class VPMPYLIAZIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA390CB0", Offset = "0xA38FAB0", VA = "0x18A390CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x10136E0", Offset = "0x10124E0", VA = "0x1810136E0")]
			[CompilerGenerated]
			get
			{
				return default(VYOUUJPNPMY.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA38D320", Offset = "0xA38C120", VA = "0x18A38D320")]
		protected EWKJDNNYWFR(float a, VYOUUJPNPMY.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x295D2C0", Offset = "0x295C0C0", VA = "0x18295D2C0")]
		[CompilerGenerated]
		private void ITFPMKMAIHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA38D300", Offset = "0xA38C100", VA = "0x18A38D300")]
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
		[Cpp2IlInjected.Address(RVA = "0x68CA6F0", Offset = "0x68C94F0", VA = "0x1868CA6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68C99E0", Offset = "0x68C87E0", VA = "0x1868C99E0", Slot = "13")]
		public override bool DCLHECOUQFX(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68CA3D0", Offset = "0x68C91D0", VA = "0x1868CA3D0", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3908B0", Offset = "0xA38F6B0", VA = "0x18A3908B0")]
			public TweenEntry(CNYJSIHTUUC tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D70340", Offset = "0x1D6F140", VA = "0x181D70340")]
			public TweenEntry(Func<CNYJSIHTUUC> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA390790", Offset = "0xA38F590", VA = "0x18A390790")]
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
		[Cpp2IlInjected.Address(RVA = "0xA38F7A0", Offset = "0xA38E5A0", VA = "0x18A38F7A0")]
		public MEODOAUWGUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA38EAF0", Offset = "0xA38D8F0", VA = "0x18A38EAF0", Slot = "15")]
		public AOHRZGHGXHU QDDKSHSSOGL(CNYJSIHTUUC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA38ED00", Offset = "0xA38DB00", VA = "0x18A38ED00", Slot = "16")]
		public AOHRZGHGXHU QDDKSHSSOGL(Func<CNYJSIHTUUC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA38EDC0", Offset = "0xA38DBC0", VA = "0x18A38EDC0", Slot = "17")]
		public AOHRZGHGXHU RGCLDHBMKZS(IEnumerable<CNYJSIHTUUC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA38F020", Offset = "0xA38DE20", VA = "0x18A38F020", Slot = "18")]
		public AOHRZGHGXHU RGCLDHBMKZS(params CNYJSIHTUUC[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA38E8C0", Offset = "0xA38D6C0", VA = "0x18A38E8C0", Slot = "19")]
		public AOHRZGHGXHU IAYFYLGVVWX(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA38E7B0", Offset = "0xA38D5B0", VA = "0x18A38E7B0", Slot = "13")]
		public override bool DCLHECOUQFX(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA38E9D0", Offset = "0xA38D7D0", VA = "0x18A38E9D0", Slot = "14")]
		public override float OWVMSSQIWFD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA38F1A0", Offset = "0xA38DFA0", VA = "0x18A38F1A0")]
		private bool ZKCFHNXITXC(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA38EF10", Offset = "0xA38DD10", VA = "0x18A38EF10")]
		private AOHRZGHGXHU RGCLDHBMKZS(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x295D2C0", Offset = "0x295C0C0", VA = "0x18295D2C0")]
		[CompilerGenerated]
		private void ITFPMKMAIHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA38D300", Offset = "0xA38C100", VA = "0x18A38D300")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GHUATSDHYIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA38D970", Offset = "0xA38C770", VA = "0x18A38D970")]
			internal Vector3 ZRVULEXWRZX()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA38D930", Offset = "0xA38C730", VA = "0x18A38D930")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public XCEEGWYISVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA391880", Offset = "0xA390680", VA = "0x18A391880")]
			internal Quaternion JUIQNWQXSHB()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA391850", Offset = "0xA390650", VA = "0x18A391850")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public YHSFOQXQLDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA3918C0", Offset = "0xA3906C0", VA = "0x18A3918C0")]
			internal Vector3 ZGQOYSJWOKQ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA391900", Offset = "0xA390700", VA = "0x18A391900")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZVHFLELJGRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA391BF0", Offset = "0xA3909F0", VA = "0x18A391BF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PIAOBGEZDVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA390470", Offset = "0xA38F270", VA = "0x18A390470")]
			internal void TQKLXGUOHIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA390580", Offset = "0xA38F380", VA = "0x18A390580")]
			internal void TQPSUNOLQTP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA390420", Offset = "0xA38F220", VA = "0x18A390420")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public DZEOILHDFHO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA38D1F0", Offset = "0xA38BFF0", VA = "0x18A38D1F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA38D2C0", Offset = "0xA38C0C0", VA = "0x18A38D2C0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public FTKNQLRKHLU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA38D5A0", Offset = "0xA38C3A0", VA = "0x18A38D5A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA38D8F0", Offset = "0xA38C6F0", VA = "0x18A38D8F0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA38CEA0", Offset = "0xA38BCA0", VA = "0x18A38CEA0")]
		[CXDXQIFYXBD.Root]
		internal static void WESKAKIVYCE(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA38D080", Offset = "0xA38BE80", VA = "0x18A38D080")]
		[UnityEngine.Scripting.Preserve]
		internal DXRMLQKPTRV([Inject(null)] CQCXTJLOHGF scheduler, [Inject(null)] KZZDIMMZPLI schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA38BE80", Offset = "0xA38AC80", VA = "0x18A38BE80", Slot = "4")]
		public XALJEQUPEEM JRLQZWYHKHE(Func<float> a, Action<float> b, float c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA38C5B0", Offset = "0xA38B3B0", VA = "0x18A38C5B0", Slot = "5")]
		public XALJEQUPEEM PEQFFPHUPUA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA38C800", Offset = "0xA38B600", VA = "0x18A38C800", Slot = "6")]
		public XALJEQUPEEM QVXTHPPDJGP(Func<Color> a, Action<Color> b, Color c, float d, VYOUUJPNPMY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA38BCB0", Offset = "0xA38AAB0", VA = "0x18A38BCB0", Slot = "7")]
		public XALJEQUPEEM JEGPYDIBTRF(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA38BF60", Offset = "0xA38AD60", VA = "0x18A38BF60", Slot = "8")]
		public XALJEQUPEEM LQZIFFIMGCJ(Transform a, Quaternion b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA38C120", Offset = "0xA38AF20", VA = "0x18A38C120", Slot = "9")]
		public XALJEQUPEEM NZRSLJFQPWQ(Transform a, Vector3 b, float c, VYOUUJPNPMY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA38CCA0", Offset = "0xA38BAA0", VA = "0x18A38CCA0", Slot = "10")]
		public AOHRZGHGXHU Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA38BB10", Offset = "0xA38A910", VA = "0x18A38BB10", Slot = "11")]
		public void AZLZXBOTCNA(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA38B9C0", Offset = "0xA38A7C0", VA = "0x18A38B9C0", Slot = "12")]
		public void AZLZXBOTCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA38C2F0", Offset = "0xA38B0F0", VA = "0x18A38C2F0")]
		private void OMJHSWRVUUE(Behaviour a, OBXJOCCEBBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA38CE30", Offset = "0xA38BC30", VA = "0x18A38CE30")]
		[IteratorStateMachine(typeof(FTKNQLRKHLU))]
		private IEnumerator<IUPNMORLIQV> WCFBJKRVHPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA38C8F0", Offset = "0xA38B6F0", VA = "0x18A38C8F0")]
		private void Run(Behaviour context, OBXJOCCEBBH sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA38B930", Offset = "0xA38A730", VA = "0x18A38B930")]
		[IteratorStateMachine(typeof(DZEOILHDFHO))]
		private IEnumerator<IUPNMORLIQV> ABNERDIBSSX(CNYJSIHTUUC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA38C6A0", Offset = "0xA38B4A0", VA = "0x18A38C6A0")]
		private void QDDKSHSSOGL(OBXJOCCEBBH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA38CF90", Offset = "0xA38BD90", VA = "0x18A38CF90")]
		private void ZHIUQJCMVME(OBXJOCCEBBH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA38B9C0", Offset = "0xA38A7C0", VA = "0x18A38B9C0")]
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
