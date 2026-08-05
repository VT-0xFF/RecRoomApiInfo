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
		[Cpp2IlInjected.Address(RVA = "0x8D66640", Offset = "0x8D64E40", VA = "0x188D66640", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2735A30", Offset = "0x2734230", VA = "0x182735A30")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class QVSMERWFCGG
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
		public static class ZMFAZMUXVYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x27CC420", Offset = "0x27CAC20", VA = "0x1827CC420")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8D65C80", Offset = "0x8D64480", VA = "0x188D65C80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8D65CA0", Offset = "0x8D644A0", VA = "0x188D65CA0")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class IFPWVNSDCHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8D60310", Offset = "0x8D5EB10", VA = "0x188D60310")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8D60320", Offset = "0x8D5EB20", VA = "0x188D60320")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8D60340", Offset = "0x8D5EB40", VA = "0x188D60340")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class BEUUAPZOWFI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FBD0", Offset = "0x8D5E3D0", VA = "0x188D5FBD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FBE0", Offset = "0x8D5E3E0", VA = "0x188D5FBE0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FC10", Offset = "0x8D5E410", VA = "0x188D5FC10")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class KHRNBNUWXLU
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8D606E0", Offset = "0x8D5EEE0", VA = "0x188D606E0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8D60700", Offset = "0x8D5EF00", VA = "0x188D60700")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8D60730", Offset = "0x8D5EF30", VA = "0x188D60730")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D64FD0", Offset = "0x8D637D0", VA = "0x188D64FD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D65000", Offset = "0x8D63800", VA = "0x188D65000")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8D65020", Offset = "0x8D63820", VA = "0x188D65020")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8D60120", Offset = "0x8D5E920", VA = "0x188D60120")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D60170", Offset = "0x8D5E970", VA = "0x188D60170")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D601D0", Offset = "0x8D5E9D0", VA = "0x188D601D0")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class WTOWAGWOBNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8D65760", Offset = "0x8D63F60", VA = "0x188D65760")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D657C0", Offset = "0x8D63FC0", VA = "0x188D657C0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D657F0", Offset = "0x8D63FF0", VA = "0x188D657F0")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class IJHCCJFHJWC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D60390", Offset = "0x8D5EB90", VA = "0x188D60390")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8D60440", Offset = "0x8D5EC40", VA = "0x188D60440")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D60500", Offset = "0x8D5ED00", VA = "0x188D60500")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float PEUOATWFSAQ;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float SGDIXUSQYDI;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FC70", Offset = "0x8D5E470", VA = "0x188D5FC70")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FCE0", Offset = "0x8D5E4E0", VA = "0x188D5FCE0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FD60", Offset = "0x8D5E560", VA = "0x188D5FD60")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FE90", Offset = "0x8D5E690", VA = "0x188D5FE90")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FF60", Offset = "0x8D5E760", VA = "0x188D5FF60")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D60000", Offset = "0x8D5E800", VA = "0x188D60000")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D64340", Offset = "0x8D62B40", VA = "0x188D64340")]
		public static float QITHQXHQPDH(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class BAPBNILCSZJ : RSUVYRZDJZT
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FAC0", Offset = "0x8D5E2C0", VA = "0x188D5FAC0")]
		public BAPBNILCSZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "13")]
		public override bool DXKUAVBELZF(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAEE860", Offset = "0xAED060", VA = "0x180AEE860", Slot = "14")]
		public override float DHIWRSRPRDF()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class VGLGGWKDIVS : JPENNILYXJY<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D65560", Offset = "0x8D63D60", VA = "0x188D65560")]
		public VGLGGWKDIVS(Func<Color> a, Action<Color> b, Color c, float d, QVSMERWFCGG.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xC6A670", Offset = "0xC68E70", VA = "0x180C6A670", Slot = "15")]
		protected override Color FCZHHZZXFAV()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8202E20", Offset = "0x8201620", VA = "0x188202E20", Slot = "16")]
		protected override Color QJINUZSQSJU(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class RRMYOVXRPUV : JPENNILYXJY<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D64E50", Offset = "0x8D63650", VA = "0x188D64E50")]
		public RRMYOVXRPUV(Func<float> a, Action<float> b, float c, float d, QVSMERWFCGG.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D64DE0", Offset = "0x8D635E0", VA = "0x188D64DE0", Slot = "15")]
		protected override float FCZHHZZXFAV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D64E30", Offset = "0x8D63630", VA = "0x188D64E30", Slot = "16")]
		protected override float QJINUZSQSJU(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class LOIMHUUKXQF : JPENNILYXJY<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D61AC0", Offset = "0x8D602C0", VA = "0x188D61AC0")]
		public LOIMHUUKXQF(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, QVSMERWFCGG.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D618B0", Offset = "0x8D600B0", VA = "0x188D618B0", Slot = "15")]
		protected override Quaternion FCZHHZZXFAV()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D61A70", Offset = "0x8D60270", VA = "0x188D61A70", Slot = "16")]
		protected override Quaternion QJINUZSQSJU(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class YWGCWRJOUQP : JPENNILYXJY<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D65BE0", Offset = "0x8D643E0", VA = "0x188D65BE0")]
		public YWGCWRJOUQP(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, QVSMERWFCGG.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D65AD0", Offset = "0x8D642D0", VA = "0x188D65AD0", Slot = "15")]
		protected override Vector3 FCZHHZZXFAV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D65B70", Offset = "0x8D64370", VA = "0x188D65B70", Slot = "16")]
		protected override Vector3 QJINUZSQSJU(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface NACNJAZEVXK
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action DMNWUCUKBXS;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NACNJAZEVXK DSKPGNNOHWD(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NACNJAZEVXK MLXTVWFYXVF(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NACNJAZEVXK JJQMCLEDGRU(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DNXWICJZUNF QQAHWJIPQWI();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DXKUAVBELZF(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float DHIWRSRPRDF();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface NBBOGJWUDYK : NACNJAZEVXK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface NDXHNBMAEAE : NACNJAZEVXK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NDXHNBMAEAE QGVJJQCICFX(NACNJAZEVXK a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NDXHNBMAEAE QGVJJQCICFX(Func<NACNJAZEVXK> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NDXHNBMAEAE WVNQYMQVNKW(IEnumerable<NACNJAZEVXK> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NDXHNBMAEAE WVNQYMQVNKW(params NACNJAZEVXK[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NDXHNBMAEAE LZQUDZJTFMF(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ESGHUDPPCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NBBOGJWUDYK DMXHIGXVLEI(Func<float> a, Action<float> b, float c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NBBOGJWUDYK XSXTNVMHFPA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NBBOGJWUDYK FEKAGNCQBJT(Func<Color> a, Action<Color> b, Color c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NBBOGJWUDYK QGCTVXPUNQN(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NBBOGJWUDYK AYYFLYOQEPJ(Transform a, Quaternion b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		NBBOGJWUDYK FIOVQZWASNQ(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		NDXHNBMAEAE Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GCWQFYNAZNO(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class PZBODRKMHDU
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static NACNJAZEVXK BAPBNILCSZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8D63F40", Offset = "0x8D62740", VA = "0x188D63F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D639E0", Offset = "0x8D621E0", VA = "0x188D639E0")]
		internal static ESGHUDPPCMA BOBCHCAXYXO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8D63A50", Offset = "0x8D62250", VA = "0x188D63A50")]
		public static NBBOGJWUDYK DMXHIGXVLEI(Func<float> a, Action<float> b, float c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D64080", Offset = "0x8D62880", VA = "0x188D64080")]
		public static NBBOGJWUDYK XSXTNVMHFPA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D63B80", Offset = "0x8D62380", VA = "0x188D63B80")]
		public static NBBOGJWUDYK FEKAGNCQBJT(Func<Color> a, Action<Color> b, Color c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D63E70", Offset = "0x8D62670", VA = "0x188D63E70")]
		public static NBBOGJWUDYK QGCTVXPUNQN(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8D638B0", Offset = "0x8D620B0", VA = "0x188D638B0")]
		public static NBBOGJWUDYK AYYFLYOQEPJ(Transform a, Quaternion b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8D63CC0", Offset = "0x8D624C0", VA = "0x188D63CC0")]
		public static NBBOGJWUDYK FIOVQZWASNQ(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D63F90", Offset = "0x8D62790", VA = "0x188D63F90")]
		public static NDXHNBMAEAE Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D63D90", Offset = "0x8D62590", VA = "0x188D63D90")]
		public static void GCWQFYNAZNO(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class ZORRRSALXZF : NACNJAZEVXK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action CVFPGCHFDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action VIRMPAWEOWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> CKAMOXHXBZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> OTDOLKXNRFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> JRFVCYIEUIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected DKIBBYYTMUS BCGUMWNTOSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object FMLWCFPZQDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool VLVMSOOOQJD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool QRUKCEWFPVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8D65FE0", Offset = "0x8D647E0", VA = "0x188D65FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool BRHRKHOCZMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8D66540", Offset = "0x8D64D40", VA = "0x188D66540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action DMNWUCUKBXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8D664A0", Offset = "0x8D64CA0", VA = "0x188D664A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8D65CF0", Offset = "0x8D644F0", VA = "0x188D65CF0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580", Slot = "9")]
		public DNXWICJZUNF QQAHWJIPQWI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D65F30", Offset = "0x8D64730", VA = "0x188D65F30", Slot = "6")]
		public NACNJAZEVXK DSKPGNNOHWD(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D66390", Offset = "0x8D64B90", VA = "0x188D66390", Slot = "7")]
		public NACNJAZEVXK MLXTVWFYXVF(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D662A0", Offset = "0x8D64AA0", VA = "0x188D662A0", Slot = "8")]
		public NACNJAZEVXK JJQMCLEDGRU(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool DXKUAVBELZF(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float DHIWRSRPRDF();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D65D90", Offset = "0x8D64590", VA = "0x188D65D90", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D66000", Offset = "0x8D64800", VA = "0x188D66000")]
		protected void HKJVWIWUAIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D66130", Offset = "0x8D64930", VA = "0x188D66130")]
		protected void HUVFKMHZTCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D66560", Offset = "0x8D64D60", VA = "0x188D66560")]
		protected ZORRRSALXZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class VMLZBKOZNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D65600", Offset = "0x8D63E00", VA = "0x188D65600")]
		public static NBBOGJWUDYK FIOVQZWASNQ(this Behaviour a, Vector3 b, float c, QVSMERWFCGG.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class RSUVYRZDJZT : ZORRRSALXZF, NBBOGJWUDYK, NACNJAZEVXK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool VANVVGGPVWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float XBKXFJJVYBV;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected QVSMERWFCGG.Functions TORMFHQEBLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD376A0", Offset = "0xD35EA0", VA = "0x180D376A0")]
			[CompilerGenerated]
			get
			{
				return default(QVSMERWFCGG.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D64EC0", Offset = "0x8D636C0", VA = "0x188D64EC0")]
		protected RSUVYRZDJZT(float a, QVSMERWFCGG.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x263C780", Offset = "0x263AF80", VA = "0x18263C780")]
		[CompilerGenerated]
		private void QMIXJXZXQNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D61380", Offset = "0x8D5FB80", VA = "0x188D61380")]
		[CompilerGenerated]
		private void QMDQMRGAHBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class JPENNILYXJY<a> : RSUVYRZDJZT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> THESGMIYUHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> CQHQKWIXVVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a EXZLMABXAGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float GUDXISQXWKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a ZENYUHYOOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a GJCHLUVZDPH;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x50FA3F0", Offset = "0x50F8BF0", VA = "0x1850FA3F0")]
		protected JPENNILYXJY(Func<a> a, Action<a> b, a c, float d, QVSMERWFCGG.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a FCZHHZZXFAV();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a QJINUZSQSJU(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x50FA1A0", Offset = "0x50F89A0", VA = "0x1850FA1A0", Slot = "13")]
		public override bool DXKUAVBELZF(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x50F9260", Offset = "0x50F7A60", VA = "0x1850F9260", Slot = "14")]
		public override float DHIWRSRPRDF()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class KHTIUOPEDNB : ZORRRSALXZF, NDXHNBMAEAE, NACNJAZEVXK
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
			private NACNJAZEVXK tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<NACNJAZEVXK> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8D65170", Offset = "0x8D63970", VA = "0x188D65170")]
			public TweenEntry(NACNJAZEVXK tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1A96DA0", Offset = "0x1A955A0", VA = "0x181A96DA0")]
			public TweenEntry(Func<NACNJAZEVXK> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8D65050", Offset = "0x8D63850", VA = "0x188D65050")]
			public NACNJAZEVXK BGWRECGKIBK()
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
		private readonly List<Step> NRNODHQLFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int FWBVPEHAOHQ;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D61770", Offset = "0x8D5FF70", VA = "0x188D61770")]
		public KHTIUOPEDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D61180", Offset = "0x8D5F980", VA = "0x188D61180", Slot = "15")]
		public NDXHNBMAEAE QGVJJQCICFX(NACNJAZEVXK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8D610C0", Offset = "0x8D5F8C0", VA = "0x188D610C0", Slot = "16")]
		public NDXHNBMAEAE QGVJJQCICFX(Func<NACNJAZEVXK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D614B0", Offset = "0x8D5FCB0", VA = "0x188D614B0", Slot = "17")]
		public NDXHNBMAEAE WVNQYMQVNKW(IEnumerable<NACNJAZEVXK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D61600", Offset = "0x8D5FE00", VA = "0x188D61600", Slot = "18")]
		public NDXHNBMAEAE WVNQYMQVNKW(params NACNJAZEVXK[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8D60FB0", Offset = "0x8D5F7B0", VA = "0x188D60FB0", Slot = "19")]
		public NDXHNBMAEAE LZQUDZJTFMF(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8D608A0", Offset = "0x8D5F0A0", VA = "0x188D608A0", Slot = "13")]
		public override bool DXKUAVBELZF(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8D60790", Offset = "0x8D5EF90", VA = "0x188D60790", Slot = "14")]
		public override float DHIWRSRPRDF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D609B0", Offset = "0x8D5F1B0", VA = "0x188D609B0")]
		private bool KMTIRIKLNRA(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D613A0", Offset = "0x8D5FBA0", VA = "0x188D613A0")]
		private NDXHNBMAEAE WVNQYMQVNKW(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x263C780", Offset = "0x263AF80", VA = "0x18263C780")]
		[CompilerGenerated]
		private void QMIXJXZXQNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D61380", Offset = "0x8D5FB80", VA = "0x188D61380")]
		[CompilerGenerated]
		private void QMDQMRGAHBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class OVPVZCVCCXX : ESGHUDPPCMA
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public ZORRRSALXZF Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class XHDCJOGKBMU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform GSKXYTUKRXM;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public XHDCJOGKBMU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8D658E0", Offset = "0x8D640E0", VA = "0x188D658E0")]
			internal Vector3 MAXGPMKHUVJ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8D658A0", Offset = "0x8D640A0", VA = "0x188D658A0")]
			internal void MARZSFQKLKA(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class WKDHTAWVSFY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform GSKXYTUKRXM;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public WKDHTAWVSFY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8D65720", Offset = "0x8D63F20", VA = "0x188D65720")]
			internal Quaternion UQCFJKSEXYF()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8D656F0", Offset = "0x8D63EF0", VA = "0x188D656F0")]
			internal void UPWYMDYHOMW(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class FPTEFWBUXSU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform GSKXYTUKRXM;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public FPTEFWBUXSU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8D60290", Offset = "0x8D5EA90", VA = "0x188D60290")]
			internal Vector3 KGLZQGILCPQ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8D602D0", Offset = "0x8D5EAD0", VA = "0x188D602D0")]
			internal void KGRGNNCIMAZ(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class PDQLYVSWNTX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public ZORRRSALXZF FWYZIKHCBTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public OVPVZCVCCXX VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour ZJYUDPTNQRI;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PDQLYVSWNTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8D637B0", Offset = "0x8D61FB0", VA = "0x188D637B0")]
			internal void XOUZNHWNCUS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class YJGILQXVTGT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public OVPVZCVCCXX VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public ZORRRSALXZF ZAIHHXQEOJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public XEXLSJPFYXK UAIIZOLEBCY;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public YJGILQXVTGT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8D65920", Offset = "0x8D64120", VA = "0x188D65920")]
			internal void QWVOBPYGTCY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8D65A30", Offset = "0x8D64230", VA = "0x188D65A30")]
			internal void QXAUYWSECOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8D65A80", Offset = "0x8D64280", VA = "0x188D65A80")]
			internal void QXGBWDMBLZQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class IRBKOHUTDAO : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public NACNJAZEVXK FWYZIKHCBTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public OVPVZCVCCXX VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public IRBKOHUTDAO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8D605D0", Offset = "0x8D5EDD0", VA = "0x188D605D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8D606A0", Offset = "0x8D5EEA0", VA = "0x188D606A0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class MUXCGJYKJDG : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public OVPVZCVCCXX VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public MUXCGJYKJDG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8D61B60", Offset = "0x8D60360", VA = "0x188D61B60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8D61EB0", Offset = "0x8D606B0", VA = "0x188D61EB0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly SEPEWOFBWYL TTKVAEMBSNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly MUGMONEUUMI EQHBWPPJJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> SHKDXOKXJVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> WHYXZEWPJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<ZORRRSALXZF> JIKDJKKJYCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<ZORRRSALXZF>> PZWGVJJJKTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool EEXWHCBPFMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private XEXLSJPFYXK LXTUCKAKTHA;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D62FA0", Offset = "0x8D617A0", VA = "0x188D62FA0")]
		[UKOBXVXKPZF.Root]
		internal static void SKEBEIJGPGG(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8D63640", Offset = "0x8D61E40", VA = "0x188D63640")]
		[UnityEngine.Scripting.Preserve]
		internal OVPVZCVCCXX([Inject(null)] SEPEWOFBWYL scheduler, [Inject(null)] MUGMONEUUMI schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8D620B0", Offset = "0x8D608B0", VA = "0x188D620B0", Slot = "4")]
		public NBBOGJWUDYK DMXHIGXVLEI(Func<float> a, Action<float> b, float c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8D63550", Offset = "0x8D61D50", VA = "0x188D63550", Slot = "5")]
		public NBBOGJWUDYK XSXTNVMHFPA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8D62190", Offset = "0x8D60990", VA = "0x188D62190", Slot = "6")]
		public NBBOGJWUDYK FEKAGNCQBJT(Func<Color> a, Action<Color> b, Color c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8D628C0", Offset = "0x8D610C0", VA = "0x188D628C0", Slot = "7")]
		public NBBOGJWUDYK QGCTVXPUNQN(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8D61EF0", Offset = "0x8D606F0", VA = "0x188D61EF0", Slot = "8")]
		public NBBOGJWUDYK AYYFLYOQEPJ(Transform a, Quaternion b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8D62280", Offset = "0x8D60A80", VA = "0x188D62280", Slot = "9")]
		public NBBOGJWUDYK FIOVQZWASNQ(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8D63090", Offset = "0x8D61890", VA = "0x188D63090", Slot = "10")]
		public NDXHNBMAEAE Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8D625A0", Offset = "0x8D60DA0", VA = "0x188D625A0", Slot = "11")]
		public void GCWQFYNAZNO(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8D62450", Offset = "0x8D60C50", VA = "0x188D62450", Slot = "12")]
		public void GCWQFYNAZNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8D63290", Offset = "0x8D61A90", VA = "0x188D63290")]
		private void XOQALWFTSJY(Behaviour a, ZORRRSALXZF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8D63220", Offset = "0x8D61A20", VA = "0x188D63220")]
		[IteratorStateMachine(typeof(MUXCGJYKJDG))]
		private IEnumerator<YTAMKWOJLST> WFFCUBGLSCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D62BF0", Offset = "0x8D613F0", VA = "0x188D62BF0")]
		private void Run(Behaviour context, ZORRRSALXZF sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D62830", Offset = "0x8D61030", VA = "0x188D62830")]
		[IteratorStateMachine(typeof(IRBKOHUTDAO))]
		private IEnumerator<YTAMKWOJLST> PHDIXPWYKMB(NACNJAZEVXK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8D62A90", Offset = "0x8D61290", VA = "0x188D62A90")]
		private void QGVJJQCICFX(ZORRRSALXZF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8D62740", Offset = "0x8D60F40", VA = "0x188D62740")]
		private void NPGIOTBXKUC(ZORRRSALXZF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8D62450", Offset = "0x8D60C50", VA = "0x188D62450")]
		private void NYJQTLFAGTZ(Scene a, LoadSceneMode b)
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
