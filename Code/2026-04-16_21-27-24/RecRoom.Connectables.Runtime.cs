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
		[Cpp2IlInjected.Address(RVA = "0x974C570", Offset = "0x974B370", VA = "0x18974C570", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		private int[] SSKDGXUXNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] SSEWJRBADRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset DGANWLFFZHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset DGFUTRZDISL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x222F190", Offset = "0x222DF90", VA = "0x18222F190", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9758410", Offset = "0x9757210", VA = "0x189758410")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9758560", Offset = "0x9757360", VA = "0x189758560")]
		private void TZHSANLRDRN(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9758100", Offset = "0x9756F00", VA = "0x189758100", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97586B0", Offset = "0x97574B0", VA = "0x1897586B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : SOQQTKUCHLH, JQVAGBYEMGQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class PGPARRHLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public SCPBEECOAOZ QPNTNGNXDHH;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PGPARRHLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9753260", Offset = "0x9752060", VA = "0x189753260")]
			internal object DCRKRNWMSTY(SCPBEECOAOZ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class PGJTUKNOLTW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public SCPBEECOAOZ THRSXZJSBAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PGPARRHLVFF DODNVPQZHNM;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PGJTUKNOLTW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9753010", Offset = "0x9751E10", VA = "0x189753010")]
			internal object DCWROUQKCFH((SCPBEECOAOZ child, SCPBEECOAOZ nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class XQYJXHPVKDK : IEnumerable<UYQXJOAYWYC>, IEnumerable, IEnumerator<UYQXJOAYWYC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private UYQXJOAYWYC OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId BQAOBVBQYQR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId DBSMZDSUWTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private OBZQXNTSABQ ZWWDAEIITJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray XKHLIQMUIOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator ULLOQJYIRFJ;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private UYQXJOAYWYC NZOMZHNXRSQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public XQYJXHPVKDK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9757FA0", Offset = "0x9756DA0", VA = "0x189757FA0", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9757C40", Offset = "0x9756A40", VA = "0x189757C40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x97580E0", Offset = "0x9756EE0", VA = "0x1897580E0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x97580C0", Offset = "0x9756EC0", VA = "0x1897580C0")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9758080", Offset = "0x9756E80", VA = "0x189758080", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9757B90", Offset = "0x9756990", VA = "0x189757B90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<UYQXJOAYWYC> LXKEGUMWSUX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9757B90", Offset = "0x9756990", VA = "0x189757B90", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log MHQRHCMNYDG;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log IPQQRWFLJYS;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log BQCETNLJNLI;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log HPLMDYHKWKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private VNFKLFXAIZX POYCVSGFMIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DCWNNOKPZMC IFFYBAZUSGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private VODJGPWQMWD MENYQRALORY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ZTLPXUATZKT BGDHEBCZSVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private QDKPRRZDPPZ MSJZBKLIPEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TARWWCUVBYJ YRJXWERUBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly KJVXVBNUPJI GUKAWUKYTGZ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCE7920", Offset = "0xCE6720", VA = "0x180CE7920", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCE82C0", Offset = "0xCE70C0", VA = "0x180CE82C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool RTUYCLFSOWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> GJWSEXEBRVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x97502A0", Offset = "0x974F0A0", VA = "0x1897502A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x974D680", Offset = "0x974C480", VA = "0x18974D680", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> OJWZLYDMXHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x974D8C0", Offset = "0x974C6C0", VA = "0x18974D8C0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x974EDC0", Offset = "0x974DBC0", VA = "0x18974EDC0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC, UYQXJOAYWYC> QUBVCYFXIDL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x97509D0", Offset = "0x974F7D0", VA = "0x1897509D0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9750AF0", Offset = "0x974F8F0", VA = "0x189750AF0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x97511E0", Offset = "0x974FFE0", VA = "0x1897511E0")]
		public OMConnectableManager(MZEBANDYSXL container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x974DD30", Offset = "0x974CB30", VA = "0x18974DD30", Slot = "12")]
		public void Initialize(GameObject gameObject, BKXJUQHPCRC configData, WCGQZYDJZIP sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x974E510", Offset = "0x974D310", VA = "0x18974E510", Slot = "26")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x974CDB0", Offset = "0x974BBB0", VA = "0x18974CDB0", Slot = "22")]
		public bool DDJJAPMNGTT(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x974F7A0", Offset = "0x974E5A0", VA = "0x18974F7A0")]
		private void QWWJJQFGHLU(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x974DA00", Offset = "0x974C800", VA = "0x18974DA00")]
		private void GRAPZHBVMVW(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9750DA0", Offset = "0x974FBA0", VA = "0x189750DA0")]
		private void YFYZXDBGKZI(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x974CF90", Offset = "0x974BD90", VA = "0x18974CF90")]
		private void DMODPEYZATP(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x974CAB0", Offset = "0x974B8B0", VA = "0x18974CAB0", Slot = "14")]
		public void CBYRPQCEVDS(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "15")]
		public void WRENKBCPLUL(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x974E8A0", Offset = "0x974D6A0", VA = "0x18974E8A0", Slot = "17")]
		public void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x974EA00", Offset = "0x974D800", VA = "0x18974EA00")]
		public void NKBBQVTHMGK(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x974D970", Offset = "0x974C770", VA = "0x18974D970")]
		public void GJPEFOXOYLY(UYQXJOAYWYC a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x974C7F0", Offset = "0x974B5F0", VA = "0x18974C7F0", Slot = "18")]
		public void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x974DC80", Offset = "0x974CA80", VA = "0x18974DC80")]
		private float IKFWRJABMQK(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x974C950", Offset = "0x974B750", VA = "0x18974C950")]
		public void BKRUUVXEXDY(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x974E3A0", Offset = "0x974D1A0", VA = "0x18974E3A0", Slot = "19")]
		public void KBQNKNMUSGI(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9750BA0", Offset = "0x974F9A0", VA = "0x189750BA0", Slot = "16")]
		public void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "20")]
		public ConnectableGraphData VXIDSANVEDT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "21")]
		public ConnectableGraphData RTFKHTNAKHN(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9751000", Offset = "0x974FE00", VA = "0x189751000", Slot = "23")]
		public void YPCGSTWAFKK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9750A80", Offset = "0x974F880", VA = "0x189750A80", Slot = "24")]
		public void VKWITVDZISQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x974CA90", Offset = "0x974B890", VA = "0x18974CA90", Slot = "25")]
		public void BNZTKFSXHMV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x974DFA0", Offset = "0x974CDA0", VA = "0x18974DFA0")]
		private void JOEABLPZTWQ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x974F9B0", Offset = "0x974E7B0", VA = "0x18974F9B0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x974E6E0", Offset = "0x974D4E0", VA = "0x18974E6E0")]
		private void MWQRYGSYLXZ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x974EE70", Offset = "0x974DC70", VA = "0x18974EE70")]
		[IteratorStateMachine(typeof(XQYJXHPVKDK))]
		public IEnumerable<UYQXJOAYWYC> PATIYMSIVCI(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x97508A0", Offset = "0x974F6A0", VA = "0x1897508A0")]
		internal UYQXJOAYWYC VBYFKXZGYVZ(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x974CE00", Offset = "0x974BC00", VA = "0x18974CE00")]
		internal ObjectLocalId DJSGNZZTUXZ(UYQXJOAYWYC a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x974F220", Offset = "0x974E020", VA = "0x18974F220")]
		private bool QPWVQZMUFQG(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x974E750", Offset = "0x974D550", VA = "0x18974E750")]
		private bool MXXSNBFCAMW(SCPBEECOAOZ a, [Out] UYQXJOAYWYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9750510", Offset = "0x974F310", VA = "0x189750510")]
		private UYQXJOAYWYC VBYFKXZGYVZ(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9750350", Offset = "0x974F150", VA = "0x189750350")]
		private UYQXJOAYWYC UJSBMTVBMSQ(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x974D4B0", Offset = "0x974C2B0", VA = "0x18974D4B0")]
		private UYQXJOAYWYC EPLSWYJPWHH(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x97504D0", Offset = "0x974F2D0", VA = "0x1897504D0")]
		private static Guid UOBELYANCGC(SCPBEECOAOZ a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x974E7B0", Offset = "0x974D5B0", VA = "0x18974E7B0")]
		private string NGGCBPZOXEL(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x974D730", Offset = "0x974C530", VA = "0x18974D730")]
		private void FFFKYXCMKJC(UYQXJOAYWYC a, UYQXJOAYWYC b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x974EF00", Offset = "0x974DD00", VA = "0x18974EF00")]
		private void PIJBWSMRAWI(UYQXJOAYWYC a, UYQXJOAYWYC b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x974DC20", Offset = "0x974CA20", VA = "0x18974DC20")]
		private void HCDZOBMDZTY(UYQXJOAYWYC a, UYQXJOAYWYC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x974F090", Offset = "0x974DE90", VA = "0x18974F090")]
		private void QMNJLMNWPXF(UYQXJOAYWYC a, UYQXJOAYWYC b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x974D3A0", Offset = "0x974C1A0", VA = "0x18974D3A0")]
		private void EHIMEJTLQQG(ObjectLocalId a, UYQXJOAYWYC b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x974EB40", Offset = "0x974D940", VA = "0x18974EB40")]
		private void OADUOPHDADH(ObjectLocalId a, UYQXJOAYWYC b, UYQXJOAYWYC c, UYQXJOAYWYC d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FTMBLTMKKMQ
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public MZEBANDYSXL container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9744FC0", Offset = "0x9743DC0", VA = "0x189744FC0")]
			internal OMConnectableManager BHQTQRZNXEW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9744E00", Offset = "0x9743C00", VA = "0x189744E00")]
		public static void AVTEYYUEURU(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9744F70", Offset = "0x9743D70", VA = "0x189744F70")]
		public static void LWHEMXMFXVX(MZEBANDYSXL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : AMQTMLRMXVU, WDYNUZLSVJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager JSKLVTMLVHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly VAQUCYXNLCM OVXDNUNSUWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly DQZHHYHLPYA BGDHEBCZSVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly NFYBVXRHWHI[] ITFMNKHCLMS;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public UYQXJOAYWYC ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9752DF0", Offset = "0x9751BF0", VA = "0x189752DF0", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public UYQXJOAYWYC HCXYZTPFJUB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9751E90", Offset = "0x9750C90", VA = "0x189751E90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 VHBTACAGZTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9751320", Offset = "0x9750120", VA = "0x189751320", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion SNBDOCCOJRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9752B20", Offset = "0x9751920", VA = "0x189752B20", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UGZXVWEUZGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x97514F0", Offset = "0x97502F0", VA = "0x1897514F0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<UYQXJOAYWYC> YIGTJYNXZQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9752280", Offset = "0x9751080", VA = "0x189752280", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool RBVWOZQEAFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD87750", Offset = "0xD86550", VA = "0x180D87750", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE6DA80", Offset = "0xE6C880", VA = "0x180E6DA80", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9752FF0", Offset = "0x9751DF0", VA = "0x189752FF0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9752D10", Offset = "0x9751B10", VA = "0x189752D10", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9752D30", Offset = "0x9751B30", VA = "0x189752D30", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9752E50", Offset = "0x9751C50", VA = "0x189752E50", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9752F30", Offset = "0x9751D30", VA = "0x189752F30", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool VIQCPVWISLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9752230", Offset = "0x9751030", VA = "0x189752230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler JZTVDHYQFSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x97516D0", Offset = "0x97504D0", VA = "0x1897516D0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9752A30", Offset = "0x9751830", VA = "0x189752A30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler DYDPPYAWPTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x97515B0", Offset = "0x97503B0", VA = "0x1897515B0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9751E40", Offset = "0x9750C40", VA = "0x189751E40", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler PKBXCUKFKUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x97524C0", Offset = "0x97512C0", VA = "0x1897524C0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9751560", Offset = "0x9750360", VA = "0x189751560", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler BNJHLICOWKR
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9752990", Offset = "0x9751790", VA = "0x189752990", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9752A80", Offset = "0x9751880", VA = "0x189752A80", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9752C10", Offset = "0x9751A10", VA = "0x189752C10")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, VAQUCYXNLCM connectableTool, NFYBVXRHWHI[] connectionPoints, DQZHHYHLPYA callbacks, SOQQTKUCHLH connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x97512F0", Offset = "0x97500F0", VA = "0x1897512F0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "21")]
		public void URDHSNOIFTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x97522B0", Offset = "0x97510B0", VA = "0x1897522B0", Slot = "22")]
		public void PETTYCGSXOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9752940", Offset = "0x9751740", VA = "0x189752940", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9751920", Offset = "0x9750720", VA = "0x189751920", Slot = "25")]
		public void HDIGKJYMSUJ(int a, UYQXJOAYWYC b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9751380", Offset = "0x9750180", VA = "0x189751380", Slot = "26")]
		public void CEDSORIXWHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9751F50", Offset = "0x9750D50", VA = "0x189751F50", Slot = "27")]
		public void MKUQGQLUBLV(int a, UYQXJOAYWYC b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9751600", Offset = "0x9750400", VA = "0x189751600", Slot = "28")]
		public void EFRWSUGLXJT(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9752510", Offset = "0x9751310", VA = "0x189752510", Slot = "31")]
		public void QCQAPMMFQTM(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9751B30", Offset = "0x9750930", VA = "0x189751B30", Slot = "29")]
		public void HKKZCUFFUUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x97522D0", Offset = "0x97510D0", VA = "0x1897522D0", Slot = "30")]
		public void PGOYYUDKJMD(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9751850", Offset = "0x9750650", VA = "0x189751850", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9751720", Offset = "0x9750520", VA = "0x189751720", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD4DBE0", Offset = "0xD4C9E0", VA = "0x180D4DBE0", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9751450", Offset = "0x9750250", VA = "0x189751450", Slot = "43")]
		public bool CanConnectTo(int slotIndex, UYQXJOAYWYC otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "44")]
		public void ParentChanged(int slotIndex, UYQXJOAYWYC newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "45")]
		public void ChildAdded(int slotIndex, UYQXJOAYWYC newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "46")]
		public void ChildRemoved(int slotIndex, UYQXJOAYWYC removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "47")]
		public void ConnectionModified(int slotIndex, UYQXJOAYWYC parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9752920", Offset = "0x9751720", VA = "0x189752920", Slot = "48")]
		public void RootChanged(UYQXJOAYWYC previousRootConnectable, UYQXJOAYWYC newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9751680", Offset = "0x9750480", VA = "0x189751680", Slot = "23")]
		public void FFJRPXNCAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x97512A0", Offset = "0x97500A0", VA = "0x1897512A0", Slot = "24")]
		public void AKAFGTKMAHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9751250", Offset = "0x9750050", VA = "0x189751250")]
		private void AEPLINLGHYS(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(RAJCNVDGZEH), new string[] { })]
	public class XGNWLWZEFVW : RAJCNVDGZEH, JIKZVPRDGWM, ORELWRZKHYY
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private ZBRSQBMDZBR IMRLHXLEJWU;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object MSHUNPRZOPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9757A90", Offset = "0x9756890", VA = "0x189757A90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9757A40", Offset = "0x9756840", VA = "0x189757A40", Slot = "5")]
		private void MBYFDPTTQYS(IKBIXEGYPOI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF418D0", Offset = "0xF406D0", VA = "0x180F418D0", Slot = "6")]
		private void NXHIFSUZYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public XGNWLWZEFVW()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(SOQQTKUCHLH), new string[] { "Ignore", "Mock" })]
	public class VEMBYXZDAGC : SOQQTKUCHLH, JQVAGBYEMGQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool RTUYCLFSOWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> GJWSEXEBRVH
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9755180", Offset = "0x9753F80", VA = "0x189755180", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9754F70", Offset = "0x9753D70", VA = "0x189754F70", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> OJWZLYDMXHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9755020", Offset = "0x9753E20", VA = "0x189755020", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x97550D0", Offset = "0x9753ED0", VA = "0x1897550D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC, UYQXJOAYWYC> QUBVCYFXIDL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9755230", Offset = "0x9754030", VA = "0x189755230", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x97552E0", Offset = "0x97540E0", VA = "0x1897552E0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "26")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "12")]
		public void Initialize(GameObject gameObject, BKXJUQHPCRC configData, WCGQZYDJZIP rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "14")]
		public void CBYRPQCEVDS(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "15")]
		public void WRENKBCPLUL(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "16")]
		public void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "17")]
		public void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "18")]
		public void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "19")]
		public void KBQNKNMUSGI(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "20")]
		public ConnectableGraphData VXIDSANVEDT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "21")]
		public ConnectableGraphData RTFKHTNAKHN(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "22")]
		public bool DDJJAPMNGTT(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "23")]
		public void YPCGSTWAFKK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "24")]
		public void VKWITVDZISQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "25")]
		public void BNZTKFSXHMV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public VEMBYXZDAGC()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface UYQXJOAYWYC : WDYNUZLSVJJ, IEquatable<UYQXJOAYWYC>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface WDYNUZLSVJJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		UYQXJOAYWYC ParentConnectable
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
		bool CanConnectTo(int slotIndex, UYQXJOAYWYC otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, UYQXJOAYWYC newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, UYQXJOAYWYC newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, UYQXJOAYWYC removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, UYQXJOAYWYC parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(UYQXJOAYWYC previousRootConnectable, UYQXJOAYWYC newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SOQQTKUCHLH : JQVAGBYEMGQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool RTUYCLFSOWU
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<UYQXJOAYWYC, UYQXJOAYWYC> GJWSEXEBRVH;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<UYQXJOAYWYC, UYQXJOAYWYC> OJWZLYDMXHJ;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<UYQXJOAYWYC, UYQXJOAYWYC, UYQXJOAYWYC> QUBVCYFXIDL;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, BKXJUQHPCRC configData, WCGQZYDJZIP rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void CBYRPQCEVDS(UYQXJOAYWYC a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void WRENKBCPLUL(UYQXJOAYWYC a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void KBQNKNMUSGI(UYQXJOAYWYC a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData VXIDSANVEDT(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData RTFKHTNAKHN(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool DDJJAPMNGTT(SCPBEECOAOZ a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void YPCGSTWAFKK(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void VKWITVDZISQ(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void BNZTKFSXHMV(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface ZTLPXUATZKT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UYQXJOAYWYC EPLSWYJPWHH(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		UYQXJOAYWYC UJSBMTVBMSQ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool UQCGPLQOLWU(UYQXJOAYWYC a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool YXWVWPBAKPO();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RANACOWKJMP(UYQXJOAYWYC a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DQZHHYHLPYA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VIQCPVWISLW(VAQUCYXNLCM a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FMYIRIDDGAV(VAQUCYXNLCM a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string ELTJGKZRZXO(VAQUCYXNLCM a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid RNOPRYXFSWH(VAQUCYXNLCM a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int OHBTMSPPMZS(VAQUCYXNLCM a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LOMAOWOBMQP(VAQUCYXNLCM a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(UYQXJOAYWYC childConnectable, int childConnectableSlot, UYQXJOAYWYC parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(UYQXJOAYWYC previousRootConnectable, UYQXJOAYWYC newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface VAQUCYXNLCM : UYQXJOAYWYC, WDYNUZLSVJJ, IEquatable<UYQXJOAYWYC>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface AMQTMLRMXVU : WDYNUZLSVJJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		UYQXJOAYWYC HCXYZTPFJUB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<UYQXJOAYWYC> YIGTJYNXZQB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 VHBTACAGZTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion SNBDOCCOJRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool UGZXVWEUZGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool RBVWOZQEAFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler JZTVDHYQFSD;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler DYDPPYAWPTL;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler PKBXCUKFKUG;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler BNJHLICOWKR;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void URDHSNOIFTJ();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void PETTYCGSXOQ();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void FFJRPXNCAFL();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void AKAFGTKMAHY();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void HDIGKJYMSUJ(int a, UYQXJOAYWYC b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void CEDSORIXWHL();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void MKUQGQLUBLV(int a, UYQXJOAYWYC b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void EFRWSUGLXJT(UYQXJOAYWYC a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void HKKZCUFFUUQ();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void PGOYYUDKJMD(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void QCQAPMMFQTM(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface NFYBVXRHWHI
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 ZOTMCNZXBQB
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
	public interface BKXJUQHPCRC
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool BEHOGNQFXXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		XAPCWFDGWNF UBNKTQQHWQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, BKXJUQHPCRC
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
		public bool BEHOGNQFXXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public XAPCWFDGWNF UBNKTQQHWQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9743670", Offset = "0x9742470", VA = "0x189743670")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9743730", Offset = "0x9742530", VA = "0x189743730")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public UYQXJOAYWYC connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x9743BF0", Offset = "0x97429F0", VA = "0x189743BF0")]
		public ConnectableLink(UYQXJOAYWYC connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9743C50", Offset = "0x9742A50", VA = "0x189743C50")]
		public ConnectableLink(UYQXJOAYWYC connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9743CF0", Offset = "0x9742AF0", VA = "0x189743CF0")]
		public ConnectableLink(UYQXJOAYWYC connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9743780", Offset = "0x9742580", VA = "0x189743780", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9743830", Offset = "0x9742630", VA = "0x189743830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : PKDIWYDSDAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform TKCNCOJLDNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private XAPCWFDGWNF MTVVWWKVBWX;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x906FA80", Offset = "0x906E880", VA = "0x18906FA80", Slot = "4")]
		public void Initialize(Transform transform, XAPCWFDGWNF linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x97457D0", Offset = "0x97445D0", VA = "0x1897457D0", Slot = "5")]
		public XAPCWFDGWNF TEAYKNAUEIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9745760", Offset = "0x9744560", VA = "0x189745760", Slot = "6")]
		public void SLQTXCHVXQZ(XAPCWFDGWNF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, CSOVYQVKJVH
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class IYQMCZATMGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public UYQXJOAYWYC UQCSRCHMDUQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public UYQXJOAYWYC GLFIIKQETOR;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public IYQMCZATMGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x9745490", Offset = "0x9744290", VA = "0x189745490")]
			internal bool LQUSHZTDFBV(BQEBEXQPNFA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly TDYHQSOOCDN ZXZTHMSXCSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private XAIEYZFQRLA METYWVVVILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IRRXGUDWHQO ZKUSRHDZZNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool DHPKNUYAQNY;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log VEHWXCYFSII;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BQEBEXQPNFA YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9748910", Offset = "0x9747710", VA = "0x189748910")]
		public bool SSTCPHHPHFM([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9746550", Offset = "0x9745350", VA = "0x189746550")]
		private bool CZXNLEUQPIR([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9749530", Offset = "0x9748330", VA = "0x189749530")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9747280", Offset = "0x9746080", VA = "0x189747280", Slot = "5")]
		public void Initialize(SOQQTKUCHLH manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x97487C0", Offset = "0x97475C0", VA = "0x1897487C0", Slot = "17")]
		public void OEJEEKIKLCT(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9747460", Offset = "0x9746260", VA = "0x189747460", Slot = "12")]
		public void JKLQHLVYHJQ(Func<UYQXJOAYWYC, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9747330", Offset = "0x9746130", VA = "0x189747330")]
		private void JKLQHLVYHJQ(TDYHQSOOCDN a, Func<UYQXJOAYWYC, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9748E40", Offset = "0x9747C40", VA = "0x189748E40", Slot = "11")]
		public void VCSUQAOKXHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9746C70", Offset = "0x9745A70", VA = "0x189746C70", Slot = "8")]
		public bool EMJOOVFRUIX(UYQXJOAYWYC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9747B30", Offset = "0x9746930", VA = "0x189747B30")]
		private bool LRPEYUFMMQQ(UYQXJOAYWYC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9746210", Offset = "0x9745010", VA = "0x189746210")]
		private static bool ASTMEXTNJMO(UYQXJOAYWYC a, TDYHQSOOCDN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9748920", Offset = "0x9747720", VA = "0x189748920")]
		private void TPSSPDBHAEQ(Transform a, TDYHQSOOCDN b, TDYHQSOOCDN[] c, UYQXJOAYWYC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9748F30", Offset = "0x9747D30", VA = "0x189748F30")]
		private ConnectableLink WCQQQFRFKBX(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9746390", Offset = "0x9745190", VA = "0x189746390")]
		private static bool CRHDKJEQLQI(TDYHQSOOCDN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9748DE0", Offset = "0x9747BE0", VA = "0x189748DE0", Slot = "9")]
		public bool UNOACROPHNR(UYQXJOAYWYC a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9746FD0", Offset = "0x9745DD0", VA = "0x189746FD0")]
		private bool IRPFALHSJPK(UYQXJOAYWYC a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9748120", Offset = "0x9746F20", VA = "0x189748120")]
		private static void MOTBIKHKCQX(UYQXJOAYWYC a, int b, int c, Vector3 d, Quaternion e, TDYHQSOOCDN f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9746C80", Offset = "0x9745A80", VA = "0x189746C80")]
		private void FFFKYXCMKJC(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9748D00", Offset = "0x9747B00", VA = "0x189748D00")]
		private void UEBOFTVSCRG(TDYHQSOOCDN a, UYQXJOAYWYC b, UYQXJOAYWYC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9748D70", Offset = "0x9747B70", VA = "0x189748D70")]
		private void UEBOFTVSCRG(UYQXJOAYWYC a, UYQXJOAYWYC b, UYQXJOAYWYC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9748650", Offset = "0x9747450", VA = "0x189748650")]
		private void OADUOPHDADH(UYQXJOAYWYC a, UYQXJOAYWYC b, UYQXJOAYWYC c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x97486C0", Offset = "0x97474C0", VA = "0x1897486C0")]
		private void OADUOPHDADH(TDYHQSOOCDN a, UYQXJOAYWYC b, UYQXJOAYWYC c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x97487F0", Offset = "0x97475F0", VA = "0x1897487F0")]
		private void PIJBWSMRAWI(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9746DA0", Offset = "0x9745BA0", VA = "0x189746DA0")]
		private void HCDZOBMDZTY(BQEBEXQPNFA a, BQEBEXQPNFA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9746B10", Offset = "0x9745910", VA = "0x189746B10", Slot = "18")]
		public UYQXJOAYWYC DNPAUXLLOIX(UYQXJOAYWYC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9749080", Offset = "0x9747E80", VA = "0x189749080", Slot = "13")]
		public void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9748410", Offset = "0x9747210", VA = "0x189748410", Slot = "14")]
		public List<UYQXJOAYWYC> NTJOONHQLNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x97462C0", Offset = "0x97450C0", VA = "0x1897462C0")]
		protected BQEBEXQPNFA AVECZYJWDBB(BQEBEXQPNFA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9746170", Offset = "0x9744F70", VA = "0x189746170")]
		protected TDYHQSOOCDN[] AOOTJVNZDHW(TDYHQSOOCDN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9748300", Offset = "0x9747100", VA = "0x189748300")]
		protected bool NEMTCMSACOJ(UYQXJOAYWYC a, [Out] TDYHQSOOCDN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9747A00", Offset = "0x9746800", VA = "0x189747A00", Slot = "15")]
		public bool JTVASFMWFVT(UYQXJOAYWYC a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9749420", Offset = "0x9748220", VA = "0x189749420")]
		protected TDYHQSOOCDN YXDRVYATCRY(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9746F70", Offset = "0x9745D70", VA = "0x189746F70", Slot = "10")]
		public bool HETWBMRLVJT(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9747470", Offset = "0x9746270", VA = "0x189747470")]
		private bool JODZLFTIXWM(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9748E60", Offset = "0x9747C60", VA = "0x189748E60")]
		private static bool VWTQVIDQMKW(TDYHQSOOCDN a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9748910", Offset = "0x9747710", VA = "0x189748910", Slot = "7")]
		private bool POUFOIRJUIT([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : SOQQTKUCHLH, JQVAGBYEMGQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly MZEBANDYSXL container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly IRRXGUDWHQO ZKUSRHDZZNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly TLZZIPWNTMX LEBWXSDWFWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly WISFGIZLQVP GHIAXQWYABZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly CSOVYQVKJVH KGGSALCPHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal LVINCAWIKVE BGDHEBCZSVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal STMWXQPJAAJ LMVVDSZGPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal XAIEYZFQRLA FADVNGFLBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool DHPKNUYAQNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool FJCOXMSPAPV;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FOHMKCZLQQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xD334C0", Offset = "0xD322C0", VA = "0x180D334C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD330B0", Offset = "0xD31EB0", VA = "0x180D330B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x131CD80", Offset = "0x131BB80", VA = "0x18131CD80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2855950", Offset = "0x2854750", VA = "0x182855950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool RTUYCLFSOWU
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> GJWSEXEBRVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x974ABC0", Offset = "0x97499C0", VA = "0x18974ABC0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x9749B50", Offset = "0x9748950", VA = "0x189749B50", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> OJWZLYDMXHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x9749BB0", Offset = "0x97489B0", VA = "0x189749BB0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x974A7E0", Offset = "0x97495E0", VA = "0x18974A7E0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC, UYQXJOAYWYC> QUBVCYFXIDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x974ACA0", Offset = "0x9749AA0", VA = "0x18974ACA0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x974ADB0", Offset = "0x9749BB0", VA = "0x18974ADB0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x974B350", Offset = "0x974A150", VA = "0x18974B350")]
		public LegacyConnectableManager(MZEBANDYSXL container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9749C10", Offset = "0x9748A10", VA = "0x189749C10", Slot = "12")]
		public void Initialize(GameObject gameObject, BKXJUQHPCRC configData, WCGQZYDJZIP rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x974A500", Offset = "0x9749300", VA = "0x18974A500", Slot = "26")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x974AC20", Offset = "0x9749A20", VA = "0x18974AC20", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9749860", Offset = "0x9748660", VA = "0x189749860", Slot = "14")]
		public void CBYRPQCEVDS(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x974A1D0", Offset = "0x9748FD0", VA = "0x18974A1D0", Slot = "15")]
		public void WRENKBCPLUL(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x97499B0", Offset = "0x97487B0", VA = "0x1897499B0", Slot = "22")]
		public bool DDJJAPMNGTT(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x974A230", Offset = "0x9749030", VA = "0x18974A230")]
		internal bool JODZLFTIXWM([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9749A00", Offset = "0x9748800", VA = "0x189749A00")]
		internal bool EJSPQMASVWK([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x974A840", Offset = "0x9749640", VA = "0x18974A840")]
		internal void PGPPKYMTSLY(UYQXJOAYWYC a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x974A1D0", Offset = "0x9748FD0", VA = "0x18974A1D0")]
		internal bool JMRTQPGCUPS(UYQXJOAYWYC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9749880", Offset = "0x9748680", VA = "0x189749880")]
		internal bool CJSFXMGOMQW(UYQXJOAYWYC a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x974AF90", Offset = "0x9749D90", VA = "0x18974AF90", Slot = "16")]
		public void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x974A5D0", Offset = "0x97493D0", VA = "0x18974A5D0", Slot = "17")]
		public void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x97496E0", Offset = "0x97484E0", VA = "0x1897496E0", Slot = "18")]
		public void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x974A340", Offset = "0x9749140", VA = "0x18974A340", Slot = "19")]
		public void KBQNKNMUSGI(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x974B080", Offset = "0x9749E80", VA = "0x18974B080")]
		public void YFLKTHSQAKF([Optional] GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x974B2C0", Offset = "0x974A0C0", VA = "0x18974B2C0", Slot = "23")]
		public void YPCGSTWAFKK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x974AE10", Offset = "0x9749C10", VA = "0x18974AE10", Slot = "20")]
		public ConnectableGraphData VXIDSANVEDT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x974AA20", Offset = "0x9749820", VA = "0x18974AA20", Slot = "21")]
		public ConnectableGraphData RTFKHTNAKHN(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9749820", Offset = "0x9748620", VA = "0x189749820", Slot = "25")]
		public void BNZTKFSXHMV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x974AD00", Offset = "0x9749B00", VA = "0x18974AD00", Slot = "24")]
		public void VKWITVDZISQ(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class IRRXGUDWHQO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly ASIDCYHIMJR<UYQXJOAYWYC, UYQXJOAYWYC> GJWSEXEBRVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly ASIDCYHIMJR<UYQXJOAYWYC, UYQXJOAYWYC> OJWZLYDMXHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly ASCWFRNLCYI<UYQXJOAYWYC, UYQXJOAYWYC, UYQXJOAYWYC> QUBVCYFXIDL;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9745390", Offset = "0x9744190", VA = "0x189745390")]
		public IRRXGUDWHQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x97452D0", Offset = "0x97440D0", VA = "0x1897452D0")]
		public void UQNJIDYNSFX(UYQXJOAYWYC a, UYQXJOAYWYC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9745330", Offset = "0x9744130", VA = "0x189745330")]
		public void XEMUMCKXRIT(UYQXJOAYWYC a, UYQXJOAYWYC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9745250", Offset = "0x9744050", VA = "0x189745250")]
		public void BQDQBMCDKUF(UYQXJOAYWYC a, UYQXJOAYWYC b, UYQXJOAYWYC c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class TLZZIPWNTMX : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager OHQUMFIDCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private STMWXQPJAAJ LMVVDSZGPPF;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public TLZZIPWNTMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9754A90", Offset = "0x9753890", VA = "0x189754A90")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9754980", Offset = "0x9753780", VA = "0x189754980", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9754C30", Offset = "0x9753A30", VA = "0x189754C30")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9754BC0", Offset = "0x97539C0", VA = "0x189754BC0")]
		private void OnMasterClientSwitched(GUPOFWBVNMS newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9754990", Offset = "0x9753790", VA = "0x189754990")]
		public void GBQLSUSMRGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9754C70", Offset = "0x9753A70", VA = "0x189754C70")]
		public void YPLLRXZSCUW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class SDTQMDWTLBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public MZEBANDYSXL container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9745060", Offset = "0x9743E60", VA = "0x189745060")]
			internal LegacyConnectableManager BHQTQRZNXEW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x97532D0", Offset = "0x97520D0", VA = "0x1897532D0")]
		public static void AVTEYYUEURU(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x97534C0", Offset = "0x97522C0", VA = "0x1897534C0")]
		public static void LWHEMXMFXVX(MZEBANDYSXL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, XAIEYZFQRLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, XAPCWFDGWNF> GJXQATIGTVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation BOAQOYOXHMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private PKDIWYDSDAJ LLEIZYEHFTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private CSOVYQVKJVH KGGSALCPHFF;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker WEPWPNLZXKR;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x974C4A0", Offset = "0x974B2A0", VA = "0x18974C4A0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x974BEE0", Offset = "0x974ACE0", VA = "0x18974BEE0", Slot = "7")]
		public void Initialize(CSOVYQVKJVH graph, PKDIWYDSDAJ creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x974BF20", Offset = "0x974AD20", VA = "0x18974BF20", Slot = "5")]
		public void PVKOHYBJMQW(BQEBEXQPNFA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x974B6E0", Offset = "0x974A4E0", VA = "0x18974B6E0", Slot = "9")]
		public void DTIADNLZCIN(BQEBEXQPNFA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x974BAD0", Offset = "0x974A8D0", VA = "0x18974BAD0", Slot = "8")]
		public void FULKBSVOGZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x974BC90", Offset = "0x974AA90", VA = "0x18974BC90", Slot = "10")]
		public void GZZDROZXCNE(BQEBEXQPNFA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x974C2F0", Offset = "0x974B0F0", VA = "0x18974C2F0", Slot = "11")]
		public void VIUXJHBCCBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x974B920", Offset = "0x974A720", VA = "0x18974B920")]
		private bool EVAVJAHURUF(BQEBEXQPNFA a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class WISFGIZLQVP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly TDYHQSOOCDN currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly SCPBEECOAOZ parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly SCPBEECOAOZ rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool YYQDGWMARZM
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x9753CD0", Offset = "0x9752AD0", VA = "0x189753CD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x9753DE0", Offset = "0x9752BE0", VA = "0x189753DE0")]
			public SerializeNodeInSubgraph(TDYHQSOOCDN currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] SCPBEECOAOZ parentNodeData, [Optional] SCPBEECOAOZ rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9753B30", Offset = "0x9752930", VA = "0x189753B30")]
			public SCPBEECOAOZ NYKTBLQYXAJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9753540", Offset = "0x9752340", VA = "0x189753540")]
			private SCPBEECOAOZ DMIIUOGZGVL([Out] SCPBEECOAOZ a, [Out] SCPBEECOAOZ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9753930", Offset = "0x9752730", VA = "0x189753930")]
			private SCPBEECOAOZ IXDNKKHCTLR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x97537C0", Offset = "0x97525C0", VA = "0x1897537C0")]
			private void EXFCHNPVAMF(SCPBEECOAOZ a, SCPBEECOAOZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9753600", Offset = "0x9752400", VA = "0x189753600")]
			private void DYWIKBAXYJQ(SCPBEECOAOZ a, SCPBEECOAOZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager OHQUMFIDCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private CSOVYQVKJVH KGGSALCPHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private XAIEYZFQRLA METYWVVVILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private STMWXQPJAAJ LMVVDSZGPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool MSSBHHFOXIJ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool UEHJXJANJMG
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9755F20", Offset = "0x9754D20", VA = "0x189755F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool FOHMKCZLQQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9756820", Offset = "0x9755620", VA = "0x189756820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x9756190", Offset = "0x9754F90", VA = "0x189756190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9755F70", Offset = "0x9754D70", VA = "0x189755F70")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9757550", Offset = "0x9756350", VA = "0x189757550")]
		public ConnectableGraphData VXIDSANVEDT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9756840", Offset = "0x9755640", VA = "0x189756840")]
		public ConnectableGraphData RTFKHTNAKHN(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9757940", Offset = "0x9756740", VA = "0x189757940")]
		public void YPCGSTWAFKK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x97574B0", Offset = "0x97562B0", VA = "0x1897574B0")]
		public void VKWITVDZISQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9756070", Offset = "0x9754E70", VA = "0x189756070")]
		public void MJVZSHIAOZU(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9756F90", Offset = "0x9755D90", VA = "0x189756F90")]
		private void UYNLGLQDBOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9756EB0", Offset = "0x9755CB0", VA = "0x189756EB0")]
		private SCPBEECOAOZ UVTRUYMLDOB(TDYHQSOOCDN a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9756C00", Offset = "0x9755A00", VA = "0x189756C00")]
		private static void TIAUQYBQELP(TDYHQSOOCDN a, bool b, SCPBEECOAOZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x97569E0", Offset = "0x97557E0", VA = "0x1897569E0")]
		private void SNIDPASAXCS(TDYHQSOOCDN a, bool b, SCPBEECOAOZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9755FE0", Offset = "0x9754DE0", VA = "0x189755FE0")]
		private SCPBEECOAOZ KRSIFXDQYPF(TDYHQSOOCDN a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x97576C0", Offset = "0x97564C0", VA = "0x1897576C0")]
		private bool YIRUADGPBCX(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x97561B0", Offset = "0x9754FB0", VA = "0x1897561B0")]
		private bool QPWVQZMUFQG(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9755390", Offset = "0x9754190", VA = "0x189755390")]
		private bool AQTCZIBPMHC(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9755E00", Offset = "0x9754C00", VA = "0x189755E00")]
		private static bool HURYTWHZIAB(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x97553B0", Offset = "0x97541B0", VA = "0x1897553B0")]
		public static bool DDJJAPMNGTT(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9757170", Offset = "0x9755F70", VA = "0x189757170")]
		private UYQXJOAYWYC VBYFKXZGYVZ(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9755640", Offset = "0x9754440", VA = "0x189755640")]
		private UYQXJOAYWYC EPLSWYJPWHH(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9755C70", Offset = "0x9754A70", VA = "0x189755C70")]
		private UYQXJOAYWYC FVFKCULBNEM(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x97504D0", Offset = "0x974F2D0", VA = "0x1897504D0")]
		private static Guid UOBELYANCGC(SCPBEECOAOZ a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x97560A0", Offset = "0x9754EA0", VA = "0x1897560A0")]
		private string NGGCBPZOXEL(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9755A80", Offset = "0x9754880", VA = "0x189755A80")]
		private bool FTCSQSBTUZQ(TDYHQSOOCDN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x97557C0", Offset = "0x97545C0", VA = "0x1897557C0")]
		private static void EZRRUUIONLG(TDYHQSOOCDN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public WISFGIZLQVP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public UYQXJOAYWYC child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public UYQXJOAYWYC parent;

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
		public ConnectableLink CJUHEBLJGXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9743DB0", Offset = "0x9742BB0", VA = "0x189743DB0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink GGWACTSJIKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9743D80", Offset = "0x9742B80", VA = "0x189743D80")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9743E50", Offset = "0x9742C50", VA = "0x189743E50")]
		public ConnectionOperationData(UYQXJOAYWYC child, UYQXJOAYWYC parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface CSOVYQVKJVH
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		BQEBEXQPNFA YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(SOQQTKUCHLH manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool SSTCPHHPHFM([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EMJOOVFRUIX(UYQXJOAYWYC a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool UNOACROPHNR(UYQXJOAYWYC a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HETWBMRLVJT(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VCSUQAOKXHA();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void JKLQHLVYHJQ(Func<UYQXJOAYWYC, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<UYQXJOAYWYC> NTJOONHQLNK();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool JTVASFMWFVT(UYQXJOAYWYC a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void OEJEEKIKLCT(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(BQEBEXQPNFA node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface BQEBEXQPNFA
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		UYQXJOAYWYC QEMCSKVGKLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		BQEBEXQPNFA ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink QNDFGGPFWUV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool WGGMUDGYHFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface XAPCWFDGWNF : CEWTOTQZQQF.DPEGWDHMNID
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RKCBVVMJUOD(UYQXJOAYWYC a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ISMIIZIVVGD(UYQXJOAYWYC a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SDCZCOVRGXC(UYQXJOAYWYC a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JIGKWACJPPK(UYQXJOAYWYC a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		XAPCWFDGWNF FFKFLCTLBRB(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface PKDIWYDSDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, XAPCWFDGWNF linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		XAPCWFDGWNF TEAYKNAUEIF();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SLQTXCHVXQZ(XAPCWFDGWNF a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface LVINCAWIKVE : ZTLPXUATZKT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool RKVIIZVZBGQ();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XOCGUJGOVYV(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface XAIEYZFQRLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PVKOHYBJMQW(BQEBEXQPNFA a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(CSOVYQVKJVH graph, PKDIWYDSDAJ linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FULKBSVOGZF();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DTIADNLZCIN(BQEBEXQPNFA a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GZZDROZXCNE(BQEBEXQPNFA a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VIUXJHBCCBU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class TDYHQSOOCDN : BQEBEXQPNFA
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class LIXDUMZZAJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink PSBZYWWKZLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public TDYHQSOOCDN SUKGCNWQIDV;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public LIXDUMZZAJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9745620", Offset = "0x9744420", VA = "0x189745620")]
			internal bool KONYXJZZMXM(BQEBEXQPNFA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink GUSSMHHANVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<TDYHQSOOCDN> EHFJOPVXKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TDYHQSOOCDN CYXCUIACAES;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink QNDFGGPFWUV
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x514D110", Offset = "0x514BF10", VA = "0x18514D110", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x97547C0", Offset = "0x97535C0", VA = "0x1897547C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private TDYHQSOOCDN WKYFTFFHETD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9754280", Offset = "0x9753080", VA = "0x189754280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public BQEBEXQPNFA ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public UYQXJOAYWYC QEMCSKVGKLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool WGGMUDGYHFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x97547B0", Offset = "0x97535B0", VA = "0x1897547B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool RPIWJHFIQXL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x97544D0", Offset = "0x97532D0", VA = "0x1897544D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected TDYHQSOOCDN NEXPSVAOOPT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x9753F90", Offset = "0x9752D90", VA = "0x189753F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x97548E0", Offset = "0x97536E0", VA = "0x1897548E0")]
		public TDYHQSOOCDN(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9753E50", Offset = "0x9752C50", VA = "0x189753E50")]
		public TDYHQSOOCDN BICMCWKPHLE(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9754100", Offset = "0x9752F00", VA = "0x189754100")]
		public TDYHQSOOCDN ECKJUUSVDWS(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9754520", Offset = "0x9753320", VA = "0x189754520")]
		public TDYHQSOOCDN Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x9753FB0", Offset = "0x9752DB0", VA = "0x189753FB0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9754700", Offset = "0x9753500", VA = "0x189754700")]
		public TDYHQSOOCDN Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9754360", Offset = "0x9753160", VA = "0x189754360")]
		private static void OEJEEKIKLCT(TDYHQSOOCDN a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x97544C0", Offset = "0x97532C0", VA = "0x1897544C0", Slot = "9")]
		public void OEJEEKIKLCT(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x97547F0", Offset = "0x97535F0", VA = "0x1897547F0")]
		public static TDYHQSOOCDN YXDRVYATCRY(TDYHQSOOCDN a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface STMWXQPJAAJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool UEHJXJANJMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> HHSNGMXUIJU;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<GUPOFWBVNMS> ZGBYUVJZSAU;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RKCBVVMJUOD(LegacyConnectableManager a, WCGQZYDJZIP b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void CMWTRMYZKTF(ConnectableGraphData a, [Optional] GUPOFWBVNMS b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class NKKBNCRJVLL
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x974C700", Offset = "0x974B500", VA = "0x18974C700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x974C750", Offset = "0x974B550", VA = "0x18974C750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x974C790", Offset = "0x974B590", VA = "0x18974C790")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class EPZCHORDWMS : STMWXQPJAAJ, IDisposable, FOHXRCVJNON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager OHQUMFIDCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private WCGQZYDJZIP WHUEZBWJQZR;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool UEHJXJANJMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x9744150", Offset = "0x9742F50", VA = "0x189744150", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x97441B0", Offset = "0x9742FB0", VA = "0x1897441B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView HMUNBSXVCEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9744450", Offset = "0x9743250", VA = "0x189744450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> HHSNGMXUIJU
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9744570", Offset = "0x9743370", VA = "0x189744570", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x9744290", Offset = "0x9743090", VA = "0x189744290", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<GUPOFWBVNMS> ZGBYUVJZSAU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9744D60", Offset = "0x9743B60", VA = "0x189744D60", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x97441F0", Offset = "0x9742FF0", VA = "0x1897441F0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x97444E0", Offset = "0x97432E0", VA = "0x1897444E0", Slot = "10")]
		public void RKCBVVMJUOD(LegacyConnectableManager a, WCGQZYDJZIP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x9744100", Offset = "0x9742F00", VA = "0x189744100", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9744330", Offset = "0x9743130", VA = "0x189744330", Slot = "11")]
		public void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9743EC0", Offset = "0x9742CC0", VA = "0x189743EC0", Slot = "12")]
		public void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9743FE0", Offset = "0x9742DE0", VA = "0x189743FE0", Slot = "13")]
		public void CMWTRMYZKTF(ConnectableGraphData a, [Optional] GUPOFWBVNMS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9744840", Offset = "0x9743640", VA = "0x189744840")]
		[RPCMethod]
		private void RpcMasterReparentNodes(UYQXJOAYWYC objectToReparent, int objectToReparentSlotIndex, UYQXJOAYWYC newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9744650", Offset = "0x9743450", VA = "0x189744650")]
		[RPCMethod]
		private void RpcMasterModifyNode(UYQXJOAYWYC connectableToModify, UYQXJOAYWYC expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9744C30", Offset = "0x9743A30", VA = "0x189744C30")]
		[RPCMethod]
		private void RpcReparentNodes(UYQXJOAYWYC objectToReparent, int objectToReparentSlotIndex, UYQXJOAYWYC newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9744B40", Offset = "0x9743940", VA = "0x189744B40")]
		[RPCMethod]
		private void RpcModifyNode(UYQXJOAYWYC connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9744610", Offset = "0x9743410", VA = "0x189744610")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public EPZCHORDWMS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, XAPCWFDGWNF, CEWTOTQZQQF.DPEGWDHMNID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9745890", Offset = "0x9744690", VA = "0x189745890", Slot = "4")]
		private void FUTVTREZDIK(UYQXJOAYWYC a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x9745C00", Offset = "0x9744A00", VA = "0x189745C00", Slot = "5")]
		private void PRHQJNOCQLQ(UYQXJOAYWYC a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9745E70", Offset = "0x9744C70", VA = "0x189745E70", Slot = "6")]
		private void SSAKAIFDAZB(UYQXJOAYWYC a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9745A10", Offset = "0x9744810", VA = "0x189745A10", Slot = "7")]
		private void NEBVGJRZPMN(UYQXJOAYWYC a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9746100", Offset = "0x9744F00", VA = "0x189746100", Slot = "8")]
		private XAPCWFDGWNF XGJLDDPZZMA(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x97460A0", Offset = "0x9744EA0", VA = "0x1897460A0", Slot = "9")]
		private void TLZNTPSEAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xCE6140", Offset = "0xCE4F40", VA = "0x180CE6140")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class FOAPPOGVNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5E40", Offset = "0x3AA4C40", VA = "0x183AA5E40")]
		public static DQCWTPSBYCY<a> CHVZGVUTJFV<a>(this MZEBANDYSXL a)
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
