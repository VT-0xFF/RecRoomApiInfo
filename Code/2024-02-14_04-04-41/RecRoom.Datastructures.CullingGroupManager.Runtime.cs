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
			[Cpp2IlInjected.Address(RVA = "0x3203840", Offset = "0x3202C40", VA = "0x183203840")]
			internal EJNLGCADPJG(int EELFJJCHLDP, float[] NIGPMNGOICO, LIBENAODHMH ANNDIDDBPFD = LIBENAODHMH.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x32037C0", Offset = "0x3202BC0", VA = "0x1832037C0", Slot = "10")]
			public void FLOHBAGDPJC(T MBCPMMHPENP, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x32037F0", Offset = "0x3202BF0", VA = "0x1832037F0", Slot = "11")]
			public void FLOHBAGDPJC(T MBCPMMHPENP, Transform DGEPPJAANCA, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3203820", Offset = "0x3202C20", VA = "0x183203820", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
				public PMIPKINDKPG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5F1D7F0", Offset = "0x5F1CBF0", VA = "0x185F1D7F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD38420", Offset = "0xD37820", VA = "0x180D38420")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3DD72F0", Offset = "0x3DD66F0", VA = "0x183DD72F0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5F1D400", Offset = "0x5F1C800", VA = "0x185F1D400")]
			internal FLCGAIKBHOH(int EELFJJCHLDP, float[] NIGPMNGOICO, LIBENAODHMH ANNDIDDBPFD = LIBENAODHMH.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5F1BFC0", Offset = "0x5F1B3C0", VA = "0x185F1BFC0")]
			public void DKAFEGPPHEN(bool FEMNBAGCEDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5F1C740", Offset = "0x5F1BB40", VA = "0x185F1C740", Slot = "6")]
			public void FLOHBAGDPJC(ONOFPFCCGPJ MBCPMMHPENP, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5F1C7D0", Offset = "0x5F1BBD0", VA = "0x185F1C7D0", Slot = "9")]
			public void FLOHBAGDPJC(ONOFPFCCGPJ MBCPMMHPENP, Transform DGEPPJAANCA, float NLAEHEEAFBH, CALKAHELOOG AOFGOOBPHHL = CALKAHELOOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5F1CD20", Offset = "0x5F1C120", VA = "0x185F1CD20")]
			public void MBKKNMOCNDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5F1BBF0", Offset = "0x5F1AFF0", VA = "0x185F1BBF0")]
			private void CJDELJONODH(int OJANCMLFDOJ, [Optional] float? NLAEHEEAFBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5F1CFB0", Offset = "0x5F1C3B0", VA = "0x185F1CFB0", Slot = "7")]
			public void NJHEJNEGCKN(ONOFPFCCGPJ DFPLMDONLJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5F1CBC0", Offset = "0x5F1BFC0", VA = "0x185F1CBC0", Slot = "8")]
			public void IFGFJPJBMBD(ONOFPFCCGPJ MBCPMMHPENP, CALKAHELOOG JCFHKGFEGFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5F1BFF0", Offset = "0x5F1B3F0", VA = "0x185F1BFF0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5F1B860", Offset = "0x5F1AC60", VA = "0x185F1B860")]
			private void BPMHLPDPCJL(OMNILKAOLFN MGHLCIOKNKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5F1BD20", Offset = "0x5F1B120", VA = "0x185F1BD20")]
			private void DGPOKIKJKDK(OMNILKAOLFN MGHLCIOKNKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5F1D3A0", Offset = "0x5F1C7A0", VA = "0x185F1D3A0")]
			private void ODOOMKKBEPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5F1CCC0", Offset = "0x5F1C0C0", VA = "0x185F1CCC0")]
			private void KHBOKIDJFLI(float PLEPJKNDBHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5F1CE70", Offset = "0x5F1C270", VA = "0x185F1CE70")]
			private void MDPEEOGLFKL(OMNILKAOLFN MGHLCIOKNKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5F1CCB0", Offset = "0x5F1C0B0", VA = "0x185F1CCB0")]
			private void IJPEJCHOBKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5F1D390", Offset = "0x5F1C790", VA = "0x185F1D390")]
			private void NLGAKGJOIHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5F1C2B0", Offset = "0x5F1B6B0", VA = "0x185F1C2B0")]
			private void EFPJMPDCCKJ(CullingGroupEvent AOBNCCPAFBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5F1C5D0", Offset = "0x5F1B9D0", VA = "0x185F1C5D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KKEEGFAPLDK LJCHBOEHPFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KKEEGFAPLDK FDODGFPGEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PMBPGIOGIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBF3010", Offset = "0xBF2410", VA = "0x180BF3010", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KLLKLMHOGPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7F4190", Offset = "0x7F3590", VA = "0x1807F4190", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7F3C90", Offset = "0x7F3090", VA = "0x1807F3C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A640", Offset = "0x5F19A40", VA = "0x185F1A640", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F1AD30", Offset = "0x5F1A130", VA = "0x185F1AD30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F1AD10", Offset = "0x5F1A110", VA = "0x185F1AD10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A5E0", Offset = "0x5F199E0", VA = "0x185F1A5E0")]
		private void AECPLDCIDEB(Scene KIGINGBAPMD, LoadSceneMode GBFDMJLKPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F1AC30", Offset = "0x5F1A030", VA = "0x185F1AC30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B2F0", Offset = "0x5F1A6F0", VA = "0x185F1B2F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A700", Offset = "0x5F19B00", VA = "0x185F1A700")]
		private void BJGAOALLGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B0B0", Offset = "0x5F1A4B0", VA = "0x185F1B0B0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F1AF30", Offset = "0x5F1A330", VA = "0x185F1AF30")]
		private void PKBPAAKBDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F1AA00", Offset = "0x5F19E00", VA = "0x185F1AA00")]
		public ALKOPEINFBL GetOrCreateCullingGroup(Type JOIBCJBLEDL, int MJPLCAMIMGI, ushort GICEIMBJBKL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x24DF2B0", Offset = "0x24DE6B0", VA = "0x1824DF2B0")]
		public LICEHFAGJJH<T> GetOrCreateCullingGroup<T>(int MJPLCAMIMGI, ushort GICEIMBJBKL = 0) where T : class, ONOFPFCCGPJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F1AD50", Offset = "0x5F1A150", VA = "0x185F1AD50")]
		private ALKOPEINFBL PEJDIJPIGGI(Type JOIBCJBLEDL, int MJPLCAMIMGI, float[] NIGPMNGOICO, ushort GICEIMBJBKL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24DF350", Offset = "0x24DE750", VA = "0x1824DF350")]
		private LICEHFAGJJH<T> PEJDIJPIGGI<T>(int MJPLCAMIMGI, float[] NIGPMNGOICO, ushort GICEIMBJBKL = 0) where T : class, ONOFPFCCGPJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A8A0", Offset = "0x5F19CA0", VA = "0x185F1A8A0")]
		public static FOIDAKOAIBK FindClosestDefaultUpdateLod(float CHFGLNCAJDM)
		{
			return default(FOIDAKOAIBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFB0", Offset = "0x7CA3B0", VA = "0x1807CAFB0")]
		public static FOIDAKOAIBK MinUpdateLod(FOIDAKOAIBK BDJJBBGKGHF, FOIDAKOAIBK LBMBEHGEICJ)
		{
			return default(FOIDAKOAIBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F1AC20", Offset = "0x5F1A020", VA = "0x185F1AC20")]
		public static FOIDAKOAIBK MaxUpdateLod(FOIDAKOAIBK BDJJBBGKGHF, FOIDAKOAIBK LBMBEHGEICJ)
		{
			return default(FOIDAKOAIBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B760", Offset = "0x5F1AB60", VA = "0x185F1B760")]
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
