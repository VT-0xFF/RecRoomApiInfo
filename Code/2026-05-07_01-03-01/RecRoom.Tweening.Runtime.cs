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
		[Cpp2IlInjected.Address(RVA = "0xA38FCA0", Offset = "0xA38E6A0", VA = "0x18A38FCA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F5EA0", Offset = "0x29F48A0", VA = "0x1829F5EA0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class HIUUMHNYSHL
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
		public static class IFEKJTJMKLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D2B0", Offset = "0x2A8BCB0", VA = "0x182A8D2B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA38C5B0", Offset = "0xA38AFB0", VA = "0x18A38C5B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA38C560", Offset = "0xA38AF60", VA = "0x18A38C560")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class VWDSFSVBWZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA38F080", Offset = "0xA38DA80", VA = "0x18A38F080")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA38F0E0", Offset = "0xA38DAE0", VA = "0x18A38F0E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA38F090", Offset = "0xA38DA90", VA = "0x18A38F090")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class OXHOMJNAQOD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA38E180", Offset = "0xA38CB80", VA = "0x18A38E180")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA38E1F0", Offset = "0xA38CBF0", VA = "0x18A38E1F0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA38E190", Offset = "0xA38CB90", VA = "0x18A38E190")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class BCVQUFNTUJR
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA389BB0", Offset = "0xA3885B0", VA = "0x18A389BB0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA389C30", Offset = "0xA388630", VA = "0x18A389C30")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA389BD0", Offset = "0xA3885D0", VA = "0x18A389BD0")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA38E7A0", Offset = "0xA38D1A0", VA = "0x18A38E7A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA38E800", Offset = "0xA38D200", VA = "0x18A38E800")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA38E7D0", Offset = "0xA38D1D0", VA = "0x18A38E7D0")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA38A460", Offset = "0xA388E60", VA = "0x18A38A460")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA38A570", Offset = "0xA388F70", VA = "0x18A38A570")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA38A4B0", Offset = "0xA388EB0", VA = "0x18A38A4B0")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class ASTZLAHUQON
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA389120", Offset = "0xA387B20", VA = "0x18A389120")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA389230", Offset = "0xA387C30", VA = "0x18A389230")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA389180", Offset = "0xA387B80", VA = "0x18A389180")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class PLNRKYHCQEP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA38E220", Offset = "0xA38CC20", VA = "0x18A38E220")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA38E3A0", Offset = "0xA38CDA0", VA = "0x18A38E3A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA38E2D0", Offset = "0xA38CCD0", VA = "0x18A38E2D0")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float GUIGHZQEUXP;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float KJNNTJNDPQB;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA389C60", Offset = "0xA388660", VA = "0x18A389C60")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA389DC0", Offset = "0xA3887C0", VA = "0x18A389DC0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA389CE0", Offset = "0xA3886E0", VA = "0x18A389CE0")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA389EA0", Offset = "0xA3888A0", VA = "0x18A389EA0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA38A090", Offset = "0xA388A90", VA = "0x18A38A090")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA389F70", Offset = "0xA388970", VA = "0x18A389F70")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA38A960", Offset = "0xA389360", VA = "0x18A38A960")]
		public static float AOYBNYPMGSS(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class VGTOMPSAYPO : XEQQULJINRC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA38EF70", Offset = "0xA38D970", VA = "0x18A38EF70")]
		public VGTOMPSAYPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "13")]
		public override bool SLGPFWXGSXA(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD21EE0", Offset = "0xD208E0", VA = "0x180D21EE0", Slot = "14")]
		public override float DWKQHQKJXQQ()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class QFKKBLPTOKT : HZONXEXTIXF<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA38E460", Offset = "0xA38CE60", VA = "0x18A38E460")]
		public QFKKBLPTOKT(Func<Color> a, Action<Color> b, Color c, float d, HIUUMHNYSHL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF1ECD0", Offset = "0xF1D6D0", VA = "0x180F1ECD0", Slot = "15")]
		protected override Color BMZEOZXUPSW()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x97ED6C0", Offset = "0x97EC0C0", VA = "0x1897ED6C0", Slot = "16")]
		protected override Color ZOXIHPOGJKL(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class NWIOLOEDDVU : HZONXEXTIXF<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA38E000", Offset = "0xA38CA00", VA = "0x18A38E000")]
		public NWIOLOEDDVU(Func<float> a, Action<float> b, float c, float d, HIUUMHNYSHL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA38DF90", Offset = "0xA38C990", VA = "0x18A38DF90", Slot = "15")]
		protected override float BMZEOZXUPSW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA38DFE0", Offset = "0xA38C9E0", VA = "0x18A38DFE0", Slot = "16")]
		protected override float ZOXIHPOGJKL(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class EPKJKZYMEZO : HZONXEXTIXF<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA38A3C0", Offset = "0xA388DC0", VA = "0x18A38A3C0")]
		public EPKJKZYMEZO(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, HIUUMHNYSHL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA38A1B0", Offset = "0xA388BB0", VA = "0x18A38A1B0", Slot = "15")]
		protected override Quaternion BMZEOZXUPSW()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA38A370", Offset = "0xA388D70", VA = "0x18A38A370", Slot = "16")]
		protected override Quaternion ZOXIHPOGJKL(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class VFPTFQYLMWQ : HZONXEXTIXF<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA38EED0", Offset = "0xA38D8D0", VA = "0x18A38EED0")]
		public VFPTFQYLMWQ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, HIUUMHNYSHL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA38EE30", Offset = "0xA38D830", VA = "0x18A38EE30", Slot = "15")]
		protected override Vector3 BMZEOZXUPSW()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA37DD40", Offset = "0xA37C740", VA = "0x18A37DD40", Slot = "16")]
		protected override Vector3 ZOXIHPOGJKL(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface NQMMKODNGZV
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action LZTNTMMIMHX;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NQMMKODNGZV RTBSELKRNNS(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NQMMKODNGZV SGGELPTWYVQ(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NQMMKODNGZV XMPGEDJDZNN(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		NXPIPFBMDQY CTZMMSFIPBH();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool SLGPFWXGSXA(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float DWKQHQKJXQQ();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface GQDZNWRMBCF : NQMMKODNGZV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface GYVJNJPTPCD : NQMMKODNGZV
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GYVJNJPTPCD PQLCSKTCCOG(NQMMKODNGZV a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GYVJNJPTPCD PQLCSKTCCOG(Func<NQMMKODNGZV> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GYVJNJPTPCD DIBEBFVALUH(IEnumerable<NQMMKODNGZV> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GYVJNJPTPCD DIBEBFVALUH(params NQMMKODNGZV[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GYVJNJPTPCD VLKTMEZIYGS(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface GCHWDXADGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GQDZNWRMBCF UXPBWOWRKNF(Func<float> a, Action<float> b, float c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GQDZNWRMBCF EQJBCTEFAWF(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GQDZNWRMBCF MLPWNEPLJUO(Func<Color> a, Action<Color> b, Color c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GQDZNWRMBCF TUZRDDHEDMU(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GQDZNWRMBCF FLKSLFDKZIM(Transform a, Quaternion b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GQDZNWRMBCF POSDMJWJLPT(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		GYVJNJPTPCD Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void UWDIYJACREJ(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class WISSJDQBCOH
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static NQMMKODNGZV VGTOMPSAYPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA38F9E0", Offset = "0xA38E3E0", VA = "0x18A38F9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA38F100", Offset = "0xA38DB00", VA = "0x18A38F100")]
		internal static GCHWDXADGBP DODVAYLOFEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA38F8B0", Offset = "0xA38E2B0", VA = "0x18A38F8B0")]
		public static GQDZNWRMBCF UXPBWOWRKNF(Func<float> a, Action<float> b, float c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA38F170", Offset = "0xA38DB70", VA = "0x18A38F170")]
		public static GQDZNWRMBCF EQJBCTEFAWF(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA38F400", Offset = "0xA38DE00", VA = "0x18A38F400")]
		public static GQDZNWRMBCF MLPWNEPLJUO(Func<Color> a, Action<Color> b, Color c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA38F700", Offset = "0xA38E100", VA = "0x18A38F700")]
		public static GQDZNWRMBCF TUZRDDHEDMU(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA38F2D0", Offset = "0xA38DCD0", VA = "0x18A38F2D0")]
		public static GQDZNWRMBCF FLKSLFDKZIM(Transform a, Quaternion b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA38F540", Offset = "0xA38DF40", VA = "0x18A38F540")]
		public static GQDZNWRMBCF POSDMJWJLPT(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA38F610", Offset = "0xA38E010", VA = "0x18A38F610")]
		public static GYVJNJPTPCD Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA38F7D0", Offset = "0xA38E1D0", VA = "0x18A38F7D0")]
		public static void UWDIYJACREJ(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class ATTFFUJKCVE : NQMMKODNGZV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action ISBJWURAWRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action UWDCUMVEREL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> RKQLFVBEDWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> TCLVWGJHUOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> OAZAYPZWRKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected ILTXAVTAZAX MRDAKWBRKMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object KGDUMRCNBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool NXPVOJMMEPE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool WBXCCURDJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA389530", Offset = "0xA387F30", VA = "0x18A389530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool OEDHLMOSWBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA3899C0", Offset = "0xA3883C0", VA = "0x18A3899C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action LZTNTMMIMHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA3895F0", Offset = "0xA387FF0", VA = "0x18A3895F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA389550", Offset = "0xA387F50", VA = "0x18A389550", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260", Slot = "9")]
		public NXPIPFBMDQY CTZMMSFIPBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA389690", Offset = "0xA388090", VA = "0x18A389690", Slot = "6")]
		public NQMMKODNGZV RTBSELKRNNS(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA389740", Offset = "0xA388140", VA = "0x18A389740", Slot = "7")]
		public NQMMKODNGZV SGGELPTWYVQ(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA3899E0", Offset = "0xA3883E0", VA = "0x18A3899E0", Slot = "8")]
		public NQMMKODNGZV XMPGEDJDZNN(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool SLGPFWXGSXA(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float DWKQHQKJXQQ();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA389390", Offset = "0xA387D90", VA = "0x18A389390", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA389260", Offset = "0xA387C60", VA = "0x18A389260")]
		protected void CAXRTBNXGHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA389850", Offset = "0xA388250", VA = "0x18A389850")]
		protected void WSQJBAIUKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA389AD0", Offset = "0xA3884D0", VA = "0x18A389AD0")]
		protected ATTFFUJKCVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class RJSODNRHDQB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA38E500", Offset = "0xA38CF00", VA = "0x18A38E500")]
		public static GQDZNWRMBCF POSDMJWJLPT(this Behaviour a, Vector3 b, float c, HIUUMHNYSHL.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class XEQQULJINRC : ATTFFUJKCVE, GQDZNWRMBCF, NQMMKODNGZV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool SUNJILEASNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float USSTVRVIIKY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected HIUUMHNYSHL.Functions OIUFZVYPHXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1001CF0", Offset = "0x10006F0", VA = "0x181001CF0")]
			[CompilerGenerated]
			get
			{
				return default(HIUUMHNYSHL.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA38FB90", Offset = "0xA38E590", VA = "0x18A38FB90")]
		protected XEQQULJINRC(float a, HIUUMHNYSHL.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2964040", Offset = "0x2962A40", VA = "0x182964040")]
		[CompilerGenerated]
		private void OLJDULFAKKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA38B910", Offset = "0xA38A310", VA = "0x18A38B910")]
		[CompilerGenerated]
		private void OLOKRRYXTWF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class HZONXEXTIXF<a> : XEQQULJINRC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> LQIKMAAHQKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> JRZEEFCRAUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a RSPIUEEEWRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float DGJUACMALNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a SLBAWWFVIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a JGSZPOIPWSC;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x654A130", Offset = "0x6548B30", VA = "0x18654A130")]
		protected HZONXEXTIXF(Func<a> a, Action<a> b, a c, float d, HIUUMHNYSHL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a BMZEOZXUPSW();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a ZOXIHPOGJKL(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6549710", Offset = "0x6548110", VA = "0x186549710", Slot = "13")]
		public override bool SLGPFWXGSXA(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x65491A0", Offset = "0x6547BA0", VA = "0x1865491A0", Slot = "14")]
		public override float DWKQHQKJXQQ()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class HRPHNPLCBWS : ATTFFUJKCVE, GYVJNJPTPCD, NQMMKODNGZV
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
			private NQMMKODNGZV tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<NQMMKODNGZV> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA38E9C0", Offset = "0xA38D3C0", VA = "0x18A38E9C0")]
			public TweenEntry(NQMMKODNGZV tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D6D610", Offset = "0x1D6C010", VA = "0x181D6D610")]
			public TweenEntry(Func<NQMMKODNGZV> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA38E8A0", Offset = "0xA38D2A0", VA = "0x18A38E8A0")]
			public NQMMKODNGZV WWNWRNJTBGH()
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
		private readonly List<Step> XWKUNAWDZOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int AFKQMHRPZEX;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA38C420", Offset = "0xA38AE20", VA = "0x18A38C420")]
		public HRPHNPLCBWS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA38B930", Offset = "0xA38A330", VA = "0x18A38B930", Slot = "15")]
		public GYVJNJPTPCD PQLCSKTCCOG(NQMMKODNGZV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA38BB40", Offset = "0xA38A540", VA = "0x18A38BB40", Slot = "16")]
		public GYVJNJPTPCD PQLCSKTCCOG(Func<NQMMKODNGZV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA38B520", Offset = "0xA389F20", VA = "0x18A38B520", Slot = "17")]
		public GYVJNJPTPCD DIBEBFVALUH(IEnumerable<NQMMKODNGZV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA38B670", Offset = "0xA38A070", VA = "0x18A38B670", Slot = "18")]
		public GYVJNJPTPCD DIBEBFVALUH(params NQMMKODNGZV[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA38C310", Offset = "0xA38AD10", VA = "0x18A38C310", Slot = "19")]
		public GYVJNJPTPCD VLKTMEZIYGS(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA38C200", Offset = "0xA38AC00", VA = "0x18A38C200", Slot = "13")]
		public override bool SLGPFWXGSXA(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA38B7F0", Offset = "0xA38A1F0", VA = "0x18A38B7F0", Slot = "14")]
		public override float DWKQHQKJXQQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA38BC00", Offset = "0xA38A600", VA = "0x18A38BC00")]
		private bool SDEIIHHKBYX(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA38B410", Offset = "0xA389E10", VA = "0x18A38B410")]
		private GYVJNJPTPCD DIBEBFVALUH(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2964040", Offset = "0x2962A40", VA = "0x182964040")]
		[CompilerGenerated]
		private void OLJDULFAKKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA38B910", Offset = "0xA38A310", VA = "0x18A38B910")]
		[CompilerGenerated]
		private void OLOKRRYXTWF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class MOWLFFPCFPM : GCHWDXADGBP
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public ATTFFUJKCVE Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class TLBQOBCWRUV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform GQSPRKBSOJL;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public TLBQOBCWRUV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA38E820", Offset = "0xA38D220", VA = "0x18A38E820")]
			internal Vector3 NNDPWNIVXGO()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA38E860", Offset = "0xA38D260", VA = "0x18A38E860")]
			internal void NNIWTUCTGRX(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class UONXUWZERAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform GQSPRKBSOJL;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public UONXUWZERAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA38EDC0", Offset = "0xA38D7C0", VA = "0x18A38EDC0")]
			internal Quaternion QLVSYSRJLEK()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA38EE00", Offset = "0xA38D800", VA = "0x18A38EE00")]
			internal void QMAZVZLGUPT(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class DBTOPYTYXQB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform GQSPRKBSOJL;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public DBTOPYTYXQB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA38A170", Offset = "0xA388B70", VA = "0x18A38A170")]
			internal Vector3 VYWTYXZJVAF()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA38A130", Offset = "0xA388B30", VA = "0x18A38A130")]
			internal void VYRNBRFMLOW(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class JVZGIHOIAUE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public ATTFFUJKCVE ROLWAOKCNSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public MOWLFFPCFPM AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour VCAJEJENTLV;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JVZGIHOIAUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA38C5D0", Offset = "0xA38AFD0", VA = "0x18A38C5D0")]
			internal void XMRQGDVONHR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class SBAZLBMLJQO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public MOWLFFPCFPM AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public ATTFFUJKCVE QDQAPZTJNOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AMGSXYCAQOJ FPEOXNZBWXH;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public SBAZLBMLJQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA38E690", Offset = "0xA38D090", VA = "0x18A38E690")]
			internal void XQMXCDEAANL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA38E640", Offset = "0xA38D040", VA = "0x18A38E640")]
			internal void XQHQEWKCRCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA38E5F0", Offset = "0xA38CFF0", VA = "0x18A38E5F0")]
			internal void XQCJHPQFHQT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class NXEEZGBWRYH : IEnumerator<PESYKSMCDNI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private PESYKSMCDNI AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public NQMMKODNGZV ROLWAOKCNSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public MOWLFFPCFPM AFKVCRAYCVS;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private PESYKSMCDNI TPPDVWBUFIZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public NXEEZGBWRYH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA38E070", Offset = "0xA38CA70", VA = "0x18A38E070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA38E140", Offset = "0xA38CB40", VA = "0x18A38E140", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class FLOOHOXIDYL : IEnumerator<PESYKSMCDNI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private PESYKSMCDNI AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public MOWLFFPCFPM AFKVCRAYCVS;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private PESYKSMCDNI TPPDVWBUFIZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public FLOOHOXIDYL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA38A5D0", Offset = "0xA388FD0", VA = "0x18A38A5D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA38A920", Offset = "0xA389320", VA = "0x18A38A920", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HIVJVEKFYXO KYNXOFCTFQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly BNFWNHVDKGB JDADJWZURNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> PCHMQLAKPTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> CSRCRHMFEUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<ATTFFUJKCVE> CRLOVQWOAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<ATTFFUJKCVE>> MFSRILQXCGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool NTFGNJMOEQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private AMGSXYCAQOJ AMVJTWJBHLT;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA38C6D0", Offset = "0xA38B0D0", VA = "0x18A38C6D0")]
		[ONTQUCAGRJW.Root]
		internal static void BREYGLPBXMV(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA38DE20", Offset = "0xA38C820", VA = "0x18A38DE20")]
		[UnityEngine.Scripting.Preserve]
		internal MOWLFFPCFPM([Inject(null)] HIVJVEKFYXO scheduler, [Inject(null)] BNFWNHVDKGB schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA38DCB0", Offset = "0xA38C6B0", VA = "0x18A38DCB0", Slot = "4")]
		public GQDZNWRMBCF UXPBWOWRKNF(Func<float> a, Action<float> b, float c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA38C7C0", Offset = "0xA38B1C0", VA = "0x18A38C7C0", Slot = "5")]
		public GQDZNWRMBCF EQJBCTEFAWF(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA38CAE0", Offset = "0xA38B4E0", VA = "0x18A38CAE0", Slot = "6")]
		public GQDZNWRMBCF MLPWNEPLJUO(Func<Color> a, Action<Color> b, Color c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA38D940", Offset = "0xA38C340", VA = "0x18A38D940", Slot = "7")]
		public GQDZNWRMBCF TUZRDDHEDMU(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA38C8B0", Offset = "0xA38B2B0", VA = "0x18A38C8B0", Slot = "8")]
		public GQDZNWRMBCF FLKSLFDKZIM(Transform a, Quaternion b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA38CE10", Offset = "0xA38B810", VA = "0x18A38CE10", Slot = "9")]
		public GQDZNWRMBCF POSDMJWJLPT(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA38D4F0", Offset = "0xA38BEF0", VA = "0x18A38D4F0", Slot = "10")]
		public GYVJNJPTPCD Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA38DB10", Offset = "0xA38C510", VA = "0x18A38DB10", Slot = "11")]
		public void UWDIYJACREJ(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA38CCC0", Offset = "0xA38B6C0", VA = "0x18A38CCC0", Slot = "12")]
		public void UWDIYJACREJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA38D680", Offset = "0xA38C080", VA = "0x18A38D680")]
		private void TJBXNVCLFRF(Behaviour a, ATTFFUJKCVE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA38CA70", Offset = "0xA38B470", VA = "0x18A38CA70")]
		[IteratorStateMachine(typeof(FLOOHOXIDYL))]
		private IEnumerator<PESYKSMCDNI> JVEKFJUBJDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA38D140", Offset = "0xA38BB40", VA = "0x18A38D140")]
		private void Run(Behaviour context, ATTFFUJKCVE sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA38DD90", Offset = "0xA38C790", VA = "0x18A38DD90")]
		[IteratorStateMachine(typeof(NXEEZGBWRYH))]
		private IEnumerator<PESYKSMCDNI> YGYLQKGJFQS(NQMMKODNGZV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA38CFE0", Offset = "0xA38B9E0", VA = "0x18A38CFE0")]
		private void PQLCSKTCCOG(ATTFFUJKCVE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA38CBD0", Offset = "0xA38B5D0", VA = "0x18A38CBD0")]
		private void NLDRRJNLIKH(ATTFFUJKCVE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA38CCC0", Offset = "0xA38B6C0", VA = "0x18A38CCC0")]
		private void POFIXPVZJTQ(Scene a, LoadSceneMode b)
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
