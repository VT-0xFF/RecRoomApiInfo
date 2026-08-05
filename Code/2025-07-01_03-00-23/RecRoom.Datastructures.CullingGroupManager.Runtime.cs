using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LMKECBAEOAN, ODGGGLKDEEB
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct HCEGAOIKDDA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> ACJFHCNBBBO;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B640", Offset = "0x7F69C40", VA = "0x187F6B640", Slot = "4")]
			public void Execute(int KHMHPNKMLMD, TransformAccess DFOHJKCGEGI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct IKGAADDNIMF : IEquatable<IKGAADDNIMF>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort GOBEBCJFDFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type NKPOAGACKHO;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B7B0", Offset = "0x7F69DB0", VA = "0x187F6B7B0", Slot = "4")]
			public bool Equals(IKGAADDNIMF HOPHFOOKMCC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B6C0", Offset = "0x7F69CC0", VA = "0x187F6B6C0", Slot = "0")]
			public override bool Equals(object ODCICEDDLMB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B830", Offset = "0x7F69E30", VA = "0x187F6B830", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class IGEJEEKKOEH<T> : AFMHFIFPALF, HBMGJGOJCGP<T>, KAIJBBJPFNN where T : class, DJOKFDLOFME
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4F64C40", Offset = "0x4F63240", VA = "0x184F64C40")]
			internal IGEJEEKKOEH(int INBKPLPDIJA, float[] HLPEJNDFCAP, BEDLEEGCLKJ FPDLDCFPMKH = BEDLEEGCLKJ.PlayerHead, bool ABGMKNPJMDL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4F64BC0", Offset = "0x4F631C0", VA = "0x184F64BC0", Slot = "12")]
			public void JDPCENHCAFL(T ODCICEDDLMB, float OFCEKCJNBGJ, CNFEEBNLJFN OAELFNDGEEO = CNFEEBNLJFN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4F64BF0", Offset = "0x4F631F0", VA = "0x184F64BF0", Slot = "13")]
			public void JDPCENHCAFL(T ODCICEDDLMB, Transform ANGPDPACFMI, float OFCEKCJNBGJ, CNFEEBNLJFN OAELFNDGEEO = CNFEEBNLJFN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4F64BA0", Offset = "0x4F631A0", VA = "0x184F64BA0", Slot = "14")]
			public void BAFGFGCDOJB(T MEJMKFJBLBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4F64C20", Offset = "0x4F63220", VA = "0x184F64C20", Slot = "15")]
			public bool PJLKKPGODOL(T ODCICEDDLMB)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class AFMHFIFPALF : IDisposable, KAIJBBJPFNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct MLKJOBAHIGP
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum KKMGAHMAMFN : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000031")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public DJOKFDLOFME LIAPOAHCHLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform BDBOCHCKBIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float OLEEDNHGCLA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public CNFEEBNLJFN JMJBELBMKOA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public KKMGAHMAMFN AKEHBOGGIOP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum BEDLEEGCLKJ : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class HBLBBJCMAAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public DJOKFDLOFME LIAPOAHCHLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public CNFEEBNLJFN KHCCCHJLCOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action IJIGCOEIKAO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool IAOMPDGPFJA;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
				public HBLBBJCMAAK()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int AHOJNIBNPCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool ABGMKNPJMDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool IPJFEJDAGIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup IMKIPOHIAOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] FBJAMGAHNIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly DPPLJLJBOOB ACIHABPADPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly BEDLEEGCLKJ FPDLDCFPMKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<DJOKFDLOFME, int> FECJBEMPICN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, HBLBBJCMAAK> DKGDHJDHHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray MKJIOGCBCBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> OJIOFPHBNPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<MLKJOBAHIGP> MFKANOJHJJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool ALJBKDABDEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle JNHDFACBLOI;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int JLFCGHOLNOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int MALGGLBADDA
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAA5D70", Offset = "0xAA4370", VA = "0x180AA5D70", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAD8120", Offset = "0xAD6720", VA = "0x180AD8120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7F69CF0", Offset = "0x7F682F0", VA = "0x187F69CF0")]
			internal AFMHFIFPALF(int INBKPLPDIJA, float[] HLPEJNDFCAP, BEDLEEGCLKJ FPDLDCFPMKH = BEDLEEGCLKJ.PlayerHead, bool ABGMKNPJMDL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7F69810", Offset = "0x7F67E10", VA = "0x187F69810")]
			public void OJKJIKEDOHP(bool BNCAKEBPMFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7F693F0", Offset = "0x7F679F0", VA = "0x187F693F0", Slot = "5")]
			public void JDPCENHCAFL(DJOKFDLOFME ODCICEDDLMB, float OFCEKCJNBGJ, CNFEEBNLJFN OAELFNDGEEO = CNFEEBNLJFN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7F69350", Offset = "0x7F67950", VA = "0x187F69350", Slot = "10")]
			public void JDPCENHCAFL(DJOKFDLOFME ODCICEDDLMB, Transform ANGPDPACFMI, float OFCEKCJNBGJ, CNFEEBNLJFN OAELFNDGEEO = CNFEEBNLJFN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7F69840", Offset = "0x7F67E40", VA = "0x187F69840")]
			private void OLLMIEBJNCL(DJOKFDLOFME ODCICEDDLMB, Transform ANGPDPACFMI, float OFCEKCJNBGJ, CNFEEBNLJFN OAELFNDGEEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7F68440", Offset = "0x7F66A40", VA = "0x187F68440", Slot = "6")]
			public void BAFGFGCDOJB(DJOKFDLOFME MEJMKFJBLBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7F688E0", Offset = "0x7F66EE0", VA = "0x187F688E0")]
			private void FFCHFDJNONL(DJOKFDLOFME MEJMKFJBLBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7F695A0", Offset = "0x7F67BA0", VA = "0x187F695A0")]
			private void JPEAAMNIPCE(DJOKFDLOFME ODCICEDDLMB, [Optional] float? OFCEKCJNBGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7F69C30", Offset = "0x7F68230", VA = "0x187F69C30", Slot = "11")]
			public bool PJLKKPGODOL(DJOKFDLOFME ODCICEDDLMB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
			public void OICGKDCFCHF(DJOKFDLOFME ODCICEDDLMB, CNFEEBNLJFN DBLJOGBHBIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7F694F0", Offset = "0x7F67AF0", VA = "0x187F694F0")]
			private void JNKALFNOOHC(DJOKFDLOFME ODCICEDDLMB, CNFEEBNLJFN DBLJOGBHBIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7F68820", Offset = "0x7F66E20", VA = "0x187F68820")]
			public void EOLEGHKOEJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7F68230", Offset = "0x7F66830", VA = "0x187F68230")]
			public void AMHFCMFNJAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7F68D20", Offset = "0x7F67320", VA = "0x187F68D20")]
			private void FGOODJCOPFF(MLKJOBAHIGP HJGAGGHDFHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7F686D0", Offset = "0x7F66CD0", VA = "0x187F686D0")]
			private void EBACGKODKJE(int LIKMMIKJMGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7F684A0", Offset = "0x7F66AA0", VA = "0x187F684A0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7F69010", Offset = "0x7F67610", VA = "0x187F69010")]
			private void HHHHCAHCNMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7F69800", Offset = "0x7F67E00", VA = "0x187F69800")]
			private void KIDOEODKNDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7F69020", Offset = "0x7F67620", VA = "0x187F69020")]
			private void HODIMCDIDEB(CullingGroupEvent NPCFILNHPPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7F680C0", Offset = "0x7F666C0", VA = "0x187F680C0")]
			private void AEDCPJIKMJO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float FJACELJAJLD = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float HEDFDAJEGOE = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float KBGFLAIIDPK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float LNDKPEOJFFH = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float IDINMKGPBNJ = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float IAJMENJJFJA = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float NJLFODPPLPP = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<IKGAADDNIMF, AFMHFIFPALF> OHAKKFKNMMF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable GDEENGLICDB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable FLCHAOOEJML;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static LGEBFGGIOJB JHKMGGDOBLE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static LGEBFGGIOJB GDCOFNMDDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LGEBFGGIOJB MHBBDHAAGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LGEBFGGIOJB FEEJPNBNIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly LGEBFGGIOJB KNNCMGPAHHI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker FJMEPGFLAKO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker LNCGJFHECAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LLKKGNCPLNM EBJGJLIDLGM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool BNCAKEBPMFJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OJHFDJNPBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LGEBFGGIOJB JKIHCEHPLMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LGEBFGGIOJB CDILFMABFEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public LGEBFGGIOJB OBNCMCJANLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JJGHHKELEOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA71DD0", Offset = "0xA703D0", VA = "0x180A71DD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HMAKFNKAJGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCCADC0", Offset = "0xCC93C0", VA = "0x180CCADC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDC9890", Offset = "0xDC7E90", VA = "0x180DC9890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A1D0", Offset = "0x7F687D0", VA = "0x187F6A1D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D33C20", Offset = "0x7D32220", VA = "0x187D33C20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AD80", Offset = "0x7F69380", VA = "0x187F6AD80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCBA220", Offset = "0xCB8820", VA = "0x180CBA220")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A290", Offset = "0x7F68890", VA = "0x187F6A290")]
		private void BPGDGHONGAN(Scene EOECEDBNACA, LoadSceneMode HMNPOEHONDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6ACA0", Offset = "0x7F692A0", VA = "0x187F6ACA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B040", Offset = "0x7F69640", VA = "0x187F6B040")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A930", Offset = "0x7F68F30", VA = "0x187F6A930")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AB30", Offset = "0x7F69130", VA = "0x187F6AB30")]
		private void MBAFCEPPGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F6ADA0", Offset = "0x7F693A0", VA = "0x187F6ADA0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A2F0", Offset = "0x7F688F0", VA = "0x187F6A2F0")]
		private void DGFDAMHCMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A5C0", Offset = "0x7F68BC0", VA = "0x187F6A5C0")]
		public KAIJBBJPFNN GetOrCreateCullingGroup(Type AABLPFCAKKM, int HPNAKHDHCKG, ushort ANJGGMJCDAL = 0, bool ABGMKNPJMDL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x398C7F0", Offset = "0x398ADF0", VA = "0x18398C7F0")]
		public HBMGJGOJCGP<T> GetOrCreateCullingGroup<T>(int HPNAKHDHCKG, ushort ANJGGMJCDAL = 0, bool ABGMKNPJMDL = false) where T : class, DJOKFDLOFME
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A7A0", Offset = "0x7F68DA0", VA = "0x187F6A7A0")]
		private KAIJBBJPFNN LJJMAOCCNNE(Type AABLPFCAKKM, int HPNAKHDHCKG, float[] HLPEJNDFCAP, ushort ANJGGMJCDAL = 0, bool ABGMKNPJMDL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x398C890", Offset = "0x398AE90", VA = "0x18398C890")]
		private HBMGJGOJCGP<T> LJJMAOCCNNE<T>(int HPNAKHDHCKG, float[] HLPEJNDFCAP, ushort ANJGGMJCDAL = 0, bool ABGMKNPJMDL = false) where T : class, DJOKFDLOFME
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A460", Offset = "0x7F68A60", VA = "0x187F6A460")]
		public static LNDADOOHAMM FindClosestDefaultUpdateLod(float NIPINEINGOO)
		{
			return default(LNDADOOHAMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA735C0", Offset = "0xA71BC0", VA = "0x180A735C0")]
		public static LNDADOOHAMM MinUpdateLod(LNDADOOHAMM NONEAIIDHKI, LNDADOOHAMM HDAIDGFBGDA)
		{
			return default(LNDADOOHAMM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AC90", Offset = "0x7F69290", VA = "0x187F6AC90")]
		public static LNDADOOHAMM MaxUpdateLod(LNDADOOHAMM NONEAIIDHKI, LNDADOOHAMM HDAIDGFBGDA)
		{
			return default(LNDADOOHAMM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B4F0", Offset = "0x7F69AF0", VA = "0x187F6B4F0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA71DD0", Offset = "0xA703D0", VA = "0x180A71DD0", Slot = "11")]
		private bool HIIIPJGJLMB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DPPLJLJBOOB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool HFBGIBLDDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera BHKPFBJAIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LGEBFGGIOJB KEDKMNDOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool EAMDHIMAAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LGEBFGGIOJB MMEDNDNMAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform DFENMJGPJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KAIJBBJPFNN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDPCENHCAFL(DJOKFDLOFME ODCICEDDLMB, float OFCEKCJNBGJ, CNFEEBNLJFN OAELFNDGEEO = CNFEEBNLJFN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAFGFGCDOJB(DJOKFDLOFME MEJMKFJBLBO);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OICGKDCFCHF(DJOKFDLOFME ODCICEDDLMB, CNFEEBNLJFN MLBBFANAHME);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HBMGJGOJCGP<T> : KAIJBBJPFNN where T : class, DJOKFDLOFME
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDPCENHCAFL(T ODCICEDDLMB, float OFCEKCJNBGJ, CNFEEBNLJFN OAELFNDGEEO = CNFEEBNLJFN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDPCENHCAFL(T ODCICEDDLMB, Transform ANGPDPACFMI, float OFCEKCJNBGJ, CNFEEBNLJFN OAELFNDGEEO = CNFEEBNLJFN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAFGFGCDOJB(T MEJMKFJBLBO);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PJLKKPGODOL(T ODCICEDDLMB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DJOKFDLOFME
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform DFOHJKCGEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(LNDADOOHAMM IPEPMKFKJEC, LNDADOOHAMM BDLAAMPBEBJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool EPAEFBCGGBA);
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
