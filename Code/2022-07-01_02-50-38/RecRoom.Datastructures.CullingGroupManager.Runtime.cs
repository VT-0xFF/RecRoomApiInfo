using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, FJDFLBPCEIN
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class FHPHHKLOBFN : IDisposable, PJBJNBFFCPH
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int PINDDADLPEC
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int EKEPANLDBNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void CBDAIFFGBDK(bool LINLPJANIAH);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			protected FHPHHKLOBFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class PMOJLOFFOPK<T> : FHPHHKLOBFN, global::KGACBAGMKEF<T>, PJBJNBFFCPH where T : EAAEKEHPFBO
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum AJCCPBOCFPD : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OCDFDJLPHNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T DLOGLLCBNIO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public GELBHBHKFNO EGDJIGHNBKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action AOOHJDKHPHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool KEJIGGALOJK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int EHCNLDNBCOB;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
				public OCDFDJLPHNA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class DJHLDIJJGDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public PMOJLOFFOPK<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public OCDFDJLPHNA trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
				public DJHLDIJJGDH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int OHKFHHBJGMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int EJCAIMDIAOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int LKNEJIPBPHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool BPDPEACPAAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup AGIEMANNDPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] NNMFJAENFLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] AEEBEKGMLNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly EBKBPKMPCJA JMODMMLPIOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> AGJPHBLCEML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, OCDFDJLPHNA> MAMJDFJDJJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly AJCCPBOCFPD FFKHMIPEPNP;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int PINDDADLPEC
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x570F90", Offset = "0x56F790", VA = "0x180570F90", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int EKEPANLDBNK
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x5D5180", Offset = "0x5D3980", VA = "0x1805D5180", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x218E470", Offset = "0x218CC70", VA = "0x18218E470")]
			internal PMOJLOFFOPK(int EJCAIMDIAOJ, float[] BFDGHKOKGKC, AJCCPBOCFPD FFKHMIPEPNP = AJCCPBOCFPD.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x218C890", Offset = "0x218B090", VA = "0x18218C890", Slot = "10")]
			public override void CBDAIFFGBDK(bool LINLPJANIAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x218C6C0", Offset = "0x218AEC0", VA = "0x18218C6C0", Slot = "11")]
			public CHCOBPCEKEE AMFDKIOKPFK(float GEHDDGLHCFL)
			{
				return default(CHCOBPCEKEE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x218C8C0", Offset = "0x218B0C0", VA = "0x18218C8C0", Slot = "12")]
			public void DEOBKNOOHMB(T ALCFLDIFDGE, float JMIAJNKDJFB, GELBHBHKFNO IABKAGJADIC = GELBHBHKFNO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x218C960", Offset = "0x218B160", VA = "0x18218C960", Slot = "13")]
			public void DEOBKNOOHMB(T ALCFLDIFDGE, Transform DHINKPEJFNN, float JMIAJNKDJFB, GELBHBHKFNO IABKAGJADIC = GELBHBHKFNO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x218DE40", Offset = "0x218C640", VA = "0x18218DE40", Slot = "14")]
			public void IKDDDMMMBDA(T ALCFLDIFDGE, [Optional] float? JMIAJNKDJFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x218D300", Offset = "0x218BB00", VA = "0x18218D300")]
			private void EMDJJPNCGFJ(int EDBBKGCLEJF, [Optional] float? JMIAJNKDJFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x218DAA0", Offset = "0x218C2A0", VA = "0x18218DAA0", Slot = "15")]
			public void IIDOOJBFPNM(T KJABMJGHJCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x218E030", Offset = "0x218C830", VA = "0x18218E030", Slot = "16")]
			public CHCOBPCEKEE OGGDHAOKEBP(T ALCFLDIFDGE)
			{
				return default(CHCOBPCEKEE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x218C790", Offset = "0x218AF90", VA = "0x18218C790", Slot = "17")]
			public bool BJFELKBGDGF(T ALCFLDIFDGE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x218DEC0", Offset = "0x218C6C0", VA = "0x18218DEC0", Slot = "18")]
			public void KILPOCNDJIC(T ALCFLDIFDGE, GELBHBHKFNO IKAFHHJINAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x218CDE0", Offset = "0x218B5E0", VA = "0x18218CDE0", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x218D470", Offset = "0x218BC70", VA = "0x18218D470")]
			private void FKFFGBJAPMG(OCDFDJLPHNA JOKJCBOEKGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x218D820", Offset = "0x218C020", VA = "0x18218D820")]
			private void HGNAMKOGLBO(OCDFDJLPHNA JOKJCBOEKGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x218E400", Offset = "0x218CC00", VA = "0x18218E400")]
			private void PGPICLDACFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x218C720", Offset = "0x218AF20", VA = "0x18218C720")]
			private void ANACIJGBEON(float JGONAKIDPNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x218DFD0", Offset = "0x218C7D0", VA = "0x18218DFD0")]
			private void MJCCCHKOADE(OCDFDJLPHNA JOKJCBOEKGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x218E010", Offset = "0x218C810", VA = "0x18218E010")]
			private void NGNPIMFDFCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x218D160", Offset = "0x218B960", VA = "0x18218D160")]
			private void EHIPNOJCJCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x218E150", Offset = "0x218C950", VA = "0x18218E150")]
			private void OIBAOHAMCJF(CullingGroupEvent AAMNFJNLIKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x218D190", Offset = "0x218B990", VA = "0x18218D190")]
			private void EKFOJCNKPOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct CCCLAEHBIKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort BLLLPHLGMIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type NBBDONDCMFH;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float EILDNGFBHAO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OMFEHGJDPLB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float IDCGHMGLBJM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HDOBJCBEAFD = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float CMINHFPOAAE = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float NEFFIHBJLIC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float OEKIENPEHKK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<CCCLAEHBIKN, FHPHHKLOBFN> AOJCHOFIGGO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable AJKJLKHPOAC;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LCCPJIIKOOP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static KKJEBJGGJMD OMFJDACDPIF;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static KKJEBJGGJMD OGMNCNFDLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly KKJEBJGGJMD HODFOCAGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly KKJEBJGGJMD NCLJHIKNCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KKJEBJGGJMD BEKIHOOGMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FGPLGBJKFNK NJCAAIFFDDD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool LINLPJANIAH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KKJEBJGGJMD BKCCLOOJOCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KKJEBJGGJMD JILHIOKCACA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x573670", VA = "0x180574E70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KKJEBJGGJMD CJHFMKCOMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x5731E0", VA = "0x1805749E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ANOGIJKLLJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1231660", Offset = "0x122FE60", VA = "0x181231660", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JLJMIAFMGDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6DCFF0", Offset = "0x6DB7F0", VA = "0x1806DCFF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6DD010", Offset = "0x6DB810", VA = "0x1806DD010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1230A40", Offset = "0x122F240", VA = "0x181230A40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x12311C0", Offset = "0x122F9C0", VA = "0x1812311C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x12311A0", Offset = "0x122F9A0", VA = "0x1812311A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1230CD0", Offset = "0x122F4D0", VA = "0x181230CD0")]
		private void GDLABFBPKKD(Scene BGNFKBNCKAB, LoadSceneMode LLMKIKMAMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x12310F0", Offset = "0x122F8F0", VA = "0x1812310F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1230E90", Offset = "0x122F690", VA = "0x181230E90")]
		private void LFODHKLHKBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12311E0", Offset = "0x122F9E0", VA = "0x1812311E0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1230D30", Offset = "0x122F530", VA = "0x181230D30")]
		private void KCDFOPENKIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x222BEE0", Offset = "0x222A6E0", VA = "0x18222BEE0")]
		public global::KGACBAGMKEF<T> GetOrCreateCullingGroup<T>(int KAJDFABKIAC, ushort HEPDHLLNKAM = 0) where T : EAAEKEHPFBO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x222BCD0", Offset = "0x222A4D0", VA = "0x18222BCD0")]
		private global::KGACBAGMKEF<T> FMADCOILKLB<T>(int KAJDFABKIAC, float[] BFDGHKOKGKC, ushort HEPDHLLNKAM = 0) where T : EAAEKEHPFBO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1230AE0", Offset = "0x122F2E0", VA = "0x181230AE0")]
		public static CHCOBPCEKEE FindClosestDefaultUpdateLod(float AGFNCJDHMLD)
		{
			return default(CHCOBPCEKEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1231090", Offset = "0x122F890", VA = "0x181231090")]
		public static CHCOBPCEKEE MinUpdateLod(CHCOBPCEKEE EHJKHOBIKAE, CHCOBPCEKEE FLOEEGHKMFI)
		{
			return default(CHCOBPCEKEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1231030", Offset = "0x122F830", VA = "0x181231030")]
		public static CHCOBPCEKEE MaxUpdateLod(CHCOBPCEKEE EHJKHOBIKAE, CHCOBPCEKEE FLOEEGHKMFI)
		{
			return default(CHCOBPCEKEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1231570", Offset = "0x122FD70", VA = "0x181231570")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EBKBPKMPCJA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GJNEGHIOMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera OLJKJCGLEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KKJEBJGGJMD HCLNOBMKLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool AOINEHBFIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	KKJEBJGGJMD BCMCDHLOEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform NELEIEBJFII
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PJBJNBFFCPH
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int PINDDADLPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int EKEPANLDBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KGACBAGMKEF<T> : PJBJNBFFCPH where T : EAAEKEHPFBO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CHCOBPCEKEE AMFDKIOKPFK(float GEHDDGLHCFL);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEOBKNOOHMB(T ALCFLDIFDGE, float JMIAJNKDJFB, GELBHBHKFNO IABKAGJADIC = GELBHBHKFNO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEOBKNOOHMB(T ALCFLDIFDGE, Transform DHINKPEJFNN, float JMIAJNKDJFB, GELBHBHKFNO IABKAGJADIC = GELBHBHKFNO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IKDDDMMMBDA(T ALCFLDIFDGE, [Optional] float? JMIAJNKDJFB);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIDOOJBFPNM(T KJABMJGHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CHCOBPCEKEE OGGDHAOKEBP(T ALCFLDIFDGE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BJFELKBGDGF(T ALCFLDIFDGE);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KILPOCNDJIC(T ALCFLDIFDGE, GELBHBHKFNO OMMGCEJGAGI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EAAEKEHPFBO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform CNAHGDNAMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CHCOBPCEKEE CJLONANLGKJ, CHCOBPCEKEE AFAPGOOFJIB);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IPBJIGMLAMF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum GELBHBHKFNO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CHCOBPCEKEE
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LAHJCKFAJLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private CHCOBPCEKEE HPBILEFDEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private CHCOBPCEKEE EJNNPILJOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, CHCOBPCEKEE> IHBFIGGICEI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OAAKLHHCIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1231E40", Offset = "0x1230640", VA = "0x181231E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public CHCOBPCEKEE MNCDDKMIILP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x570F90", Offset = "0x56F790", VA = "0x180570F90")]
		get
		{
			return default(CHCOBPCEKEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CHCOBPCEKEE NCKAALJDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D5180", Offset = "0x5D3980", VA = "0x1805D5180")]
		get
		{
			return default(CHCOBPCEKEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1231DD0", Offset = "0x12305D0", VA = "0x181231DD0")]
	public bool EFBFJEKHDBL(object FIGDHHNIEAN, CHCOBPCEKEE HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1231E90", Offset = "0x1230690", VA = "0x181231E90")]
	public bool LAHIJGOLBBE(object FIGDHHNIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1231C60", Offset = "0x1230460", VA = "0x181231C60")]
	private bool CEJBLNBICOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1231EF0", Offset = "0x12306F0", VA = "0x181231EF0")]
	public LAHJCKFAJLD()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JOLDJLBOGLF
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] NNDNCLBIBCO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int BOAHHKDAAGN;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int BEAECOMNAKK;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger HPFDFIDLOGO;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JOLDJLBOGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1231670", Offset = "0x122FE70", VA = "0x181231670")]
	private static string AAANGJFGDHI(byte[] EOEFACHALFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1231770", Offset = "0x122FF70", VA = "0x181231770")]
	public static string CHJFNPPOLEP(byte[] IFAOIOLKGMC, bool CCLJOEHHPGP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
