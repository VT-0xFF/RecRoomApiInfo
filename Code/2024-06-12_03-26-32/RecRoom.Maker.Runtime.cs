using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Core.Creation;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ConfigurableSubpiece : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private Collider[] colliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Renderer[] hoverRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public FLLHEFAEBCL<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LEEPMOHLIHK FHJPEOPJOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] FANFIADIOFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] IPLIIGIKDBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<LEEPMOHLIHK> JKFFEFNOOIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6912430", Offset = "0x6911030", VA = "0x186912430")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x69124E0", Offset = "0x69110E0", VA = "0x1869124E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69120C0", Offset = "0x6910CC0", VA = "0x1869120C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6912170", Offset = "0x6910D70", VA = "0x186912170")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69121E0", Offset = "0x6910DE0", VA = "0x1869121E0")]
		public void SetIConfigurable(LEEPMOHLIHK EBGAKLGPPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69120D0", Offset = "0x6910CD0", VA = "0x1869120D0")]
		public void ChangeCollidersAndRenderers(Collider[] IDJMPPBIJIO, Renderer[] EPNLPPCMLAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6912310", Offset = "0x6910F10", VA = "0x186912310")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69121C0", Offset = "0x6910DC0", VA = "0x1869121C0")]
		public void RunConfigurationSpecialActions(LEEPMOHLIHK ADFAMEPFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69123A0", Offset = "0x6910FA0", VA = "0x1869123A0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GJIFJNAHOHC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MNKIOEJMCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object FGIAGALCIAP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JPOEICIAGNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece BDPOCBFPBNN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece BDPOCBFPBNN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider FJEKLDBPJED);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DHOKGCBDCEF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject KNJFPDLIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid DBJPCEMOCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string EAGNLBJCPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 EOHOOMJOMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 OCLAILDFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion BHIAIJDAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion OJMCLJJHOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float LAJFDNOAJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float MFAPAGPDOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 FMNJPJOLBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 LOKOLNHFJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool EBIPDHKDPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LEEPMOHLIHK FHJPEOPJOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	PCBNFGIPGNG KIOCECFJKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PFIMKPOBOGC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 OBKBPKCLGLI, float KPHKJHNLHBN, float KDPCNIMLFCM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 OBKBPKCLGLI, float KPHKJHNLHBN, bool OKDDMNMFCNK, Space MLPKAHBKLFJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider FJEKLDBPJED);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EKONPDNMAOA
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool ACEECJNMFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CFDGDNPMGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 DKNLDNINPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 PDLNGAGPOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JINBMCDJPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JCAPEKNCNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MACGNLKNBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CJEMAEDMEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KLOIKDMNBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DMFMHGAJJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool AAODPPEEABB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnDeformed(Vector3 JNKAAKHCHLJ);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnHoverStart(BLFADNMHOLO AJACKEJGABF, Collider PJBKCKGLLLK, GPGLCABCLEA OJPHOOIBBDB);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(BLFADNMHOLO AJACKEJGABF, Collider PJBKCKGLLLK);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(BLFADNMHOLO AJACKEJGABF, PHLHMBGDJPB MJLPPBLHDJM, GPGLCABCLEA.DDFMEKLHBLE EOKAEPKCPBL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Translate(Vector3 AOBANCLLHKI);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Rotate(Quaternion ONEOPKJNMPB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool Scale(float EIHPNDPLKCM);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FBICLKJEHIB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IFALLBKFFFM([In] Vector3 JJNNAHKJEAK, [In] Vector3 ALGFLILJAIC, Vector3 MJCAFGOGLJL, Vector3 KLEPCPADMKG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OGLEHGJGCIM
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JFNDPNLPPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	EFNEIMDDKAG ODONOIIIFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MasterDespawn();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FNAHALHCOAF
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool HBOPPMPJCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	FFMDBHNAECA KDEMACBMKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> DAGGJBEFFLA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int EIKAGJFHLFD);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KNCDGANFFJE GetCulprit(IMEKCHIMAAN NELCOFCIDMM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KKGPOICGLOP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IEnumerable<PJONOIGDJAF.CCHGHGGLKCL> NKJJFEKECPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(PJONOIGDJAF.CCHGHGGLKCL EFLMHACLLNO);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(PJONOIGDJAF.CCHGHGGLKCL EFLMHACLLNO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KPPDNGBKIAP
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GHMJGNECPJM
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JNGEPJPMDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool FJDHDNOAEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FCMELNPGKAA
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int FIMMKENOJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(PGDKMJABBAO? CLMABHCHDKD);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(MHJGHFLMOAG? AGFHCGHHMOJ);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IMEKCHIMAAN CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IABHLIPICPD
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool FOJHPOPICFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CostInfo MFLAMOHKKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool ADMDEHPFPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LGKDOLDOLIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool DMEIICOGGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool MHECEMMAOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool OBFNLECPCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IEnumerable<Collider> EJLNAKPBIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	KFCDGPMFABP? PKPFIDDCGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool NEKCBFICFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool CPKPIKKBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LFCMMLNADMM
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMEKCHIMAAN CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 DFPHDEDIHFK, [Out] Quaternion DELGPMLKBMI, [Out] float DOFFNGPMNBG, [Out] Vector3 NENGMBCMIFK);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? DFPHDEDIHFK, Quaternion? DELGPMLKBMI, float? DOFFNGPMNBG, Vector3? NENGMBCMIFK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DIAANKLHGPD
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	object ANHHPGIHPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Type CFIIHDCKGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Guid LADFPDGCFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LEEPMOHLIHK
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IReadOnlyList<KHEEEOFJMMN> ONMGBFEBCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string EAGNLBJCPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string PIEHGPIEAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool GKFNCCNFNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> DLMHMEEKKEN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<LEEPMOHLIHK> NMIKPOMCBOA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<LOEDDKBEKFI, ENICKHDMJJM> LCMGHAGHMAD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action NLNIJLEAJGH;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LFFCOKMKEMM
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool MBKKJDKBOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PJONOIGDJAF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate FDOPKEAPCGE CCHGHGGLKCL();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<CCHGHGGLKCL> LDPAOLAABIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CCHGHGGLKCL> DEMOEOEOIIM;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IEnumerable<CCHGHGGLKCL> JAAANOACBFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6915D10", Offset = "0x6914910", VA = "0x186915D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6915DD0", Offset = "0x69149D0", VA = "0x186915DD0")]
	public void MPFJKDGCCNN(CCHGHGGLKCL EFLMHACLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6915D70", Offset = "0x6914970", VA = "0x186915D70")]
	public bool IFPALOLJLCH(CCHGHGGLKCL EFLMHACLLNO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum FDOPKEAPCGE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PCBNFGIPGNG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int JAEGCPBACFM = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long DNIKPGPANJM = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private FIHJJBKDMIL<Guid, ObscuredLong, ObscuredInt, ObscuredBool> IOLPCGDOKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GGKFOCOBBMJ<ObscuredBool, ObscuredInt, ObscuredInt> EIICMCHAKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun ONIAHHAAJEH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid PCLBEKIAAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6915680", Offset = "0x6914280", VA = "0x186915680")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public long BCEJGOADFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6915480", Offset = "0x6914080", VA = "0x186915480")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int AAFLKLEIBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6915520", Offset = "0x6914120", VA = "0x186915520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OFFCMGAGDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69155B0", Offset = "0x69141B0", VA = "0x1869155B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OEJMPFCHOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69153F0", Offset = "0x6913FF0", VA = "0x1869153F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int MOBNIJHONKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6915360", Offset = "0x6913F60", VA = "0x186915360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int DCEAMMDEKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6915890", Offset = "0x6914490", VA = "0x186915890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool ALLAAHLPMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6915640", Offset = "0x6914240", VA = "0x186915640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x69159D0", Offset = "0x69145D0", VA = "0x1869159D0")]
	public PCBNFGIPGNG(MonoBehaviourPun DBDAPBCLCGA, string DFECLDAOFGG, Guid DNFHOMPANFM, long OBHGHNIDHDI, int JGPHBODPEGN, bool KFOHEOIDEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x69156F0", Offset = "0x69142F0", VA = "0x1869156F0")]
	public void NFKEKBEOCJF(KNCDGANFFJE JCAJDCMOECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6914E80", Offset = "0x6913A80", VA = "0x186914E80")]
	public void AEHCAPGOPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6915190", Offset = "0x6913D90", VA = "0x186915190")]
	public void EHHLDMLDHNI(Guid MIKNBMGIGMP, long OBHGHNIDHDI, int JGPHBODPEGN, bool KFOHEOIDEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69150C0", Offset = "0x6913CC0", VA = "0x1869150C0")]
	public void EHHLDMLDHNI(PCBNFGIPGNG OCNJFCPHJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6914F90", Offset = "0x6913B90", VA = "0x186914F90")]
	public void COFAJNFMBCN(KEIACDFOPNP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6915920", Offset = "0x6914520", VA = "0x186915920")]
	public void OONMCHBLDKI(KEIACDFOPNP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6915000", Offset = "0x6913C00", VA = "0x186915000")]
	public static KEIACDFOPNP DDNKJECNKML(Guid DNFHOMPANFM, long OBHGHNIDHDI, int AEODNOELJFN, bool KFOHEOIDEGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct GPGLCABCLEA : IEquatable<GPGLCABCLEA>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class KBFOHNPHMFG : DHKEGMBOJKA<GPGLCABCLEA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool IHNECOIEJHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6912A60", Offset = "0x6911660", VA = "0x186912A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6912B60", Offset = "0x6911760", VA = "0x186912B60")]
		public bool CMIPLCEBPDD(PHLHMBGDJPB MDGNLOFCCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6912B80", Offset = "0x6911780", VA = "0x186912B80")]
		public GPGLCABCLEA OKMCPIGMELN(PHLHMBGDJPB MDGNLOFCCPF)
		{
			return default(GPGLCABCLEA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6912AA0", Offset = "0x69116A0", VA = "0x186912AA0")]
		private int BEELCGPBDPB(PHLHMBGDJPB MDGNLOFCCPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6912C40", Offset = "0x6911840", VA = "0x186912C40")]
		public KBFOHNPHMFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum ANGEOHGOIPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		UgcGameplaySystem,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		ContentCreationTool,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		PlayerDirectInteraction,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		HackStandinPriorityToDistinguishNone
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum DDFMEKLHBLE
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		TARGETED_OBJECT,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		ALL_UNDER_ROOT_CONNECTABLE
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly GPGLCABCLEA JJCPLMPECOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly ANGEOHGOIPI OINDKHLECKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly PHLHMBGDJPB NDDOAFPOJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly DDFMEKLHBLE GAOEFIHNHPC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6912840", Offset = "0x6911440", VA = "0x186912840")]
	public GPGLCABCLEA(PHLHMBGDJPB MDGNLOFCCPF, ANGEOHGOIPI BBABGOPLEMJ = ANGEOHGOIPI.UgcGameplaySystem, DDFMEKLHBLE CMLBPDKMHGL = DDFMEKLHBLE.TARGETED_OBJECT)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6912780", Offset = "0x6911380", VA = "0x186912780")]
	public static bool NBAHCGFACIA(GPGLCABCLEA NABHBOMGBNH, GPGLCABCLEA EIKHFLMLKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6912650", Offset = "0x6911250", VA = "0x186912650", Slot = "4")]
	public bool Equals(GPGLCABCLEA OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6912590", Offset = "0x6911190", VA = "0x186912590", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6912700", Offset = "0x6911300", VA = "0x186912700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AEBDFJMPIHA
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RequestStartOutlining(GPGLCABCLEA CLBGLGJCBEB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RequestStopOutlining(PHLHMBGDJPB MDGNLOFCCPF, GPGLCABCLEA.DDFMEKLHBLE CMLBPDKMHGL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class HOONJHALKLJ
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static JFCBGCCGGGE<Vector3> OEMDBNLJBOO;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static JFCBGCCGGGE<Vector3> MFHLMBMELGJ;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x69128E0", Offset = "0x69114E0", VA = "0x1869128E0", Slot = "4")]
	protected virtual void NGCNBHJNCAF(Vector3 KOALEKLIJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6912850", Offset = "0x6911450", VA = "0x186912850", Slot = "5")]
	protected virtual void GDIENNNGBDA(Vector3 KOALEKLIJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected HOONJHALKLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class OCKEOLGKDKJ : HOONJHALKLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6914DD0", Offset = "0x69139D0", VA = "0x186914DD0")]
	public void ADLNIMKALMB(Vector3 DFPHDEDIHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6914E00", Offset = "0x6913A00", VA = "0x186914E00")]
	public void KEJICCECGOK(Vector3 DFPHDEDIHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6914E30", Offset = "0x6913A30", VA = "0x186914E30")]
	public OCKEOLGKDKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LIFOKCDNEJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static ProfilerMarker LABNFMGJJFI;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static ProfilerMarker KLIMNAMIEPA;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly string PGJHGBHCIME;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static readonly string OMCJHGDBFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int[] HNDOAPONEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int[] OLNMCBKPNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject LPDCNAIGOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MeshCollider GAFDFEKKDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GameObject GEFADMEABAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MeshFilter IEBIMOPNINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Mesh PBEDHLJMFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private Mesh NEKACNFMFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Collider[] MJDIJJOCOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<Collider> CNKOGJCFOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private Vector3[] CMENNNNCEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Vector3 KNIMIBOKLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Vector3 FFOKKCGLONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Quaternion JEDGJADMOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Vector3[] PKFAILFNOGK;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private Mesh IJFILBINFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6913880", Offset = "0x6912480", VA = "0x186913880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private Mesh OCEGBAKHDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6914640", Offset = "0x6913240", VA = "0x186914640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private int EGEPNPDFNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6913BD0", Offset = "0x69127D0", VA = "0x186913BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IEnumerable<Collider> KJCINEPDAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6912E20", Offset = "0x6911A20", VA = "0x186912E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6914900", Offset = "0x6913500", VA = "0x186914900")]
	public LIFOKCDNEJF(Material JBNKBPPIMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6912E30", Offset = "0x6911A30", VA = "0x186912E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6912EF0", Offset = "0x6911AF0", VA = "0x186912EF0")]
	public void EGDHNCGLODH(Vector2 JJKCBHKDIBI, Vector2 JHGMGBOODIM, Camera MEAPGGPGMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6912DE0", Offset = "0x69119E0", VA = "0x186912DE0")]
	public void ANHKADMLAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6914080", Offset = "0x6912C80", VA = "0x186914080")]
	private IEnumerable<Collider> LOIGLHLPPDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6914690", Offset = "0x6913290", VA = "0x186914690")]
	private void OBHJPBPOJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6912C80", Offset = "0x6911880", VA = "0x186912C80")]
	private void AHKFOPKJLKA(Material MBCOMNNFJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6913C90", Offset = "0x6912890", VA = "0x186913C90")]
	private void KKJHJIJFLPB(Vector2 JJKCBHKDIBI, Vector2 JHGMGBOODIM, Camera MEAPGGPGMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6912F90", Offset = "0x6911B90", VA = "0x186912F90")]
	private void EGKNOLILJIC(Vector2 JJKCBHKDIBI, Vector2 JHGMGBOODIM, Camera MEAPGGPGMOO, Vector2 CFIDHOCIFGD, Vector2 EIMEHPDGAPP, Vector3 IFCIJNNFDBF, Vector3 GPNNNLAHBBI, Vector3 MOEBPFEEGAL, Vector3 BNMNFNODEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6913810", Offset = "0x6912410", VA = "0x186913810")]
	private void EIBHCFDBBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x69138D0", Offset = "0x69124D0", VA = "0x1869138D0")]
	private void FMCMNBLECOC(Vector3 EPEFOBEHBFB, Vector3 IFCIJNNFDBF, Vector3 GPNNNLAHBBI, Vector3 MOEBPFEEGAL, Vector3 BNMNFNODEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6913BF0", Offset = "0x69127F0", VA = "0x186913BF0")]
	private void JMJNFDLEMBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CNBEIHDIFID<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NHCLJCJFEDA<T> LAIGIJMNGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NHHCDIDPLNN<T> FDBNFMNGOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<T> BKEJFPLBHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<T> DJDKLOPKJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<T> LIBHLPHHKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<T> PAPKEGEPGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<T> JJGJBNODJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<T> HCFDHGMDNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private PBMBADLILND CMLBPDKMHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private OCKEOLGKDKJ HONLEHDPODN;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x537ADD0", Offset = "0x53799D0", VA = "0x18537ADD0")]
	public CNBEIHDIFID(NHCLJCJFEDA<T> LAIGIJMNGBM, NHHCDIDPLNN<T> FDBNFMNGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x537AA10", Offset = "0x5379610", VA = "0x18537AA10")]
	public void NBMNJOJAEEO(PBMBADLILND CMLBPDKMHGL = PBMBADLILND.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5378800", Offset = "0x5377400", VA = "0x185378800")]
	public void KEIPDAMOGOG(IEnumerable<Collider> JPMHECOFCFA, Vector3 LBJDBDFBBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5378740", Offset = "0x5377340", VA = "0x185378740")]
	public bool JCAAFBHHDLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x53786E0", Offset = "0x53772E0", VA = "0x1853786E0")]
	[CompilerGenerated]
	private bool FHKNBALCEMP(T KNFDPFPHEON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x53785E0", Offset = "0x53771E0", VA = "0x1853785E0")]
	[CompilerGenerated]
	private bool ADAFLKBOPGM(T KNFDPFPHEON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum PBMBADLILND
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Remove
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
