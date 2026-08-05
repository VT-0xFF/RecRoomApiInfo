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
		[Cpp2IlInjected.Address(RVA = "0x8E2C630", Offset = "0x8E2AE30", VA = "0x188E2C630", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B9F0", VA = "0x18275D1F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IXPPQXJZKQK
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
		public static class MTZSIKXAAKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x27F38F0", Offset = "0x27F20F0", VA = "0x1827F38F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8E294E0", Offset = "0x8E27CE0", VA = "0x188E294E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8E29490", Offset = "0x8E27C90", VA = "0x188E29490")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class PYSFJUQMGWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8E29990", Offset = "0x8E28190", VA = "0x188E29990")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8E299F0", Offset = "0x8E281F0", VA = "0x188E299F0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8E299A0", Offset = "0x8E281A0", VA = "0x188E299A0")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class BUMCKCXNEWW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8E25F40", Offset = "0x8E24740", VA = "0x188E25F40")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8E25FB0", Offset = "0x8E247B0", VA = "0x188E25FB0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8E25F50", Offset = "0x8E24750", VA = "0x188E25F50")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class AKKGENXLNCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8E25B00", Offset = "0x8E24300", VA = "0x188E25B00")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8E25B80", Offset = "0x8E24380", VA = "0x188E25B80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8E25B20", Offset = "0x8E24320", VA = "0x188E25B20")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B350", Offset = "0x8E29B50", VA = "0x188E2B350")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B3B0", Offset = "0x8E29BB0", VA = "0x188E2B3B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B380", Offset = "0x8E29B80", VA = "0x188E2B380")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8E27910", Offset = "0x8E26110", VA = "0x188E27910")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8E27A20", Offset = "0x8E26220", VA = "0x188E27A20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8E27960", Offset = "0x8E26160", VA = "0x188E27960")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class TFENRKZGKSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B3D0", Offset = "0x8E29BD0", VA = "0x188E2B3D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B4E0", Offset = "0x8E29CE0", VA = "0x188E2B4E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B430", Offset = "0x8E29C30", VA = "0x188E2B430")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class JUUNBZJSURI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8E28790", Offset = "0x8E26F90", VA = "0x188E28790")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8E28910", Offset = "0x8E27110", VA = "0x188E28910")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8E28840", Offset = "0x8E27040", VA = "0x188E28840")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float UHTZBEZXSUQ;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float FVPXZQQSBIK;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8E25FE0", Offset = "0x8E247E0", VA = "0x188E25FE0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8E26130", Offset = "0x8E24930", VA = "0x188E26130")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8E26050", Offset = "0x8E24850", VA = "0x188E26050")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8E26200", Offset = "0x8E24A00", VA = "0x188E26200")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8E263F0", Offset = "0x8E24BF0", VA = "0x188E263F0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8E262D0", Offset = "0x8E24AD0", VA = "0x188E262D0")]
			public static float JWILXGTESYU(float a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E27BE0", Offset = "0x8E263E0", VA = "0x188E27BE0")]
		public static float COHZSAIPIDT(float a, Functions b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class JALKTEVZKZJ : VFGRNQZGBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E28680", Offset = "0x8E26E80", VA = "0x188E28680")]
		public JALKTEVZKZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "13")]
		public override bool VJXRKSUTUIL(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAFCE40", Offset = "0xAFB640", VA = "0x180AFCE40", Slot = "14")]
		public override float XLUIABUPKEP()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class DTCIQPKZYKI : YAYYHKZYBAC<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E27760", Offset = "0x8E25F60", VA = "0x188E27760")]
		public DTCIQPKZYKI(Func<Color> a, Action<Color> b, Color c, float d, IXPPQXJZKQK.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCA0600", Offset = "0xC9EE00", VA = "0x180CA0600", Slot = "15")]
		protected override Color TQANQUMMDCZ()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82BE310", Offset = "0x82BCB10", VA = "0x1882BE310", Slot = "16")]
		protected override Color RRYNQNGXZZI(Color a, Color b, float c)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class MXWXEBJQNAF : YAYYHKZYBAC<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E29570", Offset = "0x8E27D70", VA = "0x188E29570")]
		public MXWXEBJQNAF(Func<float> a, Action<float> b, float c, float d, IXPPQXJZKQK.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E29520", Offset = "0x8E27D20", VA = "0x188E29520", Slot = "15")]
		protected override float TQANQUMMDCZ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E29500", Offset = "0x8E27D00", VA = "0x188E29500", Slot = "16")]
		protected override float RRYNQNGXZZI(float a, float b, float c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class PCDLHWTQAPD : YAYYHKZYBAC<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E298F0", Offset = "0x8E280F0", VA = "0x188E298F0")]
		public PCDLHWTQAPD(Func<Quaternion> a, Action<Quaternion> b, Quaternion c, float d, IXPPQXJZKQK.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8E29730", Offset = "0x8E27F30", VA = "0x188E29730", Slot = "15")]
		protected override Quaternion TQANQUMMDCZ()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E296E0", Offset = "0x8E27EE0", VA = "0x188E296E0", Slot = "16")]
		protected override Quaternion RRYNQNGXZZI(Quaternion a, Quaternion b, float c)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ZULTVRUJVRR : YAYYHKZYBAC<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8E2C590", Offset = "0x8E2AD90", VA = "0x188E2C590")]
		public ZULTVRUJVRR(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IXPPQXJZKQK.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E2C4F0", Offset = "0x8E2ACF0", VA = "0x188E2C4F0", Slot = "15")]
		protected override Vector3 TQANQUMMDCZ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8E2C480", Offset = "0x8E2AC80", VA = "0x188E2C480", Slot = "16")]
		protected override Vector3 RRYNQNGXZZI(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ZIWRBALFLYI
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action WRENXAYWXIY;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ZIWRBALFLYI LKLWBBNIAAD(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ZIWRBALFLYI YGOYFDFMFBN(Action a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZIWRBALFLYI ZOMRYOWEMXA(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		QNKHPYUXYMH XVWSRSMSNGU();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool VJXRKSUTUIL(float a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float XLUIABUPKEP();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface QYMFECPGEHI : ZIWRBALFLYI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ZSVVNGRRUKQ : ZIWRBALFLYI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZSVVNGRRUKQ PWKTNMJKOLT(ZIWRBALFLYI a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ZSVVNGRRUKQ PWKTNMJKOLT(Func<ZIWRBALFLYI> a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ZSVVNGRRUKQ XILEXTSQYVM(IEnumerable<ZIWRBALFLYI> a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ZSVVNGRRUKQ XILEXTSQYVM(params ZIWRBALFLYI[] tweens);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZSVVNGRRUKQ CYWPUPIABMV(float a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ELPSJSDQYWU
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		QYMFECPGEHI XJOXHFYXXQI(Func<float> a, Action<float> b, float c, float d, IXPPQXJZKQK.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		QYMFECPGEHI LTQPKNCVMZI(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IXPPQXJZKQK.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QYMFECPGEHI QBOAHDMXKVX(Func<Color> a, Action<Color> b, Color c, float d, IXPPQXJZKQK.Functions e, [Optional] Behaviour f);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		QYMFECPGEHI RQABNBKVRWB(Transform a, Vector3 b, float c, IXPPQXJZKQK.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		QYMFECPGEHI WXSWMSKMOMH(Transform a, Quaternion b, float c, IXPPQXJZKQK.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		QYMFECPGEHI UOYWOHSAVUW(Transform a, Vector3 b, float c, IXPPQXJZKQK.Functions d, [Optional] Behaviour e);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ZSVVNGRRUKQ Sequence([Optional] Behaviour context);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void BVPLVJLGZJO(UnityEngine.Object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class LLWKTEDAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ZIWRBALFLYI JALKTEVZKZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8E292E0", Offset = "0x8E27AE0", VA = "0x188E292E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E28FF0", Offset = "0x8E277F0", VA = "0x188E28FF0")]
		internal static ELPSJSDQYWU VKUMPSHYSAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8E291A0", Offset = "0x8E279A0", VA = "0x188E291A0")]
		public static QYMFECPGEHI XJOXHFYXXQI(Func<float> a, Action<float> b, float c, float d, IXPPQXJZKQK.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8E28AB0", Offset = "0x8E272B0", VA = "0x188E28AB0")]
		public static QYMFECPGEHI LTQPKNCVMZI(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IXPPQXJZKQK.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8E28C10", Offset = "0x8E27410", VA = "0x188E28C10")]
		public static QYMFECPGEHI QBOAHDMXKVX(Func<Color> a, Action<Color> b, Color c, float d, IXPPQXJZKQK.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8E28D60", Offset = "0x8E27560", VA = "0x188E28D60")]
		public static QYMFECPGEHI RQABNBKVRWB(Transform a, Vector3 b, float c, IXPPQXJZKQK.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E29060", Offset = "0x8E27860", VA = "0x188E29060")]
		public static QYMFECPGEHI WXSWMSKMOMH(Transform a, Quaternion b, float c, IXPPQXJZKQK.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8E28F20", Offset = "0x8E27720", VA = "0x188E28F20")]
		public static QYMFECPGEHI UOYWOHSAVUW(Transform a, Vector3 b, float c, IXPPQXJZKQK.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8E28E30", Offset = "0x8E27630", VA = "0x188E28E30")]
		public static ZSVVNGRRUKQ Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8E289D0", Offset = "0x8E271D0", VA = "0x188E289D0")]
		public static void BVPLVJLGZJO(UnityEngine.Object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class TRTPHHCTUVR : ZIWRBALFLYI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[CompilerGenerated]
		private Action UXPIDNJGTIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[CompilerGenerated]
		private Action ZBWVRVSQTFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected readonly List<Action> BQZOHNUFBHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly List<Action> NSDCSAACVYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly List<Action> RGJEXMHWCYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected SUSCITIHQBY PVTOZSTIILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal UnityEngine.Object VXZCEQRCWXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal bool REQQBGMJNBP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal bool NVJYNTWQJCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8E2BB60", Offset = "0x8E2A360", VA = "0x188E2BB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool FVMFXONPYXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B970", Offset = "0x8E2A170", VA = "0x188E2B970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action WRENXAYWXIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B990", Offset = "0x8E2A190", VA = "0x188E2B990", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B8D0", Offset = "0x8E2A0D0", VA = "0x188E2B8D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "9")]
		public QNKHPYUXYMH XVWSRSMSNGU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B820", Offset = "0x8E2A020", VA = "0x188E2B820", Slot = "6")]
		public ZIWRBALFLYI LKLWBBNIAAD(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8E2BB80", Offset = "0x8E2A380", VA = "0x188E2BB80", Slot = "7")]
		public ZIWRBALFLYI YGOYFDFMFBN(Action a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8E2BC90", Offset = "0x8E2A490", VA = "0x188E2BC90", Slot = "8")]
		public ZIWRBALFLYI ZOMRYOWEMXA(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool VJXRKSUTUIL(float a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract float XLUIABUPKEP();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B510", Offset = "0x8E29D10", VA = "0x188E2B510", Slot = "12")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8E2BA30", Offset = "0x8E2A230", VA = "0x188E2BA30")]
		protected void PHHOSULGRLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B6B0", Offset = "0x8E29EB0", VA = "0x188E2B6B0")]
		protected void KWLYJLQGYFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8E2BD80", Offset = "0x8E2A580", VA = "0x188E2BD80")]
		protected TRTPHHCTUVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class FUNKKRCYTAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8E27A80", Offset = "0x8E26280", VA = "0x188E27A80")]
		public static QYMFECPGEHI UOYWOHSAVUW(this Behaviour a, Vector3 b, float c, IXPPQXJZKQK.Functions d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal abstract class VFGRNQZGBLP : TRTPHHCTUVR, QYMFECPGEHI, ZIWRBALFLYI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool TDUPMZAGCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly float PIBNFYVXEPR;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected IXPPQXJZKQK.Functions EVPYNCSDLJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD7CAE0", Offset = "0xD7B2E0", VA = "0x180D7CAE0")]
			[CompilerGenerated]
			get
			{
				return default(IXPPQXJZKQK.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8E2C370", Offset = "0x8E2AB70", VA = "0x188E2C370")]
		protected VFGRNQZGBLP(float a, IXPPQXJZKQK.Functions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x268C150", Offset = "0x268A950", VA = "0x18268C150")]
		[CompilerGenerated]
		private void UERAFBKMJGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E26A10", Offset = "0x8E25210", VA = "0x188E26A10")]
		[CompilerGenerated]
		private void UELTHUQOZVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class YAYYHKZYBAC<a> : VFGRNQZGBLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected readonly Func<a> QJFYWCOCFOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected readonly Action<a> VQUNXQDACZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly a VGJSOGYFLUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float UYUQJDSAVQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private a ELKBWLORFFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private a KOASWHNCWFP;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3E46C10", Offset = "0x3E45410", VA = "0x183E46C10")]
		protected YAYYHKZYBAC(Func<a> a, Action<a> b, a c, float d, IXPPQXJZKQK.Functions e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract a TQANQUMMDCZ();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract a RRYNQNGXZZI(a a, a b, float c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3E45AE0", Offset = "0x3E442E0", VA = "0x183E45AE0", Slot = "13")]
		public override bool VJXRKSUTUIL(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3E46880", Offset = "0x3E45080", VA = "0x183E46880", Slot = "14")]
		public override float XLUIABUPKEP()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class DBAMAPDRIEX : TRTPHHCTUVR, ZSVVNGRRUKQ, ZIWRBALFLYI
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
			private ZIWRBALFLYI tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Func<ZIWRBALFLYI> factory;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8E2BF80", Offset = "0x8E2A780", VA = "0x188E2BF80")]
			public TweenEntry(ZIWRBALFLYI tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB3D0", Offset = "0x1AD9BD0", VA = "0x181ADB3D0")]
			public TweenEntry(Func<ZIWRBALFLYI> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8E2BE60", Offset = "0x8E2A660", VA = "0x188E2BE60")]
			public ZIWRBALFLYI ECFAUIHSRDK()
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
		private readonly List<Step> AYCAECXSZWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int YGMQKQBATFI;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8E27620", Offset = "0x8E25E20", VA = "0x188E27620")]
		public DBAMAPDRIEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8E26810", Offset = "0x8E25010", VA = "0x188E26810", Slot = "15")]
		public ZSVVNGRRUKQ PWKTNMJKOLT(ZIWRBALFLYI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8E26750", Offset = "0x8E24F50", VA = "0x188E26750", Slot = "16")]
		public ZSVVNGRRUKQ PWKTNMJKOLT(Func<ZIWRBALFLYI> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8E26C50", Offset = "0x8E25450", VA = "0x188E26C50", Slot = "17")]
		public ZSVVNGRRUKQ XILEXTSQYVM(IEnumerable<ZIWRBALFLYI> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8E26DA0", Offset = "0x8E255A0", VA = "0x188E26DA0", Slot = "18")]
		public ZSVVNGRRUKQ XILEXTSQYVM(params ZIWRBALFLYI[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8E26640", Offset = "0x8E24E40", VA = "0x188E26640", Slot = "19")]
		public ZSVVNGRRUKQ CYWPUPIABMV(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8E26A30", Offset = "0x8E25230", VA = "0x188E26A30", Slot = "13")]
		public override bool VJXRKSUTUIL(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8E26F10", Offset = "0x8E25710", VA = "0x188E26F10", Slot = "14")]
		public override float XLUIABUPKEP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8E27020", Offset = "0x8E25820", VA = "0x188E27020")]
		private bool YWZBEJZLKJE(float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8E26B40", Offset = "0x8E25340", VA = "0x188E26B40")]
		private ZSVVNGRRUKQ XILEXTSQYVM(IEnumerable<TweenEntry> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x268C150", Offset = "0x268A950", VA = "0x18268C150")]
		[CompilerGenerated]
		private void UERAFBKMJGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8E26A10", Offset = "0x8E25210", VA = "0x188E26A10")]
		[CompilerGenerated]
		private void UELTHUQOZVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class SLNHQTDQTVP : ELPSJSDQYWU
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public TRTPHHCTUVR Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class SJZNEKOBZSY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Transform ZNKGZXRXJNQ;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public SJZNEKOBZSY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8E29A50", Offset = "0x8E28250", VA = "0x188E29A50")]
			internal Vector3 TRMSSSSUQBR()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8E29A10", Offset = "0x8E28210", VA = "0x188E29A10")]
			internal void TRHLVLYXGQI(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class IXGZENONTMW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Transform ZNKGZXRXJNQ;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public IXGZENONTMW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8E27BA0", Offset = "0x8E263A0", VA = "0x188E27BA0")]
			internal Quaternion XXDBYJHYUVH()
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8E27B70", Offset = "0x8E26370", VA = "0x188E27B70")]
			internal void XWXVBCOBLJY(Quaternion a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class AKBIJLTTMXO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Transform ZNKGZXRXJNQ;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public AKBIJLTTMXO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8E25A80", Offset = "0x8E24280", VA = "0x188E25A80")]
			internal Vector3 EONYQIREBHU()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8E25AC0", Offset = "0x8E242C0", VA = "0x188E25AC0")]
			internal void EOTFNPLBKTD(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class NAFFDINEDQF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public TRTPHHCTUVR VNYZOLGKTUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public SLNHQTDQTVP BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Behaviour CHVZLCUSNMW;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public NAFFDINEDQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8E295E0", Offset = "0x8E27DE0", VA = "0x188E295E0")]
			internal void OTYMRUOPSQS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class CNOSQDOPLNV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public SLNHQTDQTVP BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public TRTPHHCTUVR UYNQZRTIMBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public BFFPISQCYKM XJFRNSCBGCE;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public CNOSQDOPLNV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8E26490", Offset = "0x8E24C90", VA = "0x188E26490")]
			internal void RFMQVDDGNBS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8E265A0", Offset = "0x8E24DA0", VA = "0x188E265A0")]
			internal void RFRXSJXDWNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8E265F0", Offset = "0x8E24DF0", VA = "0x188E265F0")]
			internal void RFXEPQRBFYK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class ECXNCITABRM : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public ZIWRBALFLYI VNYZOLGKTUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public SLNHQTDQTVP BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public ECXNCITABRM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8E27840", Offset = "0x8E26040", VA = "0x188E27840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8E27800", Offset = "0x8E26000", VA = "0x188E27800", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class BECDYMBXQTK : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public SLNHQTDQTVP BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public BECDYMBXQTK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8E25BF0", Offset = "0x8E243F0", VA = "0x188E25BF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8E25BB0", Offset = "0x8E243B0", VA = "0x188E25BB0", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly UJRYTLVVYNJ BCRPUIYVFQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly LTZACRNGWOE HFNEOFAPDHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<QueuedTween> EHTCLKQACEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<QueuedTween> CZQWHNITKSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HashSet<TRTPHHCTUVR> ZJOTRJMNLYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<UnityEngine.Object, HashSet<TRTPHHCTUVR>> IKSSZYZFOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool KUUIPZAHTAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private BFFPISQCYKM IPAUALZEKAC;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B0F0", Offset = "0x8E298F0", VA = "0x188E2B0F0")]
		[SLGIUIECCXF.Root]
		internal static void XTVZYIQGOEG(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B1E0", Offset = "0x8E299E0", VA = "0x188E2B1E0")]
		[UnityEngine.Scripting.Preserve]
		internal SLNHQTDQTVP([Inject(null)] UJRYTLVVYNJ scheduler, [Inject(null)] LTZACRNGWOE schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8E2B010", Offset = "0x8E29810", VA = "0x188E2B010", Slot = "4")]
		public QYMFECPGEHI XJOXHFYXXQI(Func<float> a, Action<float> b, float c, float d, IXPPQXJZKQK.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8E2A0D0", Offset = "0x8E288D0", VA = "0x188E2A0D0", Slot = "5")]
		public QYMFECPGEHI LTQPKNCVMZI(Func<Vector3> a, Action<Vector3> b, Vector3 c, float d, IXPPQXJZKQK.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8E2A390", Offset = "0x8E28B90", VA = "0x188E2A390", Slot = "6")]
		public QYMFECPGEHI QBOAHDMXKVX(Func<Color> a, Action<Color> b, Color c, float d, IXPPQXJZKQK.Functions e, [Optional] Behaviour f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8E2A480", Offset = "0x8E28C80", VA = "0x188E2A480", Slot = "7")]
		public QYMFECPGEHI RQABNBKVRWB(Transform a, Vector3 b, float c, IXPPQXJZKQK.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8E2AE50", Offset = "0x8E29650", VA = "0x188E2AE50", Slot = "8")]
		public QYMFECPGEHI WXSWMSKMOMH(Transform a, Quaternion b, float c, IXPPQXJZKQK.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8E2AC80", Offset = "0x8E29480", VA = "0x188E2AC80", Slot = "9")]
		public QYMFECPGEHI UOYWOHSAVUW(Transform a, Vector3 b, float c, IXPPQXJZKQK.Functions d, [Optional] Behaviour e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8E2AAF0", Offset = "0x8E292F0", VA = "0x188E2AAF0", Slot = "10")]
		public ZSVVNGRRUKQ Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8E29BE0", Offset = "0x8E283E0", VA = "0x188E29BE0", Slot = "11")]
		public void BVPLVJLGZJO(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8E29A90", Offset = "0x8E28290", VA = "0x188E29A90", Slot = "12")]
		public void BVPLVJLGZJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8E29E10", Offset = "0x8E28610", VA = "0x188E29E10")]
		private void LGPYHJFLKEC(Behaviour a, TRTPHHCTUVR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8E2A1C0", Offset = "0x8E289C0", VA = "0x188E2A1C0")]
		[IteratorStateMachine(typeof(BECDYMBXQTK))]
		private IEnumerator<ZCECIALXIMT> MRGHCZHDDIZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8E2A740", Offset = "0x8E28F40", VA = "0x188E2A740")]
		private void Run(Behaviour context, TRTPHHCTUVR sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8E29D80", Offset = "0x8E28580", VA = "0x188E29D80")]
		[IteratorStateMachine(typeof(ECXNCITABRM))]
		private IEnumerator<ZCECIALXIMT> EWIWHBTURSR(ZIWRBALFLYI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8E2A230", Offset = "0x8E28A30", VA = "0x188E2A230")]
		private void PWKTNMJKOLT(TRTPHHCTUVR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8E2A650", Offset = "0x8E28E50", VA = "0x188E2A650")]
		private void RQXMKOGVZTY(TRTPHHCTUVR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8E29A90", Offset = "0x8E28290", VA = "0x188E29A90")]
		private void KVXENKFHIEX(Scene a, LoadSceneMode b)
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
