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
		[Cpp2IlInjected.Address(RVA = "0x83B6DE0", Offset = "0x83B5DE0", VA = "0x1883B6DE0", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		private int[] DGVDDFJHVEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] DGPWFYPKLTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset XRLFBVIQUFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset XRQLZCCODQN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC640", Offset = "0x1FBB640", VA = "0x181FBC640", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83C2F00", Offset = "0x83C1F00", VA = "0x1883C2F00")]
		private void ZASTUGVTQWC(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83C3050", Offset = "0x83C2050", VA = "0x1883C3050")]
		private void ZAYARNPRAHL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83C2BF0", Offset = "0x83C1BF0", VA = "0x1883C2BF0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83C31A0", Offset = "0x83C21A0", VA = "0x1883C31A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : AMQYVKEURHV, YKHKLPHTBGW
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ZRHERANYJEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public DQREECIDSJF ZDWRFGKPIDZ;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ZRHERANYJEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x83C2B80", Offset = "0x83C1B80", VA = "0x1883C2B80")]
			internal object VZVDZNCVXIE(DQREECIDSJF a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class ZRBXTTUAZTE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public DQREECIDSJF MWYYZVFVUMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ZRHERANYJEN PYDAXWOHYEE;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ZRBXTTUAZTE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x83C2940", Offset = "0x83C1940", VA = "0x1883C2940")]
			internal object WAAKWTWTGTN((DQREECIDSJF child, DQREECIDSJF nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class QRHRZYKPWBQ : IEnumerable<AJQXREXZXZS>, IEnumerable, IEnumerator<AJQXREXZXZS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private AJQXREXZXZS GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId YNWPGMPBIJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId AGHWOVUYZNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private EZAHGYHEHWY XFLVUZROYPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray EPFLCYMBLBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator NWIKLXZDURH;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private AJQXREXZXZS YOAGWZUTHVY
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD9D550", Offset = "0xD9C550", VA = "0x180D9D550")]
			[DebuggerHidden]
			public QRHRZYKPWBQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x83C0530", Offset = "0x83BF530", VA = "0x1883C0530", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x83C06C0", Offset = "0x83BF6C0", VA = "0x1883C06C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x83C0A20", Offset = "0x83BFA20", VA = "0x1883C0A20")]
			private void QJEWXGNEXZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x83C0A40", Offset = "0x83BFA40", VA = "0x1883C0A40")]
			private void QJURPAUXAHT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83C0A60", Offset = "0x83BFA60", VA = "0x1883C0A60", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x83C0610", Offset = "0x83BF610", VA = "0x1883C0610", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AJQXREXZXZS> TESKHODVNCN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x83C0610", Offset = "0x83BF610", VA = "0x1883C0610", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log NDAVSKWCMVQ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log EKLSRHRVXJS;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log MKKUSRQBZNK;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log WYORQUIDKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TXWGFUZOFUH LFZZCSHLEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ATHARUFQLBW DHKPGYDLVNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private NGNBIJBQHDP XRNWVNHFWMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BTLSYSZTAMR FPQJJVNTAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private FLHXYFARCCV PSLDBVXIVQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IMTDGINTBXF RBIKNFAGVWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly KCVWTACKSXW AJWPTNGEDHJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool OPWPRMKHCCE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DC0", Offset = "0xAD4DC0", VA = "0x180AD5DC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAD6490", Offset = "0xAD5490", VA = "0x180AD6490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ADCXXGWNYGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<AJQXREXZXZS, AJQXREXZXZS> NIKSZFIYSKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x83BDEE0", Offset = "0x83BCEE0", VA = "0x1883BDEE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x83BAE30", Offset = "0x83B9E30", VA = "0x1883BAE30", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AJQXREXZXZS, AJQXREXZXZS> PAIUXUKRZAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83BC820", Offset = "0x83BB820", VA = "0x1883BC820", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x83B9E40", Offset = "0x83B8E40", VA = "0x1883B9E40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<AJQXREXZXZS, AJQXREXZXZS, AJQXREXZXZS> CLPWWEDIYPR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x83BAD80", Offset = "0x83B9D80", VA = "0x1883BAD80", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x83BC390", Offset = "0x83BB390", VA = "0x1883BC390", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83BE2F0", Offset = "0x83BD2F0", VA = "0x1883BE2F0")]
		public OMConnectableManager(KTJKRWFMICD container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83BAAB0", Offset = "0x83B9AB0", VA = "0x1883BAAB0", Slot = "12")]
		public void Initialize(GameObject gameObject, WJKDYMTUPZI configData, FCASZNGZOTP sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83BC440", Offset = "0x83BB440", VA = "0x1883BC440", Slot = "26")]
		public void QQFIGNLTLAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83B9DF0", Offset = "0x83B8DF0", VA = "0x1883B9DF0", Slot = "22")]
		public bool DAJCMVLBQJJ(DQREECIDSJF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83BDF90", Offset = "0x83BCF90", VA = "0x1883BDF90")]
		private void ZTFHQFYHTNW(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83BA300", Offset = "0x83B9300", VA = "0x1883BA300")]
		private void GLPIVTNZIHU(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83BA0A0", Offset = "0x83B90A0", VA = "0x1883BA0A0")]
		private void EZPFVGZXKSU(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83BC8D0", Offset = "0x83BB8D0", VA = "0x1883BC8D0")]
		private void SKFJFTVALZR(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83B9A80", Offset = "0x83B8A80", VA = "0x1883B9A80", Slot = "14")]
		public void BPSMAKIBARY(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "15")]
		public void GNUCJQLWVOR(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83BD6F0", Offset = "0x83BC6F0", VA = "0x1883BD6F0", Slot = "17")]
		public void UTFEELNEITC(AJQXREXZXZS a, AJQXREXZXZS b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83BD5B0", Offset = "0x83BC5B0", VA = "0x1883BD5B0")]
		public void UTFEELNEITC(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83B9990", Offset = "0x83B8990", VA = "0x1883B9990")]
		public void AUWVLIJLWSM(AJQXREXZXZS a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83BA660", Offset = "0x83B9660", VA = "0x1883BA660", Slot = "18")]
		public void GVXFNAHOEII(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83BB9D0", Offset = "0x83BA9D0", VA = "0x1883BB9D0")]
		private float NNHOYQJWHKI(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83BA520", Offset = "0x83B9520", VA = "0x1883BA520")]
		public void GVXFNAHOEII(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83BD8C0", Offset = "0x83BC8C0", VA = "0x1883BD8C0", Slot = "19")]
		public void UYYFTAEZUPE(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83BC610", Offset = "0x83BB610", VA = "0x1883BC610", Slot = "16")]
		public void RKBIBYLYDIS(AJQXREXZXZS a, HashSet<AJQXREXZXZS> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "20")]
		public ConnectableGraphData OHWQOUDNBUL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "21")]
		public ConnectableGraphData ILTGYBSXSLX(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83B9D80", Offset = "0x83B8D80", VA = "0x1883B9D80", Slot = "23")]
		public void BVHDXOIPOAE(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83BD850", Offset = "0x83BC850", VA = "0x1883BD850", Slot = "24")]
		public void UWIJFNQBJCK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83BA080", Offset = "0x83B9080", VA = "0x1883BA080", Slot = "25")]
		public void EMHAADEIZUP(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83BBF90", Offset = "0x83BAF90", VA = "0x1883BBF90")]
		private void ONAJRLKAFPY(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83BCCE0", Offset = "0x83BBCE0", VA = "0x1883BCCE0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83BA7C0", Offset = "0x83B97C0", VA = "0x1883BA7C0")]
		private void HCLZNFCMDTP(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83BB780", Offset = "0x83BA780", VA = "0x1883BB780")]
		[IteratorStateMachine(typeof(QRHRZYKPWBQ))]
		public IEnumerable<AJQXREXZXZS> MHXTGNAIPQW(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83BDDB0", Offset = "0x83BCDB0", VA = "0x1883BDDB0")]
		internal AJQXREXZXZS WIGUZBZLYJT(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83BA920", Offset = "0x83B9920", VA = "0x1883BA920")]
		internal ObjectLocalId IYAGIWOWAWN(AJQXREXZXZS a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83BB200", Offset = "0x83BA200", VA = "0x1883BB200")]
		private bool MHEZPSCJQMM(DQREECIDSJF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83BAD20", Offset = "0x83B9D20", VA = "0x1883BAD20")]
		private bool JEKHFDECMXW(DQREECIDSJF a, [Out] AJQXREXZXZS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83BDA30", Offset = "0x83BCA30", VA = "0x1883BDA30")]
		private AJQXREXZXZS WIGUZBZLYJT(DQREECIDSJF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83BBE10", Offset = "0x83BAE10", VA = "0x1883BBE10")]
		private AJQXREXZXZS OHEFAKHOKVM(DQREECIDSJF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83BB810", Offset = "0x83BA810", VA = "0x1883BB810")]
		private AJQXREXZXZS NJRIAEVYPAT(DQREECIDSJF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83B7C70", Offset = "0x83B6C70", VA = "0x1883B7C70")]
		private static Guid KZSLRICOQQI(DQREECIDSJF a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83BA830", Offset = "0x83B9830", VA = "0x1883BA830")]
		private string IFEMOFLMLOV(DQREECIDSJF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83BB070", Offset = "0x83BA070", VA = "0x1883BB070")]
		private void MFVEKIKZIKC(AJQXREXZXZS a, AJQXREXZXZS b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83B9EF0", Offset = "0x83B8EF0", VA = "0x1883B9EF0")]
		private void DNFBYRGENPQ(AJQXREXZXZS a, AJQXREXZXZS b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83B9A20", Offset = "0x83B8A20", VA = "0x1883B9A20")]
		private void BABBFBEQVXC(AJQXREXZXZS a, AJQXREXZXZS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83BAEE0", Offset = "0x83B9EE0", VA = "0x1883BAEE0")]
		private void LGMTRQNWTLT(AJQXREXZXZS a, AJQXREXZXZS b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83BBD00", Offset = "0x83BAD00", VA = "0x1883BBD00")]
		private void OFICEPPMMTO(ObjectLocalId a, AJQXREXZXZS b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83BBA80", Offset = "0x83BAA80", VA = "0x1883BBA80")]
		private void OBHPVLLJLSX(ObjectLocalId a, AJQXREXZXZS b, AJQXREXZXZS c, AJQXREXZXZS d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class YZASEZYJLRM
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DDFDKRDHJEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public KTJKRWFMICD container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public DDFDKRDHJEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x83AFD50", Offset = "0x83AED50", VA = "0x1883AFD50")]
			internal OMConnectableManager TOLGCNRIZIY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83C2510", Offset = "0x83C1510", VA = "0x1883C2510")]
		public static void NUUESYKGQIQ(KTJKRWFMICD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83C2680", Offset = "0x83C1680", VA = "0x1883C2680")]
		public static void UQXNDFMMKQL(KTJKRWFMICD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : AETZWVJULTO, IMXEEVUKTIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager XSOSIGNQHQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly JVWNFPZRGOO VHGKCDAEXIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly HCYBCRZWVQG FPQJJVNTAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly JIFKUNMUGEQ[] MABTFYEVGPW;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AJQXREXZXZS ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x83BFEF0", Offset = "0x83BEEF0", VA = "0x1883BFEF0", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AJQXREXZXZS BVRERKJGITN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x83BF030", Offset = "0x83BE030", VA = "0x1883BF030", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 DPIHRZBAMKB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83BE970", Offset = "0x83BD970", VA = "0x1883BE970", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion GNQLORGJKOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83BF6D0", Offset = "0x83BE6D0", VA = "0x1883BF6D0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IFSSFFAVSKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x83BF540", Offset = "0x83BE540", VA = "0x1883BF540", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<AJQXREXZXZS> ZGFIYVTFPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x83BF5B0", Offset = "0x83BE5B0", VA = "0x1883BF5B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool GNERPKPROJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xBBF510", Offset = "0xBBE510", VA = "0x180BBF510", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC10080", Offset = "0xC0F080", VA = "0x180C10080", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x83C00F0", Offset = "0x83BF0F0", VA = "0x1883C00F0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x83BFE10", Offset = "0x83BEE10", VA = "0x1883BFE10", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x83BFE30", Offset = "0x83BEE30", VA = "0x1883BFE30", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x83BFF50", Offset = "0x83BEF50", VA = "0x1883BFF50", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x83C0030", Offset = "0x83BF030", VA = "0x1883C0030", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool WLVSURWXUOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x83BF680", Offset = "0x83BE680", VA = "0x1883BF680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler AUOCCVUVUXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83BF4F0", Offset = "0x83BE4F0", VA = "0x1883BF4F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83BF0F0", Offset = "0x83BE0F0", VA = "0x1883BF0F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler DWARMEGZJED
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x83BF630", Offset = "0x83BE630", VA = "0x1883BF630", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x83BE830", Offset = "0x83BD830", VA = "0x1883BE830", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler YMUAJIBTCWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x83BFC40", Offset = "0x83BEC40", VA = "0x1883BFC40", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x83BE920", Offset = "0x83BD920", VA = "0x1883BE920", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler DIDVNWPCNMP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83BE740", Offset = "0x83BD740", VA = "0x1883BE740", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x83BF450", Offset = "0x83BE450", VA = "0x1883BF450", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83BFD10", Offset = "0x83BED10", VA = "0x1883BFD10")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, JVWNFPZRGOO connectableTool, JIFKUNMUGEQ[] connectionPoints, HCYBCRZWVQG callbacks, AMQYVKEURHV connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x83BE430", Offset = "0x83BD430", VA = "0x1883BE430", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "21")]
		public void COEHCGHMSNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x83BF730", Offset = "0x83BE730", VA = "0x1883BF730", Slot = "22")]
		public void RTBSIWXCVZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83BF770", Offset = "0x83BE770", VA = "0x1883BF770", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x83BFA30", Offset = "0x83BEA30", VA = "0x1883BFA30", Slot = "25")]
		public void XZTQEZVVXAP(int a, AJQXREXZXZS b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83BE360", Offset = "0x83BD360", VA = "0x1883BE360", Slot = "26")]
		public void ANIGFRLUPCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83BE460", Offset = "0x83BD460", VA = "0x1883BE460", Slot = "27")]
		public void BDPSIJXYGWF(int a, AJQXREXZXZS b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83BF7C0", Offset = "0x83BE7C0", VA = "0x1883BF7C0", Slot = "28")]
		public void UPMAXKBQONF(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83BEC20", Offset = "0x83BDC20", VA = "0x1883BEC20", Slot = "31")]
		public void JCKVKONPFPK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83BF140", Offset = "0x83BE140", VA = "0x1883BF140", Slot = "29")]
		public void LUMMPAMGELA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83BF840", Offset = "0x83BE840", VA = "0x1883BF840", Slot = "30")]
		public void XDQCBFMQTGV(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x83BEB00", Offset = "0x83BDB00", VA = "0x1883BEB00", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83BE9D0", Offset = "0x83BD9D0", VA = "0x1883BE9D0", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB50EA0", Offset = "0xB4FEA0", VA = "0x180B50EA0", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83BE880", Offset = "0x83BD880", VA = "0x1883BE880", Slot = "43")]
		public bool CanConnectTo(int slotIndex, AJQXREXZXZS otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "44")]
		public void ParentChanged(int slotIndex, AJQXREXZXZS newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "45")]
		public void ChildAdded(int slotIndex, AJQXREXZXZS newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "46")]
		public void ChildRemoved(int slotIndex, AJQXREXZXZS removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "47")]
		public void ConnectionModified(int slotIndex, AJQXREXZXZS parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83BF750", Offset = "0x83BE750", VA = "0x1883BF750", Slot = "48")]
		public void RootChanged(AJQXREXZXZS previousRootConnectable, AJQXREXZXZS newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83BE7E0", Offset = "0x83BD7E0", VA = "0x1883BE7E0", Slot = "23")]
		public void CMZSLFFKJLZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83BF5E0", Offset = "0x83BE5E0", VA = "0x1883BF5E0", Slot = "24")]
		public void PNZUAEJLVAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83BEBD0", Offset = "0x83BDBD0", VA = "0x1883BEBD0")]
		private void ITNWBJXYRUQ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(LJLGLDTVORT), new string[] { })]
	public class XZNWRBNBZEW : LJLGLDTVORT, FGJPSHLXWSW, OZDTSOBLUVI
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NMXMBBMJYRH
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public NMXMBBMJYRH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private DQQEDLOYERD ZOLYTZVOMLE;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object OSMGFWXTPRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x83C2410", Offset = "0x83C1410", VA = "0x1883C2410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83C23C0", Offset = "0x83C13C0", VA = "0x1883C23C0", Slot = "5")]
		private void DRCAJKSLWZO(MEMEGXEKDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xCE8C60", Offset = "0xCE7C60", VA = "0x180CE8C60", Slot = "6")]
		private void ZWDRINULYCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public XZNWRBNBZEW()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(AMQYVKEURHV), new string[] { "Ignore", "Mock" })]
	public class QCSFXIEKUJC : AMQYVKEURHV, YKHKLPHTBGW
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool OPWPRMKHCCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool ADCXXGWNYGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<AJQXREXZXZS, AJQXREXZXZS> NIKSZFIYSKP
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x83C0480", Offset = "0x83BF480", VA = "0x1883C0480", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x83C0270", Offset = "0x83BF270", VA = "0x1883C0270", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AJQXREXZXZS, AJQXREXZXZS> PAIUXUKRZAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x83C03D0", Offset = "0x83BF3D0", VA = "0x1883C03D0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x83C0110", Offset = "0x83BF110", VA = "0x1883C0110", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<AJQXREXZXZS, AJQXREXZXZS, AJQXREXZXZS> CLPWWEDIYPR
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x83C01C0", Offset = "0x83BF1C0", VA = "0x1883C01C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x83C0320", Offset = "0x83BF320", VA = "0x1883C0320", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "26")]
		public void QQFIGNLTLAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "12")]
		public void Initialize(GameObject gameObject, WJKDYMTUPZI configData, FCASZNGZOTP rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "14")]
		public void BPSMAKIBARY(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "15")]
		public void GNUCJQLWVOR(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "16")]
		public void RKBIBYLYDIS(AJQXREXZXZS a, HashSet<AJQXREXZXZS> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "17")]
		public void UTFEELNEITC(AJQXREXZXZS a, AJQXREXZXZS b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "18")]
		public void GVXFNAHOEII(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "19")]
		public void UYYFTAEZUPE(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "20")]
		public ConnectableGraphData OHWQOUDNBUL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "21")]
		public ConnectableGraphData ILTGYBSXSLX(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "22")]
		public bool DAJCMVLBQJJ(DQREECIDSJF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "23")]
		public void BVHDXOIPOAE(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "24")]
		public void UWIJFNQBJCK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "25")]
		public void EMHAADEIZUP(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public QCSFXIEKUJC()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AJQXREXZXZS : IMXEEVUKTIJ, IEquatable<AJQXREXZXZS>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface IMXEEVUKTIJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		AJQXREXZXZS ParentConnectable
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
		bool CanConnectTo(int slotIndex, AJQXREXZXZS otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, AJQXREXZXZS newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, AJQXREXZXZS newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, AJQXREXZXZS removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, AJQXREXZXZS parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(AJQXREXZXZS previousRootConnectable, AJQXREXZXZS newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface AMQYVKEURHV : YKHKLPHTBGW
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool OPWPRMKHCCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ADCXXGWNYGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<AJQXREXZXZS, AJQXREXZXZS> NIKSZFIYSKP;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<AJQXREXZXZS, AJQXREXZXZS> PAIUXUKRZAJ;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<AJQXREXZXZS, AJQXREXZXZS, AJQXREXZXZS> CLPWWEDIYPR;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, WJKDYMTUPZI configData, FCASZNGZOTP rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BPSMAKIBARY(AJQXREXZXZS a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GNUCJQLWVOR(AJQXREXZXZS a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void RKBIBYLYDIS(AJQXREXZXZS a, HashSet<AJQXREXZXZS> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void UTFEELNEITC(AJQXREXZXZS a, AJQXREXZXZS b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void GVXFNAHOEII(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void UYYFTAEZUPE(AJQXREXZXZS a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData OHWQOUDNBUL(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData ILTGYBSXSLX(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool DAJCMVLBQJJ(DQREECIDSJF a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void BVHDXOIPOAE(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void UWIJFNQBJCK(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void EMHAADEIZUP(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface BTLSYSZTAMR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool GJCZRRWYTMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AJQXREXZXZS NJRIAEVYPAT(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AJQXREXZXZS OHEFAKHOKVM(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TTJOFQUZSSC(AJQXREXZXZS a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KIBCKMVMEVU();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZDVGPTQZFVD(AJQXREXZXZS a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface HCYBCRZWVQG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WLVSURWXUOC(JVWNFPZRGOO a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JHVIQVFFRVF(JVWNFPZRGOO a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string BOEJGZKHMOG(JVWNFPZRGOO a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid BGDDLVJELGJ(JVWNFPZRGOO a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int GRTCIPRNYCC(JVWNFPZRGOO a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SVIWUWXVRNH(JVWNFPZRGOO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(AJQXREXZXZS childConnectable, int childConnectableSlot, AJQXREXZXZS parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(AJQXREXZXZS previousRootConnectable, AJQXREXZXZS newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface JVWNFPZRGOO : AJQXREXZXZS, IMXEEVUKTIJ, IEquatable<AJQXREXZXZS>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface AETZWVJULTO : IMXEEVUKTIJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		AJQXREXZXZS BVRERKJGITN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<AJQXREXZXZS> ZGFIYVTFPKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 DPIHRZBAMKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion GNQLORGJKOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IFSSFFAVSKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool GNERPKPROJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler AUOCCVUVUXD;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler DWARMEGZJED;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler YMUAJIBTCWY;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler DIDVNWPCNMP;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void COEHCGHMSNH();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void RTBSIWXCVZY();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void CMZSLFFKJLZ();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void PNZUAEJLVAY();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void XZTQEZVVXAP(int a, AJQXREXZXZS b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void ANIGFRLUPCX();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void BDPSIJXYGWF(int a, AJQXREXZXZS b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void UPMAXKBQONF(AJQXREXZXZS a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void LUMMPAMGELA();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void XDQCBFMQTGV(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void JCKVKONPFPK(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface JIFKUNMUGEQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 PAXGUFYFRUT
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
	public interface WJKDYMTUPZI
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool CMVKYRUMHJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		RZJWLEMKAYV WAEHYKMKFIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, WJKDYMTUPZI
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
		public bool CMVKYRUMHJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xC35BD0", Offset = "0xC34BD0", VA = "0x180C35BD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public RZJWLEMKAYV WAEHYKMKFIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83AF520", Offset = "0x83AE520", VA = "0x1883AF520")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x83AF5E0", Offset = "0x83AE5E0", VA = "0x1883AF5E0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AJQXREXZXZS connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x83AFBB0", Offset = "0x83AEBB0", VA = "0x1883AFBB0")]
		public ConnectableLink(AJQXREXZXZS connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x83AFA90", Offset = "0x83AEA90", VA = "0x1883AFA90")]
		public ConnectableLink(AJQXREXZXZS connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x83AFB30", Offset = "0x83AEB30", VA = "0x1883AFB30")]
		public ConnectableLink(AJQXREXZXZS connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x83AF630", Offset = "0x83AE630", VA = "0x1883AF630", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x83AF6E0", Offset = "0x83AE6E0", VA = "0x1883AF6E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : SWAAXYXTMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform PBSPRLEJMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private RZJWLEMKAYV OUOANALEEFP;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7CE80D0", Offset = "0x7CE70D0", VA = "0x187CE80D0", Slot = "4")]
		public void Initialize(Transform transform, RZJWLEMKAYV linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x83B0290", Offset = "0x83AF290", VA = "0x1883B0290", Slot = "5")]
		public RZJWLEMKAYV JJBMAWHCQWH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x83B0220", Offset = "0x83AF220", VA = "0x1883B0220", Slot = "6")]
		public void FWDHDQZZYBJ(RZJWLEMKAYV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, JKLTQWVJEFN
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class VQXJMTHRJLS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AJQXREXZXZS ZTWQSBDWLHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AJQXREXZXZS KYENNJPMISX;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public VQXJMTHRJLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83C21C0", Offset = "0x83C11C0", VA = "0x1883C21C0")]
			internal bool IAAHHNHOTMR(YJHZACZZYMU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly RCRJELTYAEN UFEXEIHPYSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EGUXHSGNEJG VISEEGEEXSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LZVGMLFUZUM IYRBRTFQFRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool WEDSEEOLKHS;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log WJQSAAZNZWC;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public YJHZACZZYMU SYFXSLEPKPV
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x83B21B0", Offset = "0x83B11B0", VA = "0x1883B21B0")]
		public bool LOQSPOKCGGE([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x83B0B50", Offset = "0x83AFB50", VA = "0x1883B0B50")]
		private bool AZWIKYCOCYD([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83B3EE0", Offset = "0x83B2EE0", VA = "0x1883B3EE0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x83B1F20", Offset = "0x83B0F20", VA = "0x1883B1F20", Slot = "5")]
		public void Initialize(AMQYVKEURHV manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83B13A0", Offset = "0x83B03A0", VA = "0x1883B13A0", Slot = "17")]
		public void BXEKWDKRZAJ(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83B1390", Offset = "0x83B0390", VA = "0x1883B1390", Slot = "12")]
		public void BVSNFSORDTG(Func<AJQXREXZXZS, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x83B1260", Offset = "0x83B0260", VA = "0x1883B1260")]
		private void BVSNFSORDTG(RCRJELTYAEN a, Func<AJQXREXZXZS, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x83B3650", Offset = "0x83B2650", VA = "0x1883B3650", Slot = "11")]
		public void SHXAHUKBAWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x83B2620", Offset = "0x83B1620", VA = "0x1883B2620", Slot = "8")]
		public bool NSLWRIZWGHX(AJQXREXZXZS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x83B2630", Offset = "0x83B1630", VA = "0x1883B2630")]
		private bool NTPXCFCFLNI(AJQXREXZXZS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x83B2570", Offset = "0x83B1570", VA = "0x1883B2570")]
		private static bool MRESJNKVFJC(AJQXREXZXZS a, RCRJELTYAEN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x83B1470", Offset = "0x83B0470", VA = "0x1883B1470")]
		private void DAZDKFNGEJU(Transform a, RCRJELTYAEN b, RCRJELTYAEN[] c, AJQXREXZXZS d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x83B3BA0", Offset = "0x83B2BA0", VA = "0x1883B3BA0")]
		private ConnectableLink YKQQZHKVLYP(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x83B3980", Offset = "0x83B2980", VA = "0x1883B3980")]
		private static bool VKAZADLWBKK(RCRJELTYAEN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83B3180", Offset = "0x83B2180", VA = "0x1883B3180", Slot = "9")]
		public bool PTYCFDTZMUV(AJQXREXZXZS a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83B21C0", Offset = "0x83B11C0", VA = "0x1883B21C0")]
		private bool LQRKJYAFEBA(AJQXREXZXZS a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83B3000", Offset = "0x83B2000", VA = "0x1883B3000")]
		private static void PEZKVBJYWKN(AJQXREXZXZS a, int b, int c, Vector3 d, Quaternion e, RCRJELTYAEN f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83B2450", Offset = "0x83B1450", VA = "0x1883B2450")]
		private void MFVEKIKZIKC(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x83B31E0", Offset = "0x83B21E0", VA = "0x1883B31E0")]
		private void QUDUWDLLRTA(RCRJELTYAEN a, AJQXREXZXZS b, AJQXREXZXZS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x83B3250", Offset = "0x83B2250", VA = "0x1883B3250")]
		private void QUDUWDLLRTA(AJQXREXZXZS a, AJQXREXZXZS b, AJQXREXZXZS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x83B2D30", Offset = "0x83B1D30", VA = "0x1883B2D30")]
		private void OBHPVLLJLSX(AJQXREXZXZS a, AJQXREXZXZS b, AJQXREXZXZS c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x83B2DA0", Offset = "0x83B1DA0", VA = "0x1883B2DA0")]
		private void OBHPVLLJLSX(RCRJELTYAEN a, AJQXREXZXZS b, AJQXREXZXZS c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x83B1860", Offset = "0x83B0860", VA = "0x1883B1860")]
		private void DNFBYRGENPQ(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x83B1100", Offset = "0x83B0100", VA = "0x1883B1100")]
		private void BABBFBEQVXC(YJHZACZZYMU a, YJHZACZZYMU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x83B2EA0", Offset = "0x83B1EA0", VA = "0x1883B2EA0", Slot = "18")]
		public AJQXREXZXZS ODYRTWGICIF(AJQXREXZXZS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x83B32C0", Offset = "0x83B22C0", VA = "0x1883B32C0", Slot = "13")]
		public void RKBIBYLYDIS(AJQXREXZXZS a, HashSet<AJQXREXZXZS> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x83B3740", Offset = "0x83B2740", VA = "0x1883B3740", Slot = "14")]
		public List<AJQXREXZXZS> TTWDAPFMOIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x83B3670", Offset = "0x83B2670", VA = "0x1883B3670")]
		protected YJHZACZZYMU TFITGEHYAOJ(YJHZACZZYMU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x83B13D0", Offset = "0x83B03D0", VA = "0x1883B13D0")]
		protected RCRJELTYAEN[] BYSLZIEZNVA(RCRJELTYAEN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x83B1FD0", Offset = "0x83B0FD0", VA = "0x1883B1FD0")]
		protected bool KLBQGONSPIX(AJQXREXZXZS a, [Out] RCRJELTYAEN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x83B3CF0", Offset = "0x83B2CF0", VA = "0x1883B3CF0", Slot = "15")]
		public bool ZVPTNHPJZUT(AJQXREXZXZS a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x83B2410", Offset = "0x83B1410", VA = "0x1883B2410")]
		protected RCRJELTYAEN MEZKZZGCVUM(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x83B3B40", Offset = "0x83B2B40", VA = "0x1883B3B40", Slot = "10")]
		public bool WWGQAPJADLB(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x83B1980", Offset = "0x83B0980", VA = "0x1883B1980")]
		private bool HSXTOXBAWTY(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x83B20E0", Offset = "0x83B10E0", VA = "0x1883B20E0")]
		private static bool KUKUWSQODHW(RCRJELTYAEN a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x83B21B0", Offset = "0x83B11B0", VA = "0x1883B21B0", Slot = "7")]
		private bool OTSHDCTAYEB([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : AMQYVKEURHV, YKHKLPHTBGW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly KTJKRWFMICD container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly LZVGMLFUZUM IYRBRTFQFRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly NMBMIUJIRGN WJFYQDQJZQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly OBIWCMPUVPB DQGBSZZVUKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly JKLTQWVJEFN PTFWWNVRRWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal UHAMCFLRMAE FPQJJVNTAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal GPVAXENYLRV KHSTRZZHITT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal EGUXHSGNEJG VYISQGULFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool WEDSEEOLKHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool JQLHBZAWVUB;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CRVZFQSTWEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB188E0", Offset = "0xB178E0", VA = "0x180B188E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xB18800", Offset = "0xB17800", VA = "0x180B18800")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OPWPRMKHCCE
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x10BC6C0", Offset = "0x10BB6C0", VA = "0x1810BC6C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x25BFCF0", Offset = "0x25BECF0", VA = "0x1825BFCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ADCXXGWNYGC
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<AJQXREXZXZS, AJQXREXZXZS> NIKSZFIYSKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x83B5CC0", Offset = "0x83B4CC0", VA = "0x1883B5CC0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x83B5220", Offset = "0x83B4220", VA = "0x1883B5220", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<AJQXREXZXZS, AJQXREXZXZS> PAIUXUKRZAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x83B5620", Offset = "0x83B4620", VA = "0x1883B5620", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x83B4190", Offset = "0x83B3190", VA = "0x1883B4190", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<AJQXREXZXZS, AJQXREXZXZS, AJQXREXZXZS> CLPWWEDIYPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x83B51C0", Offset = "0x83B41C0", VA = "0x1883B51C0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x83B5400", Offset = "0x83B4400", VA = "0x1883B5400", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x83B5D20", Offset = "0x83B4D20", VA = "0x1883B5D20")]
		public LegacyConnectableManager(KTJKRWFMICD container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x83B4C00", Offset = "0x83B3C00", VA = "0x1883B4C00", Slot = "12")]
		public void Initialize(GameObject gameObject, WJKDYMTUPZI configData, FCASZNGZOTP rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x83B5460", Offset = "0x83B4460", VA = "0x1883B5460", Slot = "26")]
		public void QQFIGNLTLAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x83B5B00", Offset = "0x83B4B00", VA = "0x1883B5B00", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x83B4090", Offset = "0x83B3090", VA = "0x1883B4090", Slot = "14")]
		public void BPSMAKIBARY(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x83B4410", Offset = "0x83B3410", VA = "0x1883B4410", Slot = "15")]
		public void GNUCJQLWVOR(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x83B4140", Offset = "0x83B3140", VA = "0x1883B4140", Slot = "22")]
		public bool DAJCMVLBQJJ(DQREECIDSJF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x83B4800", Offset = "0x83B3800", VA = "0x1883B4800")]
		internal bool HSXTOXBAWTY([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x83B4AB0", Offset = "0x83B3AB0", VA = "0x1883B4AB0")]
		internal bool IRQOHDENWMI([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x83B41F0", Offset = "0x83B31F0", VA = "0x1883B41F0")]
		internal void DRSXXITMKTG(AJQXREXZXZS a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x83B4410", Offset = "0x83B3410", VA = "0x1883B4410")]
		internal bool FCVICKSTDWO(AJQXREXZXZS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x83B5B80", Offset = "0x83B4B80", VA = "0x1883B5B80")]
		internal bool XOHLVUFSNOY(AJQXREXZXZS a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x83B5530", Offset = "0x83B4530", VA = "0x1883B5530", Slot = "16")]
		public void RKBIBYLYDIS(AJQXREXZXZS a, HashSet<AJQXREXZXZS> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x83B5680", Offset = "0x83B4680", VA = "0x1883B5680", Slot = "17")]
		public void UTFEELNEITC(AJQXREXZXZS a, AJQXREXZXZS b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x83B4470", Offset = "0x83B3470", VA = "0x1883B4470", Slot = "18")]
		public void GVXFNAHOEII(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x83B5940", Offset = "0x83B4940", VA = "0x1883B5940", Slot = "19")]
		public void UYYFTAEZUPE(AJQXREXZXZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x83B45B0", Offset = "0x83B35B0", VA = "0x1883B45B0")]
		public void HHXBXYOSNXZ([Optional] OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x83B40B0", Offset = "0x83B30B0", VA = "0x1883B40B0", Slot = "23")]
		public void BVHDXOIPOAE(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x83B5280", Offset = "0x83B4280", VA = "0x1883B5280", Slot = "20")]
		public ConnectableGraphData OHWQOUDNBUL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x83B4910", Offset = "0x83B3910", VA = "0x1883B4910", Slot = "21")]
		public ConnectableGraphData ILTGYBSXSLX(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x83B43D0", Offset = "0x83B33D0", VA = "0x1883B43D0", Slot = "25")]
		public void EMHAADEIZUP(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x83B5890", Offset = "0x83B4890", VA = "0x1883B5890", Slot = "24")]
		public void UWIJFNQBJCK(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class LZVGMLFUZUM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly KJMRSJLDVJP<AJQXREXZXZS, AJQXREXZXZS> NIKSZFIYSKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly KJMRSJLDVJP<AJQXREXZXZS, AJQXREXZXZS> PAIUXUKRZAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly KJHKVCRGLYG<AJQXREXZXZS, AJQXREXZXZS, AJQXREXZXZS> CLPWWEDIYPR;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x83B0120", Offset = "0x83AF120", VA = "0x1883B0120")]
		public LZVGMLFUZUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x83B0040", Offset = "0x83AF040", VA = "0x1883B0040")]
		public void XSYAKFGVZAX(AJQXREXZXZS a, AJQXREXZXZS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x83AFFE0", Offset = "0x83AEFE0", VA = "0x1883AFFE0")]
		public void WWDMSVEQPTT(AJQXREXZXZS a, AJQXREXZXZS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83B00A0", Offset = "0x83AF0A0", VA = "0x1883B00A0")]
		public void ZOCBSIKCETB(AJQXREXZXZS a, AJQXREXZXZS b, AJQXREXZXZS c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class NMBMIUJIRGN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager KJBHTHEXJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private GPVAXENYLRV KHSTRZZHITT;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public NMBMIUJIRGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x83B6F80", Offset = "0x83B5F80", VA = "0x1883B6F80")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x83B6F70", Offset = "0x83B5F70", VA = "0x1883B6F70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x83B7220", Offset = "0x83B6220", VA = "0x1883B7220")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x83B71B0", Offset = "0x83B61B0", VA = "0x1883B71B0")]
		private void OnMasterClientSwitched(OVSEBXDBUJS newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x83B70B0", Offset = "0x83B60B0", VA = "0x1883B70B0")]
		public void JNMVRLKXMPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x83B7260", Offset = "0x83B6260", VA = "0x1883B7260")]
		public void SKWDJQBIMPG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class ZFQMCGELJZD
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class DDFDKRDHJEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KTJKRWFMICD container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public DDFDKRDHJEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x83AFDF0", Offset = "0x83AEDF0", VA = "0x1883AFDF0")]
			internal LegacyConnectableManager TOLGCNRIZIY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x83C26D0", Offset = "0x83C16D0", VA = "0x1883C26D0")]
		public static void NUUESYKGQIQ(KTJKRWFMICD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x83C28C0", Offset = "0x83C18C0", VA = "0x1883C28C0")]
		public static void UQXNDFMMKQL(KTJKRWFMICD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, EGUXHSGNEJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, RZJWLEMKAYV> ZQUSMMIXGUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation MWQKSSMSDIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SWAAXYXTMDB OMAUCVNIZCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private JKLTQWVJEFN PTFWWNVRRWN;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker VVBOLFAPUPR;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x83B6D10", Offset = "0x83B5D10", VA = "0x1883B6D10")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x83B6AB0", Offset = "0x83B5AB0", VA = "0x1883B6AB0", Slot = "7")]
		public void Initialize(JKLTQWVJEFN graph, SWAAXYXTMDB creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x83B63D0", Offset = "0x83B53D0", VA = "0x1883B63D0", Slot = "5")]
		public void CKERNSLAPFG(YJHZACZZYMU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x83B60B0", Offset = "0x83B50B0", VA = "0x1883B60B0", Slot = "9")]
		public void ABVZZXVGKVZ(YJHZACZZYMU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x83B6AF0", Offset = "0x83B5AF0", VA = "0x1883B6AF0", Slot = "8")]
		public void YYZVLSHZSTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x83B6610", Offset = "0x83B5610", VA = "0x1883B6610", Slot = "10")]
		public void EUEVOBIJFSQ(YJHZACZZYMU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x83B6960", Offset = "0x83B5960", VA = "0x1883B6960", Slot = "11")]
		public void FIKKSSACSVW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x83B6220", Offset = "0x83B5220", VA = "0x1883B6220")]
		private bool BQCNLXTJYED(YJHZACZZYMU a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class OBIWCMPUVPB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly RCRJELTYAEN currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly DQREECIDSJF parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly DQREECIDSJF rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool PDTXZLLOHXC
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x83C1820", Offset = "0x83C0820", VA = "0x1883C1820")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x83C1F50", Offset = "0x83C0F50", VA = "0x1883C1F50")]
			public SerializeNodeInSubgraph(RCRJELTYAEN currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] DQREECIDSJF parentNodeData, [Optional] DQREECIDSJF rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x83C1AF0", Offset = "0x83C0AF0", VA = "0x1883C1AF0")]
			public DQREECIDSJF XRHSQBYDVHR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x83C1E90", Offset = "0x83C0E90", VA = "0x1883C1E90")]
			private DQREECIDSJF YUQMYYHHXWD([Out] DQREECIDSJF a, [Out] DQREECIDSJF b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x83C1C90", Offset = "0x83C0C90", VA = "0x1883C1C90")]
			private DQREECIDSJF YMYTJCSZDTD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x83C16B0", Offset = "0x83C06B0", VA = "0x1883C16B0")]
			private void DALNGHIRMTB(DQREECIDSJF a, DQREECIDSJF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x83C1930", Offset = "0x83C0930", VA = "0x1883C1930")]
			private void VBNPSPRJGWQ(DQREECIDSJF a, DQREECIDSJF b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager KJBHTHEXJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private JKLTQWVJEFN PTFWWNVRRWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private EGUXHSGNEJG VISEEGEEXSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private GPVAXENYLRV KHSTRZZHITT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool ICKMEZENMJF;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool RULESLSINHC
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x83B76B0", Offset = "0x83B66B0", VA = "0x1883B76B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool CRVZFQSTWEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x83B8A40", Offset = "0x83B7A40", VA = "0x1883B8A40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x83B7C50", Offset = "0x83B6C50", VA = "0x1883B7C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x83B7BE0", Offset = "0x83B6BE0", VA = "0x1883B7BE0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x83B86F0", Offset = "0x83B76F0", VA = "0x1883B86F0")]
		public ConnectableGraphData OHWQOUDNBUL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A40", Offset = "0x83B6A40", VA = "0x1883B7A40")]
		public ConnectableGraphData ILTGYBSXSLX(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x83B7360", Offset = "0x83B6360", VA = "0x1883B7360")]
		public void BVHDXOIPOAE(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x83B91A0", Offset = "0x83B81A0", VA = "0x1883B91A0")]
		public void UWIJFNQBJCK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x83B7680", Offset = "0x83B6680", VA = "0x1883B7680")]
		public void FCHGRETLFYY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x83B8860", Offset = "0x83B7860", VA = "0x1883B8860")]
		private void PRAJBVBNRES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x83B8CE0", Offset = "0x83B7CE0", VA = "0x1883B8CE0")]
		private DQREECIDSJF RUIDZDMPAYL(RCRJELTYAEN a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x83B8EF0", Offset = "0x83B7EF0", VA = "0x1883B8EF0")]
		private static void UWIAXLFFGHF(RCRJELTYAEN a, bool b, DQREECIDSJF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x83B9570", Offset = "0x83B8570", VA = "0x1883B9570")]
		private void WMCPOWDFIIQ(RCRJELTYAEN a, bool b, DQREECIDSJF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x83B7CB0", Offset = "0x83B6CB0", VA = "0x1883B7CB0")]
		private DQREECIDSJF LTMXNPOSJEF(RCRJELTYAEN a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x83B8A60", Offset = "0x83B7A60", VA = "0x1883B8A60")]
		private bool QSWAVXLTFHL(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x83B7D40", Offset = "0x83B6D40", VA = "0x1883B7D40")]
		private bool MHEZPSCJQMM(DQREECIDSJF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x83B8ED0", Offset = "0x83B7ED0", VA = "0x1883B8ED0")]
		private bool TNDUXXHVKXE(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x83B8DC0", Offset = "0x83B7DC0", VA = "0x1883B8DC0")]
		private static bool SDAUVNYXDHF(DQREECIDSJF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x83B73F0", Offset = "0x83B63F0", VA = "0x1883B73F0")]
		public static bool DAJCMVLBQJJ(DQREECIDSJF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x83B9240", Offset = "0x83B8240", VA = "0x1883B9240")]
		private AJQXREXZXZS WIGUZBZLYJT(DQREECIDSJF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x83B8580", Offset = "0x83B7580", VA = "0x1883B8580")]
		private AJQXREXZXZS NJRIAEVYPAT(DQREECIDSJF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x83B9790", Offset = "0x83B8790", VA = "0x1883B9790")]
		private AJQXREXZXZS ZJBTFLHJWYO(DQREECIDSJF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x83B7C70", Offset = "0x83B6C70", VA = "0x1883B7C70")]
		private static Guid KZSLRICOQQI(DQREECIDSJF a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x83B7950", Offset = "0x83B6950", VA = "0x1883B7950")]
		private string IFEMOFLMLOV(DQREECIDSJF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x83B8390", Offset = "0x83B7390", VA = "0x1883B8390")]
		private bool MVWWKBILVTG(RCRJELTYAEN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x83B7700", Offset = "0x83B6700", VA = "0x1883B7700")]
		private static void HIESCLWKCXI(RCRJELTYAEN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public OBIWCMPUVPB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AJQXREXZXZS child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AJQXREXZXZS parent;

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
		public ConnectableLink WFWIIIEYLEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x83AFC40", Offset = "0x83AEC40", VA = "0x1883AFC40")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink MQGDYWDYRIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x83AFC10", Offset = "0x83AEC10", VA = "0x1883AFC10")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x83AFCE0", Offset = "0x83AECE0", VA = "0x1883AFCE0")]
		public ConnectionOperationData(AJQXREXZXZS child, AJQXREXZXZS parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface JKLTQWVJEFN
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		YJHZACZZYMU SYFXSLEPKPV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(AMQYVKEURHV manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LOQSPOKCGGE([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NSLWRIZWGHX(AJQXREXZXZS a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool PTYCFDTZMUV(AJQXREXZXZS a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool WWGQAPJADLB(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SHXAHUKBAWU();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void BVSNFSORDTG(Func<AJQXREXZXZS, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RKBIBYLYDIS(AJQXREXZXZS a, HashSet<AJQXREXZXZS> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<AJQXREXZXZS> TTWDAPFMOIO();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool ZVPTNHPJZUT(AJQXREXZXZS a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void BXEKWDKRZAJ(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(YJHZACZZYMU node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface YJHZACZZYMU
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		AJQXREXZXZS KRTMCYIHRUD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		YJHZACZZYMU YODRVKGPXDV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink VCFOACTTWED
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool NJCUNBOEJTV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface RZJWLEMKAYV : AXZKIGCFCYD.WRWCUWEHOCZ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GRLRHMOCTOZ(AJQXREXZXZS a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PUZJDLZCGUF(AJQXREXZXZS a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FHHMCCXPNWO(AJQXREXZXZS a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NZPHSMVDQHQ(AJQXREXZXZS a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RZJWLEMKAYV GXLTHYQOLSN(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface SWAAXYXTMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, RZJWLEMKAYV linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RZJWLEMKAYV JJBMAWHCQWH();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FWDHDQZZYBJ(RZJWLEMKAYV a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface UHAMCFLRMAE : BTLSYSZTAMR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XUPIVUARVPQ();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VMCKUDVIJAT(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface EGUXHSGNEJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CKERNSLAPFG(YJHZACZZYMU a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(JKLTQWVJEFN graph, SWAAXYXTMDB linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YYZVLSHZSTT();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ABVZZXVGKVZ(YJHZACZZYMU a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EUEVOBIJFSQ(YJHZACZZYMU a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FIKKSSACSVW();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class RCRJELTYAEN : YJHZACZZYMU
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class WHHMAWZYPTP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink QHUNACXUGFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public RCRJELTYAEN EOPBBTSIDFD;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public WHHMAWZYPTP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x83C2280", Offset = "0x83C1280", VA = "0x1883C2280")]
			internal bool TZSRPWZZDZC(YJHZACZZYMU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink MCHQHJXLTKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<RCRJELTYAEN> JZQCABQWCXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private RCRJELTYAEN CWZDDPDMJCA;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink VCFOACTTWED
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4911540", Offset = "0x4910540", VA = "0x184911540", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x83C1200", Offset = "0x83C0200", VA = "0x1883C1200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private RCRJELTYAEN CGKCNLBHYUH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x83C0FE0", Offset = "0x83BFFE0", VA = "0x1883C0FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public YJHZACZZYMU YODRVKGPXDV
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public AJQXREXZXZS KRTMCYIHRUD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool NJCUNBOEJTV
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x83C14C0", Offset = "0x83C04C0", VA = "0x1883C14C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool DWTEUOYEQTB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x83C11B0", Offset = "0x83C01B0", VA = "0x1883C11B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected RCRJELTYAEN EQMHNAKVRHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x83C0B80", Offset = "0x83BFB80", VA = "0x1883C0B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x83C1610", Offset = "0x83C0610", VA = "0x1883C1610")]
		public RCRJELTYAEN(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x83C14D0", Offset = "0x83C04D0", VA = "0x1883C14D0")]
		public RCRJELTYAEN VVRQOXRGJLG(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x83C0BA0", Offset = "0x83BFBA0", VA = "0x1883C0BA0")]
		public RCRJELTYAEN BIKOABBDVNG(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x83C1230", Offset = "0x83C0230", VA = "0x1883C1230")]
		public RCRJELTYAEN Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x83C0E90", Offset = "0x83BFE90", VA = "0x1883C0E90")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x83C1410", Offset = "0x83C0410", VA = "0x1883C1410")]
		public RCRJELTYAEN Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x83C0D20", Offset = "0x83BFD20", VA = "0x1883C0D20")]
		private static void BXEKWDKRZAJ(RCRJELTYAEN a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x83C0E80", Offset = "0x83BFE80", VA = "0x1883C0E80", Slot = "9")]
		public void BXEKWDKRZAJ(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x83C10C0", Offset = "0x83C00C0", VA = "0x1883C10C0")]
		public static RCRJELTYAEN MEZKZZGCVUM(RCRJELTYAEN a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface GPVAXENYLRV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool RULESLSINHC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool GJCZRRWYTMO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> XMTWLMXNULG;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<OVSEBXDBUJS> XDATQVSJUTY;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GRLRHMOCTOZ(LegacyConnectableManager a, FCASZNGZOTP b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void UTFEELNEITC(AJQXREXZXZS a, AJQXREXZXZS b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void GVXFNAHOEII(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void FPYSFRENXNX(ConnectableGraphData a, [Optional] OVSEBXDBUJS b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class QSECNPHWBUL
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x83C0AE0", Offset = "0x83BFAE0", VA = "0x1883C0AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x83C0AA0", Offset = "0x83BFAA0", VA = "0x1883C0AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x83C0B30", Offset = "0x83BFB30", VA = "0x1883C0B30")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class CXXJXWEWTRK : GPVAXENYLRV, IDisposable, KSNDWFAOSUH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager KJBHTHEXJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private FCASZNGZOTP IBDOMDKMDKR;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool RULESLSINHC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x83AE680", Offset = "0x83AD680", VA = "0x1883AE680", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool GJCZRRWYTMO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x83AE640", Offset = "0x83AD640", VA = "0x1883AE640", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView LPDBWVMLSVN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x83AF2D0", Offset = "0x83AE2D0", VA = "0x1883AF2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> XMTWLMXNULG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x83AF490", Offset = "0x83AE490", VA = "0x1883AF490", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x83AEAF0", Offset = "0x83ADAF0", VA = "0x1883AEAF0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<OVSEBXDBUJS> XDATQVSJUTY
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x83AEA50", Offset = "0x83ADA50", VA = "0x1883AEA50", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x83AE9B0", Offset = "0x83AD9B0", VA = "0x1883AE9B0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x83AE800", Offset = "0x83AD800", VA = "0x1883AE800", Slot = "10")]
		public void GRLRHMOCTOZ(LegacyConnectableManager a, FCASZNGZOTP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x83AE5F0", Offset = "0x83AD5F0", VA = "0x1883AE5F0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x83AF370", Offset = "0x83AE370", VA = "0x1883AF370", Slot = "11")]
		public void UTFEELNEITC(AJQXREXZXZS a, AJQXREXZXZS b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x83AE890", Offset = "0x83AD890", VA = "0x1883AE890", Slot = "12")]
		public void GVXFNAHOEII(AJQXREXZXZS a, int b, AJQXREXZXZS c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x83AE6E0", Offset = "0x83AD6E0", VA = "0x1883AE6E0", Slot = "13")]
		public void FPYSFRENXNX(ConnectableGraphData a, [Optional] OVSEBXDBUJS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x83AEDB0", Offset = "0x83ADDB0", VA = "0x1883AEDB0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(AJQXREXZXZS objectToReparent, int objectToReparentSlotIndex, AJQXREXZXZS newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x83AEBC0", Offset = "0x83ADBC0", VA = "0x1883AEBC0")]
		[RPCMethod]
		private void RpcMasterModifyNode(AJQXREXZXZS connectableToModify, AJQXREXZXZS expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x83AF1A0", Offset = "0x83AE1A0", VA = "0x1883AF1A0")]
		[RPCMethod]
		private void RpcReparentNodes(AJQXREXZXZS objectToReparent, int objectToReparentSlotIndex, AJQXREXZXZS newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x83AF0B0", Offset = "0x83AE0B0", VA = "0x1883AF0B0")]
		[RPCMethod]
		private void RpcModifyNode(AJQXREXZXZS connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x83AEB80", Offset = "0x83ADB80", VA = "0x1883AEB80")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public CXXJXWEWTRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, RZJWLEMKAYV, AXZKIGCFCYD.WRWCUWEHOCZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x83B0770", Offset = "0x83AF770", VA = "0x1883B0770", Slot = "4")]
		private void SIYKDXZJURS(AJQXREXZXZS a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x83B08F0", Offset = "0x83AF8F0", VA = "0x1883B08F0", Slot = "5")]
		private void XECPBYMUYTG(AJQXREXZXZS a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x83B0610", Offset = "0x83AF610", VA = "0x1883B0610", Slot = "6")]
		private void QCFYNKTIQAF(AJQXREXZXZS a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x83B0420", Offset = "0x83AF420", VA = "0x1883B0420", Slot = "7")]
		private void PMSSFDGIIOD(AJQXREXZXZS a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x83B0350", Offset = "0x83AF350", VA = "0x1883B0350", Slot = "8")]
		private RZJWLEMKAYV KNYMIXQCCBU(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x83B03C0", Offset = "0x83AF3C0", VA = "0x1883B03C0", Slot = "9")]
		private void MLYYULTBGZW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class DRUYAPZJMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x35EEBF0", Offset = "0x35EDBF0", VA = "0x1835EEBF0")]
		public static MCDWWYSAWIS<a> HNCXVYCNABL<a>(this KTJKRWFMICD a)
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
