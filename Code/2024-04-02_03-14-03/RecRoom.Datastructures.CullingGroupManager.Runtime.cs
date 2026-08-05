using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, CLPNKHJDECL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class OOBHMBOOPAL<T> : EDGPDEHKBEO, DECINKGEKPI<T>, LNGAEKLFLOG where T : class, NMBBICMEIBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x403C970", Offset = "0x403B570", VA = "0x18403C970")]
			internal OOBHMBOOPAL(int EGOMOCLKKOB, float[] ANGLIOCMHFJ, KAAOJDBCCJF OIMINHLJEPA = KAAOJDBCCJF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x403C920", Offset = "0x403B520", VA = "0x18403C920", Slot = "10")]
			public void BGJHDHHBMPP(T OGGNGHKHHGI, float HAPMMMMDGHH, ELFGFCBFNPG IHBGAAIHCOJ = ELFGFCBFNPG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x403C8F0", Offset = "0x403B4F0", VA = "0x18403C8F0", Slot = "11")]
			public void BGJHDHHBMPP(T OGGNGHKHHGI, Transform DDABJLPHLGK, float HAPMMMMDGHH, ELFGFCBFNPG IHBGAAIHCOJ = ELFGFCBFNPG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x403C950", Offset = "0x403B550", VA = "0x18403C950", Slot = "12")]
			public void DMBJGENFJDP(T AIHAJGNGAMF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class EDGPDEHKBEO : IDisposable, LNGAEKLFLOG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum KAAOJDBCCJF : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class MJHFHCKCOLC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public NMBBICMEIBB DFCLJPAOEGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public ELFGFCBFNPG GNMAGIEAFIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action NGCCKEAPMNF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool JDNGOFAGCDN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int KGAKPAMIIIB;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
				public MJHFHCKCOLC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class JCCOFFNJHHE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public EDGPDEHKBEO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public MJHFHCKCOLC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
				public JCCOFFNJHHE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x60F6740", Offset = "0x60F5340", VA = "0x1860F6740")]
				internal void DHHPCKAOOBJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int OOADADCMCON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int EGOMOCLKKOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int NFKAENFANAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool DLLGBEPLAAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup JOJIEIFLOFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] BDEFMEAOIJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] OBCOJHKBFPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly GBNHJCPBPCG FOHLLAJCPJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<NMBBICMEIBB, int> GFDMBHJNJLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, MJHFHCKCOLC> LHNJKEHFOOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly KAAOJDBCCJF OIMINHLJEPA;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool GFDFJMHJGOA
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xDE9340", Offset = "0xDE7F40", VA = "0x180DE9340")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3ED6490", Offset = "0x3ED5090", VA = "0x183ED6490", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x60F6350", Offset = "0x60F4F50", VA = "0x1860F6350")]
			internal EDGPDEHKBEO(int EGOMOCLKKOB, float[] ANGLIOCMHFJ, KAAOJDBCCJF OIMINHLJEPA = KAAOJDBCCJF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60F47B0", Offset = "0x60F33B0", VA = "0x1860F47B0")]
			public void AELAAGLFBIK(bool FEFNOLNHMAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x60F4C30", Offset = "0x60F3830", VA = "0x1860F4C30", Slot = "6")]
			public void BGJHDHHBMPP(NMBBICMEIBB OGGNGHKHHGI, float HAPMMMMDGHH, ELFGFCBFNPG IHBGAAIHCOJ = ELFGFCBFNPG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60F4840", Offset = "0x60F3440", VA = "0x1860F4840", Slot = "9")]
			public void BGJHDHHBMPP(NMBBICMEIBB OGGNGHKHHGI, Transform DDABJLPHLGK, float HAPMMMMDGHH, ELFGFCBFNPG IHBGAAIHCOJ = ELFGFCBFNPG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x60F57D0", Offset = "0x60F43D0", VA = "0x1860F57D0")]
			public void EJMHEKLDPPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x60F4CD0", Offset = "0x60F38D0", VA = "0x1860F4CD0")]
			private void DEHMELLHFBM(int PMIDLPOCCEE, [Optional] float? HAPMMMMDGHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60F4E00", Offset = "0x60F3A00", VA = "0x1860F4E00", Slot = "7")]
			public void DMBJGENFJDP(NMBBICMEIBB AIHAJGNGAMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60F5980", Offset = "0x60F4580", VA = "0x1860F5980", Slot = "8")]
			public void FBFFFHNJLNA(NMBBICMEIBB OGGNGHKHHGI, ELFGFCBFNPG OJFGEDCMFNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x60F51E0", Offset = "0x60F3DE0", VA = "0x1860F51E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x60F5BB0", Offset = "0x60F47B0", VA = "0x1860F5BB0")]
			private void IFCJGHCPGCN(MJHFHCKCOLC EHGJJMKPMBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x60F60B0", Offset = "0x60F4CB0", VA = "0x1860F60B0")]
			private void POGLEAJHAOP(MJHFHCKCOLC EHGJJMKPMBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60F5920", Offset = "0x60F4520", VA = "0x1860F5920")]
			private void FBCAFPJJIFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x60F47E0", Offset = "0x60F33E0", VA = "0x1860F47E0")]
			private void AKMKNFGIJKI(float HINGOJPJBCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x60F5A70", Offset = "0x60F4670", VA = "0x1860F5A70")]
			private void HLPKLMEIDKI(MJHFHCKCOLC EHGJJMKPMBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x60F57C0", Offset = "0x60F43C0", VA = "0x1860F57C0")]
			private void EFEOJDBLIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x60F4CC0", Offset = "0x60F38C0", VA = "0x1860F4CC0")]
			private void CJAIPMJGKBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x60F54A0", Offset = "0x60F40A0", VA = "0x1860F54A0")]
			private void EDDNKBCCHFC(CullingGroupEvent ONJKKBBOCJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60F5F40", Offset = "0x60F4B40", VA = "0x1860F5F40")]
			private void MFFGDGJJDJO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct CDEECNGOGFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort MEPLILKMILI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type MEDLOPBPJAJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float PPODCMHGGPA = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float DAALFGDHDDA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float APNAHOBDKOF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float MEKOPPMMMFF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float CMHIJCHPIKM = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FOCBGNAOGFN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float DNIIGEAIHLO = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<CDEECNGOGFN, EDGPDEHKBEO> EBPLCDOICAC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable COKBFMLMLJH;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LPOFLDPNMCE;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static GPEAFMNAGCL MFIFHONBCGD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static GPEAFMNAGCL OAACPHGEAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly GPEAFMNAGCL BICJOEDFEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly GPEAFMNAGCL OMLJADFABIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GPEAFMNAGCL DDDBLAAEBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DIJEKGOINOG HAJMJPBJMIM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool FEFNOLNHMAC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GPEAFMNAGCL KFAJIJEMHFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GPEAFMNAGCL LBIPOKDJBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GPEAFMNAGCL ENPLKDAKNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JAEFJLLMPPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD81CD0", Offset = "0xD808D0", VA = "0x180D81CD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HJEMEPFJAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x879630", Offset = "0x878230", VA = "0x180879630", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x961730", Offset = "0x960330", VA = "0x180961730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60F3530", Offset = "0x60F2130", VA = "0x1860F3530", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60F3C60", Offset = "0x60F2860", VA = "0x1860F3C60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60F3C40", Offset = "0x60F2840", VA = "0x1860F3C40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60F3AF0", Offset = "0x60F26F0", VA = "0x1860F3AF0")]
		private void JOPFFIJNHBF(Scene LCNNNOGNJJG, LoadSceneMode HJPHBEGAFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60F3B60", Offset = "0x60F2760", VA = "0x1860F3B60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60F4240", Offset = "0x60F2E40", VA = "0x1860F4240")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60F3E60", Offset = "0x60F2A60", VA = "0x1860F3E60")]
		private void PLBDKBELCJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60F4000", Offset = "0x60F2C00", VA = "0x1860F4000")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60F3970", Offset = "0x60F2570", VA = "0x1860F3970")]
		private void JCGNFMJMBIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60F3750", Offset = "0x60F2350", VA = "0x1860F3750")]
		public LNGAEKLFLOG GetOrCreateCullingGroup(Type GPEBPPHKPNC, int FCBAFNCKNJA, ushort KBHCHEKNJJE = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x26395F0", Offset = "0x26381F0", VA = "0x1826395F0")]
		public DECINKGEKPI<T> GetOrCreateCullingGroup<T>(int FCBAFNCKNJA, ushort KBHCHEKNJJE = 0) where T : class, NMBBICMEIBB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60F3C80", Offset = "0x60F2880", VA = "0x1860F3C80")]
		private LNGAEKLFLOG PGAPFJDODBN(Type GPEBPPHKPNC, int FCBAFNCKNJA, float[] ANGLIOCMHFJ, ushort KBHCHEKNJJE = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2639690", Offset = "0x2638290", VA = "0x182639690")]
		private DECINKGEKPI<T> PGAPFJDODBN<T>(int FCBAFNCKNJA, float[] ANGLIOCMHFJ, ushort KBHCHEKNJJE = 0) where T : class, NMBBICMEIBB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60F35F0", Offset = "0x60F21F0", VA = "0x1860F35F0")]
		public static FPPFILBLGKN FindClosestDefaultUpdateLod(float BFCILKGOPCK)
		{
			return default(FPPFILBLGKN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7DDFF0", Offset = "0x7DCBF0", VA = "0x1807DDFF0")]
		public static FPPFILBLGKN MinUpdateLod(FPPFILBLGKN BGEJGMBLDIH, FPPFILBLGKN LKFFEFCDLMI)
		{
			return default(FPPFILBLGKN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60F3B50", Offset = "0x60F2750", VA = "0x1860F3B50")]
		public static FPPFILBLGKN MaxUpdateLod(FPPFILBLGKN BGEJGMBLDIH, FPPFILBLGKN LKFFEFCDLMI)
		{
			return default(FPPFILBLGKN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60F46B0", Offset = "0x60F32B0", VA = "0x1860F46B0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GBNHJCPBPCG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OPDCFOBCBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera PGFCPHAJFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GPEAFMNAGCL LHOAFEIMNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GLABAEHIPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GPEAFMNAGCL KCJBEOGHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform KMBOLPMOKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LNGAEKLFLOG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GFDFJMHJGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGJHDHHBMPP(NMBBICMEIBB OGGNGHKHHGI, float HAPMMMMDGHH, ELFGFCBFNPG IHBGAAIHCOJ = ELFGFCBFNPG.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMBJGENFJDP(NMBBICMEIBB AIHAJGNGAMF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBFFFHNJLNA(NMBBICMEIBB OGGNGHKHHGI, ELFGFCBFNPG BLCNMEHAGHM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DECINKGEKPI<T> : LNGAEKLFLOG where T : class, NMBBICMEIBB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGJHDHHBMPP(T OGGNGHKHHGI, float HAPMMMMDGHH, ELFGFCBFNPG IHBGAAIHCOJ = ELFGFCBFNPG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGJHDHHBMPP(T OGGNGHKHHGI, Transform DDABJLPHLGK, float HAPMMMMDGHH, ELFGFCBFNPG IHBGAAIHCOJ = ELFGFCBFNPG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMBJGENFJDP(T AIHAJGNGAMF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NMBBICMEIBB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform NBNNMCCMOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FPPFILBLGKN OJAIGPFEEFN, FPPFILBLGKN PHHKIEBOCCO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool JFOEBCKJLLB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum ELFGFCBFNPG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FPPFILBLGKN
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Invalid = -1
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
