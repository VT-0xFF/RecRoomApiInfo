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
		[Cpp2IlInjected.Address(RVA = "0x98CD940", Offset = "0x98CC340", VA = "0x1898CD940", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x22688A0", Offset = "0x22672A0", VA = "0x1822688A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98D9890", Offset = "0x98D8290", VA = "0x1898D9890")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98D99E0", Offset = "0x98D83E0", VA = "0x1898D99E0")]
		private void TZHSANLRDRN(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98D9580", Offset = "0x98D7F80", VA = "0x1898D9580", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98D9B30", Offset = "0x98D8530", VA = "0x1898D9B30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PGPARRHLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x98D4690", Offset = "0x98D3090", VA = "0x1898D4690")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PGJTUKNOLTW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x98D4440", Offset = "0x98D2E40", VA = "0x1898D4440")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1031740", Offset = "0x1030140", VA = "0x181031740")]
			[DebuggerHidden]
			public XQYJXHPVKDK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x98D9420", Offset = "0x98D7E20", VA = "0x1898D9420", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x98D90C0", Offset = "0x98D7AC0", VA = "0x1898D90C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x98D9560", Offset = "0x98D7F60", VA = "0x1898D9560")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x98D9540", Offset = "0x98D7F40", VA = "0x1898D9540")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x98D9500", Offset = "0x98D7F00", VA = "0x1898D9500", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x98D9010", Offset = "0x98D7A10", VA = "0x1898D9010", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<UYQXJOAYWYC> LXKEGUMWSUX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x98D9010", Offset = "0x98D7A10", VA = "0x1898D9010", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11920", Offset = "0xD10320", VA = "0x180D11920", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD122C0", Offset = "0xD10CC0", VA = "0x180D122C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool RTUYCLFSOWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> GJWSEXEBRVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x98D1690", Offset = "0x98D0090", VA = "0x1898D1690", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x98CEA60", Offset = "0x98CD460", VA = "0x1898CEA60", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> OJWZLYDMXHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x98CECA0", Offset = "0x98CD6A0", VA = "0x1898CECA0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x98D01B0", Offset = "0x98CEBB0", VA = "0x1898D01B0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC, UYQXJOAYWYC> QUBVCYFXIDL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x98D1DD0", Offset = "0x98D07D0", VA = "0x1898D1DD0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x98D1EF0", Offset = "0x98D08F0", VA = "0x1898D1EF0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x98D25F0", Offset = "0x98D0FF0", VA = "0x1898D25F0")]
		public OMConnectableManager(MZEBANDYSXL container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98CF110", Offset = "0x98CDB10", VA = "0x1898CF110", Slot = "12")]
		public void Initialize(GameObject gameObject, BKXJUQHPCRC configData, WCGQZYDJZIP sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98CF900", Offset = "0x98CE300", VA = "0x1898CF900", Slot = "26")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x98CE190", Offset = "0x98CCB90", VA = "0x1898CE190", Slot = "22")]
		public bool DDJJAPMNGTT(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x98D0B90", Offset = "0x98CF590", VA = "0x1898D0B90")]
		private void QWWJJQFGHLU(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98CEDE0", Offset = "0x98CD7E0", VA = "0x1898CEDE0")]
		private void GRAPZHBVMVW(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98D21B0", Offset = "0x98D0BB0", VA = "0x1898D21B0")]
		private void YFYZXDBGKZI(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98CE370", Offset = "0x98CCD70", VA = "0x1898CE370")]
		private void DMODPEYZATP(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x98CDE80", Offset = "0x98CC880", VA = "0x1898CDE80", Slot = "14")]
		public void CBYRPQCEVDS(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "15")]
		public void WRENKBCPLUL(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98CFC90", Offset = "0x98CE690", VA = "0x1898CFC90", Slot = "17")]
		public void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98CFDF0", Offset = "0x98CE7F0", VA = "0x1898CFDF0")]
		public void NKBBQVTHMGK(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98CED50", Offset = "0x98CD750", VA = "0x1898CED50")]
		public void GJPEFOXOYLY(UYQXJOAYWYC a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98CDBC0", Offset = "0x98CC5C0", VA = "0x1898CDBC0", Slot = "18")]
		public void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98CF060", Offset = "0x98CDA60", VA = "0x1898CF060")]
		private float IKFWRJABMQK(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98CDD20", Offset = "0x98CC720", VA = "0x1898CDD20")]
		public void BKRUUVXEXDY(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x98CF790", Offset = "0x98CE190", VA = "0x1898CF790", Slot = "19")]
		public void KBQNKNMUSGI(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98D1FA0", Offset = "0x98D09A0", VA = "0x1898D1FA0", Slot = "16")]
		public void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "20")]
		public ConnectableGraphData VXIDSANVEDT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "21")]
		public ConnectableGraphData RTFKHTNAKHN(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98D2410", Offset = "0x98D0E10", VA = "0x1898D2410", Slot = "23")]
		public void YPCGSTWAFKK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98D1E80", Offset = "0x98D0880", VA = "0x1898D1E80", Slot = "24")]
		public void VKWITVDZISQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98CDE60", Offset = "0x98CC860", VA = "0x1898CDE60", Slot = "25")]
		public void BNZTKFSXHMV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x98CF380", Offset = "0x98CDD80", VA = "0x1898CF380")]
		private void JOEABLPZTWQ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98D0DA0", Offset = "0x98CF7A0", VA = "0x1898D0DA0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98CFAD0", Offset = "0x98CE4D0", VA = "0x1898CFAD0")]
		private void MWQRYGSYLXZ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98D0260", Offset = "0x98CEC60", VA = "0x1898D0260")]
		[IteratorStateMachine(typeof(XQYJXHPVKDK))]
		public IEnumerable<UYQXJOAYWYC> PATIYMSIVCI(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98D1CA0", Offset = "0x98D06A0", VA = "0x1898D1CA0")]
		internal UYQXJOAYWYC VBYFKXZGYVZ(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98CE1E0", Offset = "0x98CCBE0", VA = "0x1898CE1E0")]
		internal ObjectLocalId DJSGNZZTUXZ(UYQXJOAYWYC a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98D0610", Offset = "0x98CF010", VA = "0x1898D0610")]
		private bool QPWVQZMUFQG(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98CFB40", Offset = "0x98CE540", VA = "0x1898CFB40")]
		private bool MXXSNBFCAMW(SCPBEECOAOZ a, [Out] UYQXJOAYWYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98D1910", Offset = "0x98D0310", VA = "0x1898D1910")]
		private UYQXJOAYWYC VBYFKXZGYVZ(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x98D1740", Offset = "0x98D0140", VA = "0x1898D1740")]
		private UYQXJOAYWYC UJSBMTVBMSQ(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98CE890", Offset = "0x98CD290", VA = "0x1898CE890")]
		private UYQXJOAYWYC EPLSWYJPWHH(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98D18D0", Offset = "0x98D02D0", VA = "0x1898D18D0")]
		private static Guid UOBELYANCGC(SCPBEECOAOZ a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98CFBA0", Offset = "0x98CE5A0", VA = "0x1898CFBA0")]
		private string NGGCBPZOXEL(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98CEB10", Offset = "0x98CD510", VA = "0x1898CEB10")]
		private void FFFKYXCMKJC(UYQXJOAYWYC a, UYQXJOAYWYC b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98D02F0", Offset = "0x98CECF0", VA = "0x1898D02F0")]
		private void PIJBWSMRAWI(UYQXJOAYWYC a, UYQXJOAYWYC b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x98CF000", Offset = "0x98CDA00", VA = "0x1898CF000")]
		private void HCDZOBMDZTY(UYQXJOAYWYC a, UYQXJOAYWYC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x98D0480", Offset = "0x98CEE80", VA = "0x1898D0480")]
		private void QMNJLMNWPXF(UYQXJOAYWYC a, UYQXJOAYWYC b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98CE780", Offset = "0x98CD180", VA = "0x1898CE780")]
		private void EHIMEJTLQQG(ObjectLocalId a, UYQXJOAYWYC b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98CFF30", Offset = "0x98CE930", VA = "0x1898CFF30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x98C6600", Offset = "0x98C5000", VA = "0x1898C6600")]
			internal OMConnectableManager BHQTQRZNXEW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98C6440", Offset = "0x98C4E40", VA = "0x1898C6440")]
		public static void AVTEYYUEURU(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98C65B0", Offset = "0x98C4FB0", VA = "0x1898C65B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280", Slot = "38")]
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
			[Cpp2IlInjected.Address(RVA = "0x98D4210", Offset = "0x98D2C10", VA = "0x1898D4210", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public UYQXJOAYWYC HCXYZTPFJUB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x98D32A0", Offset = "0x98D1CA0", VA = "0x1898D32A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 VHBTACAGZTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x98D2730", Offset = "0x98D1130", VA = "0x1898D2730", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion SNBDOCCOJRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x98D3F30", Offset = "0x98D2930", VA = "0x1898D3F30", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UGZXVWEUZGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x98D2900", Offset = "0x98D1300", VA = "0x1898D2900", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<UYQXJOAYWYC> YIGTJYNXZQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x98D3690", Offset = "0x98D2090", VA = "0x1898D3690", Slot = "13")]
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
			[Cpp2IlInjected.Address(RVA = "0xDB1A50", Offset = "0xDB0450", VA = "0x180DB1A50", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xEAA1E0", Offset = "0xEA8BE0", VA = "0x180EAA1E0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x98D4420", Offset = "0x98D2E20", VA = "0x1898D4420", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x98D4120", Offset = "0x98D2B20", VA = "0x1898D4120", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x98D4140", Offset = "0x98D2B40", VA = "0x1898D4140", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x98D4270", Offset = "0x98D2C70", VA = "0x1898D4270", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x98D4350", Offset = "0x98D2D50", VA = "0x1898D4350", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool VIQCPVWISLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x98D3640", Offset = "0x98D2040", VA = "0x1898D3640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler JZTVDHYQFSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x98D2AE0", Offset = "0x98D14E0", VA = "0x1898D2AE0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x98D3E40", Offset = "0x98D2840", VA = "0x1898D3E40", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler DYDPPYAWPTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x98D29C0", Offset = "0x98D13C0", VA = "0x1898D29C0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x98D3250", Offset = "0x98D1C50", VA = "0x1898D3250", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler PKBXCUKFKUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x98D38D0", Offset = "0x98D22D0", VA = "0x1898D38D0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x98D2970", Offset = "0x98D1370", VA = "0x1898D2970", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler BNJHLICOWKR
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x98D3DA0", Offset = "0x98D27A0", VA = "0x1898D3DA0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x98D3E90", Offset = "0x98D2890", VA = "0x1898D3E90", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x98D4020", Offset = "0x98D2A20", VA = "0x1898D4020")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, VAQUCYXNLCM connectableTool, NFYBVXRHWHI[] connectionPoints, DQZHHYHLPYA callbacks, SOQQTKUCHLH connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x98D2700", Offset = "0x98D1100", VA = "0x1898D2700", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "21")]
		public void URDHSNOIFTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x98D36C0", Offset = "0x98D20C0", VA = "0x1898D36C0", Slot = "22")]
		public void PETTYCGSXOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x98D3D50", Offset = "0x98D2750", VA = "0x1898D3D50", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x98D2D30", Offset = "0x98D1730", VA = "0x1898D2D30", Slot = "25")]
		public void HDIGKJYMSUJ(int a, UYQXJOAYWYC b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x98D2790", Offset = "0x98D1190", VA = "0x1898D2790", Slot = "26")]
		public void CEDSORIXWHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98D3360", Offset = "0x98D1D60", VA = "0x1898D3360", Slot = "27")]
		public void MKUQGQLUBLV(int a, UYQXJOAYWYC b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x98D2A10", Offset = "0x98D1410", VA = "0x1898D2A10", Slot = "28")]
		public void EFRWSUGLXJT(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x98D3920", Offset = "0x98D2320", VA = "0x1898D3920", Slot = "31")]
		public void QCQAPMMFQTM(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x98D2F40", Offset = "0x98D1940", VA = "0x1898D2F40", Slot = "29")]
		public void HKKZCUFFUUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x98D36E0", Offset = "0x98D20E0", VA = "0x1898D36E0", Slot = "30")]
		public void PGOYYUDKJMD(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x98D2C60", Offset = "0x98D1660", VA = "0x1898D2C60", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x98D2B30", Offset = "0x98D1530", VA = "0x1898D2B30", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD77E30", Offset = "0xD76830", VA = "0x180D77E30", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98D2860", Offset = "0x98D1260", VA = "0x1898D2860", Slot = "43")]
		public bool CanConnectTo(int slotIndex, UYQXJOAYWYC otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "44")]
		public void ParentChanged(int slotIndex, UYQXJOAYWYC newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "45")]
		public void ChildAdded(int slotIndex, UYQXJOAYWYC newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "46")]
		public void ChildRemoved(int slotIndex, UYQXJOAYWYC removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "47")]
		public void ConnectionModified(int slotIndex, UYQXJOAYWYC parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x98D3D30", Offset = "0x98D2730", VA = "0x1898D3D30", Slot = "48")]
		public void RootChanged(UYQXJOAYWYC previousRootConnectable, UYQXJOAYWYC newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x98D2A90", Offset = "0x98D1490", VA = "0x1898D2A90", Slot = "23")]
		public void FFJRPXNCAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x98D26B0", Offset = "0x98D10B0", VA = "0x1898D26B0", Slot = "24")]
		public void AKAFGTKMAHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x98D2660", Offset = "0x98D1060", VA = "0x1898D2660")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x98D8F10", Offset = "0x98D7910", VA = "0x1898D8F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x98D8EC0", Offset = "0x98D78C0", VA = "0x1898D8EC0", Slot = "5")]
		private void MBYFDPTTQYS(IKBIXEGYPOI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF854D0", Offset = "0xF83ED0", VA = "0x180F854D0", Slot = "6")]
		private void NXHIFSUZYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool RTUYCLFSOWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> GJWSEXEBRVH
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x98D65D0", Offset = "0x98D4FD0", VA = "0x1898D65D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x98D63C0", Offset = "0x98D4DC0", VA = "0x1898D63C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> OJWZLYDMXHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x98D6470", Offset = "0x98D4E70", VA = "0x1898D6470", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x98D6520", Offset = "0x98D4F20", VA = "0x1898D6520", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC, UYQXJOAYWYC> QUBVCYFXIDL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x98D6680", Offset = "0x98D5080", VA = "0x1898D6680", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x98D6730", Offset = "0x98D5130", VA = "0x1898D6730", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "26")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "12")]
		public void Initialize(GameObject gameObject, BKXJUQHPCRC configData, WCGQZYDJZIP rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "14")]
		public void CBYRPQCEVDS(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "15")]
		public void WRENKBCPLUL(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "16")]
		public void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "17")]
		public void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "18")]
		public void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "19")]
		public void KBQNKNMUSGI(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "20")]
		public ConnectableGraphData VXIDSANVEDT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "21")]
		public ConnectableGraphData RTFKHTNAKHN(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "22")]
		public bool DDJJAPMNGTT(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "23")]
		public void YPCGSTWAFKK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "24")]
		public void VKWITVDZISQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "25")]
		public void BNZTKFSXHMV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public XAPCWFDGWNF UBNKTQQHWQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x98C4CB0", Offset = "0x98C36B0", VA = "0x1898C4CB0")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x98C4D70", Offset = "0x98C3770", VA = "0x1898C4D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C5230", Offset = "0x98C3C30", VA = "0x1898C5230")]
		public ConnectableLink(UYQXJOAYWYC connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x98C5290", Offset = "0x98C3C90", VA = "0x1898C5290")]
		public ConnectableLink(UYQXJOAYWYC connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x98C5330", Offset = "0x98C3D30", VA = "0x1898C5330")]
		public ConnectableLink(UYQXJOAYWYC connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x98C4DC0", Offset = "0x98C37C0", VA = "0x1898C4DC0", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x98C4E70", Offset = "0x98C3870", VA = "0x1898C4E70", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x91F00B0", Offset = "0x91EEAB0", VA = "0x1891F00B0", Slot = "4")]
		public void Initialize(Transform transform, XAPCWFDGWNF linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x98C6D30", Offset = "0x98C5730", VA = "0x1898C6D30", Slot = "5")]
		public XAPCWFDGWNF TEAYKNAUEIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x98C6CC0", Offset = "0x98C56C0", VA = "0x1898C6CC0", Slot = "6")]
		public void SLQTXCHVXQZ(XAPCWFDGWNF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public IYQMCZATMGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x98C6AC0", Offset = "0x98C54C0", VA = "0x1898C6AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x98C9DB0", Offset = "0x98C87B0", VA = "0x1898C9DB0")]
		public bool SSTCPHHPHFM([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x98C79F0", Offset = "0x98C63F0", VA = "0x1898C79F0")]
		private bool CZXNLEUQPIR([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x98CA9D0", Offset = "0x98C93D0", VA = "0x1898CA9D0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x98C8650", Offset = "0x98C7050", VA = "0x1898C8650", Slot = "5")]
		public void Initialize(SOQQTKUCHLH manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C60", Offset = "0x98C8660", VA = "0x1898C9C60", Slot = "17")]
		public void OEJEEKIKLCT(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x98C8830", Offset = "0x98C7230", VA = "0x1898C8830", Slot = "12")]
		public void JKLQHLVYHJQ(Func<UYQXJOAYWYC, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x98C8700", Offset = "0x98C7100", VA = "0x1898C8700")]
		private void JKLQHLVYHJQ(TDYHQSOOCDN a, Func<UYQXJOAYWYC, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x98CA2E0", Offset = "0x98C8CE0", VA = "0x1898CA2E0", Slot = "11")]
		public void VCSUQAOKXHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x98C8110", Offset = "0x98C6B10", VA = "0x1898C8110", Slot = "8")]
		public bool EMJOOVFRUIX(UYQXJOAYWYC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x98C8F10", Offset = "0x98C7910", VA = "0x1898C8F10")]
		private bool LRPEYUFMMQQ(UYQXJOAYWYC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x98C76B0", Offset = "0x98C60B0", VA = "0x1898C76B0")]
		private static bool ASTMEXTNJMO(UYQXJOAYWYC a, TDYHQSOOCDN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x98C9DC0", Offset = "0x98C87C0", VA = "0x1898C9DC0")]
		private void TPSSPDBHAEQ(Transform a, TDYHQSOOCDN b, TDYHQSOOCDN[] c, UYQXJOAYWYC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x98CA3D0", Offset = "0x98C8DD0", VA = "0x1898CA3D0")]
		private ConnectableLink WCQQQFRFKBX(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x98C7830", Offset = "0x98C6230", VA = "0x1898C7830")]
		private static bool CRHDKJEQLQI(TDYHQSOOCDN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x98CA280", Offset = "0x98C8C80", VA = "0x1898CA280", Slot = "9")]
		public bool UNOACROPHNR(UYQXJOAYWYC a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x98C8400", Offset = "0x98C6E00", VA = "0x1898C8400")]
		private bool IRPFALHSJPK(UYQXJOAYWYC a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x98C9620", Offset = "0x98C8020", VA = "0x1898C9620")]
		private static void MOTBIKHKCQX(UYQXJOAYWYC a, int b, int c, Vector3 d, Quaternion e, TDYHQSOOCDN f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x98C8120", Offset = "0x98C6B20", VA = "0x1898C8120")]
		private void FFFKYXCMKJC(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x98CA1A0", Offset = "0x98C8BA0", VA = "0x1898CA1A0")]
		private void UEBOFTVSCRG(TDYHQSOOCDN a, UYQXJOAYWYC b, UYQXJOAYWYC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x98CA210", Offset = "0x98C8C10", VA = "0x1898CA210")]
		private void UEBOFTVSCRG(UYQXJOAYWYC a, UYQXJOAYWYC b, UYQXJOAYWYC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x98C9AF0", Offset = "0x98C84F0", VA = "0x1898C9AF0")]
		private void OADUOPHDADH(UYQXJOAYWYC a, UYQXJOAYWYC b, UYQXJOAYWYC c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x98C9B60", Offset = "0x98C8560", VA = "0x1898C9B60")]
		private void OADUOPHDADH(TDYHQSOOCDN a, UYQXJOAYWYC b, UYQXJOAYWYC c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C90", Offset = "0x98C8690", VA = "0x1898C9C90")]
		private void PIJBWSMRAWI(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x98C8240", Offset = "0x98C6C40", VA = "0x1898C8240")]
		private void HCDZOBMDZTY(BQEBEXQPNFA a, BQEBEXQPNFA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x98C7FB0", Offset = "0x98C69B0", VA = "0x1898C7FB0", Slot = "18")]
		public UYQXJOAYWYC DNPAUXLLOIX(UYQXJOAYWYC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x98CA520", Offset = "0x98C8F20", VA = "0x1898CA520", Slot = "13")]
		public void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x98C98B0", Offset = "0x98C82B0", VA = "0x1898C98B0", Slot = "14")]
		public List<UYQXJOAYWYC> NTJOONHQLNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x98C7760", Offset = "0x98C6160", VA = "0x1898C7760")]
		protected BQEBEXQPNFA AVECZYJWDBB(BQEBEXQPNFA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x98C7610", Offset = "0x98C6010", VA = "0x1898C7610")]
		protected TDYHQSOOCDN[] AOOTJVNZDHW(TDYHQSOOCDN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x98C97A0", Offset = "0x98C81A0", VA = "0x1898C97A0")]
		protected bool NEMTCMSACOJ(UYQXJOAYWYC a, [Out] TDYHQSOOCDN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x98C8DE0", Offset = "0x98C77E0", VA = "0x1898C8DE0", Slot = "15")]
		public bool JTVASFMWFVT(UYQXJOAYWYC a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x98CA8C0", Offset = "0x98C92C0", VA = "0x1898CA8C0")]
		protected TDYHQSOOCDN YXDRVYATCRY(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x98C83A0", Offset = "0x98C6DA0", VA = "0x1898C83A0", Slot = "10")]
		public bool HETWBMRLVJT(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x98C8840", Offset = "0x98C7240", VA = "0x1898C8840")]
		private bool JODZLFTIXWM(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x98CA300", Offset = "0x98C8D00", VA = "0x1898CA300")]
		private static bool VWTQVIDQMKW(TDYHQSOOCDN a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x98C9DB0", Offset = "0x98C87B0", VA = "0x1898C9DB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5D670", Offset = "0xD5C070", VA = "0x180D5D670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD5D260", Offset = "0xD5BC60", VA = "0x180D5D260")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x137D840", Offset = "0x137C240", VA = "0x18137D840", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2894160", Offset = "0x2892B60", VA = "0x182894160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool RTUYCLFSOWU
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> GJWSEXEBRVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x98CC070", Offset = "0x98CAA70", VA = "0x1898CC070", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x98CAFF0", Offset = "0x98C99F0", VA = "0x1898CAFF0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC> OJWZLYDMXHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x98CB050", Offset = "0x98C9A50", VA = "0x1898CB050", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x98CBC90", Offset = "0x98CA690", VA = "0x1898CBC90", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<UYQXJOAYWYC, UYQXJOAYWYC, UYQXJOAYWYC> QUBVCYFXIDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x98CC150", Offset = "0x98CAB50", VA = "0x1898CC150", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x98CC260", Offset = "0x98CAC60", VA = "0x1898CC260", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x98CC820", Offset = "0x98CB220", VA = "0x1898CC820")]
		public LegacyConnectableManager(MZEBANDYSXL container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x98CB0B0", Offset = "0x98C9AB0", VA = "0x1898CB0B0", Slot = "12")]
		public void Initialize(GameObject gameObject, BKXJUQHPCRC configData, WCGQZYDJZIP rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x98CB9B0", Offset = "0x98CA3B0", VA = "0x1898CB9B0", Slot = "26")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x98CC0D0", Offset = "0x98CAAD0", VA = "0x1898CC0D0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x98CAD00", Offset = "0x98C9700", VA = "0x1898CAD00", Slot = "14")]
		public void CBYRPQCEVDS(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x98CB670", Offset = "0x98CA070", VA = "0x1898CB670", Slot = "15")]
		public void WRENKBCPLUL(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x98CAE50", Offset = "0x98C9850", VA = "0x1898CAE50", Slot = "22")]
		public bool DDJJAPMNGTT(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x98CB6D0", Offset = "0x98CA0D0", VA = "0x1898CB6D0")]
		internal bool JODZLFTIXWM([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x98CAEA0", Offset = "0x98C98A0", VA = "0x1898CAEA0")]
		internal bool EJSPQMASVWK([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x98CBCF0", Offset = "0x98CA6F0", VA = "0x1898CBCF0")]
		internal void PGPPKYMTSLY(UYQXJOAYWYC a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x98CB670", Offset = "0x98CA070", VA = "0x1898CB670")]
		internal bool JMRTQPGCUPS(UYQXJOAYWYC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x98CAD20", Offset = "0x98C9720", VA = "0x1898CAD20")]
		internal bool CJSFXMGOMQW(UYQXJOAYWYC a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x98CC440", Offset = "0x98CAE40", VA = "0x1898CC440", Slot = "16")]
		public void WDGPPRKAZTK(UYQXJOAYWYC a, HashSet<UYQXJOAYWYC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x98CBA80", Offset = "0x98CA480", VA = "0x1898CBA80", Slot = "17")]
		public void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x98CAB80", Offset = "0x98C9580", VA = "0x1898CAB80", Slot = "18")]
		public void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x98CB7E0", Offset = "0x98CA1E0", VA = "0x1898CB7E0", Slot = "19")]
		public void KBQNKNMUSGI(UYQXJOAYWYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x98CC540", Offset = "0x98CAF40", VA = "0x1898CC540")]
		public void YFLKTHSQAKF([Optional] GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x98CC790", Offset = "0x98CB190", VA = "0x1898CC790", Slot = "23")]
		public void YPCGSTWAFKK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x98CC2C0", Offset = "0x98CACC0", VA = "0x1898CC2C0", Slot = "20")]
		public ConnectableGraphData VXIDSANVEDT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x98CBED0", Offset = "0x98CA8D0", VA = "0x1898CBED0", Slot = "21")]
		public ConnectableGraphData RTFKHTNAKHN(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x98CACC0", Offset = "0x98C96C0", VA = "0x1898CACC0", Slot = "25")]
		public void BNZTKFSXHMV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x98CC1B0", Offset = "0x98CABB0", VA = "0x1898CC1B0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C69C0", Offset = "0x98C53C0", VA = "0x1898C69C0")]
		public IRRXGUDWHQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x98C6900", Offset = "0x98C5300", VA = "0x1898C6900")]
		public void UQNJIDYNSFX(UYQXJOAYWYC a, UYQXJOAYWYC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x98C6960", Offset = "0x98C5360", VA = "0x1898C6960")]
		public void XEMUMCKXRIT(UYQXJOAYWYC a, UYQXJOAYWYC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x98C6880", Offset = "0x98C5280", VA = "0x1898C6880")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TLZZIPWNTMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x98D5EE0", Offset = "0x98D48E0", VA = "0x1898D5EE0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x98D5DD0", Offset = "0x98D47D0", VA = "0x1898D5DD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x98D6080", Offset = "0x98D4A80", VA = "0x1898D6080")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x98D6010", Offset = "0x98D4A10", VA = "0x1898D6010")]
		private void OnMasterClientSwitched(GUPOFWBVNMS newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x98D5DE0", Offset = "0x98D47E0", VA = "0x1898D5DE0")]
		public void GBQLSUSMRGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x98D60C0", Offset = "0x98D4AC0", VA = "0x1898D60C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x98C66A0", Offset = "0x98C50A0", VA = "0x1898C66A0")]
			internal LegacyConnectableManager BHQTQRZNXEW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x98D4700", Offset = "0x98D3100", VA = "0x1898D4700")]
		public static void AVTEYYUEURU(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x98D4900", Offset = "0x98D3300", VA = "0x1898D4900")]
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
		[Cpp2IlInjected.Address(RVA = "0x98CD870", Offset = "0x98CC270", VA = "0x1898CD870")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x98CD3E0", Offset = "0x98CBDE0", VA = "0x1898CD3E0", Slot = "7")]
		public void Initialize(CSOVYQVKJVH graph, PKDIWYDSDAJ creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x98CD420", Offset = "0x98CBE20", VA = "0x1898CD420", Slot = "5")]
		public void PVKOHYBJMQW(BQEBEXQPNFA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x98CCBB0", Offset = "0x98CB5B0", VA = "0x1898CCBB0", Slot = "9")]
		public void DTIADNLZCIN(BQEBEXQPNFA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x98CCED0", Offset = "0x98CB8D0", VA = "0x1898CCED0", Slot = "8")]
		public void FULKBSVOGZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x98CD090", Offset = "0x98CBA90", VA = "0x1898CD090", Slot = "10")]
		public void GZZDROZXCNE(BQEBEXQPNFA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x98CD6C0", Offset = "0x98CC0C0", VA = "0x1898CD6C0", Slot = "11")]
		public void VIUXJHBCCBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x98CCD20", Offset = "0x98CB720", VA = "0x1898CCD20")]
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
				[Cpp2IlInjected.Address(RVA = "0x98D5110", Offset = "0x98D3B10", VA = "0x1898D5110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x98D5230", Offset = "0x98D3C30", VA = "0x1898D5230")]
			public SerializeNodeInSubgraph(TDYHQSOOCDN currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] SCPBEECOAOZ parentNodeData, [Optional] SCPBEECOAOZ rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x98D4F70", Offset = "0x98D3970", VA = "0x1898D4F70")]
			public SCPBEECOAOZ NYKTBLQYXAJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x98D4980", Offset = "0x98D3380", VA = "0x1898D4980")]
			private SCPBEECOAOZ DMIIUOGZGVL([Out] SCPBEECOAOZ a, [Out] SCPBEECOAOZ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x98D4D70", Offset = "0x98D3770", VA = "0x1898D4D70")]
			private SCPBEECOAOZ IXDNKKHCTLR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x98D4C00", Offset = "0x98D3600", VA = "0x1898D4C00")]
			private void EXFCHNPVAMF(SCPBEECOAOZ a, SCPBEECOAOZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x98D4A40", Offset = "0x98D3440", VA = "0x1898D4A40")]
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
			[Cpp2IlInjected.Address(RVA = "0x98D72B0", Offset = "0x98D5CB0", VA = "0x1898D72B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool FOHMKCZLQQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x98D7BB0", Offset = "0x98D65B0", VA = "0x1898D7BB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x98D7520", Offset = "0x98D5F20", VA = "0x1898D7520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x98D7300", Offset = "0x98D5D00", VA = "0x1898D7300")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x98D89C0", Offset = "0x98D73C0", VA = "0x1898D89C0")]
		public ConnectableGraphData VXIDSANVEDT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x98D7BD0", Offset = "0x98D65D0", VA = "0x1898D7BD0")]
		public ConnectableGraphData RTFKHTNAKHN(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x98D8DC0", Offset = "0x98D77C0", VA = "0x1898D8DC0")]
		public void YPCGSTWAFKK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x98D8920", Offset = "0x98D7320", VA = "0x1898D8920")]
		public void VKWITVDZISQ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x98D7400", Offset = "0x98D5E00", VA = "0x1898D7400")]
		public void MJVZSHIAOZU(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x98D8400", Offset = "0x98D6E00", VA = "0x1898D8400")]
		private void UYNLGLQDBOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x98D81E0", Offset = "0x98D6BE0", VA = "0x1898D81E0")]
		private SCPBEECOAOZ UVTRUYMLDOB(TDYHQSOOCDN a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x98D7F90", Offset = "0x98D6990", VA = "0x1898D7F90")]
		private static void TIAUQYBQELP(TDYHQSOOCDN a, bool b, SCPBEECOAOZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x98D7D70", Offset = "0x98D6770", VA = "0x1898D7D70")]
		private void SNIDPASAXCS(TDYHQSOOCDN a, bool b, SCPBEECOAOZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x98D7370", Offset = "0x98D5D70", VA = "0x1898D7370")]
		private SCPBEECOAOZ KRSIFXDQYPF(TDYHQSOOCDN a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x98D8B30", Offset = "0x98D7530", VA = "0x1898D8B30")]
		private bool YIRUADGPBCX(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x98D7540", Offset = "0x98D5F40", VA = "0x1898D7540")]
		private bool QPWVQZMUFQG(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x98D67E0", Offset = "0x98D51E0", VA = "0x1898D67E0")]
		private bool AQTCZIBPMHC(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x98D7190", Offset = "0x98D5B90", VA = "0x1898D7190")]
		private static bool HURYTWHZIAB(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x98D6800", Offset = "0x98D5200", VA = "0x1898D6800")]
		public static bool DDJJAPMNGTT(SCPBEECOAOZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x98D85E0", Offset = "0x98D6FE0", VA = "0x1898D85E0")]
		private UYQXJOAYWYC VBYFKXZGYVZ(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x98D6A90", Offset = "0x98D5490", VA = "0x1898D6A90")]
		private UYQXJOAYWYC EPLSWYJPWHH(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x98D7000", Offset = "0x98D5A00", VA = "0x1898D7000")]
		private UYQXJOAYWYC FVFKCULBNEM(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x98D18D0", Offset = "0x98D02D0", VA = "0x1898D18D0")]
		private static Guid UOBELYANCGC(SCPBEECOAOZ a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x98D7430", Offset = "0x98D5E30", VA = "0x1898D7430")]
		private string NGGCBPZOXEL(SCPBEECOAOZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x98D6E70", Offset = "0x98D5870", VA = "0x1898D6E70")]
		private bool FTCSQSBTUZQ(TDYHQSOOCDN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C10", Offset = "0x98D5610", VA = "0x1898D6C10")]
		private static void EZRRUUIONLG(TDYHQSOOCDN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x98C53F0", Offset = "0x98C3DF0", VA = "0x1898C53F0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink GGWACTSJIKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x98C53C0", Offset = "0x98C3DC0", VA = "0x1898C53C0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x98C5490", Offset = "0x98C3E90", VA = "0x1898C5490")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public LIXDUMZZAJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x98C6B80", Offset = "0x98C5580", VA = "0x1898C6B80")]
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
			[Cpp2IlInjected.Address(RVA = "0x51A87E0", Offset = "0x51A71E0", VA = "0x1851A87E0", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x98D5C10", Offset = "0x98D4610", VA = "0x1898D5C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private TDYHQSOOCDN WKYFTFFHETD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x98D56D0", Offset = "0x98D40D0", VA = "0x1898D56D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public BQEBEXQPNFA ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public UYQXJOAYWYC QEMCSKVGKLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool WGGMUDGYHFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x98D5C00", Offset = "0x98D4600", VA = "0x1898D5C00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool RPIWJHFIQXL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x98D5920", Offset = "0x98D4320", VA = "0x1898D5920", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected TDYHQSOOCDN NEXPSVAOOPT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x98D53E0", Offset = "0x98D3DE0", VA = "0x1898D53E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x98D5D30", Offset = "0x98D4730", VA = "0x1898D5D30")]
		public TDYHQSOOCDN(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x98D52A0", Offset = "0x98D3CA0", VA = "0x1898D52A0")]
		public TDYHQSOOCDN BICMCWKPHLE(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x98D5550", Offset = "0x98D3F50", VA = "0x1898D5550")]
		public TDYHQSOOCDN ECKJUUSVDWS(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x98D5970", Offset = "0x98D4370", VA = "0x1898D5970")]
		public TDYHQSOOCDN Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x98D5400", Offset = "0x98D3E00", VA = "0x1898D5400")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x98D5B50", Offset = "0x98D4550", VA = "0x1898D5B50")]
		public TDYHQSOOCDN Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x98D57B0", Offset = "0x98D41B0", VA = "0x1898D57B0")]
		private static void OEJEEKIKLCT(TDYHQSOOCDN a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x98D5910", Offset = "0x98D4310", VA = "0x1898D5910", Slot = "9")]
		public void OEJEEKIKLCT(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x98D5C40", Offset = "0x98D4640", VA = "0x1898D5C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x98CDAD0", Offset = "0x98CC4D0", VA = "0x1898CDAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x98CDB20", Offset = "0x98CC520", VA = "0x1898CDB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x98CDB60", Offset = "0x98CC560", VA = "0x1898CDB60")]
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
			[Cpp2IlInjected.Address(RVA = "0x98C5790", Offset = "0x98C4190", VA = "0x1898C5790", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x98C57F0", Offset = "0x98C41F0", VA = "0x1898C57F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView HMUNBSXVCEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x98C5A90", Offset = "0x98C4490", VA = "0x1898C5A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> HHSNGMXUIJU
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x98C5BB0", Offset = "0x98C45B0", VA = "0x1898C5BB0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x98C58D0", Offset = "0x98C42D0", VA = "0x1898C58D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<GUPOFWBVNMS> ZGBYUVJZSAU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x98C63A0", Offset = "0x98C4DA0", VA = "0x1898C63A0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x98C5830", Offset = "0x98C4230", VA = "0x1898C5830", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x98C5B20", Offset = "0x98C4520", VA = "0x1898C5B20", Slot = "10")]
		public void RKCBVVMJUOD(LegacyConnectableManager a, WCGQZYDJZIP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x98C5740", Offset = "0x98C4140", VA = "0x1898C5740", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x98C5970", Offset = "0x98C4370", VA = "0x1898C5970", Slot = "11")]
		public void NKBBQVTHMGK(UYQXJOAYWYC a, UYQXJOAYWYC b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x98C5500", Offset = "0x98C3F00", VA = "0x1898C5500", Slot = "12")]
		public void BKRUUVXEXDY(UYQXJOAYWYC a, int b, UYQXJOAYWYC c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x98C5620", Offset = "0x98C4020", VA = "0x1898C5620", Slot = "13")]
		public void CMWTRMYZKTF(ConnectableGraphData a, [Optional] GUPOFWBVNMS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x98C5E80", Offset = "0x98C4880", VA = "0x1898C5E80")]
		[RPCMethod]
		private void RpcMasterReparentNodes(UYQXJOAYWYC objectToReparent, int objectToReparentSlotIndex, UYQXJOAYWYC newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x98C5C90", Offset = "0x98C4690", VA = "0x1898C5C90")]
		[RPCMethod]
		private void RpcMasterModifyNode(UYQXJOAYWYC connectableToModify, UYQXJOAYWYC expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x98C6270", Offset = "0x98C4C70", VA = "0x1898C6270")]
		[RPCMethod]
		private void RpcReparentNodes(UYQXJOAYWYC objectToReparent, int objectToReparentSlotIndex, UYQXJOAYWYC newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x98C6180", Offset = "0x98C4B80", VA = "0x1898C6180")]
		[RPCMethod]
		private void RpcModifyNode(UYQXJOAYWYC connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x98C5C50", Offset = "0x98C4650", VA = "0x1898C5C50")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C6E00", Offset = "0x98C5800", VA = "0x1898C6E00", Slot = "4")]
		private void FUTVTREZDIK(UYQXJOAYWYC a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x98C7170", Offset = "0x98C5B70", VA = "0x1898C7170", Slot = "5")]
		private void PRHQJNOCQLQ(UYQXJOAYWYC a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x98C73E0", Offset = "0x98C5DE0", VA = "0x1898C73E0", Slot = "6")]
		private void SSAKAIFDAZB(UYQXJOAYWYC a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x98C6F80", Offset = "0x98C5980", VA = "0x1898C6F80", Slot = "7")]
		private void NEBVGJRZPMN(UYQXJOAYWYC a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x98C75A0", Offset = "0x98C5FA0", VA = "0x1898C75A0", Slot = "8")]
		private XAPCWFDGWNF XGJLDDPZZMA(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x98C7540", Offset = "0x98C5F40", VA = "0x1898C7540", Slot = "9")]
		private void TLZNTPSEAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class FOAPPOGVNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AED370", Offset = "0x3AEBD70", VA = "0x183AED370")]
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
