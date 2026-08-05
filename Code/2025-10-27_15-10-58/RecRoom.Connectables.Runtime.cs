using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Creation;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.RPC;
using RecRoom.ObjectModel;
using RecRoom.Protobuf;
using UJect;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86385F0", Offset = "0x86375F0", VA = "0x1886385F0", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] LHVPIFQWCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] LHQIKYWYSQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EVWCTMNURRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset EWBJQTHSBCX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x24AA5C0", Offset = "0x24A95C0", VA = "0x1824AA5C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86443F0", Offset = "0x86433F0", VA = "0x1886443F0")]
		private void SSAHAHAUBXG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8644540", Offset = "0x8643540", VA = "0x188644540")]
		private void SSFNXNURLIP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86440E0", Offset = "0x86430E0", VA = "0x1886440E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8644690", Offset = "0x8643690", VA = "0x188644690")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : BONINMIQGTT, AXORFOQTGRK
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JIOZJZIVYOX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public YXVHLKGIDGF RBEPUGKERAV;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public JIOZJZIVYOX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8631980", Offset = "0x8630980", VA = "0x188631980")]
			internal object CJHIISNGGHI(YXVHLKGIDGF a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JIJSMSOYPDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public YXVHLKGIDGF WICVSZEERZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JIOZJZIVYOX OYIFPNPIBTY;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public JIJSMSOYPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8631730", Offset = "0x8630730", VA = "0x188631730")]
			internal object CJMPFZHDPSR((YXVHLKGIDGF child, YXVHLKGIDGF nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class XSKONFKZRMM : IEnumerable<GCAFAZALTZU>, IEnumerable, IEnumerator<GCAFAZALTZU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private GCAFAZALTZU IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int FMHFHEECSRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId RBUTAZXQOGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId QFKKVCTDICU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private BSRRZNNEGRQ KYCPYTSNTOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray WYDTIKENNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator WDYSBUHTFMD;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private GCAFAZALTZU NXSMTJSQLWQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xBB3120", Offset = "0xBB2120", VA = "0x180BB3120")]
			[DebuggerHidden]
			public XSKONFKZRMM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8643FC0", Offset = "0x8642FC0", VA = "0x188643FC0", Slot = "7")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8643C60", Offset = "0x8642C60", VA = "0x188643C60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x86440C0", Offset = "0x86430C0", VA = "0x1886440C0")]
			private void ZLAPFDWYPLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x86440A0", Offset = "0x86430A0", VA = "0x1886440A0")]
			private void ZKVIHXDBGAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8643B70", Offset = "0x8642B70", VA = "0x188643B70", Slot = "10")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8643BB0", Offset = "0x8642BB0", VA = "0x188643BB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GCAFAZALTZU> VAJFEJOZIUP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8643BB0", Offset = "0x8642BB0", VA = "0x188643BB0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log RKWJRCLBSOI;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log CHKCJYFIPMC;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log EKAISDSYCOG;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log QNYAHEHUXKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private YZBBOESZPFD LZCCPYQMAYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JCSPYOKZILI JPXCADTCCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private RXQKKAIWGJF BMQCWESXTKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NYQHQDYNZLR RGMEXGNFAUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private FYGUGTKHMYT HOSMCISHCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private XRHRZRXAJUR PAJTXMDORDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly UBVYIUXJIWS WWSSUQEQUGN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GZOGBLRDHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xADAB60", Offset = "0xAD9B60", VA = "0x180ADAB60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xADA3A0", Offset = "0xAD93A0", VA = "0x180ADA3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PRELZWMNHOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<GCAFAZALTZU, GCAFAZALTZU> GYCHMKDLNQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x863D2E0", Offset = "0x863C2E0", VA = "0x18863D2E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x863C010", Offset = "0x863B010", VA = "0x18863C010", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<GCAFAZALTZU, GCAFAZALTZU> ZGPOMWPPDKL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x863B620", Offset = "0x863A620", VA = "0x18863B620", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x863CDC0", Offset = "0x863BDC0", VA = "0x18863CDC0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<GCAFAZALTZU, GCAFAZALTZU, GCAFAZALTZU> NTTGYNOLQIR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x863EF10", Offset = "0x863DF10", VA = "0x18863EF10", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x863BA80", Offset = "0x863AA80", VA = "0x18863BA80", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x863FA50", Offset = "0x863EA50", VA = "0x18863FA50")]
		public OMConnectableManager(QXIJOLGHAIZ container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x863C340", Offset = "0x863B340", VA = "0x18863C340", Slot = "12")]
		public void Initialize(GameObject gameObject, CLOUCUVZUWQ configData, SRICDBZAGBR sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x863BB50", Offset = "0x863AB50", VA = "0x18863BB50", Slot = "26")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x863BFC0", Offset = "0x863AFC0", VA = "0x18863BFC0", Slot = "22")]
		public bool HRDPBLMIZND(YXVHLKGIDGF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x863F450", Offset = "0x863E450", VA = "0x18863F450")]
		private void ZKVZBFCNBUS(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x863C0C0", Offset = "0x863B0C0", VA = "0x18863C0C0")]
		private void HYYEMHAQNVC(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x863E100", Offset = "0x863D100", VA = "0x18863E100")]
		private void UYHRVBKFUCW(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x863B210", Offset = "0x863A210", VA = "0x18863B210")]
		private void APHGKXAWGZL(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x863EFC0", Offset = "0x863DFC0", VA = "0x18863EFC0", Slot = "14")]
		public void YTBQRMTMKZK(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "15")]
		public void GXZDBUQWFXF(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x863E7B0", Offset = "0x863D7B0", VA = "0x18863E7B0", Slot = "17")]
		public void XZWGFXLXPXM(GCAFAZALTZU a, GCAFAZALTZU b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x863E910", Offset = "0x863D910", VA = "0x18863E910")]
		public void XZWGFXLXPXM(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x863E010", Offset = "0x863D010", VA = "0x18863E010")]
		public void TTZEEGBXJNA(GCAFAZALTZU a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x863D4D0", Offset = "0x863C4D0", VA = "0x18863D4D0", Slot = "18")]
		public void RLEKLIJFPQG(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x863B9D0", Offset = "0x863A9D0", VA = "0x18863B9D0")]
		private float DOGKMECIREO(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x863D390", Offset = "0x863C390", VA = "0x18863D390")]
		public void RLEKLIJFPQG(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x863B860", Offset = "0x863A860", VA = "0x18863B860", Slot = "19")]
		public void CBZQPTMSDYI(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x863E3D0", Offset = "0x863D3D0", VA = "0x18863E3D0", Slot = "16")]
		public void WKFMNKTTQDO(GCAFAZALTZU a, HashSet<GCAFAZALTZU> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "20")]
		public ConnectableGraphData NMVBGZLURLP(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "21")]
		public ConnectableGraphData JAUZQDTKAYD(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x863E360", Offset = "0x863D360", VA = "0x18863E360", Slot = "23")]
		public void WAENZUYMCFA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x863D270", Offset = "0x863C270", VA = "0x18863D270", Slot = "24")]
		public void OIHGAJVZHHK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x863BB30", Offset = "0x863AB30", VA = "0x18863BB30", Slot = "25")]
		public void EQBHUGCLCQJ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x863CE70", Offset = "0x863BE70", VA = "0x18863CE70")]
		private void NHCRQTIXPSA(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x863D630", Offset = "0x863C630", VA = "0x18863D630")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x863CBC0", Offset = "0x863BBC0", VA = "0x18863CBC0")]
		private void LYGNPMNEDHB(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x863CB30", Offset = "0x863BB30", VA = "0x18863CB30")]
		[IteratorStateMachine(typeof(XSKONFKZRMM))]
		public IEnumerable<GCAFAZALTZU> JPBODAQJWPC(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x863EDE0", Offset = "0x863DDE0", VA = "0x18863EDE0")]
		internal GCAFAZALTZU YFTZFATEUHN(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x863BD20", Offset = "0x863AD20", VA = "0x18863BD20")]
		internal ObjectLocalId FLFYXTSAQVN(GCAFAZALTZU a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x863C5B0", Offset = "0x863B5B0", VA = "0x18863C5B0")]
		private bool JJYSXQCKCHU(YXVHLKGIDGF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x863E0A0", Offset = "0x863D0A0", VA = "0x18863E0A0")]
		private bool TZDRYXKGDCG(YXVHLKGIDGF a, [Out] GCAFAZALTZU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x863EA50", Offset = "0x863DA50", VA = "0x18863EA50")]
		private GCAFAZALTZU YFTZFATEUHN(YXVHLKGIDGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x863B090", Offset = "0x863A090", VA = "0x18863B090")]
		private GCAFAZALTZU AJRJEHKFEEE(YXVHLKGIDGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x863E5E0", Offset = "0x863D5E0", VA = "0x18863E5E0")]
		private GCAFAZALTZU XVFCYCDSPHT(YXVHLKGIDGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8639F90", Offset = "0x8638F90", VA = "0x188639F90")]
		private static Guid MAOSLSHSQJM(YXVHLKGIDGF a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x863DF20", Offset = "0x863CF20", VA = "0x18863DF20")]
		private string TRFIEXALOLJ(YXVHLKGIDGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x863CC30", Offset = "0x863BC30", VA = "0x18863CC30")]
		private void LYSLNHOPWAM(GCAFAZALTZU a, GCAFAZALTZU b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x863B6D0", Offset = "0x863A6D0", VA = "0x18863B6D0")]
		private void BAFDJFHRBAI(GCAFAZALTZU a, GCAFAZALTZU b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x863C2E0", Offset = "0x863B2E0", VA = "0x18863C2E0")]
		private void IBGMSJGNVCK(GCAFAZALTZU a, GCAFAZALTZU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x863F2C0", Offset = "0x863E2C0", VA = "0x18863F2C0")]
		private void ZBROEHNHEIX(GCAFAZALTZU a, GCAFAZALTZU b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x863BEB0", Offset = "0x863AEB0", VA = "0x18863BEB0")]
		private void GJVBQUIMIMO(ObjectLocalId a, GCAFAZALTZU b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x863F660", Offset = "0x863E660", VA = "0x18863F660")]
		private void ZQLJJDKYDON(ObjectLocalId a, GCAFAZALTZU b, GCAFAZALTZU c, GCAFAZALTZU d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MTOGTGOAYUQ
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HPYOHBTXMAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public QXIJOLGHAIZ container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HPYOHBTXMAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x86313B0", Offset = "0x86303B0", VA = "0x1886313B0")]
			internal OMConnectableManager MREPZTVTBOS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8638890", Offset = "0x8637890", VA = "0x188638890")]
		public static void NGORISUBURE(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8638840", Offset = "0x8637840", VA = "0x188638840")]
		public static void JWSOHQFNLLD(QXIJOLGHAIZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : QXDYKEUXOSW, KYBMRDPQCRN
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx OVAYHBSWOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager LZNUJHMXJVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly XWHUZZHTZUY HIZMDKIYWDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly IRMDIEDPCZC RGMEXGNFAUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly MJIQGYEAHWO[] XKFXNEKPESS;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GCAFAZALTZU ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8641660", Offset = "0x8640660", VA = "0x188641660", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GCAFAZALTZU DHYDATZEGIF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x86400D0", Offset = "0x863F0D0", VA = "0x1886400D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 URWMWILYFRV
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x863FD50", Offset = "0x863ED50", VA = "0x18863FD50", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion XRZWKPWSFCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8640790", Offset = "0x863F790", VA = "0x188640790", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KNPFEHISYCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8640F30", Offset = "0x863FF30", VA = "0x188640F30", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<GCAFAZALTZU> TUGJGBEZXDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8640C00", Offset = "0x863FC00", VA = "0x188640C00", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool CHPDQPAXDQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xE61210", Offset = "0xE60210", VA = "0x180E61210", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xF64490", Offset = "0xF63490", VA = "0x180F64490", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8641860", Offset = "0x8640860", VA = "0x188641860", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8641580", Offset = "0x8640580", VA = "0x188641580", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x86415A0", Offset = "0x86405A0", VA = "0x1886415A0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x86416C0", Offset = "0x86406C0", VA = "0x1886416C0", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x86417A0", Offset = "0x86407A0", VA = "0x1886417A0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool GWGXFQPIFDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x863FEF0", Offset = "0x863EEF0", VA = "0x18863FEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler BKTMTAWHLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x86406F0", Offset = "0x863F6F0", VA = "0x1886406F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x86405D0", Offset = "0x863F5D0", VA = "0x1886405D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler EVPBOPBWGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x863FE50", Offset = "0x863EE50", VA = "0x18863FE50", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8640390", Offset = "0x863F390", VA = "0x188640390", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler CVQAQBLNCCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x863FD00", Offset = "0x863ED00", VA = "0x18863FD00", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8641090", Offset = "0x8640090", VA = "0x188641090", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler KAODEIOAREJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x863FFE0", Offset = "0x863EFE0", VA = "0x18863FFE0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x863FF40", Offset = "0x863EF40", VA = "0x18863FF40", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8641480", Offset = "0x8640480", VA = "0x188641480")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, XWHUZZHTZUY connectableTool, MJIQGYEAHWO[] connectionPoints, IRMDIEDPCZC callbacks, BONINMIQGTT connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x863FCD0", Offset = "0x863ECD0", VA = "0x18863FCD0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "21")]
		public void DEGSVGTMPYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8640F10", Offset = "0x863FF10", VA = "0x188640F10", Slot = "22")]
		public void RPRXVYUDTJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8640FC0", Offset = "0x863FFC0", VA = "0x188640FC0", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x863FAC0", Offset = "0x863EAC0", VA = "0x18863FAC0", Slot = "25")]
		public void AUCIWUBYAXL(int a, GCAFAZALTZU b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8640620", Offset = "0x863F620", VA = "0x188640620", Slot = "26")]
		public void LCTUEDBMAAZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8640C30", Offset = "0x863FC30", VA = "0x188640C30", Slot = "27")]
		public void RKCBYXWYWKD(int a, GCAFAZALTZU b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8641010", Offset = "0x8640010", VA = "0x188641010", Slot = "28")]
		public void TZHIZRTXNHX(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86407F0", Offset = "0x863F7F0", VA = "0x1886407F0", Slot = "31")]
		public void NNIWVZQWIPE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x86410E0", Offset = "0x86400E0", VA = "0x1886410E0", Slot = "29")]
		public void XHIFHXMVTJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x86403E0", Offset = "0x863F3E0", VA = "0x1886403E0", Slot = "30")]
		public void JICIUIEFSKD(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86402C0", Offset = "0x863F2C0", VA = "0x1886402C0", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8640190", Offset = "0x863F190", VA = "0x188640190", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xBBE070", Offset = "0xBBD070", VA = "0x180BBE070", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x863FDB0", Offset = "0x863EDB0", VA = "0x18863FDB0", Slot = "43")]
		public bool CanConnectTo(int slotIndex, GCAFAZALTZU otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "44")]
		public void ParentChanged(int slotIndex, GCAFAZALTZU newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "45")]
		public void ChildAdded(int slotIndex, GCAFAZALTZU newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "46")]
		public void ChildRemoved(int slotIndex, GCAFAZALTZU removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "47")]
		public void ConnectionModified(int slotIndex, GCAFAZALTZU parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8640FA0", Offset = "0x863FFA0", VA = "0x188640FA0", Slot = "48")]
		public void RootChanged(GCAFAZALTZU previousRootConnectable, GCAFAZALTZU newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8640080", Offset = "0x863F080", VA = "0x188640080", Slot = "23")]
		public void GKGQEKZLEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8640740", Offset = "0x863F740", VA = "0x188640740", Slot = "24")]
		public void MTJQMAHWIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x863FEA0", Offset = "0x863EEA0", VA = "0x18863FEA0")]
		private void EXVYOGXBPVQ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(ENLXPPHGLXJ), new string[] { })]
	public class HDITLZAXBZO : ENLXPPHGLXJ, OYGFOCCYTLG, LTOXHYHZXEQ
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class YNXANUMFTWX
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public YNXANUMFTWX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private JYRMWDDJPHF WGPDOGRACKA;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object ZOXVIDWOPSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8631260", Offset = "0x8630260", VA = "0x188631260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x86312F0", Offset = "0x86302F0", VA = "0x1886312F0", Slot = "5")]
		private void SMUSGLXJIVI(GQPULEKOHTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1019640", Offset = "0x1018640", VA = "0x181019640", Slot = "6")]
		private void CXZMGJMBDJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public HDITLZAXBZO()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(BONINMIQGTT), new string[] { "Ignore", "Mock" })]
	public class EUVVNZYJHYK : BONINMIQGTT, AXORFOQTGRK
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool GZOGBLRDHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool PRELZWMNHOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<GCAFAZALTZU, GCAFAZALTZU> GYCHMKDLNQR
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8630FC0", Offset = "0x862FFC0", VA = "0x188630FC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8630E60", Offset = "0x862FE60", VA = "0x188630E60", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<GCAFAZALTZU, GCAFAZALTZU> ZGPOMWPPDKL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8630D00", Offset = "0x862FD00", VA = "0x188630D00", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8630F10", Offset = "0x862FF10", VA = "0x188630F10", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<GCAFAZALTZU, GCAFAZALTZU, GCAFAZALTZU> NTTGYNOLQIR
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8631070", Offset = "0x8630070", VA = "0x188631070", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8630DB0", Offset = "0x862FDB0", VA = "0x188630DB0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "26")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "12")]
		public void Initialize(GameObject gameObject, CLOUCUVZUWQ configData, SRICDBZAGBR rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "14")]
		public void YTBQRMTMKZK(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "15")]
		public void GXZDBUQWFXF(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "16")]
		public void WKFMNKTTQDO(GCAFAZALTZU a, HashSet<GCAFAZALTZU> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "17")]
		public void XZWGFXLXPXM(GCAFAZALTZU a, GCAFAZALTZU b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "18")]
		public void RLEKLIJFPQG(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "19")]
		public void CBZQPTMSDYI(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "20")]
		public ConnectableGraphData NMVBGZLURLP(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "21")]
		public ConnectableGraphData JAUZQDTKAYD(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "22")]
		public bool HRDPBLMIZND(YXVHLKGIDGF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "23")]
		public void WAENZUYMCFA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "24")]
		public void OIHGAJVZHHK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "25")]
		public void EQBHUGCLCQJ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public EUVVNZYJHYK()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GCAFAZALTZU : KYBMRDPQCRN, IEquatable<GCAFAZALTZU>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface KYBMRDPQCRN
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		GCAFAZALTZU ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Vector3 GetConnectionSlotLocalPosition(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Vector3 GetConnectionSlotPosition(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Color GetConnectionSlotColor(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool CanConnectTo(int slotIndex, GCAFAZALTZU otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, GCAFAZALTZU newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, GCAFAZALTZU newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, GCAFAZALTZU removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, GCAFAZALTZU parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(GCAFAZALTZU previousRootConnectable, GCAFAZALTZU newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BONINMIQGTT : AXORFOQTGRK
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool GZOGBLRDHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool PRELZWMNHOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<GCAFAZALTZU, GCAFAZALTZU> GYCHMKDLNQR;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<GCAFAZALTZU, GCAFAZALTZU> ZGPOMWPPDKL;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<GCAFAZALTZU, GCAFAZALTZU, GCAFAZALTZU> NTTGYNOLQIR;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, CLOUCUVZUWQ configData, SRICDBZAGBR rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void YTBQRMTMKZK(GCAFAZALTZU a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GXZDBUQWFXF(GCAFAZALTZU a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void WKFMNKTTQDO(GCAFAZALTZU a, HashSet<GCAFAZALTZU> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void XZWGFXLXPXM(GCAFAZALTZU a, GCAFAZALTZU b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void RLEKLIJFPQG(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void CBZQPTMSDYI(GCAFAZALTZU a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData NMVBGZLURLP(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData JAUZQDTKAYD(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool HRDPBLMIZND(YXVHLKGIDGF a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void WAENZUYMCFA(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void OIHGAJVZHHK(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void EQBHUGCLCQJ(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface NYQHQDYNZLR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool WKTDGOKMBTG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GCAFAZALTZU XVFCYCDSPHT(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GCAFAZALTZU AJRJEHKFEEE(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool WHUPEPOVJHC(GCAFAZALTZU a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool FTFXQXBETCE();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PJQDTVECALF(GCAFAZALTZU a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface IRMDIEDPCZC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool GWGXFQPIFDC(XWHUZZHTZUY a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NTNPSZXHUDH(XWHUZZHTZUY a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string UKAGMYTGYXC(XWHUZZHTZUY a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid QJRJCWDRCYL(XWHUZZHTZUY a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int TYZKWFAHVMY(XWHUZZHTZUY a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TJSYQJXKOHB(XWHUZZHTZUY a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(GCAFAZALTZU childConnectable, int childConnectableSlot, GCAFAZALTZU parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(GCAFAZALTZU previousRootConnectable, GCAFAZALTZU newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface XWHUZZHTZUY : GCAFAZALTZU, KYBMRDPQCRN, IEquatable<GCAFAZALTZU>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface QXDYKEUXOSW : KYBMRDPQCRN
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		GCAFAZALTZU DHYDATZEGIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<GCAFAZALTZU> TUGJGBEZXDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 URWMWILYFRV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion XRZWKPWSFCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool KNPFEHISYCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool CHPDQPAXDQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler BKTMTAWHLIP;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler EVPBOPBWGBL;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler CVQAQBLNCCS;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler KAODEIOAREJ;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void DEGSVGTMPYX();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void RPRXVYUDTJC();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void GKGQEKZLEEF();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void MTJQMAHWIMO();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void AUCIWUBYAXL(int a, GCAFAZALTZU b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void LCTUEDBMAAZ();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void RKCBYXWYWKD(int a, GCAFAZALTZU b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void TZHIZRTXNHX(GCAFAZALTZU a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void XHIFHXMVTJK();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void JICIUIEFSKD(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void NNIWVZQWIPE(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface MJIQGYEAHWO
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 CMNHTXFBYPX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface CLOUCUVZUWQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool XMRJOMFYSEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ENGFCVLGFYD SXSJICZKPRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, CLOUCUVZUWQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool XMRJOMFYSEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xBF9560", Offset = "0xBF8560", VA = "0x180BF9560", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ENGFCVLGFYD SXSJICZKPRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x862F980", Offset = "0x862E980", VA = "0x18862F980")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x862FA40", Offset = "0x862EA40", VA = "0x18862FA40")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public GCAFAZALTZU connectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int slot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int parentSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8630030", Offset = "0x862F030", VA = "0x188630030")]
		public ConnectableLink(GCAFAZALTZU connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x862FF00", Offset = "0x862EF00", VA = "0x18862FF00")]
		public ConnectableLink(GCAFAZALTZU connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x862FFA0", Offset = "0x862EFA0", VA = "0x18862FFA0")]
		public ConnectableLink(GCAFAZALTZU connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x862FA90", Offset = "0x862EA90", VA = "0x18862FA90", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x862FB40", Offset = "0x862EB40", VA = "0x18862FB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : RKKKIHGEJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform SHMGNXCOSGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ENGFCVLGFYD LPFHKTMVJRB;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7FA8960", Offset = "0x7FA7960", VA = "0x187FA8960", Slot = "4")]
		public void Initialize(Transform transform, ENGFCVLGFYD linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x86319F0", Offset = "0x86309F0", VA = "0x1886319F0", Slot = "5")]
		public ENGFCVLGFYD DRCYDQUDPDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8631AB0", Offset = "0x8630AB0", VA = "0x188631AB0", Slot = "6")]
		public void KVVKGEWJZER(ENGFCVLGFYD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, ABRGPZTMIYF
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class MCMUCCAHCCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public GCAFAZALTZU CJYMLHMUZMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public GCAFAZALTZU KBRGSFJDOTT;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public MCMUCCAHCCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8638780", Offset = "0x8637780", VA = "0x188638780")]
			internal bool EVPBTFAKEOH(CCRJMEGMACC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly DWQFCNFPNJV JRJYBIXELUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private QDJKOHTVKES UHIUYTOBGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private PMHQAUBGKZQ BTVGSHNLFKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool CABDHGVESXU;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log UTAQTMYDEGM;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public CCRJMEGMACC BMMCJSHXUWV
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8633C40", Offset = "0x8632C40", VA = "0x188633C40")]
		public bool YHROGMGSKQS([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8634680", Offset = "0x8633680", VA = "0x188634680")]
		private bool WELKHDINLQB([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86356F0", Offset = "0x86346F0", VA = "0x1886356F0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x86334A0", Offset = "0x86324A0", VA = "0x1886334A0", Slot = "5")]
		public void Initialize(BONINMIQGTT manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8632EC0", Offset = "0x8631EC0", VA = "0x188632EC0", Slot = "17")]
		public void EPCSGINIKYD(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8633760", Offset = "0x8632760", VA = "0x188633760", Slot = "12")]
		public void KMDWFPIFMBM(Func<GCAFAZALTZU, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8633770", Offset = "0x8632770", VA = "0x188633770")]
		private void KMDWFPIFMBM(DWQFCNFPNJV a, Func<GCAFAZALTZU, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x86330C0", Offset = "0x86320C0", VA = "0x1886330C0", Slot = "11")]
		public void FQCWSEJFNWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x86330B0", Offset = "0x86320B0", VA = "0x1886330B0", Slot = "8")]
		public bool EUQJZXUBIXZ(GCAFAZALTZU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8633F20", Offset = "0x8632F20", VA = "0x188633F20")]
		private bool TIHZIVTFXOY(GCAFAZALTZU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8633550", Offset = "0x8632550", VA = "0x188633550")]
		private static bool JBKSEFNWSNA(GCAFAZALTZU a, DWQFCNFPNJV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8632AD0", Offset = "0x8631AD0", VA = "0x188632AD0")]
		private void DXULIUOFDTW(Transform a, DWQFCNFPNJV b, DWQFCNFPNJV[] c, GCAFAZALTZU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8633C50", Offset = "0x8632C50", VA = "0x188633C50")]
		private ConnectableLink PALMXSAQDWB(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8632EF0", Offset = "0x8631EF0", VA = "0x188632EF0")]
		private static bool ETGGKVIJXQY(DWQFCNFPNJV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8634620", Offset = "0x8633620", VA = "0x188634620", Slot = "9")]
		public bool UJJRPIGOIEH(GCAFAZALTZU a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8635190", Offset = "0x8634190", VA = "0x188635190")]
		private bool ZERDCFIFUVC(GCAFAZALTZU a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8633DA0", Offset = "0x8632DA0", VA = "0x188633DA0")]
		private static void SVJVTPLLXOX(GCAFAZALTZU a, int b, int c, Vector3 d, Quaternion e, DWQFCNFPNJV f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x86338A0", Offset = "0x86328A0", VA = "0x1886338A0")]
		private void LYSLNHOPWAM(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8632450", Offset = "0x8631450", VA = "0x188632450")]
		private void CCAINYVSGAY(DWQFCNFPNJV a, GCAFAZALTZU b, GCAFAZALTZU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x86324C0", Offset = "0x86314C0", VA = "0x1886324C0")]
		private void CCAINYVSGAY(GCAFAZALTZU a, GCAFAZALTZU b, GCAFAZALTZU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x86354E0", Offset = "0x86344E0", VA = "0x1886354E0")]
		private void ZQLJJDKYDON(GCAFAZALTZU a, GCAFAZALTZU b, GCAFAZALTZU c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x86353E0", Offset = "0x86343E0", VA = "0x1886353E0")]
		private void ZQLJJDKYDON(DWQFCNFPNJV a, GCAFAZALTZU b, GCAFAZALTZU c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8632330", Offset = "0x8631330", VA = "0x188632330")]
		private void BAFDJFHRBAI(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8633270", Offset = "0x8632270", VA = "0x188633270")]
		private void IBGMSJGNVCK(CCRJMEGMACC a, CCRJMEGMACC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8633600", Offset = "0x8632600", VA = "0x188633600", Slot = "18")]
		public GCAFAZALTZU KERWNUMCJYL(GCAFAZALTZU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8634C40", Offset = "0x8633C40", VA = "0x188634C40", Slot = "13")]
		public void WKFMNKTTQDO(GCAFAZALTZU a, HashSet<GCAFAZALTZU> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8633A00", Offset = "0x8632A00", VA = "0x188633A00", Slot = "14")]
		public List<GCAFAZALTZU> MLXHVOVOJKY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8635550", Offset = "0x8634550", VA = "0x188635550")]
		protected CCRJMEGMACC ZUXJGHUWLYD(CCRJMEGMACC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x86350F0", Offset = "0x86340F0", VA = "0x1886350F0")]
		protected DWQFCNFPNJV[] XYSFDSONMRG(DWQFCNFPNJV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8634FE0", Offset = "0x8633FE0", VA = "0x188634FE0")]
		protected bool XWJSBBECTAJ(GCAFAZALTZU a, [Out] DWQFCNFPNJV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8633140", Offset = "0x8632140", VA = "0x188633140", Slot = "15")]
		public bool HEJMPXBMQJH(GCAFAZALTZU a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x86339C0", Offset = "0x86329C0", VA = "0x1886339C0")]
		protected DWQFCNFPNJV LZCVHWTYNUO(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x86330E0", Offset = "0x86320E0", VA = "0x1886330E0", Slot = "10")]
		public bool HEDVMBUMXYV(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8632530", Offset = "0x8631530", VA = "0x188632530")]
		private bool CDLZUGZXDGM(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x86333D0", Offset = "0x86323D0", VA = "0x1886333D0")]
		private static bool IJLZVTPKWUC(DWQFCNFPNJV a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8633C40", Offset = "0x8632C40", VA = "0x188633C40", Slot = "7")]
		private bool NKDATJFXDNN([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : BONINMIQGTT, AXORFOQTGRK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly QXIJOLGHAIZ container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly PMHQAUBGKZQ BTVGSHNLFKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly WCBXUYZJGCH EJDWAPHBPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly NUYYJSJUFWB USIXADGEEBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly ABRGPZTMIYF ETUZYAYUXHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal OTHKWZWQHTM RGMEXGNFAUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal TFROLBEYQRP XATNJPLCUAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal QDJKOHTVKES DZHZOPKMDMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool CABDHGVESXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool CCVWAXZNALV;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool USAEGHMICGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB19E90", Offset = "0xB18E90", VA = "0x180B19E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xB19A80", Offset = "0xB18A80", VA = "0x180B19A80")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool GZOGBLRDHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xBE8B70", Offset = "0xBE7B70", VA = "0x180BE8B70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xBE8BC0", Offset = "0xBE7BC0", VA = "0x180BE8BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PRELZWMNHOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<GCAFAZALTZU, GCAFAZALTZU> GYCHMKDLNQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8636DB0", Offset = "0x8635DB0", VA = "0x188636DB0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8636040", Offset = "0x8635040", VA = "0x188636040", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<GCAFAZALTZU, GCAFAZALTZU> ZGPOMWPPDKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x86358A0", Offset = "0x86348A0", VA = "0x1886358A0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x86369E0", Offset = "0x86359E0", VA = "0x1886369E0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<GCAFAZALTZU, GCAFAZALTZU, GCAFAZALTZU> NTTGYNOLQIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x86374B0", Offset = "0x86364B0", VA = "0x1886374B0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8635E20", Offset = "0x8634E20", VA = "0x188635E20", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8637530", Offset = "0x8636530", VA = "0x188637530")]
		public LegacyConnectableManager(QXIJOLGHAIZ container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x86360A0", Offset = "0x86350A0", VA = "0x1886360A0", Slot = "12")]
		public void Initialize(GameObject gameObject, CLOUCUVZUWQ configData, SRICDBZAGBR rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8635EC0", Offset = "0x8634EC0", VA = "0x188635EC0", Slot = "26")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x86370A0", Offset = "0x86360A0", VA = "0x1886370A0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8637510", Offset = "0x8636510", VA = "0x188637510", Slot = "14")]
		public void YTBQRMTMKZK(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8635F90", Offset = "0x8634F90", VA = "0x188635F90", Slot = "15")]
		public void GXZDBUQWFXF(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8635FF0", Offset = "0x8634FF0", VA = "0x188635FF0", Slot = "22")]
		public bool HRDPBLMIZND(YXVHLKGIDGF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8635AC0", Offset = "0x8634AC0", VA = "0x188635AC0")]
		internal bool CDLZUGZXDGM([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8636F50", Offset = "0x8635F50", VA = "0x188636F50")]
		internal bool SKVUVWXYGVI([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8636800", Offset = "0x8635800", VA = "0x188636800")]
		internal void KBKFCEIDZBI(GCAFAZALTZU a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8635F90", Offset = "0x8634F90", VA = "0x188635F90")]
		internal bool RQEYJUBOQZW(GCAFAZALTZU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8636BC0", Offset = "0x8635BC0", VA = "0x188636BC0")]
		internal bool OFXVASQEDDE(GCAFAZALTZU a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x86371B0", Offset = "0x86361B0", VA = "0x1886371B0", Slot = "16")]
		public void WKFMNKTTQDO(GCAFAZALTZU a, HashSet<GCAFAZALTZU> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x86372A0", Offset = "0x86362A0", VA = "0x1886372A0", Slot = "17")]
		public void XZWGFXLXPXM(GCAFAZALTZU a, GCAFAZALTZU b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8636E10", Offset = "0x8635E10", VA = "0x188636E10", Slot = "18")]
		public void RLEKLIJFPQG(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8635900", Offset = "0x8634900", VA = "0x188635900", Slot = "19")]
		public void CBZQPTMSDYI(GCAFAZALTZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8635BD0", Offset = "0x8634BD0", VA = "0x188635BD0")]
		public void DMEBVESXGGF([Optional] XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8637120", Offset = "0x8636120", VA = "0x188637120", Slot = "23")]
		public void WAENZUYMCFA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8636A40", Offset = "0x8635A40", VA = "0x188636A40", Slot = "20")]
		public ConnectableGraphData NMVBGZLURLP(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8636660", Offset = "0x8635660", VA = "0x188636660", Slot = "21")]
		public ConnectableGraphData JAUZQDTKAYD(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8635E80", Offset = "0x8634E80", VA = "0x188635E80", Slot = "25")]
		public void EQBHUGCLCQJ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8636D00", Offset = "0x8635D00", VA = "0x188636D00", Slot = "24")]
		public void OIHGAJVZHHK(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class PMHQAUBGKZQ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly BJLPDMMCTUP<GCAFAZALTZU, GCAFAZALTZU> GYCHMKDLNQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly BJLPDMMCTUP<GCAFAZALTZU, GCAFAZALTZU> ZGPOMWPPDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly BJGIGFSFKJG<GCAFAZALTZU, GCAFAZALTZU, GCAFAZALTZU> NTTGYNOLQIR;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x86419C0", Offset = "0x86409C0", VA = "0x1886419C0")]
		public PMHQAUBGKZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8641880", Offset = "0x8640880", VA = "0x188641880")]
		public void CNSLSPWJEAJ(GCAFAZALTZU a, GCAFAZALTZU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8641960", Offset = "0x8640960", VA = "0x188641960")]
		public void MTIQGMYWYST(GCAFAZALTZU a, GCAFAZALTZU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x86418E0", Offset = "0x86408E0", VA = "0x1886418E0")]
		public void JUVIKGQWHKV(GCAFAZALTZU a, GCAFAZALTZU b, GCAFAZALTZU c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class WCBXUYZJGCH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager LFODWQYYRMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TFROLBEYQRP XATNJPLCUAP;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public WCBXUYZJGCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8642850", Offset = "0x8641850", VA = "0x188642850")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8642840", Offset = "0x8641840", VA = "0x188642840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8642AF0", Offset = "0x8641AF0", VA = "0x188642AF0")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8642A80", Offset = "0x8641A80", VA = "0x188642A80")]
		private void OnMasterClientSwitched(XLYBIIWOHJI newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8642980", Offset = "0x8641980", VA = "0x188642980")]
		public void JNZAHCSOFSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8642B30", Offset = "0x8641B30", VA = "0x188642B30")]
		public void YCMZATMRMLI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class UUDTDTRQURB
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class HPYOHBTXMAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public QXIJOLGHAIZ container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HPYOHBTXMAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8631450", Offset = "0x8630450", VA = "0x188631450")]
			internal LegacyConnectableManager MREPZTVTBOS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8642650", Offset = "0x8641650", VA = "0x188642650")]
		public static void NGORISUBURE(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x86425D0", Offset = "0x86415D0", VA = "0x1886425D0")]
		public static void JWSOHQFNLLD(QXIJOLGHAIZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, QDJKOHTVKES
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, ENGFCVLGFYD> VUDDWNRLEEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation JIQTKFQWIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private RKKKIHGEJAJ ONEVBDKCFQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private ABRGPZTMIYF ETUZYAYUXHR;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker OEACWELJAVH;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8638520", Offset = "0x8637520", VA = "0x188638520")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8637F70", Offset = "0x8636F70", VA = "0x188637F70", Slot = "7")]
		public void Initialize(ABRGPZTMIYF graph, RKKKIHGEJAJ creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8637A30", Offset = "0x8636A30", VA = "0x188637A30", Slot = "5")]
		public void CNFCCVAYHJA(CCRJMEGMACC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x86378C0", Offset = "0x86368C0", VA = "0x1886378C0", Slot = "9")]
		public void AIVTDFNXUNL(CCRJMEGMACC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8638300", Offset = "0x8637300", VA = "0x188638300", Slot = "8")]
		public void ZJWSTOBZSRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8637FB0", Offset = "0x8636FB0", VA = "0x188637FB0", Slot = "10")]
		public void WWIPLYZKYXI(CCRJMEGMACC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8637E20", Offset = "0x8636E20", VA = "0x188637E20", Slot = "11")]
		public void DMCTSSPCVUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8637C70", Offset = "0x8636C70", VA = "0x188637C70")]
		private bool DHNWCNRIDSZ(CCRJMEGMACC a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class NUYYJSJUFWB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly DWQFCNFPNJV currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly YXVHLKGIDGF parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly YXVHLKGIDGF rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool LMLSEGWDMQK
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x8642250", Offset = "0x8641250", VA = "0x188642250")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8642360", Offset = "0x8641360", VA = "0x188642360")]
			public SerializeNodeInSubgraph(DWQFCNFPNJV currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] YXVHLKGIDGF parentNodeData, [Optional] YXVHLKGIDGF rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8641FF0", Offset = "0x8640FF0", VA = "0x188641FF0")]
			public YXVHLKGIDGF LDGVYQLXUAF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8642190", Offset = "0x8641190", VA = "0x188642190")]
			private YXVHLKGIDGF RLXDAHDBLTT([Out] YXVHLKGIDGF a, [Out] YXVHLKGIDGF b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8641C30", Offset = "0x8640C30", VA = "0x188641C30")]
			private YXVHLKGIDGF IUIIVSJOGPF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8641AC0", Offset = "0x8640AC0", VA = "0x188641AC0")]
			private void BYHHASJPXFX(YXVHLKGIDGF a, YXVHLKGIDGF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8641E30", Offset = "0x8640E30", VA = "0x188641E30")]
			private void IXKONMHRCHU(YXVHLKGIDGF a, YXVHLKGIDGF b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager LFODWQYYRMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ABRGPZTMIYF ETUZYAYUXHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private QDJKOHTVKES UHIUYTOBGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TFROLBEYQRP XATNJPLCUAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool HCMOJYPSUQN;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool CMWALDKJGOW
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x8638B20", Offset = "0x8637B20", VA = "0x188638B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool USAEGHMICGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x863A460", Offset = "0x8639460", VA = "0x18863A460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x863B000", Offset = "0x863A000", VA = "0x18863B000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8639430", Offset = "0x8638430", VA = "0x188639430")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8639FD0", Offset = "0x8638FD0", VA = "0x188639FD0")]
		public ConnectableGraphData NMVBGZLURLP(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x86394A0", Offset = "0x86384A0", VA = "0x1886394A0")]
		public ConnectableGraphData JAUZQDTKAYD(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x863A9B0", Offset = "0x86399B0", VA = "0x18863A9B0")]
		public void WAENZUYMCFA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x863A3C0", Offset = "0x86393C0", VA = "0x18863A3C0")]
		public void OIHGAJVZHHK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8639F60", Offset = "0x8638F60", VA = "0x188639F60")]
		public void KWGXBTQQVSW(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x863A480", Offset = "0x8639480", VA = "0x18863A480")]
		private void QMFKOFSNGUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x863AF20", Offset = "0x8639F20", VA = "0x18863AF20")]
		private YXVHLKGIDGF YXMEEPIZKHT(DWQFCNFPNJV a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8639CB0", Offset = "0x8638CB0", VA = "0x188639CB0")]
		private static void KAUGYUCKDGN(DWQFCNFPNJV a, bool b, YXVHLKGIDGF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8638D60", Offset = "0x8637D60", VA = "0x188638D60")]
		private void FGAZMHQPUXM(DWQFCNFPNJV a, bool b, YXVHLKGIDGF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x86393A0", Offset = "0x86383A0", VA = "0x1886393A0")]
		private YXVHLKGIDGF IAMIXNJQKXV(DWQFCNFPNJV a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x863A140", Offset = "0x8639140", VA = "0x18863A140")]
		private bool OCKAUVSUDTV(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8639640", Offset = "0x8638640", VA = "0x188639640")]
		private bool JJYSXQCKCHU(YXVHLKGIDGF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x863ABC0", Offset = "0x8639BC0", VA = "0x18863ABC0")]
		private bool YDZEXLVZBLO(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8638A00", Offset = "0x8637A00", VA = "0x188638A00")]
		private static bool AJYUTZDVFVT(YXVHLKGIDGF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8639110", Offset = "0x8638110", VA = "0x188639110")]
		public static bool HRDPBLMIZND(YXVHLKGIDGF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x863ABE0", Offset = "0x8639BE0", VA = "0x18863ABE0")]
		private GCAFAZALTZU YFTZFATEUHN(YXVHLKGIDGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x863AA40", Offset = "0x8639A40", VA = "0x18863AA40")]
		private GCAFAZALTZU XVFCYCDSPHT(YXVHLKGIDGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8638F80", Offset = "0x8637F80", VA = "0x188638F80")]
		private GCAFAZALTZU GODZFNQMYAY(YXVHLKGIDGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8639F90", Offset = "0x8638F90", VA = "0x188639F90")]
		private static Guid MAOSLSHSQJM(YXVHLKGIDGF a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x863A8C0", Offset = "0x86398C0", VA = "0x18863A8C0")]
		private string TRFIEXALOLJ(YXVHLKGIDGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8638B70", Offset = "0x8637B70", VA = "0x188638B70")]
		private bool EOCFMTASKDU(DWQFCNFPNJV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x863A660", Offset = "0x8639660", VA = "0x18863A660")]
		private static void SHFDKTVLKBW(DWQFCNFPNJV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public NUYYJSJUFWB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public GCAFAZALTZU child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public GCAFAZALTZU parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int childSlotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int parentSlotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ConnectableLink AVFZZZQTRRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x86300C0", Offset = "0x862F0C0", VA = "0x1886300C0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink PSMXYGBXTIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8630090", Offset = "0x862F090", VA = "0x188630090")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8630160", Offset = "0x862F160", VA = "0x188630160")]
		public ConnectionOperationData(GCAFAZALTZU child, GCAFAZALTZU parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface ABRGPZTMIYF
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		CCRJMEGMACC BMMCJSHXUWV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(BONINMIQGTT manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool YHROGMGSKQS([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EUQJZXUBIXZ(GCAFAZALTZU a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool UJJRPIGOIEH(GCAFAZALTZU a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HEDVMBUMXYV(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FQCWSEJFNWC();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void KMDWFPIFMBM(Func<GCAFAZALTZU, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WKFMNKTTQDO(GCAFAZALTZU a, HashSet<GCAFAZALTZU> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<GCAFAZALTZU> MLXHVOVOJKY();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HEJMPXBMQJH(GCAFAZALTZU a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void EPCSGINIKYD(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(CCRJMEGMACC node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface CCRJMEGMACC
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		GCAFAZALTZU VTNNLPCJHDT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CCRJMEGMACC JOFMWEARERP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink OGFGZTJBEGR
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool GLKLVHLGQER
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface ENGFCVLGFYD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RTFNZEQTDKX(GCAFAZALTZU a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TVIYWZIFFTZ(GCAFAZALTZU a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FCUECQLDIPC(GCAFAZALTZU a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OMHTPFWXWEU(GCAFAZALTZU a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ENGFCVLGFYD UFSGTMJZGEH(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface RKKKIHGEJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, ENGFCVLGFYD linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ENGFCVLGFYD DRCYDQUDPDL();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KVVKGEWJZER(ENGFCVLGFYD a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface OTHKWZWQHTM : NYQHQDYNZLR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MQHWGSKBAXC();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CGNBFEKTMHD(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface QDJKOHTVKES
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CNFCCVAYHJA(CCRJMEGMACC a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(ABRGPZTMIYF graph, RKKKIHGEJAJ linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZJWSTOBZSRF();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AIVTDFNXUNL(CCRJMEGMACC a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WWIPLYZKYXI(CCRJMEGMACC a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DMCTSSPCVUS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class DWQFCNFPNJV : CCRJMEGMACC
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class GKVBADAJPPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink KOKNXDJORGQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public DWQFCNFPNJV XXOJMMFFHGL;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public GKVBADAJPPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8631120", Offset = "0x8630120", VA = "0x188631120")]
			internal bool KOPIZMZJAIK(CCRJMEGMACC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink FEEJUQEPRMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<DWQFCNFPNJV> MJPURCLPGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DWQFCNFPNJV LGBXQNTSBGC;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink OGFGZTJBEGR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4AAFB40", Offset = "0x4AAEB40", VA = "0x184AAFB40", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8630890", Offset = "0x862F890", VA = "0x188630890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private DWQFCNFPNJV NDQRRLBLRIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x86308C0", Offset = "0x862F8C0", VA = "0x1886308C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public CCRJMEGMACC JOFMWEARERP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public GCAFAZALTZU VTNNLPCJHDT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool GLKLVHLGQER
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x86304E0", Offset = "0x862F4E0", VA = "0x1886304E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool JDRIXDUYLEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x86301D0", Offset = "0x862F1D0", VA = "0x1886301D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected DWQFCNFPNJV IMODBVGEZXP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x86305E0", Offset = "0x862F5E0", VA = "0x1886305E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8630C60", Offset = "0x862FC60", VA = "0x188630C60")]
		public DWQFCNFPNJV(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x86309A0", Offset = "0x862F9A0", VA = "0x1886309A0")]
		public DWQFCNFPNJV XPTCUTSUPQS(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8630AE0", Offset = "0x862FAE0", VA = "0x188630AE0")]
		public DWQFCNFPNJV XPUVJPQSZDI(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8630600", Offset = "0x862F600", VA = "0x188630600")]
		public DWQFCNFPNJV Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8630220", Offset = "0x862F220", VA = "0x188630220")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x86307E0", Offset = "0x862F7E0", VA = "0x1886307E0")]
		public DWQFCNFPNJV Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8630380", Offset = "0x862F380", VA = "0x188630380")]
		private static void EPCSGINIKYD(DWQFCNFPNJV a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8630370", Offset = "0x862F370", VA = "0x188630370", Slot = "9")]
		public void EPCSGINIKYD(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x86304F0", Offset = "0x862F4F0", VA = "0x1886304F0")]
		public static DWQFCNFPNJV LZCVHWTYNUO(DWQFCNFPNJV a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface TFROLBEYQRP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool CMWALDKJGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool WKTDGOKMBTG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> PWFMDLHAEDI;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<XLYBIIWOHJI> NOETYHQJERK;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RTFNZEQTDKX(LegacyConnectableManager a, SRICDBZAGBR b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void XZWGFXLXPXM(GCAFAZALTZU a, GCAFAZALTZU b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RLEKLIJFPQG(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LLYLZOULKIL(ConnectableGraphData a, [Optional] XLYBIIWOHJI b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class IHRLSHNREKR
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8631640", Offset = "0x8630640", VA = "0x188631640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x86316F0", Offset = "0x86306F0", VA = "0x1886316F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8631690", Offset = "0x8630690", VA = "0x188631690")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class WEXGZIFRGGG : TFROLBEYQRP, IDisposable, SZFSQMIWMYN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager LFODWQYYRMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private SRICDBZAGBR CDHCITDYSML;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool CMWALDKJGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8642C30", Offset = "0x8641C30", VA = "0x188642C30", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool WKTDGOKMBTG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8642FE0", Offset = "0x8641FE0", VA = "0x188642FE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView SBPFIYCWMPT
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8643020", Offset = "0x8642020", VA = "0x188643020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> PWFMDLHAEDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8642D80", Offset = "0x8641D80", VA = "0x188642D80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x8642CE0", Offset = "0x8641CE0", VA = "0x188642CE0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<XLYBIIWOHJI> NOETYHQJERK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8642E20", Offset = "0x8641E20", VA = "0x188642E20", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8643AD0", Offset = "0x8642AD0", VA = "0x188643AD0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x86431D0", Offset = "0x86421D0", VA = "0x1886431D0", Slot = "10")]
		public void RTFNZEQTDKX(LegacyConnectableManager a, SRICDBZAGBR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8642C90", Offset = "0x8641C90", VA = "0x188642C90", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x86439B0", Offset = "0x86429B0", VA = "0x1886439B0", Slot = "11")]
		public void XZWGFXLXPXM(GCAFAZALTZU a, GCAFAZALTZU b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x86430B0", Offset = "0x86420B0", VA = "0x1886430B0", Slot = "12")]
		public void RLEKLIJFPQG(GCAFAZALTZU a, int b, GCAFAZALTZU c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8642EC0", Offset = "0x8641EC0", VA = "0x188642EC0", Slot = "13")]
		public void LLYLZOULKIL(ConnectableGraphData a, [Optional] XLYBIIWOHJI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8643490", Offset = "0x8642490", VA = "0x188643490")]
		[RPCMethod]
		private void RpcMasterReparentNodes(GCAFAZALTZU objectToReparent, int objectToReparentSlotIndex, GCAFAZALTZU newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x86432A0", Offset = "0x86422A0", VA = "0x1886432A0")]
		[RPCMethod]
		private void RpcMasterModifyNode(GCAFAZALTZU connectableToModify, GCAFAZALTZU expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8643880", Offset = "0x8642880", VA = "0x188643880")]
		[RPCMethod]
		private void RpcReparentNodes(GCAFAZALTZU objectToReparent, int objectToReparentSlotIndex, GCAFAZALTZU newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8643790", Offset = "0x8642790", VA = "0x188643790")]
		[RPCMethod]
		private void RpcModifyNode(GCAFAZALTZU connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8643260", Offset = "0x8642260", VA = "0x188643260")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public WEXGZIFRGGG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, ENGFCVLGFYD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x86321B0", Offset = "0x86311B0", VA = "0x1886321B0", Slot = "4")]
		private void TUBVOBTMSLA(GCAFAZALTZU a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8631DE0", Offset = "0x8630DE0", VA = "0x188631DE0", Slot = "5")]
		private void HWRYOUMDLAS(GCAFAZALTZU a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8632050", Offset = "0x8631050", VA = "0x188632050", Slot = "6")]
		private void QVSXWTJWBPB(GCAFAZALTZU a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8631B20", Offset = "0x8630B20", VA = "0x188631B20", Slot = "7")]
		private void DRPIJXHRTIN(GCAFAZALTZU a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8631D10", Offset = "0x8630D10", VA = "0x188631D10", Slot = "8")]
		private ENGFCVLGFYD EHNYVTCYIIM(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8631D80", Offset = "0x8630D80", VA = "0x188631D80", Slot = "9")]
		private void GMGAEHFVECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xACE140", Offset = "0xACD140", VA = "0x180ACE140")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class JDJIMWFEWRF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A14280", Offset = "0x3A13280", VA = "0x183A14280")]
		public static MPVGSCHGGYE<a> KIBVBYPUKML<a>(this QXIJOLGHAIZ a)
		{
			return null;
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
