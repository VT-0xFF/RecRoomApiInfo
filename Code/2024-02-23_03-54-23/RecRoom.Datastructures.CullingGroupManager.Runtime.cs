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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, KBFCHONAOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class EJNLGCADPJG<T> : FLCGAIKBHOH, LICEHFAGJJH<T>, ALKOPEINFBL where T : class, ONOFPFCCGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x32330A0", Offset = "0x3231AA0", VA = "0x1832330A0")]
			internal EJNLGCADPJG(int EELFJJCHLDP, float[] NIGPMNGOICO, LIBENAODHMH ANNDIDDBPFD = LIBENAODHMH.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3233020", Offset = "0x3231A20", VA = "0x183233020", Slot = "10")]
			public void FLOHBAGDPJC(T MBCPMMHPENP, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3233050", Offset = "0x3231A50", VA = "0x183233050", Slot = "11")]
			public void FLOHBAGDPJC(T MBCPMMHPENP, Transform DGEPPJAANCA, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3233080", Offset = "0x3231A80", VA = "0x183233080", Slot = "12")]
			public void NJHEJNEGCKN(T DFPLMDONLJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class FLCGAIKBHOH : IDisposable, ALKOPEINFBL
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum LIBENAODHMH : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OMNILKAOLFN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public ONOFPFCCGPJ NFJEJMOKBJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public CALKAHELOOG ACFLEDGPFAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action MPJMPGJCNLG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool DKPDIFIPLMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int MEJJBNBBHJJ;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
				public OMNILKAOLFN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class PMIPKINDKPG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public FLCGAIKBHOH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public OMNILKAOLFN trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
				public PMIPKINDKPG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5F97040", Offset = "0x5F95A40", VA = "0x185F97040")]
				internal void FCPFLFOEFFK()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int CGGMCIOLJMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int EELFJJCHLDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int GJODBLAILPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool APMGFBPMLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup MMFOFDJGLKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] OHDCDCNDAED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] CPGPOOLMIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly CIBLGMOIHLJ CBKELGPMNJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<ONOFPFCCGPJ, int> JMIOMJAAJDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, OMNILKAOLFN> DAIFBDPJPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly LIBENAODHMH ANNDIDDBPFD;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool CCBJMCIEOAK
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xD41110", Offset = "0xD3FB10", VA = "0x180D41110")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3E0D6F0", Offset = "0x3E0C0F0", VA = "0x183E0D6F0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5F96C50", Offset = "0x5F95650", VA = "0x185F96C50")]
			internal FLCGAIKBHOH(int EELFJJCHLDP, float[] NIGPMNGOICO, LIBENAODHMH ANNDIDDBPFD = LIBENAODHMH.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5F95810", Offset = "0x5F94210", VA = "0x185F95810")]
			public void DKAFEGPPHEN(bool FEMNBAGCEDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5F95F90", Offset = "0x5F94990", VA = "0x185F95F90", Slot = "6")]
			public void FLOHBAGDPJC(ONOFPFCCGPJ MBCPMMHPENP, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5F96020", Offset = "0x5F94A20", VA = "0x185F96020", Slot = "9")]
			public void FLOHBAGDPJC(ONOFPFCCGPJ MBCPMMHPENP, Transform DGEPPJAANCA, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5F96570", Offset = "0x5F94F70", VA = "0x185F96570")]
			public void MBKKNMOCNDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5F95440", Offset = "0x5F93E40", VA = "0x185F95440")]
			private void CJDELJONODH(int OJANCMLFDOJ, [Optional] float? NLAEHEEAFBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5F96800", Offset = "0x5F95200", VA = "0x185F96800", Slot = "7")]
			public void NJHEJNEGCKN(ONOFPFCCGPJ DFPLMDONLJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5F96410", Offset = "0x5F94E10", VA = "0x185F96410", Slot = "8")]
			public void IFGFJPJBMBD(ONOFPFCCGPJ MBCPMMHPENP, CALKAHELOOG JCFHKGFEGFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5F95840", Offset = "0x5F94240", VA = "0x185F95840", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5F950B0", Offset = "0x5F93AB0", VA = "0x185F950B0")]
			private void BPMHLPDPCJL(OMNILKAOLFN MGHLCIOKNKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5F95570", Offset = "0x5F93F70", VA = "0x185F95570")]
			private void DGPOKIKJKDK(OMNILKAOLFN MGHLCIOKNKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5F96BF0", Offset = "0x5F955F0", VA = "0x185F96BF0")]
			private void ODOOMKKBEPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5F96510", Offset = "0x5F94F10", VA = "0x185F96510")]
			private void KHBOKIDJFLI(float PLEPJKNDBHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5F966C0", Offset = "0x5F950C0", VA = "0x185F966C0")]
			private void MDPEEOGLFKL(OMNILKAOLFN MGHLCIOKNKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5F96500", Offset = "0x5F94F00", VA = "0x185F96500")]
			private void IJPEJCHOBKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5F96BE0", Offset = "0x5F955E0", VA = "0x185F96BE0")]
			private void NLGAKGJOIHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5F95B00", Offset = "0x5F94500", VA = "0x185F95B00")]
			private void EFPJMPDCCKJ(CullingGroupEvent AOBNCCPAFBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5F95E20", Offset = "0x5F94820", VA = "0x185F95E20")]
			private void FIGALCDNMGN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct COFECKBGFJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort PAHKAPNLLLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type FDILMHBHCGE;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LGKJPGNICAJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float KNFGAMNMNHA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float OHOFELGKLIJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float IEMMOIBHIOH = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JJPCHCNJDJF = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float HNCDHABGKDE = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float OHEMCMKMPLH = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<COFECKBGFJK, FLCGAIKBHOH> PPDOEIENOGA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable EKFEHPBMAAD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LMDCCCMEAIA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static KKEEGFAPLDK BPFAKHEELOF;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static KKEEGFAPLDK BJLKANEDFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly KKEEGFAPLDK ODGACOFMJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly KKEEGFAPLDK GOPPKGBPGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KKEEGFAPLDK AENDFAFPLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DHBMNMGGJAH HMOAINBLICL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool FEMNBAGCEDP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KKEEGFAPLDK KKLPEAKDDDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KKEEGFAPLDK LJCHBOEHPFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KKEEGFAPLDK FDODGFPGEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PMBPGIOGIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xC00650", Offset = "0xBFF050", VA = "0x180C00650", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KLLKLMHOGPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7FDF40", Offset = "0x7FC940", VA = "0x1807FDF40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7FDA40", Offset = "0x7FC440", VA = "0x1807FDA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F93E90", Offset = "0x5F92890", VA = "0x185F93E90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F94580", Offset = "0x5F92F80", VA = "0x185F94580")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F94560", Offset = "0x5F92F60", VA = "0x185F94560")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F93E30", Offset = "0x5F92830", VA = "0x185F93E30")]
		private void AECPLDCIDEB(Scene KIGINGBAPMD, LoadSceneMode GBFDMJLKPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F94480", Offset = "0x5F92E80", VA = "0x185F94480", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F94B40", Offset = "0x5F93540", VA = "0x185F94B40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F93F50", Offset = "0x5F92950", VA = "0x185F93F50")]
		private void BJGAOALLGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F94900", Offset = "0x5F93300", VA = "0x185F94900")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F94780", Offset = "0x5F93180", VA = "0x185F94780")]
		private void PKBPAAKBDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F94250", Offset = "0x5F92C50", VA = "0x185F94250")]
		public ALKOPEINFBL GetOrCreateCullingGroup(Type JOIBCJBLEDL, int MJPLCAMIMGI, ushort GICEIMBJBKL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2531230", Offset = "0x252FC30", VA = "0x182531230")]
		public LICEHFAGJJH<T> GetOrCreateCullingGroup<T>(int MJPLCAMIMGI, ushort GICEIMBJBKL = 0) where T : class, ONOFPFCCGPJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F945A0", Offset = "0x5F92FA0", VA = "0x185F945A0")]
		private ALKOPEINFBL PEJDIJPIGGI(Type JOIBCJBLEDL, int MJPLCAMIMGI, float[] NIGPMNGOICO, ushort GICEIMBJBKL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x25312D0", Offset = "0x252FCD0", VA = "0x1825312D0")]
		private LICEHFAGJJH<T> PEJDIJPIGGI<T>(int MJPLCAMIMGI, float[] NIGPMNGOICO, ushort GICEIMBJBKL = 0) where T : class, ONOFPFCCGPJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5F940F0", Offset = "0x5F92AF0", VA = "0x185F940F0")]
		public static FOIDAKOAIBK FindClosestDefaultUpdateLod(float CHFGLNCAJDM)
		{
			return default(FOIDAKOAIBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D4FB0", Offset = "0x7D39B0", VA = "0x1807D4FB0")]
		public static FOIDAKOAIBK MinUpdateLod(FOIDAKOAIBK BDJJBBGKGHF, FOIDAKOAIBK LBMBEHGEICJ)
		{
			return default(FOIDAKOAIBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F94470", Offset = "0x5F92E70", VA = "0x185F94470")]
		public static FOIDAKOAIBK MaxUpdateLod(FOIDAKOAIBK BDJJBBGKGHF, FOIDAKOAIBK LBMBEHGEICJ)
		{
			return default(FOIDAKOAIBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F94FB0", Offset = "0x5F939B0", VA = "0x185F94FB0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CIBLGMOIHLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IHMAHKHJMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera NPGAPNFMCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	KKEEGFAPLDK DFIANOGCDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KIDAAGIEGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KKEEGFAPLDK CGHNBAOGFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform GHMCDBBPEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ALKOPEINFBL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CCBJMCIEOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLOHBAGDPJC(ONOFPFCCGPJ MBCPMMHPENP, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJHEJNEGCKN(ONOFPFCCGPJ DFPLMDONLJK);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IFGFJPJBMBD(ONOFPFCCGPJ MBCPMMHPENP, CALKAHELOOG BMDDAEFCKNN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LICEHFAGJJH<T> : ALKOPEINFBL where T : class, ONOFPFCCGPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLOHBAGDPJC(T MBCPMMHPENP, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLOHBAGDPJC(T MBCPMMHPENP, Transform DGEPPJAANCA, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJHEJNEGCKN(T DFPLMDONLJK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ONOFPFCCGPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform AOOGIIEBLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FOIDAKOAIBK DOFFEAJCHKC, FOIDAKOAIBK DFEJJMNJAAI);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MFCCDKLMMLE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum CALKAHELOOG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FOIDAKOAIBK
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
