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
		[Cpp2IlInjected.Address(RVA = "0x8FBA3C0", Offset = "0x8FB91C0", VA = "0x188FBA3C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2993B20", Offset = "0x2992920", VA = "0x182993B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class JIMPIYVNKHQ
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
		public static class DVMWRUBURRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2A2AC50", Offset = "0x2A29A50", VA = "0x182A2AC50")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3CF0", Offset = "0x8FB2AF0", VA = "0x188FB3CF0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3CA0", Offset = "0x8FB2AA0", VA = "0x188FB3CA0")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class WPIOAITVEZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9F00", Offset = "0x8FB8D00", VA = "0x188FB9F00")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9F10", Offset = "0x8FB8D10", VA = "0x188FB9F10")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9EB0", Offset = "0x8FB8CB0", VA = "0x188FB9EB0")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class QCJOJQVELCW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8FB7D10", Offset = "0x8FB6B10", VA = "0x188FB7D10")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8FB7D20", Offset = "0x8FB6B20", VA = "0x188FB7D20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8FB7CB0", Offset = "0x8FB6AB0", VA = "0x188FB7CB0")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class PASLOOZCBIG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8FB7BE0", Offset = "0x8FB69E0", VA = "0x188FB7BE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8FB7C00", Offset = "0x8FB6A00", VA = "0x188FB7C00")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8FB7B80", Offset = "0x8FB6980", VA = "0x188FB7B80")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8B40", Offset = "0x8FB7940", VA = "0x188FB8B40")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8B70", Offset = "0x8FB7970", VA = "0x188FB8B70")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8B10", Offset = "0x8FB7910", VA = "0x188FB8B10")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3DD0", Offset = "0x8FB2BD0", VA = "0x188FB3DD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3E20", Offset = "0x8FB2C20", VA = "0x188FB3E20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3D10", Offset = "0x8FB2B10", VA = "0x188FB3D10")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class MZXFKRXLPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8FB65F0", Offset = "0x8FB53F0", VA = "0x188FB65F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8FB6650", Offset = "0x8FB5450", VA = "0x188FB6650")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8FB6540", Offset = "0x8FB5340", VA = "0x188FB6540")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class YJTSVYVDBYK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8FBA250", Offset = "0x8FB9050", VA = "0x188FBA250")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8FBA300", Offset = "0x8FB9100", VA = "0x188FBA300")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8FBA180", Offset = "0x8FB8F80", VA = "0x188FBA180")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float WZDGXQLFTPK;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float XIWAIFARXJE;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3620", Offset = "0x8FB2420", VA = "0x188FB3620")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8FB36A0", Offset = "0x8FB24A0", VA = "0x188FB36A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3540", Offset = "0x8FB2340", VA = "0x188FB3540")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8FB38A0", Offset = "0x8FB26A0", VA = "0x188FB38A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3970", Offset = "0x8FB2770", VA = "0x188FB3970")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3780", Offset = "0x8FB2580", VA = "0x188FB3780")]
			public static float FLLTGNJOHRC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8FB5910", Offset = "0x8FB4710", VA = "0x188FB5910")]
		public static float WRAEBTMBBWF(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class SYHMUAGPCDJ : USOZNEQVBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8A00", Offset = "0x8FB7800", VA = "0x188FB8A00")]
		public SYHMUAGPCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "13")]
		public override bool AVADAVMGFWP(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAECCC0", Offset = "0xAEBAC0", VA = "0x180AECCC0", Slot = "14")]
		public override float TEHPTZROGJR()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class WXZPSRBVLMM : TDGUWMWPOGO<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9F30", Offset = "0x8FB8D30", VA = "0x188FB9F30")]
		public WXZPSRBVLMM(Func<Color> a, Action<Color> b, Color c, float d, JIMPIYVNKHQ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF9C9B0", Offset = "0xF9B7B0", VA = "0x180F9C9B0", Slot = "15")]
		protected override Color OXMALHEHSIF()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84412F0", Offset = "0x84400F0", VA = "0x1884412F0", Slot = "16")]
		protected override Color FZEKURUHQCW(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class DPGNUPBHLBH : TDGUWMWPOGO<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3C30", Offset = "0x8FB2A30", VA = "0x188FB3C30")]
		public DPGNUPBHLBH(Func<float> a, Action<float> b, float c, float d, JIMPIYVNKHQ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3BE0", Offset = "0x8FB29E0", VA = "0x188FB3BE0", Slot = "15")]
		protected override float OXMALHEHSIF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3BC0", Offset = "0x8FB29C0", VA = "0x188FB3BC0", Slot = "16")]
		protected override float FZEKURUHQCW(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class TBVOFEMSSVD : TDGUWMWPOGO<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8DA0", Offset = "0x8FB7BA0", VA = "0x188FB8DA0")]
		public TBVOFEMSSVD(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, JIMPIYVNKHQ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8BE0", Offset = "0x8FB79E0", VA = "0x188FB8BE0", Slot = "15")]
		protected override Quaternion OXMALHEHSIF()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8B90", Offset = "0x8FB7990", VA = "0x188FB8B90", Slot = "16")]
		protected override Quaternion FZEKURUHQCW(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class XRLZZPWPYMD : TDGUWMWPOGO<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA0E0", Offset = "0x8FB8EE0", VA = "0x188FBA0E0")]
		public XRLZZPWPYMD(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, JIMPIYVNKHQ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA040", Offset = "0x8FB8E40", VA = "0x188FBA040", Slot = "15")]
		protected override Vector3 OXMALHEHSIF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9FD0", Offset = "0x8FB8DD0", VA = "0x188FB9FD0", Slot = "16")]
		protected override Vector3 FZEKURUHQCW(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface YIRRNSOTUCE
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action ENBBBBSYCNO;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		YIRRNSOTUCE KHPTSCCMQMH(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		YIRRNSOTUCE FQZQUNBACJV(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		YIRRNSOTUCE CXEOOCNLUHM(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DQILUIFDCOX PLOGAXDRXGY();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool AVADAVMGFWP(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float TEHPTZROGJR();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface CUHMSFVHHTY : YIRRNSOTUCE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface LMNJWECWJAM : YIRRNSOTUCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LMNJWECWJAM PJTJEVBRFMB(YIRRNSOTUCE a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LMNJWECWJAM PJTJEVBRFMB(Func<YIRRNSOTUCE> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LMNJWECWJAM FBEVAAJUIYC(IEnumerable<YIRRNSOTUCE> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		LMNJWECWJAM FBEVAAJUIYC(params YIRRNSOTUCE[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		LMNJWECWJAM KVJJDLABFIB(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface TRYMWPTRNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CUHMSFVHHTY FKSNWFNUXJC(Func<float> a, Action<float> b, float c, float d, JIMPIYVNKHQ.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CUHMSFVHHTY BJZYLHCEIIG(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, JIMPIYVNKHQ.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CUHMSFVHHTY DCKWNENLESR(Func<Color> a, Action<Color> b, Color c, float d, JIMPIYVNKHQ.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CUHMSFVHHTY BXNULVYWTYJ(Transform a, Vector3 b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CUHMSFVHHTY HZPZYVGBWAD(Transform a, Quaternion b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CUHMSFVHHTY CNGJOPLBOAF(Transform a, Vector3 b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CUHMSFVHHTY DQWRBYOFAYO(Transform a, Vector3 b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		LMNJWECWJAM Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ILQNYOFQYCM(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class RWPUTBPWHLQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static YIRRNSOTUCE SYHMUAGPCDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8090", Offset = "0x8FB6E90", VA = "0x188FB8090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB81B0", Offset = "0x8FB6FB0", VA = "0x188FB81B0")]
		internal static TRYMWPTRNBG CCQENQPWLWQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8440", Offset = "0x8FB7240", VA = "0x188FB8440")]
		public static CUHMSFVHHTY FKSNWFNUXJC(Func<float> a, Action<float> b, float c, float d, JIMPIYVNKHQ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7F30", Offset = "0x8FB6D30", VA = "0x188FB7F30")]
		public static CUHMSFVHHTY BJZYLHCEIIG(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, JIMPIYVNKHQ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8220", Offset = "0x8FB7020", VA = "0x188FB8220")]
		public static CUHMSFVHHTY DCKWNENLESR(Func<Color> a, Action<Color> b, Color c, float d, JIMPIYVNKHQ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB80E0", Offset = "0x8FB6EE0", VA = "0x188FB80E0")]
		public static CUHMSFVHHTY BXNULVYWTYJ(Transform a, Vector3 b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8580", Offset = "0x8FB7380", VA = "0x188FB8580")]
		public static CUHMSFVHHTY HZPZYVGBWAD(Transform a, Quaternion b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8370", Offset = "0x8FB7170", VA = "0x188FB8370")]
		public static CUHMSFVHHTY DQWRBYOFAYO(Transform a, Vector3 b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8FB87B0", Offset = "0x8FB75B0", VA = "0x188FB87B0")]
		public static LMNJWECWJAM Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8FB86C0", Offset = "0x8FB74C0", VA = "0x188FB86C0")]
		public static void ILQNYOFQYCM(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class TOWZRNOFFLN : YIRRNSOTUCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action ULZPBUPJDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action TUFRXQDYROA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> PCCTBZDESKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> FMYXGJUOQEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> BGDOUGXXYEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected NHUAMBAIDVI RNTACPTQADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object MPMENXEKTUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool BIFLWRWBMOF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool CYUGBXNLYZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9690", Offset = "0x8FB8490", VA = "0x188FB9690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool IBDLNTIKOFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8FB91E0", Offset = "0x8FB7FE0", VA = "0x188FB91E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ENBBBBSYCNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9480", Offset = "0x8FB8280", VA = "0x188FB9480", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8FB93E0", Offset = "0x8FB81E0", VA = "0x188FB93E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210", Slot = "9")]
		public DQILUIFDCOX PLOGAXDRXGY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9200", Offset = "0x8FB8000", VA = "0x188FB9200", Slot = "6")]
		public YIRRNSOTUCE KHPTSCCMQMH(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB90D0", Offset = "0x8FB7ED0", VA = "0x188FB90D0", Slot = "7")]
		public YIRRNSOTUCE FQZQUNBACJV(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8E40", Offset = "0x8FB7C40", VA = "0x188FB8E40", Slot = "8")]
		public YIRRNSOTUCE CXEOOCNLUHM(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool AVADAVMGFWP(float a);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float TEHPTZROGJR();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8F30", Offset = "0x8FB7D30", VA = "0x188FB8F30", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8FB92B0", Offset = "0x8FB80B0", VA = "0x188FB92B0")]
		protected void LEQENJATCNT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9520", Offset = "0x8FB8320", VA = "0x188FB9520")]
		protected void SZAVKCYKVTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8FB96B0", Offset = "0x8FB84B0", VA = "0x188FB96B0")]
		protected TOWZRNOFFLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class QGWAJZTJQCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7D50", Offset = "0x8FB6B50", VA = "0x188FB7D50")]
		public static CUHMSFVHHTY CNGJOPLBOAF(this Behaviour a, Vector3 b, float c, JIMPIYVNKHQ.Functions d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7E40", Offset = "0x8FB6C40", VA = "0x188FB7E40")]
		public static CUHMSFVHHTY DQWRBYOFAYO(this Behaviour a, Vector3 b, float c, JIMPIYVNKHQ.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class USOZNEQVBLL : TOWZRNOFFLN, CUHMSFVHHTY, YIRRNSOTUCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool IOPHVGWNSHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float GIENFZNRPSD;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected JIMPIYVNKHQ.Functions PCGKHKMXIXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xC44D30", Offset = "0xC43B30", VA = "0x180C44D30")]
			[CompilerGenerated]
			get
			{
				return default(JIMPIYVNKHQ.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9DA0", Offset = "0x8FB8BA0", VA = "0x188FB9DA0")]
		protected USOZNEQVBLL(float a, JIMPIYVNKHQ.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC85730", Offset = "0xC84530", VA = "0x180C85730")]
		[CompilerGenerated]
		private void OGCBBTHHTFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8FB72A0", Offset = "0x8FB60A0", VA = "0x188FB72A0")]
		[CompilerGenerated]
		private void OFWUEMNKJUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class TDGUWMWPOGO<a> : USOZNEQVBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> MBZXXBTFXVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> UVKFBBHLKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a FRYLVRTOJAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float HDMSAMKVVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a CHILEYKTVXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a ADDFXIDPUOR;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60E9EF0", Offset = "0x60E8CF0", VA = "0x1860E9EF0")]
		protected TDGUWMWPOGO(Func<a> a, Action<a> b, a c, float d, JIMPIYVNKHQ.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a OXMALHEHSIF();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a FZEKURUHQCW(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60E9110", Offset = "0x60E7F10", VA = "0x1860E9110", Slot = "13")]
		public override bool AVADAVMGFWP(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60E9CE0", Offset = "0x60E8AE0", VA = "0x1860E9CE0", Slot = "14")]
		public override float TEHPTZROGJR()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class OKQKZWHUXZN : TOWZRNOFFLN, LMNJWECWJAM, YIRRNSOTUCE
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
			private YIRRNSOTUCE tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<YIRRNSOTUCE> factory;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8FB98B0", Offset = "0x8FB86B0", VA = "0x188FB98B0")]
			public TweenEntry(YIRRNSOTUCE tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1D7E430", Offset = "0x1D7D230", VA = "0x181D7E430")]
			public TweenEntry(Func<YIRRNSOTUCE> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9790", Offset = "0x8FB8590", VA = "0x188FB9790")]
			public YIRRNSOTUCE ZKTCPBHUEUI()
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
		private readonly List<Step> ATKKPXZNQEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int GQAGUZJTHJU;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB76B0", Offset = "0x8FB64B0", VA = "0x188FB76B0")]
		public OKQKZWHUXZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7380", Offset = "0x8FB6180", VA = "0x188FB7380", Slot = "15")]
		public LMNJWECWJAM PJTJEVBRFMB(YIRRNSOTUCE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8FB72C0", Offset = "0x8FB60C0", VA = "0x188FB72C0", Slot = "16")]
		public LMNJWECWJAM PJTJEVBRFMB(Func<YIRRNSOTUCE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8FB6910", Offset = "0x8FB5710", VA = "0x188FB6910", Slot = "17")]
		public LMNJWECWJAM FBEVAAJUIYC(IEnumerable<YIRRNSOTUCE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8FB6790", Offset = "0x8FB5590", VA = "0x188FB6790", Slot = "18")]
		public LMNJWECWJAM FBEVAAJUIYC(params YIRRNSOTUCE[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7190", Offset = "0x8FB5F90", VA = "0x188FB7190", Slot = "19")]
		public LMNJWECWJAM KVJJDLABFIB(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8FB6680", Offset = "0x8FB5480", VA = "0x188FB6680", Slot = "13")]
		public override bool AVADAVMGFWP(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7590", Offset = "0x8FB6390", VA = "0x188FB7590", Slot = "14")]
		public override float TEHPTZROGJR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8FB6B70", Offset = "0x8FB5970", VA = "0x188FB6B70")]
		private bool FPJUFEPSEOO(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8FB6A60", Offset = "0x8FB5860", VA = "0x188FB6A60")]
		private LMNJWECWJAM FBEVAAJUIYC(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC85730", Offset = "0xC84530", VA = "0x180C85730")]
		[CompilerGenerated]
		private void OGCBBTHHTFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8FB72A0", Offset = "0x8FB60A0", VA = "0x188FB72A0")]
		[CompilerGenerated]
		private void OFWUEMNKJUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class FSAGMPGGYIR : TRYMWPTRNBG
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public TOWZRNOFFLN Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class ULGETRPVWBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform YQMYOWJHTJU;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public ULGETRPVWBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9D60", Offset = "0x8FB8B60", VA = "0x188FB9D60")]
			internal Vector3 XZDJDRLJILR()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9D20", Offset = "0x8FB8B20", VA = "0x188FB9D20")]
			internal void XYYCGKRLZAI(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class UHRWADSOIRM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform YQMYOWJHTJU;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public UHRWADSOIRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9CE0", Offset = "0x8FB8AE0", VA = "0x188FB9CE0")]
			internal Quaternion CKFVUFNAAEN()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9CB0", Offset = "0x8FB8AB0", VA = "0x188FB9CB0")]
			internal void CKAOWYTCQTE(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class PUSMKHNTSRX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform YQMYOWJHTJU;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public PUSMKHNTSRX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8FB7C70", Offset = "0x8FB6A70", VA = "0x188FB7C70")]
			internal Vector3 XGWOIPOEOEX()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8FB7C30", Offset = "0x8FB6A30", VA = "0x188FB7C30")]
			internal void XGRHLIUHETO(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class KOBUZRHZHJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Transform YQMYOWJHTJU;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public KOBUZRHZHJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8FB63C0", Offset = "0x8FB51C0", VA = "0x188FB63C0")]
			internal Vector3 XMJLSJERWUK()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8FB6400", Offset = "0x8FB5200", VA = "0x188FB6400")]
			internal void XMOSPPYPGFT(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class LACTLWAXKYN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public TOWZRNOFFLN FURIXEOLEIS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public FSAGMPGGYIR SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Behaviour LKKZURHCYCC;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public LACTLWAXKYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8FB6440", Offset = "0x8FB5240", VA = "0x188FB6440")]
			internal void EUJOSFFXCEG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class CVBAJCCUCCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public FSAGMPGGYIR SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public TOWZRNOFFLN XVRJKQVNDAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public RYHDNSZFVTC LYURWAKOIXG;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public CVBAJCCUCCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3A10", Offset = "0x8FB2810", VA = "0x188FB3A10")]
			internal void PFOFFZKFSEU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3B20", Offset = "0x8FB2920", VA = "0x188FB3B20")]
			internal void PFTMDGEDBQD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3B70", Offset = "0x8FB2970", VA = "0x188FB3B70")]
			internal void PFYTAMYALBM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class ABREUOEELPE : IEnumerator<XTKXCVTPKYX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private XTKXCVTPKYX KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public YIRRNSOTUCE FURIXEOLEIS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public FSAGMPGGYIR SVDPBWSVAHX;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private XTKXCVTPKYX INPROFPLOIG
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public ABREUOEELPE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3470", Offset = "0x8FB2270", VA = "0x188FB3470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3430", Offset = "0x8FB2230", VA = "0x188FB3430", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class OXAOQDARJGE : IEnumerator<XTKXCVTPKYX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private XTKXCVTPKYX KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public FSAGMPGGYIR SVDPBWSVAHX;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private XTKXCVTPKYX INPROFPLOIG
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public OXAOQDARJGE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8FB7830", Offset = "0x8FB6630", VA = "0x188FB7830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8FB77F0", Offset = "0x8FB65F0", VA = "0x188FB77F0", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly WNUSNYDCKEP AVTSRNMEBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly UFJDXDNSYZK YQMHABMCSGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> URJEJYCFUDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> KCCQIORBSDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<TOWZRNOFFLN> TODIXKCVUQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<TOWZRNOFFLN>> SJHSWVMAWEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool XQXHMUVABZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private RYHDNSZFVTC ASPGLXBOCTQ;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3E80", Offset = "0x8FB2C80", VA = "0x188FB3E80")]
		[XNELNNYDNRZ.Root]
		internal static void AMOQIHAHUJI(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8FB57A0", Offset = "0x8FB45A0", VA = "0x188FB57A0")]
		[UnityEngine.Scripting.Preserve]
		internal FSAGMPGGYIR([Inject(null)] WNUSNYDCKEP scheduler, [Inject(null)] UFJDXDNSYZK schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8FB46C0", Offset = "0x8FB34C0", VA = "0x188FB46C0", Slot = "4")]
		public CUHMSFVHHTY FKSNWFNUXJC(Func<float> a, Action<float> b, float c, float d, JIMPIYVNKHQ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3F70", Offset = "0x8FB2D70", VA = "0x188FB3F70", Slot = "5")]
		public CUHMSFVHHTY BJZYLHCEIIG(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, JIMPIYVNKHQ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4400", Offset = "0x8FB3200", VA = "0x188FB4400", Slot = "6")]
		public CUHMSFVHHTY DCKWNENLESR(Func<Color> a, Action<Color> b, Color c, float d, JIMPIYVNKHQ.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4060", Offset = "0x8FB2E60", VA = "0x188FB4060", Slot = "7")]
		public CUHMSFVHHTY BXNULVYWTYJ(Transform a, Vector3 b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4810", Offset = "0x8FB3610", VA = "0x188FB4810", Slot = "8")]
		public CUHMSFVHHTY HZPZYVGBWAD(Transform a, Quaternion b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4230", Offset = "0x8FB3030", VA = "0x188FB4230", Slot = "9")]
		public CUHMSFVHHTY CNGJOPLBOAF(Transform a, Vector3 b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB44F0", Offset = "0x8FB32F0", VA = "0x188FB44F0", Slot = "10")]
		public CUHMSFVHHTY DQWRBYOFAYO(Transform a, Vector3 b, float c, JIMPIYVNKHQ.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB5610", Offset = "0x8FB4410", VA = "0x188FB5610", Slot = "11")]
		public LMNJWECWJAM Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4B20", Offset = "0x8FB3920", VA = "0x188FB4B20", Slot = "12")]
		public void ILQNYOFQYCM(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB49D0", Offset = "0x8FB37D0", VA = "0x188FB49D0", Slot = "13")]
		public void ILQNYOFQYCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4FA0", Offset = "0x8FB3DA0", VA = "0x188FB4FA0")]
		private void QLELOQDHZXE(Behaviour a, TOWZRNOFFLN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8FB47A0", Offset = "0x8FB35A0", VA = "0x188FB47A0")]
		[IteratorStateMachine(typeof(OXAOQDARJGE))]
		private IEnumerator<XTKXCVTPKYX> GWEZIGTBPAV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8FB5260", Offset = "0x8FB4060", VA = "0x188FB5260")]
		private void Run(Behaviour context, TOWZRNOFFLN sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4DB0", Offset = "0x8FB3BB0", VA = "0x188FB4DB0")]
		[IteratorStateMachine(typeof(ABREUOEELPE))]
		private IEnumerator<XTKXCVTPKYX> NJMLNIBBVOF(YIRRNSOTUCE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4E40", Offset = "0x8FB3C40", VA = "0x188FB4E40")]
		private void PJTJEVBRFMB(TOWZRNOFFLN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4CC0", Offset = "0x8FB3AC0", VA = "0x188FB4CC0")]
		private void MQKIAABPGWC(TOWZRNOFFLN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8FB49D0", Offset = "0x8FB37D0", VA = "0x188FB49D0")]
		private void OMSQZPZNZVF(Scene a, LoadSceneMode b)
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
