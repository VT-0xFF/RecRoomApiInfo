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
		[Cpp2IlInjected.Address(RVA = "0xA51C300", Offset = "0xA51AD00", VA = "0x18A51C300", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class BKVLAUJMDGP
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
		public static class VJKXJQCQLQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5270", Offset = "0x2AC3C70", VA = "0x182AC5270")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA51A810", Offset = "0xA519210", VA = "0x18A51A810")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA51A7C0", Offset = "0xA5191C0", VA = "0x18A51A7C0")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class HMHUISHQRXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA5182A0", Offset = "0xA516CA0", VA = "0x18A5182A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA5182B0", Offset = "0xA516CB0", VA = "0x18A5182B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA518250", Offset = "0xA516C50", VA = "0x18A518250")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class RRMNZQANSCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA51A130", Offset = "0xA518B30", VA = "0x18A51A130")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA51A140", Offset = "0xA518B40", VA = "0x18A51A140")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA51A0D0", Offset = "0xA518AD0", VA = "0x18A51A0D0")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class RXRSQUTBWMR
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA51A1D0", Offset = "0xA518BD0", VA = "0x18A51A1D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA51A1F0", Offset = "0xA518BF0", VA = "0x18A51A1F0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA51A170", Offset = "0xA518B70", VA = "0x18A51A170")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA51A250", Offset = "0xA518C50", VA = "0x18A51A250")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA51A280", Offset = "0xA518C80", VA = "0x18A51A280")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA51A220", Offset = "0xA518C20", VA = "0x18A51A220")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA516B80", Offset = "0xA515580", VA = "0x18A516B80")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA516BD0", Offset = "0xA5155D0", VA = "0x18A516BD0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA516AC0", Offset = "0xA5154C0", VA = "0x18A516AC0")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class PWCYGGDMUQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA519D90", Offset = "0xA518790", VA = "0x18A519D90")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA519DF0", Offset = "0xA5187F0", VA = "0x18A519DF0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA519CE0", Offset = "0xA5186E0", VA = "0x18A519CE0")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class BBCNORFZOFT
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA515830", Offset = "0xA514230", VA = "0x18A515830")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA5158E0", Offset = "0xA5142E0", VA = "0x18A5158E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA515760", Offset = "0xA514160", VA = "0x18A515760")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float TVGLYEFVUSL;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float UNCKMJNUFZB;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA516530", Offset = "0xA514F30", VA = "0x18A516530")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA5165B0", Offset = "0xA514FB0", VA = "0x18A5165B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA516450", Offset = "0xA514E50", VA = "0x18A516450")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA5167B0", Offset = "0xA5151B0", VA = "0x18A5167B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA516880", Offset = "0xA515280", VA = "0x18A516880")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA516690", Offset = "0xA515090", VA = "0x18A516690")]
			public static float BACFEGVNTHR(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA5159A0", Offset = "0xA5143A0", VA = "0x18A5159A0")]
		public static float VIOIRPIPJXC(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class QSCSXCESRES : ILCKPZXANIS
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA519E20", Offset = "0xA518820", VA = "0x18A519E20")]
		public QSCSXCESRES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "13")]
		public override bool ZHGKRTYGLDW(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD62000", Offset = "0xD60A00", VA = "0x180D62000", Slot = "14")]
		public override float TOITVTQUHHE()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class CIEJVBOMYIZ : UWOTITHBYDT<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA516920", Offset = "0xA515320", VA = "0x18A516920")]
		public CIEJVBOMYIZ(Func<Color> a, Action<Color> b, Color c, float d, BKVLAUJMDGP.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF58170", Offset = "0xF56B70", VA = "0x180F58170", Slot = "15")]
		protected override Color GDWHBCUZZHW()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x997ACD0", Offset = "0x99796D0", VA = "0x18997ACD0", Slot = "16")]
		protected override Color DLBNHPNNTGN(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class HAMRHDQSMPG : UWOTITHBYDT<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA5181E0", Offset = "0xA516BE0", VA = "0x18A5181E0")]
		public HAMRHDQSMPG(Func<float> a, Action<float> b, float c, float d, BKVLAUJMDGP.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA518190", Offset = "0xA516B90", VA = "0x18A518190", Slot = "15")]
		protected override float GDWHBCUZZHW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA518170", Offset = "0xA516B70", VA = "0x18A518170", Slot = "16")]
		protected override float DLBNHPNNTGN(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class ILOYPLBKUDQ : UWOTITHBYDT<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA5186C0", Offset = "0xA5170C0", VA = "0x18A5186C0")]
		public ILOYPLBKUDQ(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, BKVLAUJMDGP.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA518500", Offset = "0xA516F00", VA = "0x18A518500", Slot = "15")]
		protected override Quaternion GDWHBCUZZHW()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA5184B0", Offset = "0xA516EB0", VA = "0x18A5184B0", Slot = "16")]
		protected override Quaternion DLBNHPNNTGN(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class AGMUQRVZOEC : UWOTITHBYDT<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5156C0", Offset = "0xA5140C0", VA = "0x18A5156C0")]
		public AGMUQRVZOEC(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, BKVLAUJMDGP.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA515620", Offset = "0xA514020", VA = "0x18A515620", Slot = "15")]
		protected override Vector3 GDWHBCUZZHW()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA50B030", Offset = "0xA509A30", VA = "0x18A50B030", Slot = "16")]
		protected override Vector3 DLBNHPNNTGN(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface OMZBMDMACIR
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action CUTDAVMGUCP;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OMZBMDMACIR KZZPXYEIHZI(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		OMZBMDMACIR HCUYPICVJMY(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		OMZBMDMACIR INKPBEHRBUF(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		LTBUWQFXCGW TTJFJZLVBWT();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ZHGKRTYGLDW(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float TOITVTQUHHE();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface WWYTPSMPURF : OMZBMDMACIR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ELMBBSGFHWB : OMZBMDMACIR
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ELMBBSGFHWB DJIXHLLXUVK(OMZBMDMACIR a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ELMBBSGFHWB DJIXHLLXUVK(Func<OMZBMDMACIR> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ELMBBSGFHWB QZKEAORHOCB(IEnumerable<OMZBMDMACIR> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ELMBBSGFHWB QZKEAORHOCB(params OMZBMDMACIR[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ELMBBSGFHWB EGXFAUZFDZC(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface FDGHTUHRLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WWYTPSMPURF TUKFELUMIYR(Func<float> a, Action<float> b, float c, float d, BKVLAUJMDGP.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WWYTPSMPURF EJOWFSQBCHJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, BKVLAUJMDGP.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		WWYTPSMPURF ZJZTGHWIQDO(Func<Color> a, Action<Color> b, Color c, float d, BKVLAUJMDGP.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		WWYTPSMPURF QLWMMDEQLVY(Transform a, Vector3 b, float c, BKVLAUJMDGP.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		WWYTPSMPURF HNEEAJLHBHI(Transform a, Quaternion b, float c, BKVLAUJMDGP.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		WWYTPSMPURF MLRLGMZFOMH(Transform a, Vector3 b, float c, BKVLAUJMDGP.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ELMBBSGFHWB Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LXPHPBYMXVB(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class GCSSTVWTVWR
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static OMZBMDMACIR QSCSXCESRES
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA5178B0", Offset = "0xA5162B0", VA = "0x18A5178B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA517DB0", Offset = "0xA5167B0", VA = "0x18A517DB0")]
		internal static FDGHTUHRLGP XJOQVYQSJWR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA517C70", Offset = "0xA516670", VA = "0x18A517C70")]
		public static WWYTPSMPURF TUKFELUMIYR(Func<float> a, Action<float> b, float c, float d, BKVLAUJMDGP.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA517610", Offset = "0xA516010", VA = "0x18A517610")]
		public static WWYTPSMPURF EJOWFSQBCHJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, BKVLAUJMDGP.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA517E20", Offset = "0xA516820", VA = "0x18A517E20")]
		public static WWYTPSMPURF ZJZTGHWIQDO(Func<Color> a, Action<Color> b, Color c, float d, BKVLAUJMDGP.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA517AB0", Offset = "0xA5164B0", VA = "0x18A517AB0")]
		public static WWYTPSMPURF QLWMMDEQLVY(Transform a, Vector3 b, float c, BKVLAUJMDGP.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA517770", Offset = "0xA516170", VA = "0x18A517770")]
		public static WWYTPSMPURF HNEEAJLHBHI(Transform a, Quaternion b, float c, BKVLAUJMDGP.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA5179E0", Offset = "0xA5163E0", VA = "0x18A5179E0")]
		public static WWYTPSMPURF MLRLGMZFOMH(Transform a, Vector3 b, float c, BKVLAUJMDGP.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA517B80", Offset = "0xA516580", VA = "0x18A517B80")]
		public static ELMBBSGFHWB Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA517900", Offset = "0xA516300", VA = "0x18A517900")]
		public static void LXPHPBYMXVB(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class FSXXEMXVQWQ : OMZBMDMACIR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action HMFRTWCEUER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action PLWZRKZVWKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> UOEVIFTRRFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> FALTXJKTEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> EMYGXJCULYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected ZJNBIUQLBKF NWEYXMFGTGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object ZYFESKEKZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool ZPTKDMTJCRC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool WUDZZTDYKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA517360", Offset = "0xA515D60", VA = "0x18A517360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool KRFCYIIVZMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA517420", Offset = "0xA515E20", VA = "0x18A517420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action CUTDAVMGUCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA517380", Offset = "0xA515D80", VA = "0x18A517380", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA517040", Offset = "0xA515A40", VA = "0x18A517040", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "9")]
		public LTBUWQFXCGW TTJFJZLVBWT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA5172A0", Offset = "0xA515CA0", VA = "0x18A5172A0", Slot = "6")]
		public OMZBMDMACIR KZZPXYEIHZI(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA516F40", Offset = "0xA515940", VA = "0x18A516F40", Slot = "7")]
		public OMZBMDMACIR HCUYPICVJMY(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA517210", Offset = "0xA515C10", VA = "0x18A517210", Slot = "8")]
		public OMZBMDMACIR INKPBEHRBUF(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool ZHGKRTYGLDW(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float TOITVTQUHHE();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA516DA0", Offset = "0xA5157A0", VA = "0x18A516DA0", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA5170E0", Offset = "0xA515AE0", VA = "0x18A5170E0")]
		protected void HYQMYSPSSVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA516C30", Offset = "0xA515630", VA = "0x18A516C30")]
		protected void BSSHXEOTRCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA517440", Offset = "0xA515E40", VA = "0x18A517440")]
		protected FSXXEMXVQWQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class GBZMKEDBULJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA517520", Offset = "0xA515F20", VA = "0x18A517520")]
		public static WWYTPSMPURF MLRLGMZFOMH(this Behaviour a, Vector3 b, float c, BKVLAUJMDGP.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class ILCKPZXANIS : FSXXEMXVQWQ, WWYTPSMPURF, OMZBMDMACIR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool UGQRUTTYYJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float EYNIIESDTNM;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected BKVLAUJMDGP.Functions FWJXVIZCEQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x103E5C0", Offset = "0x103CFC0", VA = "0x18103E5C0")]
			[CompilerGenerated]
			get
			{
				return default(BKVLAUJMDGP.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA5182F0", Offset = "0xA516CF0", VA = "0x18A5182F0")]
		protected ILCKPZXANIS(float a, BKVLAUJMDGP.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x299C850", Offset = "0x299B250", VA = "0x18299C850")]
		[CompilerGenerated]
		private void GWXTCRDPOWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA5182D0", Offset = "0xA516CD0", VA = "0x18A5182D0")]
		[CompilerGenerated]
		private void GXCZZXXMYHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class UWOTITHBYDT<a> : ILCKPZXANIS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> FWIGASNVTON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> EACEWAYWXAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a RMJOUWDFXOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float WHYMFLSQLTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a XVARBOMUVZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a RUFRWCLCEKU;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7D2DB20", Offset = "0x7D2C520", VA = "0x187D2DB20")]
		protected UWOTITHBYDT(Func<a> a, Action<a> b, a c, float d, BKVLAUJMDGP.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a GDWHBCUZZHW();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a DLBNHPNNTGN(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7D2D2B0", Offset = "0x7D2BCB0", VA = "0x187D2D2B0", Slot = "13")]
		public override bool ZHGKRTYGLDW(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D2CB50", Offset = "0x7D2B550", VA = "0x187D2CB50", Slot = "14")]
		public override float TOITVTQUHHE()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class INYDWRMGNKM : FSXXEMXVQWQ, ELMBBSGFHWB, OMZBMDMACIR
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
			private OMZBMDMACIR tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<OMZBMDMACIR> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA51A3C0", Offset = "0xA518DC0", VA = "0x18A51A3C0")]
			public TweenEntry(OMZBMDMACIR tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1DA9FF0", Offset = "0x1DA89F0", VA = "0x181DA9FF0")]
			public TweenEntry(Func<OMZBMDMACIR> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA51A2A0", Offset = "0xA518CA0", VA = "0x18A51A2A0")]
			public OMZBMDMACIR JDSYYIDCAQV()
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
		private readonly List<Step> OPQMYEWSVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int WTOVUOYNAEF;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA519770", Offset = "0xA518170", VA = "0x18A519770")]
		public INYDWRMGNKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA518760", Offset = "0xA517160", VA = "0x18A518760", Slot = "15")]
		public ELMBBSGFHWB DJIXHLLXUVK(OMZBMDMACIR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA518970", Offset = "0xA517370", VA = "0x18A518970", Slot = "16")]
		public ELMBBSGFHWB DJIXHLLXUVK(Func<OMZBMDMACIR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA519150", Offset = "0xA517B50", VA = "0x18A519150", Slot = "17")]
		public ELMBBSGFHWB QZKEAORHOCB(IEnumerable<OMZBMDMACIR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA5192A0", Offset = "0xA517CA0", VA = "0x18A5192A0", Slot = "18")]
		public ELMBBSGFHWB QZKEAORHOCB(params OMZBMDMACIR[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA518A30", Offset = "0xA517430", VA = "0x18A518A30", Slot = "19")]
		public ELMBBSGFHWB EGXFAUZFDZC(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA519660", Offset = "0xA518060", VA = "0x18A519660", Slot = "13")]
		public override bool ZHGKRTYGLDW(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA519540", Offset = "0xA517F40", VA = "0x18A519540", Slot = "14")]
		public override float TOITVTQUHHE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA518B40", Offset = "0xA517540", VA = "0x18A518B40")]
		private bool NWTCWTBJZJP(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA519420", Offset = "0xA517E20", VA = "0x18A519420")]
		private ELMBBSGFHWB QZKEAORHOCB(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x299C850", Offset = "0x299B250", VA = "0x18299C850")]
		[CompilerGenerated]
		private void GWXTCRDPOWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA5182D0", Offset = "0xA516CD0", VA = "0x18A5182D0")]
		[CompilerGenerated]
		private void GXCZZXXMYHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class WGAEJIXEEHS : FDGHTUHRLGP
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public FSXXEMXVQWQ Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class YMQNZVANQVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform DNQJNRFFLRB;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public YMQNZVANQVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA51C280", Offset = "0xA51AC80", VA = "0x18A51C280")]
			internal Vector3 GOIEUTLZAKI()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA51C2C0", Offset = "0xA51ACC0", VA = "0x18A51C2C0")]
			internal void GONLSAFWJVR(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class XPQTJHQZHON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform DNQJNRFFLRB;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XPQTJHQZHON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA51C210", Offset = "0xA51AC10", VA = "0x18A51C210")]
			internal Quaternion YYHLEBEFREE()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA51C250", Offset = "0xA51AC50", VA = "0x18A51C250")]
			internal void YYMSBHYDAPN(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class WKCSBNRRPGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform DNQJNRFFLRB;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKCSBNRRPGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA51C020", Offset = "0xA51AA20", VA = "0x18A51C020")]
			internal Vector3 NQYPXESQAKX()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA51BFE0", Offset = "0xA51A9E0", VA = "0x18A51BFE0")]
			internal void NQTIZXYSQZO(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class EAFIVIHKRYC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public FSXXEMXVQWQ QEVHPDAEBGZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public WGAEJIXEEHS TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour LTCUZYHUHUF;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EAFIVIHKRYC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA5169C0", Offset = "0xA5153C0", VA = "0x18A5169C0")]
			internal void LXWRCVXOSPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class XKNHXSJBZBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public WGAEJIXEEHS TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public FSXXEMXVQWQ GHPUANZLFGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public OVUANEJXOET YGRONSPFEHB;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XKNHXSJBZBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA51C0B0", Offset = "0xA51AAB0", VA = "0x18A51C0B0")]
			internal void IARLMYCFSDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA51C060", Offset = "0xA51AA60", VA = "0x18A51C060")]
			internal void IAMEPRIIIRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA51C1C0", Offset = "0xA51ABC0", VA = "0x18A51C1C0")]
			internal void IBBZHLQAKZX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class RKGKSCWNXYJ : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private OSEXMMYDSBS RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public OMZBMDMACIR QEVHPDAEBGZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public WGAEJIXEEHS TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private OSEXMMYDSBS XMCHSAEGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public RKGKSCWNXYJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA51A000", Offset = "0xA518A00", VA = "0x18A51A000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA519FC0", Offset = "0xA5189C0", VA = "0x18A519FC0", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class PRVDTCUKOLL : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private OSEXMMYDSBS RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public WGAEJIXEEHS TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private OSEXMMYDSBS XMCHSAEGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public PRVDTCUKOLL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA519990", Offset = "0xA518390", VA = "0x18A519990", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA519950", Offset = "0xA518350", VA = "0x18A519950", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly AQNWLBANTQG FTHBHRLZINB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly XORBCPHKNCD GITIRLPOLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> LLHJUOUNKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> BHDYKTOCBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<FSXXEMXVQWQ> WHRNBSPFZAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<FSXXEMXVQWQ>> HONWSSTWAUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool LHBSXXKSFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private OVUANEJXOET UZGIDJPYSRN;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA51A830", Offset = "0xA519230", VA = "0x18A51A830")]
		[BRMSZAJTATI.Root]
		internal static void BZJNQHTNBAL(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA51BE70", Offset = "0xA51A870", VA = "0x18A51BE70")]
		[UnityEngine.Scripting.Preserve]
		internal WGAEJIXEEHS([Inject(null)] AQNWLBANTQG scheduler, [Inject(null)] XORBCPHKNCD schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA51BCA0", Offset = "0xA51A6A0", VA = "0x18A51BCA0", Slot = "4")]
		public WWYTPSMPURF TUKFELUMIYR(Func<float> a, Action<float> b, float c, float d, BKVLAUJMDGP.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA51AE50", Offset = "0xA519850", VA = "0x18A51AE50", Slot = "5")]
		public WWYTPSMPURF EJOWFSQBCHJ(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, BKVLAUJMDGP.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA51BD80", Offset = "0xA51A780", VA = "0x18A51BD80", Slot = "6")]
		public WWYTPSMPURF ZJZTGHWIQDO(Func<Color> a, Action<Color> b, Color c, float d, BKVLAUJMDGP.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA51B6B0", Offset = "0xA51A0B0", VA = "0x18A51B6B0", Slot = "7")]
		public WWYTPSMPURF QLWMMDEQLVY(Transform a, Vector3 b, float c, BKVLAUJMDGP.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA51B030", Offset = "0xA519A30", VA = "0x18A51B030", Slot = "8")]
		public WWYTPSMPURF HNEEAJLHBHI(Transform a, Quaternion b, float c, BKVLAUJMDGP.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA51B4E0", Offset = "0xA519EE0", VA = "0x18A51B4E0", Slot = "9")]
		public WWYTPSMPURF MLRLGMZFOMH(Transform a, Vector3 b, float c, BKVLAUJMDGP.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA51BC30", Offset = "0xA51A630", VA = "0x18A51BC30", Slot = "10")]
		public ELMBBSGFHWB Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA51B340", Offset = "0xA519D40", VA = "0x18A51B340", Slot = "11")]
		public void LXPHPBYMXVB(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA51B1F0", Offset = "0xA519BF0", VA = "0x18A51B1F0", Slot = "12")]
		public void LXPHPBYMXVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA51AB80", Offset = "0xA519580", VA = "0x18A51AB80")]
		private void DNPHLLIUZJL(Behaviour a, FSXXEMXVQWQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA51A920", Offset = "0xA519320", VA = "0x18A51A920")]
		[IteratorStateMachine(typeof(PRVDTCUKOLL))]
		private IEnumerator<OSEXMMYDSBS> DCZIGDPCPZI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA51B880", Offset = "0xA51A280", VA = "0x18A51B880")]
		private void Run(Behaviour context, FSXXEMXVQWQ sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA51A990", Offset = "0xA519390", VA = "0x18A51A990")]
		[IteratorStateMachine(typeof(RKGKSCWNXYJ))]
		private IEnumerator<OSEXMMYDSBS> DGRMUBYWVAQ(OMZBMDMACIR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA51AA20", Offset = "0xA519420", VA = "0x18A51AA20")]
		private void DJIXHLLXUVK(FSXXEMXVQWQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA51AF40", Offset = "0xA519940", VA = "0x18A51AF40")]
		private void FLVKTUDLAPX(FSXXEMXVQWQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA51B1F0", Offset = "0xA519BF0", VA = "0x18A51B1F0")]
		private void SSNBVFQMBYM(Scene a, LoadSceneMode b)
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
