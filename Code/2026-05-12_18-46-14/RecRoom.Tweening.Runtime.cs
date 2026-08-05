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
		[Cpp2IlInjected.Address(RVA = "0xA4E5D00", Offset = "0xA4E4700", VA = "0x18A4E5D00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A16AE0", Offset = "0x2A154E0", VA = "0x182A16AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AAD2B0", Offset = "0x2AABCB0", VA = "0x182AAD2B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2540", Offset = "0xA4E0F40", VA = "0x18A4E2540")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA4E24F0", Offset = "0xA4E0EF0", VA = "0x18A4E24F0")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class VWDSFSVBWZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4F80", Offset = "0xA4E3980", VA = "0x18A4E4F80")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4FE0", Offset = "0xA4E39E0", VA = "0x18A4E4FE0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4F90", Offset = "0xA4E3990", VA = "0x18A4E4F90")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class OXHOMJNAQOD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4000", Offset = "0xA4E2A00", VA = "0x18A4E4000")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4070", Offset = "0xA4E2A70", VA = "0x18A4E4070")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4010", Offset = "0xA4E2A10", VA = "0x18A4E4010")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class BCVQUFNTUJR
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFAE0", Offset = "0xA4DE4E0", VA = "0x18A4DFAE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFB60", Offset = "0xA4DE560", VA = "0x18A4DFB60")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFB00", Offset = "0xA4DE500", VA = "0x18A4DFB00")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4620", Offset = "0xA4E3020", VA = "0x18A4E4620")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4680", Offset = "0xA4E3080", VA = "0x18A4E4680")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4650", Offset = "0xA4E3050", VA = "0x18A4E4650")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0370", Offset = "0xA4DED70", VA = "0x18A4E0370")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0480", Offset = "0xA4DEE80", VA = "0x18A4E0480")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA4E03C0", Offset = "0xA4DEDC0", VA = "0x18A4E03C0")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class ASTZLAHUQON
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF0B0", Offset = "0xA4DDAB0", VA = "0x18A4DF0B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF1C0", Offset = "0xA4DDBC0", VA = "0x18A4DF1C0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF110", Offset = "0xA4DDB10", VA = "0x18A4DF110")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class PLNRKYHCQEP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E40A0", Offset = "0xA4E2AA0", VA = "0x18A4E40A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4220", Offset = "0xA4E2C20", VA = "0x18A4E4220")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4150", Offset = "0xA4E2B50", VA = "0x18A4E4150")]
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
			[Cpp2IlInjected.Address(RVA = "0xA4DFB90", Offset = "0xA4DE590", VA = "0x18A4DFB90")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFCE0", Offset = "0xA4DE6E0", VA = "0x18A4DFCE0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFC00", Offset = "0xA4DE600", VA = "0x18A4DFC00")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFDB0", Offset = "0xA4DE7B0", VA = "0x18A4DFDB0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFFA0", Offset = "0xA4DE9A0", VA = "0x18A4DFFA0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFE80", Offset = "0xA4DE880", VA = "0x18A4DFE80")]
			public static float LVEDYBZXKDP(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA4E0870", Offset = "0xA4DF270", VA = "0x18A4E0870")]
		public static float AOYBNYPMGSS(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class VGTOMPSAYPO : XEQQULJINRC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4DE0", Offset = "0xA4E37E0", VA = "0x18A4E4DE0")]
		public VGTOMPSAYPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "13")]
		public override bool SLGPFWXGSXA(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD5B420", Offset = "0xD59E20", VA = "0x180D5B420", Slot = "14")]
		public override float DWKQHQKJXQQ()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class QFKKBLPTOKT : HZONXEXTIXF<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA4E42E0", Offset = "0xA4E2CE0", VA = "0x18A4E42E0")]
		public QFKKBLPTOKT(Func<Color> a, Action<Color> b, Color c, float d, HIUUMHNYSHL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF4B7C0", Offset = "0xF4A1C0", VA = "0x180F4B7C0", Slot = "15")]
		protected override Color BMZEOZXUPSW()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9951FA0", Offset = "0x99509A0", VA = "0x189951FA0", Slot = "16")]
		protected override Color ZOXIHPOGJKL(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class NWIOLOEDDVU : HZONXEXTIXF<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3E80", Offset = "0xA4E2880", VA = "0x18A4E3E80")]
		public NWIOLOEDDVU(Func<float> a, Action<float> b, float c, float d, HIUUMHNYSHL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3E10", Offset = "0xA4E2810", VA = "0x18A4E3E10", Slot = "15")]
		protected override float BMZEOZXUPSW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3E60", Offset = "0xA4E2860", VA = "0x18A4E3E60", Slot = "16")]
		protected override float ZOXIHPOGJKL(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class EPKJKZYMEZO : HZONXEXTIXF<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E02D0", Offset = "0xA4DECD0", VA = "0x18A4E02D0")]
		public EPKJKZYMEZO(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, HIUUMHNYSHL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E00C0", Offset = "0xA4DEAC0", VA = "0x18A4E00C0", Slot = "15")]
		protected override Quaternion BMZEOZXUPSW()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E0280", Offset = "0xA4DEC80", VA = "0x18A4E0280", Slot = "16")]
		protected override Quaternion ZOXIHPOGJKL(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class VFPTFQYLMWQ : HZONXEXTIXF<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4D40", Offset = "0xA4E3740", VA = "0x18A4E4D40")]
		public VFPTFQYLMWQ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, HIUUMHNYSHL.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4CA0", Offset = "0xA4E36A0", VA = "0x18A4E4CA0", Slot = "15")]
		protected override Vector3 BMZEOZXUPSW()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3D60", Offset = "0xA4D2760", VA = "0x18A4D3D60", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xA4E58F0", Offset = "0xA4E42F0", VA = "0x18A4E58F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5000", Offset = "0xA4E3A00", VA = "0x18A4E5000")]
		internal static GCHWDXADGBP DODVAYLOFEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E57C0", Offset = "0xA4E41C0", VA = "0x18A4E57C0")]
		public static GQDZNWRMBCF UXPBWOWRKNF(Func<float> a, Action<float> b, float c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5070", Offset = "0xA4E3A70", VA = "0x18A4E5070")]
		public static GQDZNWRMBCF EQJBCTEFAWF(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5300", Offset = "0xA4E3D00", VA = "0x18A4E5300")]
		public static GQDZNWRMBCF MLPWNEPLJUO(Func<Color> a, Action<Color> b, Color c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5600", Offset = "0xA4E4000", VA = "0x18A4E5600")]
		public static GQDZNWRMBCF TUZRDDHEDMU(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E51D0", Offset = "0xA4E3BD0", VA = "0x18A4E51D0")]
		public static GQDZNWRMBCF FLKSLFDKZIM(Transform a, Quaternion b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5440", Offset = "0xA4E3E40", VA = "0x18A4E5440")]
		public static GQDZNWRMBCF POSDMJWJLPT(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5510", Offset = "0xA4E3F10", VA = "0x18A4E5510")]
		public static GYVJNJPTPCD Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4E56D0", Offset = "0xA4E40D0", VA = "0x18A4E56D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA4DF4C0", Offset = "0xA4DDEC0", VA = "0x18A4DF4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool OEDHLMOSWBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF950", Offset = "0xA4DE350", VA = "0x18A4DF950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action LZTNTMMIMHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF580", Offset = "0xA4DDF80", VA = "0x18A4DF580", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF4E0", Offset = "0xA4DDEE0", VA = "0x18A4DF4E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD14260", Offset = "0xD12C60", VA = "0x180D14260", Slot = "9")]
		public NXPIPFBMDQY CTZMMSFIPBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF620", Offset = "0xA4DE020", VA = "0x18A4DF620", Slot = "6")]
		public NQMMKODNGZV RTBSELKRNNS(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF6E0", Offset = "0xA4DE0E0", VA = "0x18A4DF6E0", Slot = "7")]
		public NQMMKODNGZV SGGELPTWYVQ(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF970", Offset = "0xA4DE370", VA = "0x18A4DF970", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4DF320", Offset = "0xA4DDD20", VA = "0x18A4DF320", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF1F0", Offset = "0xA4DDBF0", VA = "0x18A4DF1F0")]
		protected void CAXRTBNXGHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF7E0", Offset = "0xA4DE1E0", VA = "0x18A4DF7E0")]
		protected void WSQJBAIUKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA4DFA00", Offset = "0xA4DE400", VA = "0x18A4DFA00")]
		protected ATTFFUJKCVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class RJSODNRHDQB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4380", Offset = "0xA4E2D80", VA = "0x18A4E4380")]
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
			[Cpp2IlInjected.Address(RVA = "0x10434E0", Offset = "0x1041EE0", VA = "0x1810434E0")]
			[CompilerGenerated]
			get
			{
				return default(HIUUMHNYSHL.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5B40", Offset = "0xA4E4540", VA = "0x18A4E5B40")]
		protected XEQQULJINRC(float a, HIUUMHNYSHL.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2985B40", Offset = "0x2984540", VA = "0x182985B40")]
		[CompilerGenerated]
		private void OLJDULFAKKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1800", Offset = "0xA4E0200", VA = "0x18A4E1800")]
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
		[Cpp2IlInjected.Address(RVA = "0x65EBE00", Offset = "0x65EA800", VA = "0x1865EBE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x65EB390", Offset = "0x65E9D90", VA = "0x1865EB390", Slot = "13")]
		public override bool SLGPFWXGSXA(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x65EAE20", Offset = "0x65E9820", VA = "0x1865EAE20", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0xA4E4840", Offset = "0xA4E3240", VA = "0x18A4E4840")]
			public TweenEntry(NQMMKODNGZV tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D97510", Offset = "0x1D95F10", VA = "0x181D97510")]
			public TweenEntry(Func<NQMMKODNGZV> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4720", Offset = "0xA4E3120", VA = "0x18A4E4720")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4E2310", Offset = "0xA4E0D10", VA = "0x18A4E2310")]
		public HRPHNPLCBWS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1820", Offset = "0xA4E0220", VA = "0x18A4E1820", Slot = "15")]
		public GYVJNJPTPCD PQLCSKTCCOG(NQMMKODNGZV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1A20", Offset = "0xA4E0420", VA = "0x18A4E1A20", Slot = "16")]
		public GYVJNJPTPCD PQLCSKTCCOG(Func<NQMMKODNGZV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1430", Offset = "0xA4DFE30", VA = "0x18A4E1430", Slot = "17")]
		public GYVJNJPTPCD DIBEBFVALUH(IEnumerable<NQMMKODNGZV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1580", Offset = "0xA4DFF80", VA = "0x18A4E1580", Slot = "18")]
		public GYVJNJPTPCD DIBEBFVALUH(params NQMMKODNGZV[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2200", Offset = "0xA4E0C00", VA = "0x18A4E2200", Slot = "19")]
		public GYVJNJPTPCD VLKTMEZIYGS(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA4E20F0", Offset = "0xA4E0AF0", VA = "0x18A4E20F0", Slot = "13")]
		public override bool SLGPFWXGSXA(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA4E16F0", Offset = "0xA4E00F0", VA = "0x18A4E16F0", Slot = "14")]
		public override float DWKQHQKJXQQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1AE0", Offset = "0xA4E04E0", VA = "0x18A4E1AE0")]
		private bool SDEIIHHKBYX(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1310", Offset = "0xA4DFD10", VA = "0x18A4E1310")]
		private GYVJNJPTPCD DIBEBFVALUH(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2985B40", Offset = "0x2984540", VA = "0x182985B40")]
		[CompilerGenerated]
		private void OLJDULFAKKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1800", Offset = "0xA4E0200", VA = "0x18A4E1800")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public TLBQOBCWRUV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA4E46A0", Offset = "0xA4E30A0", VA = "0x18A4E46A0")]
			internal Vector3 NNDPWNIVXGO()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA4E46E0", Offset = "0xA4E30E0", VA = "0x18A4E46E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public UONXUWZERAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C30", Offset = "0xA4E3630", VA = "0x18A4E4C30")]
			internal Quaternion QLVSYSRJLEK()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C70", Offset = "0xA4E3670", VA = "0x18A4E4C70")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public DBTOPYTYXQB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0080", Offset = "0xA4DEA80", VA = "0x18A4E0080")]
			internal Vector3 VYWTYXZJVAF()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0040", Offset = "0xA4DEA40", VA = "0x18A4E0040")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JVZGIHOIAUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2560", Offset = "0xA4E0F60", VA = "0x18A4E2560")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public SBAZLBMLJQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4510", Offset = "0xA4E2F10", VA = "0x18A4E4510")]
			internal void XQMXCDEAANL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA4E44C0", Offset = "0xA4E2EC0", VA = "0x18A4E44C0")]
			internal void XQHQEWKCRCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4470", Offset = "0xA4E2E70", VA = "0x18A4E4470")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
			[DebuggerHidden]
			public NXEEZGBWRYH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA4E3EF0", Offset = "0xA4E28F0", VA = "0x18A4E3EF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA4E3FC0", Offset = "0xA4E29C0", VA = "0x18A4E3FC0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
			[DebuggerHidden]
			public FLOOHOXIDYL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA4E04E0", Offset = "0xA4DEEE0", VA = "0x18A4E04E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0830", Offset = "0xA4DF230", VA = "0x18A4E0830", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4E2660", Offset = "0xA4E1060", VA = "0x18A4E2660")]
		[ONTQUCAGRJW.Root]
		internal static void BREYGLPBXMV(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3CA0", Offset = "0xA4E26A0", VA = "0x18A4E3CA0")]
		[UnityEngine.Scripting.Preserve]
		internal MOWLFFPCFPM([Inject(null)] HIVJVEKFYXO scheduler, [Inject(null)] BNFWNHVDKGB schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3B30", Offset = "0xA4E2530", VA = "0x18A4E3B30", Slot = "4")]
		public GQDZNWRMBCF UXPBWOWRKNF(Func<float> a, Action<float> b, float c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2750", Offset = "0xA4E1150", VA = "0x18A4E2750", Slot = "5")]
		public GQDZNWRMBCF EQJBCTEFAWF(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2A70", Offset = "0xA4E1470", VA = "0x18A4E2A70", Slot = "6")]
		public GQDZNWRMBCF MLPWNEPLJUO(Func<Color> a, Action<Color> b, Color c, float d, HIUUMHNYSHL.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA4E37C0", Offset = "0xA4E21C0", VA = "0x18A4E37C0", Slot = "7")]
		public GQDZNWRMBCF TUZRDDHEDMU(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2840", Offset = "0xA4E1240", VA = "0x18A4E2840", Slot = "8")]
		public GQDZNWRMBCF FLKSLFDKZIM(Transform a, Quaternion b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2DA0", Offset = "0xA4E17A0", VA = "0x18A4E2DA0", Slot = "9")]
		public GQDZNWRMBCF POSDMJWJLPT(Transform a, Vector3 b, float c, HIUUMHNYSHL.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3480", Offset = "0xA4E1E80", VA = "0x18A4E3480", Slot = "10")]
		public GYVJNJPTPCD Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3990", Offset = "0xA4E2390", VA = "0x18A4E3990", Slot = "11")]
		public void UWDIYJACREJ(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2C50", Offset = "0xA4E1650", VA = "0x18A4E2C50", Slot = "12")]
		public void UWDIYJACREJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E34F0", Offset = "0xA4E1EF0", VA = "0x18A4E34F0")]
		private void TJBXNVCLFRF(Behaviour a, ATTFFUJKCVE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2A00", Offset = "0xA4E1400", VA = "0x18A4E2A00")]
		[IteratorStateMachine(typeof(FLOOHOXIDYL))]
		private IEnumerator<PESYKSMCDNI> JVEKFJUBJDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E30D0", Offset = "0xA4E1AD0", VA = "0x18A4E30D0")]
		private void Run(Behaviour context, ATTFFUJKCVE sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3C10", Offset = "0xA4E2610", VA = "0x18A4E3C10")]
		[IteratorStateMachine(typeof(NXEEZGBWRYH))]
		private IEnumerator<PESYKSMCDNI> YGYLQKGJFQS(NQMMKODNGZV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2F70", Offset = "0xA4E1970", VA = "0x18A4E2F70")]
		private void PQLCSKTCCOG(ATTFFUJKCVE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2B60", Offset = "0xA4E1560", VA = "0x18A4E2B60")]
		private void NLDRRJNLIKH(ATTFFUJKCVE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2C50", Offset = "0xA4E1650", VA = "0x18A4E2C50")]
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
