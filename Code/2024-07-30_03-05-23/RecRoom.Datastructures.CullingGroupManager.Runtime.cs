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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LFJANMAIOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class GHLMJAFNKCJ<T> : OBBLDPKEJGO, POAFDGOOMBI<T>, PKJGAMOJFGP where T : class, CBACEKMNGCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D710", Offset = "0x3D0BD10", VA = "0x183D0D710")]
			internal GHLMJAFNKCJ(int ALPPFPAKDJB, float[] OIFMMJDEGME, POHICDMALMJ PIIAAIAOIKH = POHICDMALMJ.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D6E0", Offset = "0x3D0BCE0", VA = "0x183D0D6E0", Slot = "10")]
			public void LHEPNGLDBLI(T NJKKPOFFNNJ, float PKDKCKJPOHP, IBJOHPGNLAO HFPCFOLHGLD = IBJOHPGNLAO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D6B0", Offset = "0x3D0BCB0", VA = "0x183D0D6B0", Slot = "11")]
			public void LHEPNGLDBLI(T NJKKPOFFNNJ, Transform LMOCLGJAPDJ, float PKDKCKJPOHP, IBJOHPGNLAO HFPCFOLHGLD = IBJOHPGNLAO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D690", Offset = "0x3D0BC90", VA = "0x183D0D690", Slot = "12")]
			public void HHOKGKJNBNI(T EEGPHIPOOGE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class OBBLDPKEJGO : IDisposable, PKJGAMOJFGP
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum POHICDMALMJ : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class KOBFCNDNJDO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public CBACEKMNGCB JFGGKCGEEOA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public IBJOHPGNLAO PNNIMOLMCAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action INBFMMCKALF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool DALBPNGGEFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int MIMJDCDEIKK;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
				public KOBFCNDNJDO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class ECOBNFHLIPF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public OBBLDPKEJGO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public KOBFCNDNJDO trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
				public ECOBNFHLIPF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x69D23D0", Offset = "0x69D09D0", VA = "0x1869D23D0")]
				internal void EHBJMIAIHMK()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int KABOFLNMIIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int ALPPFPAKDJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BHKHFILLELG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool LFHFPMACPBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup NMLANPMNNNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] KAIPCFOOMOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] KEKDMAPIKKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly EFFBKLJEMDJ MBKGOLHFIHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<CBACEKMNGCB, int> LCDKOBDFAEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, KOBFCNDNJDO> EEPOGLBCHOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly POHICDMALMJ PIIAAIAOIKH;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool JGGIBHLMALF
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xF874E0", Offset = "0xF85AE0", VA = "0x180F874E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x45320A0", Offset = "0x45306A0", VA = "0x1845320A0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x69D40F0", Offset = "0x69D26F0", VA = "0x1869D40F0")]
			internal OBBLDPKEJGO(int ALPPFPAKDJB, float[] OIFMMJDEGME, POHICDMALMJ PIIAAIAOIKH = POHICDMALMJ.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x69D2980", Offset = "0x69D0F80", VA = "0x1869D2980")]
			public void CEEMLJFNFKN(bool FAHCMEHFGDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x69D39D0", Offset = "0x69D1FD0", VA = "0x1869D39D0", Slot = "6")]
			public void LHEPNGLDBLI(CBACEKMNGCB NJKKPOFFNNJ, float PKDKCKJPOHP, IBJOHPGNLAO HFPCFOLHGLD = IBJOHPGNLAO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x69D35D0", Offset = "0x69D1BD0", VA = "0x1869D35D0", Slot = "9")]
			public void LHEPNGLDBLI(CBACEKMNGCB NJKKPOFFNNJ, Transform LMOCLGJAPDJ, float PKDKCKJPOHP, IBJOHPGNLAO HFPCFOLHGLD = IBJOHPGNLAO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69D3FA0", Offset = "0x69D25A0", VA = "0x1869D3FA0")]
			public void PLLJNNAIODM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69D2850", Offset = "0x69D0E50", VA = "0x1869D2850")]
			private void AIPEPFNCKAD(int PDMMEDBMFPP, [Optional] float? PKDKCKJPOHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69D3070", Offset = "0x69D1670", VA = "0x1869D3070", Slot = "7")]
			public void HHOKGKJNBNI(CBACEKMNGCB EEGPHIPOOGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69D3E40", Offset = "0x69D2440", VA = "0x1869D3E40", Slot = "8")]
			public void NIFHLPABNOL(CBACEKMNGCB NJKKPOFFNNJ, IBJOHPGNLAO DCHFLGPONLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69D2A10", Offset = "0x69D1010", VA = "0x1869D2A10", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x69D2CD0", Offset = "0x69D12D0", VA = "0x1869D2CD0")]
			private void EEBCGFLAHDM(KOBFCNDNJDO CFDJPDGGAOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x69D3BA0", Offset = "0x69D21A0", VA = "0x1869D3BA0")]
			private void NCBCACPNLHO(KOBFCNDNJDO CFDJPDGGAOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69D29B0", Offset = "0x69D0FB0", VA = "0x1869D29B0")]
			private void CPOCAFEDMDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69D3F30", Offset = "0x69D2530", VA = "0x1869D3F30")]
			private void OFKJANLLGLK(float JOOMCFPDCGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x69D3A60", Offset = "0x69D2060", VA = "0x1869D3A60")]
			private void NAMAKCPFFOG(KOBFCNDNJDO CFDJPDGGAOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69D3060", Offset = "0x69D1660", VA = "0x1869D3060")]
			private void GOFHCFCEJEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x69D3F90", Offset = "0x69D2590", VA = "0x1869D3F90")]
			private void PFHFGKNKLMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x69D2520", Offset = "0x69D0B20", VA = "0x1869D2520")]
			private void AFAICFLAAPB(CullingGroupEvent LLCJNAAJONF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x69D3460", Offset = "0x69D1A60", VA = "0x1869D3460")]
			private void HNALNEBOIIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FICOCMGEAEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort ILNDICKONHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type GPKNKIMDOLG;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float EBNCJLNIGFN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float PGEGAPHLKFL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float GCLOANLFJDA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NNKOHGCFJPF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JLLMKIKNBCC = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GLJMMJAOAPJ = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GJNCFMICAAL = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<FICOCMGEAEN, OBBLDPKEJGO> JNBKAKOLGLB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable NBIDCFKGBBN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable OCCCDHOAGLE;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static AOBPFOPEJNG JKEIKBLKGIE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static AOBPFOPEJNG LELDAAHPJBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly AOBPFOPEJNG FIOEELCBFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly AOBPFOPEJNG LIKKMIAJFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AOBPFOPEJNG NBIAODBACDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EKNCDBKDOPI PJECMDEMGLG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool FAHCMEHFGDC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AOBPFOPEJNG NFBHHFIMGHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AOBPFOPEJNG EGPPIAABHPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AOBPFOPEJNG KKOBFBEJLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CKEDPHEIBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF98830", Offset = "0xF96E30", VA = "0x180F98830", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IKMAEEHNEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C60", Offset = "0x9F5260", VA = "0x1809F6C60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA1E7F0", Offset = "0xA1CDF0", VA = "0x180A1E7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69D1150", Offset = "0x69CF750", VA = "0x1869D1150", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69D1A80", Offset = "0x69D0080", VA = "0x1869D1A80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69D1A60", Offset = "0x69D0060", VA = "0x1869D1A60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69D1910", Offset = "0x69CFF10", VA = "0x1869D1910")]
		private void LOHJGJIAINP(Scene KOGJGCFCINN, LoadSceneMode HIHEPGOGOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69D1980", Offset = "0x69CFF80", VA = "0x1869D1980", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69D1E60", Offset = "0x69D0460", VA = "0x1869D1E60")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69D1770", Offset = "0x69CFD70", VA = "0x1869D1770")]
		private void IGHMAEMIGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69D1C20", Offset = "0x69D0220", VA = "0x1869D1C20")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69D1AA0", Offset = "0x69D00A0", VA = "0x1869D1AA0")]
		private void PPOGPJAHHBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69D1550", Offset = "0x69CFB50", VA = "0x1869D1550")]
		public PKJGAMOJFGP GetOrCreateCullingGroup(Type FDDEADJODCD, int HCIIFNIMAGN, ushort GGKDJLEDCAJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29E1560", Offset = "0x29DFB60", VA = "0x1829E1560")]
		public POAFDGOOMBI<T> GetOrCreateCullingGroup<T>(int HCIIFNIMAGN, ushort GGKDJLEDCAJ = 0) where T : class, CBACEKMNGCB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69D1210", Offset = "0x69CF810", VA = "0x1869D1210")]
		private PKJGAMOJFGP FEDCPOPPHOH(Type FDDEADJODCD, int HCIIFNIMAGN, float[] OIFMMJDEGME, ushort GGKDJLEDCAJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29E12D0", Offset = "0x29DF8D0", VA = "0x1829E12D0")]
		private POAFDGOOMBI<T> FEDCPOPPHOH<T>(int HCIIFNIMAGN, float[] OIFMMJDEGME, ushort GGKDJLEDCAJ = 0) where T : class, CBACEKMNGCB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69D13F0", Offset = "0x69CF9F0", VA = "0x1869D13F0")]
		public static JCHEPGBFHGG FindClosestDefaultUpdateLod(float BJJPKFKDHPB)
		{
			return default(JCHEPGBFHGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x894190", Offset = "0x892790", VA = "0x180894190")]
		public static JCHEPGBFHGG MinUpdateLod(JCHEPGBFHGG HAJDOBGGGNC, JCHEPGBFHGG JEIDFGBFAEE)
		{
			return default(JCHEPGBFHGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69D1970", Offset = "0x69CFF70", VA = "0x1869D1970")]
		public static JCHEPGBFHGG MaxUpdateLod(JCHEPGBFHGG HAJDOBGGGNC, JCHEPGBFHGG JEIDFGBFAEE)
		{
			return default(JCHEPGBFHGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69D22D0", Offset = "0x69D08D0", VA = "0x1869D22D0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EFFBKLJEMDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool HGBALLHFKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera PABLCPJIDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AOBPFOPEJNG NMJFBPCPJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BNCGLDFAAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AOBPFOPEJNG GDPNNDNLBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform JODFEKNEJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PKJGAMOJFGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JGGIBHLMALF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHEPNGLDBLI(CBACEKMNGCB NJKKPOFFNNJ, float PKDKCKJPOHP, IBJOHPGNLAO HFPCFOLHGLD = IBJOHPGNLAO.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHOKGKJNBNI(CBACEKMNGCB EEGPHIPOOGE);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NIFHLPABNOL(CBACEKMNGCB NJKKPOFFNNJ, IBJOHPGNLAO ANFDEHFFJEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface POAFDGOOMBI<T> : PKJGAMOJFGP where T : class, CBACEKMNGCB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHEPNGLDBLI(T NJKKPOFFNNJ, float PKDKCKJPOHP, IBJOHPGNLAO HFPCFOLHGLD = IBJOHPGNLAO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHEPNGLDBLI(T NJKKPOFFNNJ, Transform LMOCLGJAPDJ, float PKDKCKJPOHP, IBJOHPGNLAO HFPCFOLHGLD = IBJOHPGNLAO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHOKGKJNBNI(T EEGPHIPOOGE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CBACEKMNGCB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform AFJHLFMCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(JCHEPGBFHGG OAIAKECGFEC, JCHEPGBFHGG EFHFFPHCNPM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool KBMCAOCOMKD);
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
