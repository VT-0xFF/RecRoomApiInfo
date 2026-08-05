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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, NJIBLDPNMNG, GKEGMHGFIBN
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct DMGLGMJOKFB : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> IMINNNCPCJF;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7F62FB0", Offset = "0x7F617B0", VA = "0x187F62FB0", Slot = "4")]
			public void Execute(int PNJCJGEIDHG, TransformAccess KCODNJGBFEK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct KNDCKNGLGDP : IEquatable<KNDCKNGLGDP>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort DFMDGOPGOJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type DPCLJHHGGLE;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7F63120", Offset = "0x7F61920", VA = "0x187F63120", Slot = "4")]
			public bool Equals(KNDCKNGLGDP KEKEFPAJGHD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7F63030", Offset = "0x7F61830", VA = "0x187F63030", Slot = "0")]
			public override bool Equals(object HPLLAPMNIJF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7F631A0", Offset = "0x7F619A0", VA = "0x187F631A0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class MEJEBBHLCLN<T> : DFJOKMLKIJD, EDCEKHNADLJ<T>, MAFINHHDDBC where T : class, FFMEMGNEFKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5538350", Offset = "0x5536B50", VA = "0x185538350")]
			internal MEJEBBHLCLN(int IMPFOHAIHIN, float[] CCHGJFMMBIH, IPBCBBBLDJK IBCCFHCNKAL = IPBCBBBLDJK.PlayerHead, bool BPJJBHHNMBI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x55382B0", Offset = "0x5536AB0", VA = "0x1855382B0", Slot = "12")]
			public void GGGBGBDKNKJ(T HPLLAPMNIJF, float ANIHENNGJAL, LHKNHJGBEJF HAPBBILFGJL = LHKNHJGBEJF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x55382E0", Offset = "0x5536AE0", VA = "0x1855382E0", Slot = "13")]
			public void GGGBGBDKNKJ(T HPLLAPMNIJF, Transform AMNPCNOLOKB, float ANIHENNGJAL, LHKNHJGBEJF HAPBBILFGJL = LHKNHJGBEJF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5538310", Offset = "0x5536B10", VA = "0x185538310", Slot = "14")]
			public void HKOLMKDGPPH(T NILCDEOMKKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5538330", Offset = "0x5536B30", VA = "0x185538330", Slot = "15")]
			public bool OHBEAOEBEGB(T HPLLAPMNIJF)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class DFJOKMLKIJD : IDisposable, MAFINHHDDBC
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct CGFGAJHNNKC
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum AAOHKAIJNCD : byte
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
				public FFMEMGNEFKM FNEEDJKOJML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform GNOACPCNCKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float DDOAMKNOBPD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public LHKNHJGBEJF NLEBFOEIIGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public AAOHKAIJNCD PBNBGAHIAOD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum IPBCBBBLDJK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class JCKHIOAIBAM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public FFMEMGNEFKM FNEEDJKOJML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public LHKNHJGBEJF EMJEBKOLGIL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action LFOHGENLJIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool KFOIEDKPIFG;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
				public JCKHIOAIBAM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int DOKKPGJAENM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool BPJJBHHNMBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool DMJNBPLABAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup BLCOKHMNDPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] GIDJKNKAFHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly HPMKIPIOOML PJHMONPOPCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly IPBCBBBLDJK IBCCFHCNKAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<FFMEMGNEFKM, int> EJEEPBEDILB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, JCKHIOAIBAM> CBGADFMAIJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray ALPKLKJEPDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> AKLIBELJOHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<CGFGAJHNNKC> GMHNMIJEADE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool GNALEGJBGKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle GGAIACICGIO;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int PGCBAHBCMBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int ALGBBCJEJFG
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xABDC60", Offset = "0xABC460", VA = "0x180ABDC60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7F62AD0", Offset = "0x7F612D0", VA = "0x187F62AD0")]
			internal DFJOKMLKIJD(int IMPFOHAIHIN, float[] CCHGJFMMBIH, IPBCBBBLDJK IBCCFHCNKAL = IPBCBBBLDJK.PlayerHead, bool BPJJBHHNMBI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7F610D0", Offset = "0x7F5F8D0", VA = "0x187F610D0")]
			public void EBNGMOLCEKI(bool FNEFOMNCPLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7F618F0", Offset = "0x7F600F0", VA = "0x187F618F0", Slot = "5")]
			public void GGGBGBDKNKJ(FFMEMGNEFKM HPLLAPMNIJF, float ANIHENNGJAL, LHKNHJGBEJF HAPBBILFGJL = LHKNHJGBEJF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7F61850", Offset = "0x7F60050", VA = "0x187F61850", Slot = "10")]
			public void GGGBGBDKNKJ(FFMEMGNEFKM HPLLAPMNIJF, Transform AMNPCNOLOKB, float ANIHENNGJAL, LHKNHJGBEJF HAPBBILFGJL = LHKNHJGBEJF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7F624D0", Offset = "0x7F60CD0", VA = "0x187F624D0")]
			private void PCFANDHIJNJ(FFMEMGNEFKM HPLLAPMNIJF, Transform AMNPCNOLOKB, float ANIHENNGJAL, LHKNHJGBEJF HAPBBILFGJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7F61D00", Offset = "0x7F60500", VA = "0x187F61D00", Slot = "6")]
			public void HKOLMKDGPPH(FFMEMGNEFKM NILCDEOMKKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7F61410", Offset = "0x7F5FC10", VA = "0x187F61410")]
			private void FIMKMMFPMFG(FFMEMGNEFKM NILCDEOMKKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7F61100", Offset = "0x7F5F900", VA = "0x187F61100")]
			private void ELKMJEFNNBA(FFMEMGNEFKM HPLLAPMNIJF, [Optional] float? ANIHENNGJAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7F620E0", Offset = "0x7F608E0", VA = "0x187F620E0", Slot = "11")]
			public bool OHBEAOEBEGB(FFMEMGNEFKM HPLLAPMNIJF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
			public void JAPLJAPCCMJ(FFMEMGNEFKM HPLLAPMNIJF, LHKNHJGBEJF BEOHLOAKCDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7F61360", Offset = "0x7F5FB60", VA = "0x187F61360")]
			private void FHBMPBAOOIP(FFMEMGNEFKM HPLLAPMNIJF, LHKNHJGBEJF BEOHLOAKCDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7F61EB0", Offset = "0x7F606B0", VA = "0x187F61EB0")]
			public void JNGIHMDKPJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7F628C0", Offset = "0x7F610C0", VA = "0x187F628C0")]
			public void PFFJEIBKODN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7F61A00", Offset = "0x7F60200", VA = "0x187F61A00")]
			private void HJKCOPPLLJN(CGFGAJHNNKC GJJIDOPGHFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7F61D60", Offset = "0x7F60560", VA = "0x187F61D60")]
			private void IIDFACNPBCA(int GJNLFMAEJOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7F60EA0", Offset = "0x7F5F6A0", VA = "0x187F60EA0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7F619F0", Offset = "0x7F601F0", VA = "0x187F619F0")]
			private void GHEMPOFGOFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7F60E90", Offset = "0x7F5F690", VA = "0x187F60E90")]
			private void DKBNMOEELHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7F621A0", Offset = "0x7F609A0", VA = "0x187F621A0")]
			private void ONOGBHKDNDN(CullingGroupEvent BNLGHCICIHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7F61F70", Offset = "0x7F60770", VA = "0x187F61F70")]
			private void OBJKOKHIKBP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float CLBMFPNCCAP = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OJJLHBMFGNH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LONLGNNBGML = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HFPJHJBDCPM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float KCCMDFAHOIB = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float CJOAFPAJFMB = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float AOCHKKIAAIP = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<KNDCKNGLGDP, DFJOKMLKIJD> KFHBAOAKCJB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable ACMNAKEBOED;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable BPPFOLKFBKG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static KECNPIDOCPH GEHGGDMEMEE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static KECNPIDOCPH LOIPHCNLPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly KECNPIDOCPH MPJJNNFLIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KECNPIDOCPH ABLEBCJBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KECNPIDOCPH MBEKPHALIGA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker PMAEGJBNDBF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker JGFDGBIOMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NGLIALCAJHK AIGFCKLOIBP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool FNEFOMNCPLE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NPBENHPKCNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KECNPIDOCPH PNIDINJCGFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KECNPIDOCPH COIJMLDBMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public KECNPIDOCPH GKOLNCJIEJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LKKJKOFPIKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA55AC0", Offset = "0xA542C0", VA = "0x180A55AC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HCCNGCNINIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xC9B990", Offset = "0xC9A190", VA = "0x180C9B990", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD98160", Offset = "0xD96960", VA = "0x180D98160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F9C0", Offset = "0x7F5E1C0", VA = "0x187F5F9C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D940", Offset = "0x7D3C140", VA = "0x187D3D940")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F605B0", Offset = "0x7F5EDB0", VA = "0x187F605B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC8B0A0", Offset = "0xC898A0", VA = "0x180C8B0A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FA80", Offset = "0x7F5E280", VA = "0x187F5FA80")]
		private void BMEKIMFJOOC(Scene NBLBLIGFFMD, LoadSceneMode MFMCIMMKBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F604D0", Offset = "0x7F5ECD0", VA = "0x187F604D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F60860", Offset = "0x7F5F060", VA = "0x187F60860")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F60120", Offset = "0x7F5E920", VA = "0x187F60120")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F60370", Offset = "0x7F5EB70", VA = "0x187F60370")]
		private void OICBABCKAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F605D0", Offset = "0x7F5EDD0", VA = "0x187F605D0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FFB0", Offset = "0x7F5E7B0", VA = "0x187F5FFB0")]
		private void KMCONADHOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FDD0", Offset = "0x7F5E5D0", VA = "0x187F5FDD0")]
		public MAFINHHDDBC GetOrCreateCullingGroup(Type FGHJKKBPHNJ, int BIHIGDEFBIF, ushort OCMNOKOOFCJ = 0, bool BPJJBHHNMBI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37F2030", Offset = "0x37F0830", VA = "0x1837F2030")]
		public EDCEKHNADLJ<T> GetOrCreateCullingGroup<T>(int BIHIGDEFBIF, ushort OCMNOKOOFCJ = 0, bool BPJJBHHNMBI = false) where T : class, FFMEMGNEFKM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FAE0", Offset = "0x7F5E2E0", VA = "0x187F5FAE0")]
		private MAFINHHDDBC COCAELFKNFG(Type FGHJKKBPHNJ, int BIHIGDEFBIF, float[] CCHGJFMMBIH, ushort OCMNOKOOFCJ = 0, bool BPJJBHHNMBI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37F1DF0", Offset = "0x37F05F0", VA = "0x1837F1DF0")]
		private EDCEKHNADLJ<T> COCAELFKNFG<T>(int BIHIGDEFBIF, float[] CCHGJFMMBIH, ushort OCMNOKOOFCJ = 0, bool BPJJBHHNMBI = false) where T : class, FFMEMGNEFKM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FC70", Offset = "0x7F5E470", VA = "0x187F5FC70")]
		public static KEIJGPDJMGG FindClosestDefaultUpdateLod(float CBMCFOGLPMB)
		{
			return default(KEIJGPDJMGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA563E0", Offset = "0xA54BE0", VA = "0x180A563E0")]
		public static KEIJGPDJMGG MinUpdateLod(KEIJGPDJMGG PCMCBAFEBOB, KEIJGPDJMGG MKLBOLLAIJJ)
		{
			return default(KEIJGPDJMGG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F60360", Offset = "0x7F5EB60", VA = "0x187F60360")]
		public static KEIJGPDJMGG MaxUpdateLod(KEIJGPDJMGG PCMCBAFEBOB, KEIJGPDJMGG MKLBOLLAIJJ)
		{
			return default(KEIJGPDJMGG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F60D40", Offset = "0x7F5F540", VA = "0x187F60D40")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA55AC0", Offset = "0xA542C0", VA = "0x180A55AC0", Slot = "11")]
		private bool LNOMDLNGNMA()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HPMKIPIOOML
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool PKNBFKCPNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera BAAFKILGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KECNPIDOCPH GGKKCKCNFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KBLLPIDFFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	KECNPIDOCPH GHECEANPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform DJFOIAFNLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MAFINHHDDBC
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGGBGBDKNKJ(FFMEMGNEFKM HPLLAPMNIJF, float ANIHENNGJAL, LHKNHJGBEJF HAPBBILFGJL = LHKNHJGBEJF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKOLMKDGPPH(FFMEMGNEFKM NILCDEOMKKF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAPLJAPCCMJ(FFMEMGNEFKM HPLLAPMNIJF, LHKNHJGBEJF MBNCIAFPDJL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EDCEKHNADLJ<T> : MAFINHHDDBC where T : class, FFMEMGNEFKM
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGGBGBDKNKJ(T HPLLAPMNIJF, float ANIHENNGJAL, LHKNHJGBEJF HAPBBILFGJL = LHKNHJGBEJF.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGGBGBDKNKJ(T HPLLAPMNIJF, Transform AMNPCNOLOKB, float ANIHENNGJAL, LHKNHJGBEJF HAPBBILFGJL = LHKNHJGBEJF.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKOLMKDGPPH(T NILCDEOMKKF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHBEAOEBEGB(T HPLLAPMNIJF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FFMEMGNEFKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform KCODNJGBFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(KEIJGPDJMGG OPICACCPKDF, KEIJGPDJMGG MLCOHGNCKEI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool EIHIBPCMLAH);
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
