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
		[Cpp2IlInjected.Address(RVA = "0x8E68A40", Offset = "0x8E67440", VA = "0x188E68A40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2748530", Offset = "0x2746F30", VA = "0x182748530")]
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
			[Cpp2IlInjected.Address(RVA = "0x27DEBB0", Offset = "0x27DD5B0", VA = "0x1827DEBB0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8E680E0", Offset = "0x8E66AE0", VA = "0x188E680E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8E68100", Offset = "0x8E66B00", VA = "0x188E68100")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class IFPWVNSDCHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8E62650", Offset = "0x8E61050", VA = "0x188E62650")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8E62660", Offset = "0x8E61060", VA = "0x188E62660")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8E62680", Offset = "0x8E61080", VA = "0x188E62680")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class BEUUAPZOWFI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8E61F10", Offset = "0x8E60910", VA = "0x188E61F10")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8E61F20", Offset = "0x8E60920", VA = "0x188E61F20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8E61F50", Offset = "0x8E60950", VA = "0x188E61F50")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class KHRNBNUWXLU
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8E62A20", Offset = "0x8E61420", VA = "0x188E62A20")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8E62A40", Offset = "0x8E61440", VA = "0x188E62A40")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8E62A70", Offset = "0x8E61470", VA = "0x188E62A70")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8E67430", Offset = "0x8E65E30", VA = "0x188E67430")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8E67460", Offset = "0x8E65E60", VA = "0x188E67460")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8E67480", Offset = "0x8E65E80", VA = "0x188E67480")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8E62460", Offset = "0x8E60E60", VA = "0x188E62460")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8E624B0", Offset = "0x8E60EB0", VA = "0x188E624B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8E62510", Offset = "0x8E60F10", VA = "0x188E62510")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class WTOWAGWOBNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8E67BC0", Offset = "0x8E665C0", VA = "0x188E67BC0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8E67C20", Offset = "0x8E66620", VA = "0x188E67C20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8E67C50", Offset = "0x8E66650", VA = "0x188E67C50")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class IJHCCJFHJWC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8E626D0", Offset = "0x8E610D0", VA = "0x188E626D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8E62780", Offset = "0x8E61180", VA = "0x188E62780")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8E62840", Offset = "0x8E61240", VA = "0x188E62840")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E61FB0", Offset = "0x8E609B0", VA = "0x188E61FB0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8E62020", Offset = "0x8E60A20", VA = "0x188E62020")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8E620A0", Offset = "0x8E60AA0", VA = "0x188E620A0")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8E621D0", Offset = "0x8E60BD0", VA = "0x188E621D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8E622A0", Offset = "0x8E60CA0", VA = "0x188E622A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8E62340", Offset = "0x8E60D40", VA = "0x188E62340")]
			public static float XBYZOXRZHTC(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E666F0", Offset = "0x8E650F0", VA = "0x188E666F0")]
		public static float QITHQXHQPDH(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class BAPBNILCSZJ : RSUVYRZDJZT
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E61D70", Offset = "0x8E60770", VA = "0x188E61D70")]
		public BAPBNILCSZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "13")]
		public override bool DXKUAVBELZF(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB05980", Offset = "0xB04380", VA = "0x180B05980", Slot = "14")]
		public override float DHIWRSRPRDF()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class VGLGGWKDIVS : JPENNILYXJY<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E679C0", Offset = "0x8E663C0", VA = "0x188E679C0")]
		public VGLGGWKDIVS(Func<Color> a, Action<Color> b, Color c, float d, QVSMERWFCGG.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xC81A50", Offset = "0xC80450", VA = "0x180C81A50", Slot = "15")]
		protected override Color FCZHHZZXFAV()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8306850", Offset = "0x8305250", VA = "0x188306850", Slot = "16")]
		protected override Color QJINUZSQSJU(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class RRMYOVXRPUV : JPENNILYXJY<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E67200", Offset = "0x8E65C00", VA = "0x188E67200")]
		public RRMYOVXRPUV(Func<float> a, Action<float> b, float c, float d, QVSMERWFCGG.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E67190", Offset = "0x8E65B90", VA = "0x188E67190", Slot = "15")]
		protected override float FCZHHZZXFAV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E671E0", Offset = "0x8E65BE0", VA = "0x188E671E0", Slot = "16")]
		protected override float QJINUZSQSJU(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class LOIMHUUKXQF : JPENNILYXJY<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E63EB0", Offset = "0x8E628B0", VA = "0x188E63EB0")]
		public LOIMHUUKXQF(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, QVSMERWFCGG.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8E63CA0", Offset = "0x8E626A0", VA = "0x188E63CA0", Slot = "15")]
		protected override Quaternion FCZHHZZXFAV()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E63E60", Offset = "0x8E62860", VA = "0x188E63E60", Slot = "16")]
		protected override Quaternion QJINUZSQSJU(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class YWGCWRJOUQP : JPENNILYXJY<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8E68040", Offset = "0x8E66A40", VA = "0x188E68040")]
		public YWGCWRJOUQP(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, QVSMERWFCGG.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E67F30", Offset = "0x8E66930", VA = "0x188E67F30", Slot = "15")]
		protected override Vector3 FCZHHZZXFAV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8E67FD0", Offset = "0x8E669D0", VA = "0x188E67FD0", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E66250", Offset = "0x8E64C50", VA = "0x188E66250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E65CD0", Offset = "0x8E646D0", VA = "0x188E65CD0")]
		internal static ESGHUDPPCMA BOBCHCAXYXO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8E65D40", Offset = "0x8E64740", VA = "0x188E65D40")]
		public static NBBOGJWUDYK DMXHIGXVLEI(Func<float> a, Action<float> b, float c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8E66390", Offset = "0x8E64D90", VA = "0x188E66390")]
		public static NBBOGJWUDYK XSXTNVMHFPA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8E65E80", Offset = "0x8E64880", VA = "0x188E65E80")]
		public static NBBOGJWUDYK FEKAGNCQBJT(Func<Color> a, Action<Color> b, Color c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8E66180", Offset = "0x8E64B80", VA = "0x188E66180")]
		public static NBBOGJWUDYK QGCTVXPUNQN(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E65B90", Offset = "0x8E64590", VA = "0x188E65B90")]
		public static NBBOGJWUDYK AYYFLYOQEPJ(Transform a, Quaternion b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8E65FD0", Offset = "0x8E649D0", VA = "0x188E65FD0")]
		public static NBBOGJWUDYK FIOVQZWASNQ(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8E662A0", Offset = "0x8E64CA0", VA = "0x188E662A0")]
		public static NDXHNBMAEAE Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8E660A0", Offset = "0x8E64AA0", VA = "0x188E660A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E68450", Offset = "0x8E66E50", VA = "0x188E68450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool BRHRKHOCZMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8E68940", Offset = "0x8E67340", VA = "0x188E68940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action DMNWUCUKBXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8E688A0", Offset = "0x8E672A0", VA = "0x188E688A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8E68150", Offset = "0x8E66B50", VA = "0x188E68150", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0", Slot = "9")]
		public DNXWICJZUNF QQAHWJIPQWI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8E68390", Offset = "0x8E66D90", VA = "0x188E68390", Slot = "6")]
		public NACNJAZEVXK DSKPGNNOHWD(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8E687A0", Offset = "0x8E671A0", VA = "0x188E687A0", Slot = "7")]
		public NACNJAZEVXK MLXTVWFYXVF(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8E68710", Offset = "0x8E67110", VA = "0x188E68710", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E681F0", Offset = "0x8E66BF0", VA = "0x188E681F0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8E68470", Offset = "0x8E66E70", VA = "0x188E68470")]
		protected void HKJVWIWUAIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8E685A0", Offset = "0x8E66FA0", VA = "0x188E685A0")]
		protected void HUVFKMHZTCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8E68960", Offset = "0x8E67360", VA = "0x188E68960")]
		protected ZORRRSALXZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class VMLZBKOZNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8E67A60", Offset = "0x8E66460", VA = "0x188E67A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xD4EC40", Offset = "0xD4D640", VA = "0x180D4EC40")]
			[CompilerGenerated]
			get
			{
				return default(QVSMERWFCGG.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8E67270", Offset = "0x8E65C70", VA = "0x188E67270")]
		protected RSUVYRZDJZT(float a, QVSMERWFCGG.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x264F5B0", Offset = "0x264DFB0", VA = "0x18264F5B0")]
		[CompilerGenerated]
		private void QMIXJXZXQNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E636C0", Offset = "0x8E620C0", VA = "0x188E636C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x517E960", Offset = "0x517D360", VA = "0x18517E960")]
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
		[Cpp2IlInjected.Address(RVA = "0x517E710", Offset = "0x517D110", VA = "0x18517E710", Slot = "13")]
		public override bool DXKUAVBELZF(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x517D790", Offset = "0x517C190", VA = "0x18517D790", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E675D0", Offset = "0x8E65FD0", VA = "0x188E675D0")]
			public TweenEntry(NACNJAZEVXK tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1AAE010", Offset = "0x1AACA10", VA = "0x181AAE010")]
			public TweenEntry(Func<NACNJAZEVXK> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8E674B0", Offset = "0x8E65EB0", VA = "0x188E674B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E63AC0", Offset = "0x8E624C0", VA = "0x188E63AC0")]
		public KHTIUOPEDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8E634C0", Offset = "0x8E61EC0", VA = "0x188E634C0", Slot = "15")]
		public NDXHNBMAEAE QGVJJQCICFX(NACNJAZEVXK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8E63400", Offset = "0x8E61E00", VA = "0x188E63400", Slot = "16")]
		public NDXHNBMAEAE QGVJJQCICFX(Func<NACNJAZEVXK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8E63800", Offset = "0x8E62200", VA = "0x188E63800", Slot = "17")]
		public NDXHNBMAEAE WVNQYMQVNKW(IEnumerable<NACNJAZEVXK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8E63950", Offset = "0x8E62350", VA = "0x188E63950", Slot = "18")]
		public NDXHNBMAEAE WVNQYMQVNKW(params NACNJAZEVXK[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8E632F0", Offset = "0x8E61CF0", VA = "0x188E632F0", Slot = "19")]
		public NDXHNBMAEAE LZQUDZJTFMF(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8E62BE0", Offset = "0x8E615E0", VA = "0x188E62BE0", Slot = "13")]
		public override bool DXKUAVBELZF(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8E62AD0", Offset = "0x8E614D0", VA = "0x188E62AD0", Slot = "14")]
		public override float DHIWRSRPRDF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8E62CF0", Offset = "0x8E616F0", VA = "0x188E62CF0")]
		private bool KMTIRIKLNRA(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8E636E0", Offset = "0x8E620E0", VA = "0x188E636E0")]
		private NDXHNBMAEAE WVNQYMQVNKW(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x264F5B0", Offset = "0x264DFB0", VA = "0x18264F5B0")]
		[CompilerGenerated]
		private void QMIXJXZXQNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8E636C0", Offset = "0x8E620C0", VA = "0x188E636C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public XHDCJOGKBMU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8E67D40", Offset = "0x8E66740", VA = "0x188E67D40")]
			internal Vector3 MAXGPMKHUVJ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8E67D00", Offset = "0x8E66700", VA = "0x188E67D00")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public WKDHTAWVSFY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8E67B80", Offset = "0x8E66580", VA = "0x188E67B80")]
			internal Quaternion UQCFJKSEXYF()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8E67B50", Offset = "0x8E66550", VA = "0x188E67B50")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public FPTEFWBUXSU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8E625D0", Offset = "0x8E60FD0", VA = "0x188E625D0")]
			internal Vector3 KGLZQGILCPQ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8E62610", Offset = "0x8E61010", VA = "0x188E62610")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public PDQLYVSWNTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8E65A90", Offset = "0x8E64490", VA = "0x188E65A90")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public YJGILQXVTGT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8E67D80", Offset = "0x8E66780", VA = "0x188E67D80")]
			internal void QWVOBPYGTCY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8E67E90", Offset = "0x8E66890", VA = "0x188E67E90")]
			internal void QXAUYWSECOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8E67EE0", Offset = "0x8E668E0", VA = "0x188E67EE0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public IRBKOHUTDAO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8E62910", Offset = "0x8E61310", VA = "0x188E62910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8E629E0", Offset = "0x8E613E0", VA = "0x188E629E0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public MUXCGJYKJDG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8E63F50", Offset = "0x8E62950", VA = "0x188E63F50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8E642A0", Offset = "0x8E62CA0", VA = "0x188E642A0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E65390", Offset = "0x8E63D90", VA = "0x188E65390")]
		[UKOBXVXKPZF.Root]
		internal static void SKEBEIJGPGG(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8E65920", Offset = "0x8E64320", VA = "0x188E65920")]
		[UnityEngine.Scripting.Preserve]
		internal OVPVZCVCCXX([Inject(null)] SEPEWOFBWYL scheduler, [Inject(null)] MUGMONEUUMI schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8E644A0", Offset = "0x8E62EA0", VA = "0x188E644A0", Slot = "4")]
		public NBBOGJWUDYK DMXHIGXVLEI(Func<float> a, Action<float> b, float c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8E65830", Offset = "0x8E64230", VA = "0x188E65830", Slot = "5")]
		public NBBOGJWUDYK XSXTNVMHFPA(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8E64580", Offset = "0x8E62F80", VA = "0x188E64580", Slot = "6")]
		public NBBOGJWUDYK FEKAGNCQBJT(Func<Color> a, Action<Color> b, Color c, float d, QVSMERWFCGG.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8E64CB0", Offset = "0x8E636B0", VA = "0x188E64CB0", Slot = "7")]
		public NBBOGJWUDYK QGCTVXPUNQN(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8E642E0", Offset = "0x8E62CE0", VA = "0x188E642E0", Slot = "8")]
		public NBBOGJWUDYK AYYFLYOQEPJ(Transform a, Quaternion b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8E64670", Offset = "0x8E63070", VA = "0x188E64670", Slot = "9")]
		public NBBOGJWUDYK FIOVQZWASNQ(Transform a, Vector3 b, float c, QVSMERWFCGG.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8E65480", Offset = "0x8E63E80", VA = "0x188E65480", Slot = "10")]
		public NDXHNBMAEAE Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8E64990", Offset = "0x8E63390", VA = "0x188E64990", Slot = "11")]
		public void GCWQFYNAZNO(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8E64840", Offset = "0x8E63240", VA = "0x188E64840", Slot = "12")]
		public void GCWQFYNAZNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8E65560", Offset = "0x8E63F60", VA = "0x188E65560")]
		private void XOQALWFTSJY(Behaviour a, ZORRRSALXZF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8E654F0", Offset = "0x8E63EF0", VA = "0x188E654F0")]
		[IteratorStateMachine(typeof(MUXCGJYKJDG))]
		private IEnumerator<YTAMKWOJLST> WFFCUBGLSCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8E64FE0", Offset = "0x8E639E0", VA = "0x188E64FE0")]
		private void Run(Behaviour context, ZORRRSALXZF sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8E64C20", Offset = "0x8E63620", VA = "0x188E64C20")]
		[IteratorStateMachine(typeof(IRBKOHUTDAO))]
		private IEnumerator<YTAMKWOJLST> PHDIXPWYKMB(NACNJAZEVXK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8E64E80", Offset = "0x8E63880", VA = "0x188E64E80")]
		private void QGVJJQCICFX(ZORRRSALXZF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8E64B30", Offset = "0x8E63530", VA = "0x188E64B30")]
		private void NPGIOTBXKUC(ZORRRSALXZF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8E64840", Offset = "0x8E63240", VA = "0x188E64840")]
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
