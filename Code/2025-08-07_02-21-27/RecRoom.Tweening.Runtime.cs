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
		[Cpp2IlInjected.Address(RVA = "0x95768C0", Offset = "0x95754C0", VA = "0x1895768C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IMVKQQIYIQY
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
		public static class DHTRUXYXWLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2CD73E0", Offset = "0x2CD5FE0", VA = "0x182CD73E0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9570410", Offset = "0x956F010", VA = "0x189570410")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9570430", Offset = "0x956F030", VA = "0x189570430")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class KOGQUNTNKEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9573800", Offset = "0x9572400", VA = "0x189573800")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9573810", Offset = "0x9572410", VA = "0x189573810")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9573830", Offset = "0x9572430", VA = "0x189573830")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class MYQAHFUBCPC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9573AC0", Offset = "0x95726C0", VA = "0x189573AC0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9573AD0", Offset = "0x95726D0", VA = "0x189573AD0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9573B00", Offset = "0x9572700", VA = "0x189573B00")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class NPCUIOABMIE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9574CA0", Offset = "0x95738A0", VA = "0x189574CA0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9574CC0", Offset = "0x95738C0", VA = "0x189574CC0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9574CF0", Offset = "0x95738F0", VA = "0x189574CF0")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9574D50", Offset = "0x9573950", VA = "0x189574D50")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9574D80", Offset = "0x9573980", VA = "0x189574D80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9574DA0", Offset = "0x95739A0", VA = "0x189574DA0")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9570480", Offset = "0x956F080", VA = "0x189570480")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x95704D0", Offset = "0x956F0D0", VA = "0x1895704D0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9570530", Offset = "0x956F130", VA = "0x189570530")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class JDQNYZQJRHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x95736C0", Offset = "0x95722C0", VA = "0x1895736C0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9573720", Offset = "0x9572320", VA = "0x189573720")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9573750", Offset = "0x9572350", VA = "0x189573750")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class HOWOXYRLEEY
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9572950", Offset = "0x9571550", VA = "0x189572950")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9572A00", Offset = "0x9571600", VA = "0x189572A00")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9572AC0", Offset = "0x95716C0", VA = "0x189572AC0")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float HYBRGVPMGAK;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float RBTDPDMYUVO;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x956FD90", Offset = "0x956E990", VA = "0x18956FD90")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x956FE10", Offset = "0x956EA10", VA = "0x18956FE10")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x956FEA0", Offset = "0x956EAA0", VA = "0x18956FEA0")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x956FFD0", Offset = "0x956EBD0", VA = "0x18956FFD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x95700A0", Offset = "0x956ECA0", VA = "0x1895700A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9570140", Offset = "0x956ED40", VA = "0x189570140")]
			public static float QPGNGFJVFMO(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9572C10", Offset = "0x9571810", VA = "0x189572C10")]
		public static float EWLBDMMSTEL(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class YWZXOURMRSV : MFKBRCCMWTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x95766C0", Offset = "0x95752C0", VA = "0x1895766C0")]
		public YWZXOURMRSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "13")]
		public override bool VHTHDILNRYB(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB64500", Offset = "0xB63100", VA = "0x180B64500", Slot = "14")]
		public override float GSQABSNEOGN()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class XTJXJLFTPHM : LPYIEOKAIMU<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9576620", Offset = "0x9575220", VA = "0x189576620")]
		public XTJXJLFTPHM(Func<Color> a, Action<Color> b, Color c, float d, IMVKQQIYIQY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x142A4C0", Offset = "0x14290C0", VA = "0x18142A4C0", Slot = "15")]
		protected override Color XRPCHUQMDXR()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89B5F70", Offset = "0x89B4B70", VA = "0x1889B5F70", Slot = "16")]
		protected override Color WZLZVIIQJIM(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ARCNIHRLEOP : LPYIEOKAIMU<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x956FD20", Offset = "0x956E920", VA = "0x18956FD20")]
		public ARCNIHRLEOP(Func<float> a, Action<float> b, float c, float d, IMVKQQIYIQY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x956FCD0", Offset = "0x956E8D0", VA = "0x18956FCD0", Slot = "15")]
		protected override float XRPCHUQMDXR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x956FCB0", Offset = "0x956E8B0", VA = "0x18956FCB0", Slot = "16")]
		protected override float WZLZVIIQJIM(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class TETFQJXJQWD : LPYIEOKAIMU<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9574FE0", Offset = "0x9573BE0", VA = "0x189574FE0")]
		public TETFQJXJQWD(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, IMVKQQIYIQY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9574E20", Offset = "0x9573A20", VA = "0x189574E20", Slot = "15")]
		protected override Quaternion XRPCHUQMDXR()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9574DD0", Offset = "0x95739D0", VA = "0x189574DD0", Slot = "16")]
		protected override Quaternion WZLZVIIQJIM(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class VBGOVGFTNON : LPYIEOKAIMU<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9576100", Offset = "0x9574D00", VA = "0x189576100")]
		public VBGOVGFTNON(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IMVKQQIYIQY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9576060", Offset = "0x9574C60", VA = "0x189576060", Slot = "15")]
		protected override Vector3 XRPCHUQMDXR()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9575FF0", Offset = "0x9574BF0", VA = "0x189575FF0", Slot = "16")]
		protected override Vector3 WZLZVIIQJIM(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface PSWYBKIWRHU
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action DMDREZVJBRM;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PSWYBKIWRHU VQZPCEMYQSV(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PSWYBKIWRHU CBGYLRVNQUV(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		PSWYBKIWRHU SMBEVDFUIYE(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ZPYKPRNSTIB HXCCTMNVROS();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool VHTHDILNRYB(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float GSQABSNEOGN();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface OUIBCSUVLSI : PSWYBKIWRHU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface RLNCCLDPVTY : PSWYBKIWRHU
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RLNCCLDPVTY IQRXWWEOODN(PSWYBKIWRHU a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RLNCCLDPVTY IQRXWWEOODN(Func<PSWYBKIWRHU> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RLNCCLDPVTY DRCWOLJFNCQ(IEnumerable<PSWYBKIWRHU> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RLNCCLDPVTY DRCWOLJFNCQ(params PSWYBKIWRHU[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RLNCCLDPVTY AMGALQHNGTV(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DOLBXMQBSSS
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OUIBCSUVLSI CGOOZMHIWDY(Func<float> a, Action<float> b, float c, float d, IMVKQQIYIQY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OUIBCSUVLSI PQVGKQOGEDK(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IMVKQQIYIQY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OUIBCSUVLSI FOEMYVTJTHZ(Func<Color> a, Action<Color> b, Color c, float d, IMVKQQIYIQY.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		OUIBCSUVLSI ALKDJTFXCXR(Transform a, Vector3 b, float c, IMVKQQIYIQY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		OUIBCSUVLSI HKGEKFUZJGR(Transform a, Quaternion b, float c, IMVKQQIYIQY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		OUIBCSUVLSI GFVBLMMGNTS(Transform a, Vector3 b, float c, IMVKQQIYIQY.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RLNCCLDPVTY Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void MRNQWMZSOYG(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class HCBASSIHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static PSWYBKIWRHU YWZXOURMRSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9572460", Offset = "0x9571060", VA = "0x189572460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9571EB0", Offset = "0x9570AB0", VA = "0x189571EB0")]
		internal static DOLBXMQBSSS AHIAETVHJOS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9571FF0", Offset = "0x9570BF0", VA = "0x189571FF0")]
		public static OUIBCSUVLSI CGOOZMHIWDY(Func<float> a, Action<float> b, float c, float d, IMVKQQIYIQY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x95725A0", Offset = "0x95711A0", VA = "0x1895725A0")]
		public static OUIBCSUVLSI PQVGKQOGEDK(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IMVKQQIYIQY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9572120", Offset = "0x9570D20", VA = "0x189572120")]
		public static OUIBCSUVLSI FOEMYVTJTHZ(Func<Color> a, Action<Color> b, Color c, float d, IMVKQQIYIQY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9571F20", Offset = "0x9570B20", VA = "0x189571F20")]
		public static OUIBCSUVLSI ALKDJTFXCXR(Transform a, Vector3 b, float c, IMVKQQIYIQY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9572330", Offset = "0x9570F30", VA = "0x189572330")]
		public static OUIBCSUVLSI HKGEKFUZJGR(Transform a, Quaternion b, float c, IMVKQQIYIQY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9572260", Offset = "0x9570E60", VA = "0x189572260")]
		public static OUIBCSUVLSI GFVBLMMGNTS(Transform a, Vector3 b, float c, IMVKQQIYIQY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9572700", Offset = "0x9571300", VA = "0x189572700")]
		public static RLNCCLDPVTY Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x95724B0", Offset = "0x95710B0", VA = "0x1895724B0")]
		public static void MRNQWMZSOYG(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class TTDCHEPGPIN : PSWYBKIWRHU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action GRBHWVJZWLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action HEPXNNOJNUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> OGZXHECLWOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> OXKABXOPHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> LTOEHAYUQJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected QHMKGAGJHZG CUISEVBXVQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object MNOZMKLYXSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool LDFABXYUUJF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool EBCNOXUAERQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9575190", Offset = "0x9573D90", VA = "0x189575190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool JZXUPAMYITE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9575690", Offset = "0x9574290", VA = "0x189575690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action DMDREZVJBRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9575850", Offset = "0x9574450", VA = "0x189575850", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9575480", Offset = "0x9574080", VA = "0x189575480", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "9")]
		public ZPYKPRNSTIB HXCCTMNVROS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x95757A0", Offset = "0x95743A0", VA = "0x1895757A0", Slot = "6")]
		public PSWYBKIWRHU VQZPCEMYQSV(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9575080", Offset = "0x9573C80", VA = "0x189575080", Slot = "7")]
		public PSWYBKIWRHU CBGYLRVNQUV(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x95756B0", Offset = "0x95742B0", VA = "0x1895756B0", Slot = "8")]
		public PSWYBKIWRHU SMBEVDFUIYE(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool VHTHDILNRYB(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float GSQABSNEOGN();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x95751B0", Offset = "0x9573DB0", VA = "0x1895751B0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9575350", Offset = "0x9573F50", VA = "0x189575350")]
		protected void EHSPUGVVZRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9575520", Offset = "0x9574120", VA = "0x189575520")]
		protected void JADSOETMOZX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x95758F0", Offset = "0x95744F0", VA = "0x1895758F0")]
		protected TTDCHEPGPIN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ZZYOFHYCXHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x95767D0", Offset = "0x95753D0", VA = "0x1895767D0")]
		public static OUIBCSUVLSI GFVBLMMGNTS(this Behaviour a, Vector3 b, float c, IMVKQQIYIQY.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class MFKBRCCMWTR : TTDCHEPGPIN, OUIBCSUVLSI, PSWYBKIWRHU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool HIRZICLJBCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float GEQVKKZYQOB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected IMVKQQIYIQY.Functions WNQODSUIKIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB6E220", Offset = "0xB6CE20", VA = "0x180B6E220")]
			[CompilerGenerated]
			get
			{
				return default(IMVKQQIYIQY.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x95739B0", Offset = "0x95725B0", VA = "0x1895739B0")]
		protected MFKBRCCMWTR(float a, IMVKQQIYIQY.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC669C0", Offset = "0xC655C0", VA = "0x180C669C0")]
		[CompilerGenerated]
		private void LSKOBINUMMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9573990", Offset = "0x9572590", VA = "0x189573990")]
		[CompilerGenerated]
		private void LSFHEBTXDAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class LPYIEOKAIMU<a> : MFKBRCCMWTR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> TTUJSIVHIXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> CECJIZCGLIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a ZHLENRMIBNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float PDAIETMKFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a NNRWGZKDBWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a WTDJMAQLFTJ;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x59D4F80", Offset = "0x59D3B80", VA = "0x1859D4F80")]
		protected LPYIEOKAIMU(Func<a> a, Action<a> b, a c, float d, IMVKQQIYIQY.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a XRPCHUQMDXR();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a WZLZVIIQJIM(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x59D42C0", Offset = "0x59D2EC0", VA = "0x1859D42C0", Slot = "13")]
		public override bool VHTHDILNRYB(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x59D3E90", Offset = "0x59D2A90", VA = "0x1859D3E90", Slot = "14")]
		public override float GSQABSNEOGN()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class MZYDTAQBHPH : TTDCHEPGPIN, RLNCCLDPVTY, PSWYBKIWRHU
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
			private PSWYBKIWRHU tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<PSWYBKIWRHU> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9575BF0", Offset = "0x95747F0", VA = "0x189575BF0")]
			public TweenEntry(PSWYBKIWRHU tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2031100", Offset = "0x202FD00", VA = "0x182031100")]
			public TweenEntry(Func<PSWYBKIWRHU> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9575AD0", Offset = "0x95746D0", VA = "0x189575AD0")]
			public PSWYBKIWRHU HPTSXWFTUWO()
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
		private readonly List<Step> DPVMQQGEEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int HYJKCFEEWJG;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9574B60", Offset = "0x9573760", VA = "0x189574B60")]
		public MZYDTAQBHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9574840", Offset = "0x9573440", VA = "0x189574840", Slot = "15")]
		public RLNCCLDPVTY IQRXWWEOODN(PSWYBKIWRHU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9574780", Offset = "0x9573380", VA = "0x189574780", Slot = "16")]
		public RLNCCLDPVTY IQRXWWEOODN(Func<PSWYBKIWRHU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9573C70", Offset = "0x9572870", VA = "0x189573C70", Slot = "17")]
		public RLNCCLDPVTY DRCWOLJFNCQ(IEnumerable<PSWYBKIWRHU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9573DC0", Offset = "0x95729C0", VA = "0x189573DC0", Slot = "18")]
		public RLNCCLDPVTY DRCWOLJFNCQ(params PSWYBKIWRHU[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9573B60", Offset = "0x9572760", VA = "0x189573B60", Slot = "19")]
		public RLNCCLDPVTY AMGALQHNGTV(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9574A50", Offset = "0x9573650", VA = "0x189574A50", Slot = "13")]
		public override bool VHTHDILNRYB(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9574660", Offset = "0x9573260", VA = "0x189574660", Slot = "14")]
		public override float GSQABSNEOGN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9574050", Offset = "0x9572C50", VA = "0x189574050")]
		private bool FHLSTIEZUEY(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9573F40", Offset = "0x9572B40", VA = "0x189573F40")]
		private RLNCCLDPVTY DRCWOLJFNCQ(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC669C0", Offset = "0xC655C0", VA = "0x180C669C0")]
		[CompilerGenerated]
		private void LSKOBINUMMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9573990", Offset = "0x9572590", VA = "0x189573990")]
		[CompilerGenerated]
		private void LSFHEBTXDAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class GBRNXALMXYD : DOLBXMQBSSS
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public TTDCHEPGPIN Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class XLYSDAWRGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform YOPTNJQVXIE;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XLYSDAWRGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9576570", Offset = "0x9575170", VA = "0x189576570")]
			internal Vector3 WFNROZIDWNX()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9576530", Offset = "0x9575130", VA = "0x189576530")]
			internal void WFIKRSOGNCO(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class XPNAWOTYTOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform YOPTNJQVXIE;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XPNAWOTYTOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x95765E0", Offset = "0x95751E0", VA = "0x1895765E0")]
			internal Quaternion OGOTZKFXZRF()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x95765B0", Offset = "0x95751B0", VA = "0x1895765B0")]
			internal void OGJNCDMAQFW(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class IJBAKJDOGSK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform YOPTNJQVXIE;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IJBAKJDOGSK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9572B90", Offset = "0x9571790", VA = "0x189572B90")]
			internal Vector3 BRMDCLSRPQU()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9572BD0", Offset = "0x95717D0", VA = "0x189572BD0")]
			internal void BRRJZSMOZCD(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class TZPDHATRBYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public TTDCHEPGPIN VACOWVGWIHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public GBRNXALMXYD VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour KEBYUPXJULG;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TZPDHATRBYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x95759D0", Offset = "0x95745D0", VA = "0x1895759D0")]
			internal void YMWIPMMVDHW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class CLOJKKCVFXH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public GBRNXALMXYD VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public TTDCHEPGPIN VBFCXQVUCHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public GEUHFRHGIWS RXORLNVKNWC;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CLOJKKCVFXH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x95702B0", Offset = "0x956EEB0", VA = "0x1895702B0")]
			internal void HJZPPMASNVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x95703C0", Offset = "0x956EFC0", VA = "0x1895703C0")]
			internal void HKEWMSUPXGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9570260", Offset = "0x956EE60", VA = "0x189570260")]
			internal void HJPBUYMXUYI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class KQQGGNBVBNG : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public PSWYBKIWRHU VACOWVGWIHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public GBRNXALMXYD VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public KQQGGNBVBNG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9573880", Offset = "0x9572480", VA = "0x189573880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9573950", Offset = "0x9572550", VA = "0x189573950", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class VTVQNHVDZXA : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public GBRNXALMXYD VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public VTVQNHVDZXA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x95761A0", Offset = "0x9574DA0", VA = "0x1895761A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x95764F0", Offset = "0x95750F0", VA = "0x1895764F0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly PABQSBFBGZX LVOZVQMMXRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly PDLRKGLSCHQ CUAVQIGNOZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> SOMEKSAKFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> ZEYQKDVFWMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<TTDCHEPGPIN> WACYNOVHUBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<TTDCHEPGPIN>> QZZMMUAEVID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool UCWBSNBCBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private GEUHFRHGIWS YOTBYIJBKGA;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x95710D0", Offset = "0x956FCD0", VA = "0x1895710D0")]
		[IFIZWETSKCB.Root]
		internal static void KQEBINAABYI(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9571D40", Offset = "0x9570940", VA = "0x189571D40")]
		[UnityEngine.Scripting.Preserve]
		internal GBRNXALMXYD([Inject(null)] PABQSBFBGZX scheduler, [Inject(null)] PDLRKGLSCHQ schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9570850", Offset = "0x956F450", VA = "0x189570850", Slot = "4")]
		public OUIBCSUVLSI CGOOZMHIWDY(Func<float> a, Action<float> b, float c, float d, IMVKQQIYIQY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9571620", Offset = "0x9570220", VA = "0x189571620", Slot = "5")]
		public OUIBCSUVLSI PQVGKQOGEDK(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IMVKQQIYIQY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x95709A0", Offset = "0x956F5A0", VA = "0x1895709A0", Slot = "6")]
		public OUIBCSUVLSI FOEMYVTJTHZ(Func<Color> a, Action<Color> b, Color c, float d, IMVKQQIYIQY.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x95705F0", Offset = "0x956F1F0", VA = "0x1895705F0", Slot = "7")]
		public OUIBCSUVLSI ALKDJTFXCXR(Transform a, Vector3 b, float c, IMVKQQIYIQY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9570DB0", Offset = "0x956F9B0", VA = "0x189570DB0", Slot = "8")]
		public OUIBCSUVLSI HKGEKFUZJGR(Transform a, Quaternion b, float c, IMVKQQIYIQY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9570A90", Offset = "0x956F690", VA = "0x189570A90", Slot = "9")]
		public OUIBCSUVLSI GFVBLMMGNTS(Transform a, Vector3 b, float c, IMVKQQIYIQY.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9571AC0", Offset = "0x95706C0", VA = "0x189571AC0", Slot = "10")]
		public RLNCCLDPVTY Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9571480", Offset = "0x9570080", VA = "0x189571480", Slot = "11")]
		public void MRNQWMZSOYG(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9570C60", Offset = "0x956F860", VA = "0x189570C60", Slot = "12")]
		public void MRNQWMZSOYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x95711C0", Offset = "0x956FDC0", VA = "0x1895711C0")]
		private void LYKWEKFLMEI(Behaviour a, TTDCHEPGPIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9570930", Offset = "0x956F530", VA = "0x189570930")]
		[IteratorStateMachine(typeof(VTVQNHVDZXA))]
		private IEnumerator<UGECMBPSTCZ> DQMQKZZNYGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9571710", Offset = "0x9570310", VA = "0x189571710")]
		private void Run(Behaviour context, TTDCHEPGPIN sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x95707C0", Offset = "0x956F3C0", VA = "0x1895707C0")]
		[IteratorStateMachine(typeof(KQQGGNBVBNG))]
		private IEnumerator<UGECMBPSTCZ> BJUBPZHZWCT(PSWYBKIWRHU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9570F70", Offset = "0x956FB70", VA = "0x189570F70")]
		private void IQRXWWEOODN(TTDCHEPGPIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9571C50", Offset = "0x9570850", VA = "0x189571C50")]
		private void TYLRYLDQBGU(TTDCHEPGPIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9570C60", Offset = "0x956F860", VA = "0x189570C60")]
		private void GLZSLQHFRCF(Scene a, LoadSceneMode b)
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
