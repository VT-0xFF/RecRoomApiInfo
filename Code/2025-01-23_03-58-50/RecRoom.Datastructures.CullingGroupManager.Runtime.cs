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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OOOILGHOBHM, DLKJMFLDODE
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct JLEPBPAOIKH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NativeArray<BoundingSphere> EBNFOODJNOB;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F13240", Offset = "0x6F11A40", VA = "0x186F13240", Slot = "4")]
			public void Execute(int ECDOOAABOPD, TransformAccess NBEDBEKEEBM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct DGDDCEFHEOI : IEquatable<DGDDCEFHEOI>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ushort OFBMPDKIOMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Type MOBKCNMBEKL;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F13060", Offset = "0x6F11860", VA = "0x186F13060", Slot = "4")]
			public bool Equals(DGDDCEFHEOI LIHCAHPMPHD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F130E0", Offset = "0x6F118E0", VA = "0x186F130E0", Slot = "0")]
			public override bool Equals(object INCBEIDOHDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F131D0", Offset = "0x6F119D0", VA = "0x186F131D0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class OPKKEDGPFNC<T> : CNBBLNNAEAI, MCMCMEKGLDE<T>, EJEKKKILJCH where T : class, OPLCNBEPAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4B71500", Offset = "0x4B6FD00", VA = "0x184B71500")]
			internal OPKKEDGPFNC(int GIKHJMJAGEH, float[] NLLOJKKPLGO, HKLHJJLKELD NBDOCCBBPFA = HKLHJJLKELD.PlayerHead, bool CGHMKFECCFF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4B714D0", Offset = "0x4B6FCD0", VA = "0x184B714D0", Slot = "12")]
			public void JGCMIIMCCFC(T INCBEIDOHDO, float EKHPIDKNFIF, FMLELDCHGMI NHNAAKCKAJB = FMLELDCHGMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4B714A0", Offset = "0x4B6FCA0", VA = "0x184B714A0", Slot = "13")]
			public void JGCMIIMCCFC(T INCBEIDOHDO, Transform COGKOKAOAEJ, float EKHPIDKNFIF, FMLELDCHGMI NHNAAKCKAJB = FMLELDCHGMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4B71460", Offset = "0x4B6FC60", VA = "0x184B71460", Slot = "14")]
			public void CGFLGFPAOEK(T KBGDKHDOHDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4B71480", Offset = "0x4B6FC80", VA = "0x184B71480", Slot = "15")]
			public bool GAPLIKLFKLG(T INCBEIDOHDO)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class CNBBLNNAEAI : IDisposable, EJEKKKILJCH
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct PFDLJOLHOGD
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum JDFHNDPJFOP : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000036")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public OPLCNBEPAIK OKJEJOLANIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public Transform KEKDMLOCEEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public float FBKOADJLGDC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public FMLELDCHGMI EDGNEAHFJOP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public JDFHNDPJFOP JDHDLBDLIBL;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum HKLHJJLKELD : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class FOOOJPALPML
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public OPLCNBEPAIK OKJEJOLANIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public FMLELDCHGMI FMCHGDBNDDB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public Action DFBCPPFKDAO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public bool ICJACGGPADA;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
				public FOOOJPALPML()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class CPDCIONGCDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public CNBBLNNAEAI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				public FOOOJPALPML trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
				public CPDCIONGCDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x6F11CC0", Offset = "0x6F104C0", VA = "0x186F11CC0")]
				internal void CFINNLELJOO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly int MIEHFACIEHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool CGHMKFECCFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private bool LOEKDIGJGDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly CullingGroup BPPOAOLJAFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private BoundingSphere[] KDFBJFKIAOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly LJCAGCGIHMF BIJBPNIFOLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly HKLHJJLKELD NBDOCCBBPFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<OPLCNBEPAIK, int> POIBCPFLDGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly Dictionary<int, FOOOJPALPML> KOOHDIEPOFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TransformAccessArray DDFLEHFHJLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private NativeList<BoundingSphere> EHOAFDJCIHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<PFDLJOLHOGD> FNLBKABANIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private bool FLCPMGBLOOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private JobHandle HGLLPADGGCE;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int HABBCBNOJIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3A10", VA = "0x1808B5210")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int KHLKKGEHOEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA8EA70", Offset = "0xA8D270", VA = "0x180A8EA70", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xA8EAA0", Offset = "0xA8D2A0", VA = "0x180A8EAA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F117E0", Offset = "0x6F0FFE0", VA = "0x186F117E0")]
			internal CNBBLNNAEAI(int GIKHJMJAGEH, float[] NLLOJKKPLGO, HKLHJJLKELD NBDOCCBBPFA = HKLHJJLKELD.PlayerHead, bool CGHMKFECCFF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F117B0", Offset = "0x6F0FFB0", VA = "0x186F117B0")]
			public void PLMAOEGMJFO(bool DCCBIOFBKCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F10790", Offset = "0x6F0EF90", VA = "0x186F10790", Slot = "5")]
			public void JGCMIIMCCFC(OPLCNBEPAIK INCBEIDOHDO, float EKHPIDKNFIF, FMLELDCHGMI NHNAAKCKAJB = FMLELDCHGMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F10890", Offset = "0x6F0F090", VA = "0x186F10890", Slot = "10")]
			public void JGCMIIMCCFC(OPLCNBEPAIK INCBEIDOHDO, Transform COGKOKAOAEJ, float EKHPIDKNFIF, FMLELDCHGMI NHNAAKCKAJB = FMLELDCHGMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F10330", Offset = "0x6F0EB30", VA = "0x186F10330")]
			private void GCCLLGOKMGB(OPLCNBEPAIK INCBEIDOHDO, Transform COGKOKAOAEJ, float EKHPIDKNFIF, FMLELDCHGMI NHNAAKCKAJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F0F720", Offset = "0x6F0DF20", VA = "0x186F0F720", Slot = "6")]
			public void CGFLGFPAOEK(OPLCNBEPAIK KBGDKHDOHDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F10EC0", Offset = "0x6F0F6C0", VA = "0x186F10EC0")]
			private void OHOCGLDPCEI(OPLCNBEPAIK KBGDKHDOHDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F0F070", Offset = "0x6F0D870", VA = "0x186F0F070")]
			private void AECOKMJAMBP(OPLCNBEPAIK INCBEIDOHDO, [Optional] float? EKHPIDKNFIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F10270", Offset = "0x6F0EA70", VA = "0x186F10270", Slot = "11")]
			public bool GAPLIKLFKLG(OPLCNBEPAIK INCBEIDOHDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F11310", Offset = "0x6F0FB10", VA = "0x186F11310", Slot = "7")]
			public void OLKJIGBHKGJ(OPLCNBEPAIK INCBEIDOHDO, FMLELDCHGMI JODGOIDJFKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F0F650", Offset = "0x6F0DE50", VA = "0x186F0F650")]
			private void CBHHKANANMK(OPLCNBEPAIK INCBEIDOHDO, FMLELDCHGMI JODGOIDJFKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F0F780", Offset = "0x6F0DF80", VA = "0x186F0F780")]
			public void CJHGIGMMHNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F10060", Offset = "0x6F0E860", VA = "0x186F10060")]
			public void FLKLGIIADOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F0F9A0", Offset = "0x6F0E1A0", VA = "0x186F0F9A0")]
			private void DMIBJPNHINI(PFDLJOLHOGD HPEMNIMCDDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F10930", Offset = "0x6F0F130", VA = "0x186F10930")]
			private void JHNJKFGMOIN(int GLDGPOMBNJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F0FCD0", Offset = "0x6F0E4D0", VA = "0x186F0FCD0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F113E0", Offset = "0x6F0FBE0", VA = "0x186F113E0")]
			private void OMFNKFBOOOK(FOOOJPALPML DGNALFILMFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F10A80", Offset = "0x6F0F280", VA = "0x186F10A80")]
			private static void JLDAGKEHINL(FOOOJPALPML DGNALFILMFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F0F5E0", Offset = "0x6F0DDE0", VA = "0x186F0F5E0")]
			private void AOAJKNPOLOI(FOOOJPALPML DGNALFILMFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F10000", Offset = "0x6F0E800", VA = "0x186F10000")]
			private static void FHDBAANDLNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F10730", Offset = "0x6F0EF30", VA = "0x186F10730")]
			private static void HMHMIBLNIHE(float HKMEEJMCKCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F10EB0", Offset = "0x6F0F6B0", VA = "0x186F10EB0")]
			private void KGAMNLOBEIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F117A0", Offset = "0x6F0FFA0", VA = "0x186F117A0")]
			private void PEDHBDMPIAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F0F2B0", Offset = "0x6F0DAB0", VA = "0x186F0F2B0")]
			private void ALKPCLNDOGN(CullingGroupEvent OBILKFIFAML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F10D40", Offset = "0x6F0F540", VA = "0x186F10D40")]
			private void KAHKAIIEHHN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float EKPPDICBFOP = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float ABKNAOOOMON = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float KKFDHEBIMKP = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float PGDGNPILIHB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FMCFGJBLEPM = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FNFBCGOABHI = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float NELCOOEOJBL = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<DGDDCEFHEOI, CNBBLNNAEAI> FAIDCBMFDKI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable GMKAJBMMEFB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable MAKEDJCFOAB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static GCOJJNPJFGN IDMGCIBLBIP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static GCOJJNPJFGN GGOFGPGCFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly GCOJJNPJFGN FLNOGFPOBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GCOJJNPJFGN LJDDMACAEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly GCOJJNPJFGN PKPLFJFMBEL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static bool UseJobs;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker BCPIAGMOAFM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static ProfilerMarker CKILBFCGCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private EBBFPAKHIHA OLOOKHBEAHM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static bool DCCBIOFBKCH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DALNJCHFIBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8B9830", VA = "0x1808BB030", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8BB010", Offset = "0x8B9810", VA = "0x1808BB010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GCOJJNPJFGN KFDOIOHHDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GCOJJNPJFGN BLKPHJBKCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GCOJJNPJFGN OCFPDICACJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FNKNGAPOJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8E2910", Offset = "0x8E1110", VA = "0x1808E2910", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FOGODCAGMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x933530", Offset = "0x931D30", VA = "0x180933530", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x932FF0", Offset = "0x9317F0", VA = "0x180932FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F11D40", Offset = "0x6F10540", VA = "0x186F11D40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F128F0", Offset = "0x6F110F0", VA = "0x186F128F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x183F2D0", Offset = "0x183DAD0", VA = "0x18183F2D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDCC3B0", Offset = "0xDCABB0", VA = "0x180DCC3B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F12430", Offset = "0x6F10C30", VA = "0x186F12430")]
		private void KNALEOJEAGA(Scene CMJNKCJNAGB, LoadSceneMode MPFGBBEJAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F12810", Offset = "0x6F11010", VA = "0x186F12810", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F12B40", Offset = "0x6F11340", VA = "0x186F12B40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F12490", Offset = "0x6F10C90", VA = "0x186F12490")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F11E00", Offset = "0x6F10600", VA = "0x186F11E00")]
		private void CLDJGGKDBBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F12910", Offset = "0x6F11110", VA = "0x186F12910")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F126A0", Offset = "0x6F10EA0", VA = "0x186F126A0")]
		private void NMABJDEFFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F120C0", Offset = "0x6F108C0", VA = "0x186F120C0")]
		public EJEKKKILJCH GetOrCreateCullingGroup(Type DODIALOIKLP, int IKHNADFPCIG, ushort FLJDOCLGEJB = 0, bool CGHMKFECCFF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2E95B20", Offset = "0x2E94320", VA = "0x182E95B20")]
		public MCMCMEKGLDE<T> GetOrCreateCullingGroup<T>(int IKHNADFPCIG, ushort FLJDOCLGEJB = 0, bool CGHMKFECCFF = false) where T : class, OPLCNBEPAIK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F122A0", Offset = "0x6F10AA0", VA = "0x186F122A0")]
		private EJEKKKILJCH HOFIHAHLICE(Type DODIALOIKLP, int IKHNADFPCIG, float[] NLLOJKKPLGO, ushort FLJDOCLGEJB = 0, bool CGHMKFECCFF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2E95BE0", Offset = "0x2E943E0", VA = "0x182E95BE0")]
		private MCMCMEKGLDE<T> HOFIHAHLICE<T>(int IKHNADFPCIG, float[] NLLOJKKPLGO, ushort FLJDOCLGEJB = 0, bool CGHMKFECCFF = false) where T : class, OPLCNBEPAIK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F11F60", Offset = "0x6F10760", VA = "0x186F11F60")]
		public static HNNBIECDFEH FindClosestDefaultUpdateLod(float PNAEEABELPB)
		{
			return default(HNNBIECDFEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E00", Offset = "0x8E2600", VA = "0x1808E3E00")]
		public static HNNBIECDFEH MinUpdateLod(HNNBIECDFEH NCIDPPENHNG, HNNBIECDFEH GCPPACBPGED)
		{
			return default(HNNBIECDFEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F12690", Offset = "0x6F10E90", VA = "0x186F12690")]
		public static HNNBIECDFEH MaxUpdateLod(HNNBIECDFEH NCIDPPENHNG, HNNBIECDFEH GCPPACBPGED)
		{
			return default(HNNBIECDFEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F12F10", Offset = "0x6F11710", VA = "0x186F12F10")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8E2910", Offset = "0x8E1110", VA = "0x1808E2910", Slot = "11")]
		private bool KPBLGHLFFCL()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LJCAGCGIHMF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CICPOFIICOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera NOBANDIEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GCOJJNPJFGN EKFLEKGKOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LEHCOAFFOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GCOJJNPJFGN NMJBGJBGGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform FCINKLPEOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EJEKKKILJCH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGCMIIMCCFC(OPLCNBEPAIK INCBEIDOHDO, float EKHPIDKNFIF, FMLELDCHGMI NHNAAKCKAJB = FMLELDCHGMI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGFLGFPAOEK(OPLCNBEPAIK KBGDKHDOHDK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLKJIGBHKGJ(OPLCNBEPAIK INCBEIDOHDO, FMLELDCHGMI GHHCDMMHNPC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MCMCMEKGLDE<T> : EJEKKKILJCH where T : class, OPLCNBEPAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGCMIIMCCFC(T INCBEIDOHDO, float EKHPIDKNFIF, FMLELDCHGMI NHNAAKCKAJB = FMLELDCHGMI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCMIIMCCFC(T INCBEIDOHDO, Transform COGKOKAOAEJ, float EKHPIDKNFIF, FMLELDCHGMI NHNAAKCKAJB = FMLELDCHGMI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGFLGFPAOEK(T KBGDKHDOHDK);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GAPLIKLFKLG(T INCBEIDOHDO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OPLCNBEPAIK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform NBEDBEKEEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(HNNBIECDFEH HGJGJDCJCFP, HNNBIECDFEH AAHIGDGBAHJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool EMGABJHBLDH);
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
