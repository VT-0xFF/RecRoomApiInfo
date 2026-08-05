using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IAGFFDEPPKL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6803A0", Offset = "0x67F1A0", VA = "0x1806803A0")]
	public IAGFFDEPPKL()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[PPMOACCEDLJ]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[PPMOACCEDLJ]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4A59200", Offset = "0x4A58000", VA = "0x184A59200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4A591C0", Offset = "0x4A57FC0", VA = "0x184A591C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4A59240", Offset = "0x4A58040", VA = "0x184A59240")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4A59450", Offset = "0x4A58250", VA = "0x184A59450")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4A593C0", Offset = "0x4A581C0", VA = "0x184A593C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE372E0", Offset = "0xE360E0", VA = "0x180E372E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xECBEB0", Offset = "0xECACB0", VA = "0x180ECBEB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4A59180", Offset = "0x4A57F80", VA = "0x184A59180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4A59330", Offset = "0x4A58130", VA = "0x184A59330")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A58E80", Offset = "0x4A57C80", VA = "0x184A58E80")]
	public void CopyBounds(SavedExtents NDGDPPHIMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A590F0", Offset = "0x4A57EF0", VA = "0x184A590F0")]
	public void SetLocalSpaceBounds(Bounds CEPKJKNEBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x855860", Offset = "0x854660", VA = "0x180855860")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A590E0", Offset = "0x4A57EE0", VA = "0x184A590E0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A586B0", Offset = "0x4A574B0", VA = "0x184A586B0")]
	private void BKBGKJLMDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A58EB0", Offset = "0x4A57CB0", VA = "0x184A58EB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A588C0", Offset = "0x4A576C0", VA = "0x184A588C0")]
	public static void CalculateLocalBoundsFor(GameObject HJMLHPKHBHJ, out Bounds CEPKJKNEBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4A585F0", Offset = "0x4A573F0", VA = "0x184A585F0")]
	private static void AOIHCCEKDDH(Bounds KBBKPHEOPAB, Color EACNPFGCNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4A59110", Offset = "0x4A57F10", VA = "0x184A59110")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51CEE0", Offset = "0x51BCE0", VA = "0x18051CEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51C4A0", Offset = "0x51B2A0", VA = "0x18051C4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "4")]
	public virtual void IKDMAIGFPEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[IAGFFDEPPKL]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x28299A0", Offset = "0x28287A0", VA = "0x1828299A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x28294E0", Offset = "0x28282E0", VA = "0x1828294E0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2829FA0", Offset = "0x2828DA0", VA = "0x182829FA0")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OOIKAKELACD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public OOIKAKELACD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x31C8D40", Offset = "0x31C7B40", VA = "0x1831C8D40")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[IAGFFDEPPKL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x31C8430", Offset = "0x31C7230", VA = "0x1831C8430", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x31C8460", Offset = "0x31C7260", VA = "0x1831C8460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x31C8380", Offset = "0x31C7180", VA = "0x1831C8380", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey LHOJNLGGKDH]
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x31C8400", Offset = "0x31C7200", VA = "0x1831C8400", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x31C8280", Offset = "0x31C7080", VA = "0x1831C8280", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x31C7D10", Offset = "0x31C6B10", VA = "0x1831C7D10", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x31C79B0", Offset = "0x31C67B0", VA = "0x1831C79B0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x31C75E0", Offset = "0x31C63E0", VA = "0x1831C75E0", Slot = "14")]
	protected virtual string OLBNHIPMEAC(TKeyVal LEPLHGJCADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1D8A2D0", Offset = "0x1D890D0", VA = "0x181D8A2D0", Slot = "4")]
	public bool ContainsKey(TKey LHOJNLGGKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x31C8170", Offset = "0x31C6F70", VA = "0x1831C8170", Slot = "5")]
	public bool TryGetValue(TKey LHOJNLGGKDH, out TVal KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x31C7550", Offset = "0x31C6350", VA = "0x1831C7550", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x31C7550", Offset = "0x31C6350", VA = "0x1831C7550", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x31C81A0", Offset = "0x31C6FA0", VA = "0x1831C81A0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DGFIAIDNPAK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EKPNLCMKHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public EKPNLCMKHLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x36E2EA0", Offset = "0x36E1CA0", VA = "0x1836E2EA0")]
		internal bool <GetSamples>b__0(global::GNGECOGIHFJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float FMPIKCNLAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float AOPKLFKDKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::GNGECOGIHFJ<float, T>> CIOGPNFGIAP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PEBEHNDBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x36DDCF0", Offset = "0x36DCAF0", VA = "0x1836DDCF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x36DDEB0", Offset = "0x36DCCB0", VA = "0x1836DDEB0")]
	public DGFIAIDNPAK(float POBPDIHDJKF, float MCDCDLLLOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x36DDB90", Offset = "0x36DC990", VA = "0x1836DDB90")]
	public bool JKMLAFBLBNB(float KHAHKAHHHDF, T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x36DD320", Offset = "0x36DC120", VA = "0x1836DD320")]
	public int DPPDPJFMPMF(float KHAHKAHHHDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x36DD380", Offset = "0x36DC180", VA = "0x1836DD380")]
	public IEnumerable<T> FFHDPGBCPEH(float KHAHKAHHHDF, [Optional] float? CEGKJJPBKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x36DDA00", Offset = "0x36DC800", VA = "0x1836DDA00")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36DDDF0", Offset = "0x36DCBF0", VA = "0x1836DDDF0")]
	private void OFIMJPMDLJP(float KHAHKAHHHDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class OENFAAFFEEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct ELMDHCGPGMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T MKDOFJMDMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float ILKHIGMMOFF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float FPABPJDJLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> MKBEPIJIIIM;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int DFLEJEDBHAC = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private ELMDHCGPGMC[] DMCIGPCAGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int FGJEBOFHNCG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float EJCMKIBCBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF22D70", Offset = "0xF21B70", VA = "0x180F22D70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF22DA0", Offset = "0xF21BA0", VA = "0x180F22DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x390BE40", Offset = "0x390AC40", VA = "0x18390BE40")]
	public OENFAAFFEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x390BD60", Offset = "0x390AB60", VA = "0x18390BD60")]
	public OENFAAFFEEC(int DPKPMBGBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x390BB70", Offset = "0x390A970", VA = "0x18390BB70")]
	public void PEIDOEKHNGH(float KHAHKAHHHDF, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x390A980", Offset = "0x3909780", VA = "0x18390A980")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x390AC20", Offset = "0x3909A20", VA = "0x18390AC20")]
	public bool HDDPIMKEHOO(float ENLOGOJDMAL, float IADJIGEDKBL, out T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x390B360", Offset = "0x390A160", VA = "0x18390B360")]
	public bool MBMICDLBKNL(float ENLOGOJDMAL, float IADJIGEDKBL, out T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x390B6A0", Offset = "0x390A4A0", VA = "0x18390B6A0")]
	public void OPLAMAEAHHM(float ENLOGOJDMAL, float IADJIGEDKBL, List<T> FLHEFONBKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x390B670", Offset = "0x390A470", VA = "0x18390B670")]
	private int NIKLBOPHELF(int DFOPBFLJHHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x390B630", Offset = "0x390A430", VA = "0x18390B630")]
	private void MMHIEMLDFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CFNIEMNKMBN();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T AMCJKDCKJOG(T NFDHPBJGLLD, T OKAHHBEIFGO, float LIIJOLOJJBP);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T PBNHMFCAOHA(T KCFMHIDCDCO, float LIIJOLOJJBP);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IOGBFJBBFDG(T NFDHPBJGLLD, T OKAHHBEIFGO);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T IMEDALOGBGJ(T NFDHPBJGLLD, T OKAHHBEIFGO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BKBAKJGFDHI : global::OENFAAFFEEC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A53FE0", Offset = "0x4A52DE0", VA = "0x184A53FE0", Slot = "4")]
	protected override Vector3 CFNIEMNKMBN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4A53F20", Offset = "0x4A52D20", VA = "0x184A53F20", Slot = "5")]
	protected override Vector3 AMCJKDCKJOG(Vector3 NFDHPBJGLLD, Vector3 OKAHHBEIFGO, float LIIJOLOJJBP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4A54170", Offset = "0x4A52F70", VA = "0x184A54170", Slot = "6")]
	protected override Vector3 PBNHMFCAOHA(Vector3 KCFMHIDCDCO, float LIIJOLOJJBP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4A540C0", Offset = "0x4A52EC0", VA = "0x184A540C0", Slot = "7")]
	protected override Vector3 IOGBFJBBFDG(Vector3 NFDHPBJGLLD, Vector3 OKAHHBEIFGO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4A54050", Offset = "0x4A52E50", VA = "0x184A54050", Slot = "8")]
	protected override Vector3 IMEDALOGBGJ(Vector3 NFDHPBJGLLD, Vector3 OKAHHBEIFGO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4A54210", Offset = "0x4A53010", VA = "0x184A54210")]
	public BKBAKJGFDHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FMIAELBEDKA : global::OENFAAFFEEC<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4A54AF0", Offset = "0x4A538F0", VA = "0x184A54AF0")]
	public FMIAELBEDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4A54A80", Offset = "0x4A53880", VA = "0x184A54A80")]
	public FMIAELBEDKA(int DPKPMBGBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xECAFD0", Offset = "0xEC9DD0", VA = "0x180ECAFD0", Slot = "4")]
	protected override float CFNIEMNKMBN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4A549E0", Offset = "0x4A537E0", VA = "0x184A549E0", Slot = "5")]
	protected override float AMCJKDCKJOG(float NFDHPBJGLLD, float OKAHHBEIFGO, float LIIJOLOJJBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E2F9E0", Offset = "0x3E2E7E0", VA = "0x183E2F9E0", Slot = "6")]
	protected override float PBNHMFCAOHA(float KCFMHIDCDCO, float LIIJOLOJJBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4A54A70", Offset = "0x4A53870", VA = "0x184A54A70", Slot = "7")]
	protected override float IOGBFJBBFDG(float NFDHPBJGLLD, float OKAHHBEIFGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4A54A60", Offset = "0x4A53860", VA = "0x184A54A60", Slot = "8")]
	protected override float IMEDALOGBGJ(float NFDHPBJGLLD, float OKAHHBEIFGO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BDKIMIHCKMA
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D2BBB0", Offset = "0x1D2A9B0", VA = "0x181D2BBB0")]
	public static global::AIKMFDKICKN<T1> PEDPEIEILOF<T1>(T1 LKBFNDKPDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x224FDB0", Offset = "0x224EBB0", VA = "0x18224FDB0")]
	public static global::GNGECOGIHFJ<T1, T2> PEDPEIEILOF<T1, T2>(T1 LKBFNDKPDFD, T2 PCABAHAHPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x224FE20", Offset = "0x224EC20", VA = "0x18224FE20")]
	public static global::FEFBKDDIFFN<T1, T2, T3> PEDPEIEILOF<T1, T2, T3>(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x22500D0", Offset = "0x224EED0", VA = "0x1822500D0")]
	public static global::CBOCFAHDNPH<T1, T2, T3, T4> PEDPEIEILOF<T1, T2, T3, T4>(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2250030", Offset = "0x224EE30", VA = "0x182250030")]
	public static global::FGDCJCEJCAB<T1, T2, T3, T4, T5> PEDPEIEILOF<T1, T2, T3, T4, T5>(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON, T5 EGAGPDLIPJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x224FF80", Offset = "0x224ED80", VA = "0x18224FF80")]
	public static global::CLPCOHFOCCE<T1, T2, T3, T4, T5, T6> PEDPEIEILOF<T1, T2, T3, T4, T5, T6>(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON, T5 EGAGPDLIPJK, T6 AMICGKMEIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2889EB0", Offset = "0x2888CB0", VA = "0x182889EB0")]
	public static global::OMFIECEJIEF<T1, T2, T3, T4, T5, T6, T7> PEDPEIEILOF<T1, T2, T3, T4, T5, T6, T7>(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON, T5 EGAGPDLIPJK, T6 AMICGKMEIAI, T7 FNDBNAINPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x224FEB0", Offset = "0x224ECB0", VA = "0x18224FEB0")]
	public static global::JGOAOFNOIAG<T1, T2, T3, T4, T5, T6, T7, T8> PEDPEIEILOF<T1, T2, T3, T4, T5, T6, T7, T8>(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON, T5 EGAGPDLIPJK, T6 AMICGKMEIAI, T7 FNDBNAINPKI, T8 ABHNEPOLHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x19D5F50", Offset = "0x19D4D50", VA = "0x1819D5F50")]
	[IteratorStateMachine(typeof(JIKADAELHMP))]
	public static IEnumerable<global::GNGECOGIHFJ<T1, T2>> AMOOFCLHADE<T1, T2>(IEnumerable<T1> OCLDIKFJHHO, IEnumerable<T2> KBBKPHEOPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x19D7FA0", Offset = "0x19D6DA0", VA = "0x1819D7FA0")]
	[IteratorStateMachine(typeof(PGHPFKKIBMA))]
	public static IEnumerable<global::FEFBKDDIFFN<T1, T2, T3>> AMOOFCLHADE<T1, T2, T3>(IEnumerable<T1> OCLDIKFJHHO, IEnumerable<T2> KBBKPHEOPAB, IEnumerable<T3> EACNPFGCNPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x22D4A80", Offset = "0x22D3880", VA = "0x1822D4A80")]
	internal static int GCEMMBLEIIP(int EMAMDAOICIA, int KPOALLAMEMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4270620", Offset = "0x426F420", VA = "0x184270620")]
	internal static int GCEMMBLEIIP(int EMAMDAOICIA, int KPOALLAMEMI, int BALNFALJAMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4270630", Offset = "0x426F430", VA = "0x184270630")]
	internal static int GCEMMBLEIIP(int EMAMDAOICIA, int KPOALLAMEMI, int BALNFALJAMF, int AFDFIHKLAFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4A53E30", Offset = "0x4A52C30", VA = "0x184A53E30")]
	internal static int GCEMMBLEIIP(int EMAMDAOICIA, int KPOALLAMEMI, int BALNFALJAMF, int AFDFIHKLAFL, int HAMPAFIDJNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A53E10", Offset = "0x4A52C10", VA = "0x184A53E10")]
	internal static int GCEMMBLEIIP(int EMAMDAOICIA, int KPOALLAMEMI, int BALNFALJAMF, int AFDFIHKLAFL, int HAMPAFIDJNL, int GJJJDABNKOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4A53E50", Offset = "0x4A52C50", VA = "0x184A53E50")]
	internal static int GCEMMBLEIIP(int EMAMDAOICIA, int KPOALLAMEMI, int BALNFALJAMF, int AFDFIHKLAFL, int HAMPAFIDJNL, int GJJJDABNKOL, int AHBFLBJEAIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4A53E80", Offset = "0x4A52C80", VA = "0x184A53E80")]
	internal static int GCEMMBLEIIP(int EMAMDAOICIA, int KPOALLAMEMI, int BALNFALJAMF, int AFDFIHKLAFL, int HAMPAFIDJNL, int GJJJDABNKOL, int AHBFLBJEAIE, int ODFOKNAIFNN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AIKMFDKICKN<T1> : IComparable<global::AIKMFDKICKN<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 GKLANGHLLJN;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDF20", Offset = "0x1CBCD20", VA = "0x181CBDF20")]
	public AIKMFDKICKN(T1 LKBFNDKPDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1D7D610", Offset = "0x1D7C410", VA = "0x181D7D610", Slot = "4")]
	public int CompareTo(global::AIKMFDKICKN<T1> NDGDPPHIMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1D7D680", Offset = "0x1D7C480", VA = "0x181D7D680", Slot = "0")]
	public override bool Equals(object NDGDPPHIMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x848320", Offset = "0x847120", VA = "0x180848320", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D7D720", Offset = "0x1D7C520", VA = "0x181D7D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GNGECOGIHFJ<T1, T2> : IComparable<global::GNGECOGIHFJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 GKLANGHLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 GCMBPKPFNBK;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x283B7A0", Offset = "0x283A5A0", VA = "0x18283B7A0")]
	public GNGECOGIHFJ(T1 LKBFNDKPDFD, T2 PCABAHAHPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2839DA0", Offset = "0x2838BA0", VA = "0x182839DA0", Slot = "4")]
	public int CompareTo(global::GNGECOGIHFJ<T1, T2> NDGDPPHIMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2839EC0", Offset = "0x2838CC0", VA = "0x182839EC0", Slot = "0")]
	public override bool Equals(object NDGDPPHIMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x283A890", Offset = "0x2839690", VA = "0x18283A890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x283ACC0", Offset = "0x2839AC0", VA = "0x18283ACC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FEFBKDDIFFN<T1, T2, T3> : IComparable<global::FEFBKDDIFFN<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 GKLANGHLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 GCMBPKPFNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 PIJKHIOFKDI;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3AD8870", Offset = "0x3AD7670", VA = "0x183AD8870")]
	public FEFBKDDIFFN(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AD8090", Offset = "0x3AD6E90", VA = "0x183AD8090", Slot = "4")]
	public int CompareTo(global::FEFBKDDIFFN<T1, T2, T3> NDGDPPHIMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AD8380", Offset = "0x3AD7180", VA = "0x183AD8380", Slot = "0")]
	public override bool Equals(object NDGDPPHIMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD84F0", Offset = "0x3AD72F0", VA = "0x183AD84F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3AD85F0", Offset = "0x3AD73F0", VA = "0x183AD85F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CBOCFAHDNPH<T1, T2, T3, T4> : IComparable<global::CBOCFAHDNPH<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 GKLANGHLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 GCMBPKPFNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 PIJKHIOFKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 NHIJJJPHHPH;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x31CCC20", Offset = "0x31CBA20", VA = "0x1831CCC20")]
	public CBOCFAHDNPH(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x31CC7F0", Offset = "0x31CB5F0", VA = "0x1831CC7F0", Slot = "4")]
	public int CompareTo(global::CBOCFAHDNPH<T1, T2, T3, T4> NDGDPPHIMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x31CC930", Offset = "0x31CB730", VA = "0x1831CC930", Slot = "0")]
	public override bool Equals(object NDGDPPHIMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x31CCA50", Offset = "0x31CB850", VA = "0x1831CCA50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x31CCB10", Offset = "0x31CB910", VA = "0x1831CCB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FGDCJCEJCAB<T1, T2, T3, T4, T5> : IComparable<global::FGDCJCEJCAB<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 GKLANGHLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 GCMBPKPFNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 PIJKHIOFKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 NHIJJJPHHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 IJNGHFPPAGO;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x298CE80", Offset = "0x298BC80", VA = "0x18298CE80")]
	public FGDCJCEJCAB(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON, T5 EGAGPDLIPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3441130", Offset = "0x343FF30", VA = "0x183441130", Slot = "4")]
	public int CompareTo(global::FGDCJCEJCAB<T1, T2, T3, T4, T5> NDGDPPHIMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x34412B0", Offset = "0x34400B0", VA = "0x1834412B0", Slot = "0")]
	public override bool Equals(object NDGDPPHIMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x34413F0", Offset = "0x34401F0", VA = "0x1834413F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x34414F0", Offset = "0x34402F0", VA = "0x1834414F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CLPCOHFOCCE<T1, T2, T3, T4, T5, T6> : IComparable<global::CLPCOHFOCCE<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 GKLANGHLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 GCMBPKPFNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 PIJKHIOFKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 NHIJJJPHHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 IJNGHFPPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 CDIDKEALJNA;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x298C7D0", Offset = "0x298B5D0", VA = "0x18298C7D0")]
	public CLPCOHFOCCE(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON, T5 EGAGPDLIPJK, T6 AMICGKMEIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FA20", Offset = "0x3D4E820", VA = "0x183D4FA20", Slot = "4")]
	public int CompareTo(global::CLPCOHFOCCE<T1, T2, T3, T4, T5, T6> NDGDPPHIMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FBE0", Offset = "0x3D4E9E0", VA = "0x183D4FBE0", Slot = "0")]
	public override bool Equals(object NDGDPPHIMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FD50", Offset = "0x3D4EB50", VA = "0x183D4FD50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FE70", Offset = "0x3D4EC70", VA = "0x183D4FE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OMFIECEJIEF<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::OMFIECEJIEF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 GKLANGHLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 GCMBPKPFNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 PIJKHIOFKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 NHIJJJPHHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 IJNGHFPPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 CDIDKEALJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 NAIIMMJOCDD;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x31E7370", Offset = "0x31E6170", VA = "0x1831E7370")]
	public OMFIECEJIEF(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON, T5 EGAGPDLIPJK, T6 AMICGKMEIAI, T7 FNDBNAINPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x31E6D10", Offset = "0x31E5B10", VA = "0x1831E6D10", Slot = "4")]
	public int CompareTo(global::OMFIECEJIEF<T1, T2, T3, T4, T5, T6, T7> NDGDPPHIMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x31E6F10", Offset = "0x31E5D10", VA = "0x1831E6F10", Slot = "0")]
	public override bool Equals(object NDGDPPHIMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x31E70B0", Offset = "0x31E5EB0", VA = "0x1831E70B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x31E7200", Offset = "0x31E6000", VA = "0x1831E7200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JGOAOFNOIAG<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::JGOAOFNOIAG<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 GKLANGHLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 GCMBPKPFNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 PIJKHIOFKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 NHIJJJPHHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 IJNGHFPPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 CDIDKEALJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 NAIIMMJOCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 HNHHOEOGPAH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x29A2BC0", Offset = "0x29A19C0", VA = "0x1829A2BC0")]
	public JGOAOFNOIAG(T1 LKBFNDKPDFD, T2 PCABAHAHPIC, T3 LPFEDHKFMCB, T4 ANJFCABANON, T5 EGAGPDLIPJK, T6 AMICGKMEIAI, T7 FNDBNAINPKI, T8 ABHNEPOLHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x29A24B0", Offset = "0x29A12B0", VA = "0x1829A24B0", Slot = "4")]
	public int CompareTo(global::JGOAOFNOIAG<T1, T2, T3, T4, T5, T6, T7, T8> NDGDPPHIMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x29A2700", Offset = "0x29A1500", VA = "0x1829A2700", Slot = "0")]
	public override bool Equals(object NDGDPPHIMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x29A28C0", Offset = "0x29A16C0", VA = "0x1829A28C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x29A2A30", Offset = "0x29A1830", VA = "0x1829A2A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T MKDOFJMDMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x544A30", Offset = "0x543830", VA = "0x180544A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x654540", Offset = "0x653340", VA = "0x180654540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float CDCDFNKFJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xEFB970", Offset = "0xEFA770", VA = "0x180EFB970")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x39237B0", Offset = "0x39225B0", VA = "0x1839237B0")]
	public T PPAEKHECFIA(float LIIJOLOJJBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3923520", Offset = "0x3922320", VA = "0x183923520")]
	public T FIHAFPKLNJB(float LIIJOLOJJBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AMCJKDCKJOG(T NFDHPBJGLLD, T OKAHHBEIFGO, float LIIJOLOJJBP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4A54B50", Offset = "0x4A53950", VA = "0x184A54B50", Slot = "4")]
	protected override float AMCJKDCKJOG(float NFDHPBJGLLD, float OKAHHBEIFGO, float LIIJOLOJJBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4A54BD0", Offset = "0x4A539D0", VA = "0x184A54BD0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A3B0", Offset = "0x4A591B0", VA = "0x184A5A3B0", Slot = "4")]
	protected override Vector3 AMCJKDCKJOG(Vector3 NFDHPBJGLLD, Vector3 OKAHHBEIFGO, float LIIJOLOJJBP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A470", Offset = "0x4A59270", VA = "0x184A5A470")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4A54340", Offset = "0x4A53140", VA = "0x184A54340", Slot = "4")]
	protected override Color AMCJKDCKJOG(Color NFDHPBJGLLD, Color OKAHHBEIFGO, float LIIJOLOJJBP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A54390", Offset = "0x4A53190", VA = "0x184A54390")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public sealed class FGPNKPBJJBP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] CGIFNNOOHEM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5A8670", Offset = "0x5A7470", VA = "0x1805A8670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x66E5D0", Offset = "0x66D3D0", VA = "0x18066E5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3442640", Offset = "0x3441440", VA = "0x183442640")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3442680", Offset = "0x3441480", VA = "0x183442680")]
	public static global::FGPNKPBJJBP<T> JFAIMEGCMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3441BC0", Offset = "0x34409C0", VA = "0x183441BC0")]
	public static global::FGPNKPBJJBP<T> EIPEFEJDBOA(int OIICMJBLBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3442C20", Offset = "0x3441A20", VA = "0x183442C20")]
	private FGPNKPBJJBP(T[] FCEGCFCHCFK, int OIICMJBLBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3441B50", Offset = "0x3440950", VA = "0x183441B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3442B10", Offset = "0x3441910", VA = "0x183442B10")]
	public void PEIDOEKHNGH(in T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3441AB0", Offset = "0x34408B0", VA = "0x183441AB0")]
	public void DLCNBCCKCCI(int CKPFCCCIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x34420F0", Offset = "0x3440EF0", VA = "0x1834420F0")]
	public void FKDIFICKHIH(in T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3441E30", Offset = "0x3440C30", VA = "0x183441E30")]
	public void EKHEADGGAIL(int DPKPMBGBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x34427B0", Offset = "0x34415B0", VA = "0x1834427B0")]
	private void OABALLCMNBO(int OIICMJBLBOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class AKKEBJFBKKH
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F0E3F0", Offset = "0x1F0D1F0", VA = "0x181F0E3F0")]
	public static global::FGPNKPBJJBP<T> JFAIMEGCMDM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x14B6370", Offset = "0x14B5170", VA = "0x1814B6370")]
	public static global::FGPNKPBJJBP<T> EIPEFEJDBOA<T>(int OIICMJBLBOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class LNNCIDFJIAH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> MEHHFJACNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> LLIMGHINCPN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1C35B90", Offset = "0x1C34990", VA = "0x181C35B90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool FNDABHNHEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x51CEC0", Offset = "0x51BCC0", VA = "0x18051CEC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> JOIAKEPJDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x36E1C60", Offset = "0x36E0A60", VA = "0x1836E1C60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> ELJLPBBBHNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2999E90", Offset = "0x2998C90", VA = "0x182999E90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B032D0", Offset = "0x3B020D0", VA = "0x183B032D0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3B34C70", Offset = "0x3B33A70", VA = "0x183B34C70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3B34610", Offset = "0x3B33410", VA = "0x183B34610")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3B342A0", Offset = "0x3B330A0", VA = "0x183B342A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3B34170", Offset = "0x3B32F70", VA = "0x183B34170", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3B34AC0", Offset = "0x3B338C0", VA = "0x183B34AC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3B34110", Offset = "0x3B32F10", VA = "0x183B34110", Slot = "9")]
	public void Add(TKey LHOJNLGGKDH, TVal KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3B340E0", Offset = "0x3B32EE0", VA = "0x183B340E0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FCFNKDCAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x32C9BC0", Offset = "0x32C89C0", VA = "0x1832C9BC0", Slot = "8")]
	public bool ContainsKey(TKey LHOJNLGGKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x376F1A0", Offset = "0x376DFA0", VA = "0x18376F1A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FCFNKDCAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1CBA380", Offset = "0x1CB9180", VA = "0x181CBA380", Slot = "10")]
	public bool Remove(TKey LHOJNLGGKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1CBA380", Offset = "0x1CB9180", VA = "0x181CBA380", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FCFNKDCAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B34B60", Offset = "0x3B33960", VA = "0x183B34B60", Slot = "11")]
	public bool TryGetValue(TKey LHOJNLGGKDH, out TVal KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3B34640", Offset = "0x3B33440", VA = "0x183B34640", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3B34200", Offset = "0x3B33000", VA = "0x183B34200", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DMCIGPCAGBM, int BFEAINKINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3B34970", Offset = "0x3B33770", VA = "0x183B34970")]
	public void PEIDOEKHNGH(TVal DPFKJHANDFP, TKey LHOJNLGGKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3B349E0", Offset = "0x3B337E0", VA = "0x183B349E0")]
	public void PEIDOEKHNGH(KeyValuePair<TVal, TKey> FCFNKDCAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3B34A60", Offset = "0x3B33860", VA = "0x183B34A60")]
	public bool PNOLIKCGLNL(TVal LHOJNLGGKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3B347D0", Offset = "0x3B335D0", VA = "0x183B347D0")]
	public bool MLBCOPDEJLG(KeyValuePair<TVal, TKey> FCFNKDCAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x34E8270", Offset = "0x34E7070", VA = "0x1834E8270")]
	public bool FKDIFICKHIH(TVal LHOJNLGGKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x34E8270", Offset = "0x34E7070", VA = "0x1834E8270")]
	public bool FKDIFICKHIH(KeyValuePair<TVal, TKey> FCFNKDCAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B34830", Offset = "0x3B33630", VA = "0x183B34830")]
	public bool MNODOEFIIGL(TVal LHOJNLGGKDH, out TKey KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B33FD0", Offset = "0x3B32DD0", VA = "0x183B33FD0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> ACJNKDOAIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3B348F0", Offset = "0x3B336F0", VA = "0x183B348F0")]
	private void NONMAMIHIHB(TKey LHOJNLGGKDH, TVal DPFKJHANDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B346C0", Offset = "0x3B334C0", VA = "0x183B346C0")]
	private void LOAEMBLDHBM(TKey LHOJNLGGKDH, TVal DPFKJHANDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B34460", Offset = "0x3B33260", VA = "0x183B34460")]
	private bool EKECMEMCJEB(TKey LHOJNLGGKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B342E0", Offset = "0x3B330E0", VA = "0x183B342E0")]
	private bool EKECMEMCJEB(TVal DPFKJHANDFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B34B90", Offset = "0x3B33990", VA = "0x183B34B90")]
	public LNNCIDFJIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class DDDCLGFPAMH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::DDDCLGFPAMH<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xF22D70", Offset = "0xF21B70", VA = "0x180F22D70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2BEC490", Offset = "0x2BEB290", VA = "0x182BEC490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC9A0", Offset = "0x2BEB7A0", VA = "0x182BEC9A0")]
		public Enumerator(global::DDDCLGFPAMH<T> FLHEFONBKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BEBE70", Offset = "0x2BEAC70", VA = "0x182BEBE70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BEC3F0", Offset = "0x2BEB1F0", VA = "0x182BEC3F0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BEBD70", Offset = "0x2BEAB70", VA = "0x182BEBD70")]
		private void BNDFMPEONGL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] PANNBAPOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int CJMMDDOFLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int PHNLGMLLEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int NLHLOLJPAOB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0120", Offset = "0x2BDEF20", VA = "0x182BE0120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0960", Offset = "0x2BDF760", VA = "0x182BE0960")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BE02F0", Offset = "0x2BDF0F0", VA = "0x182BE02F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2BE21A0", Offset = "0x2BE0FA0", VA = "0x182BE21A0")]
	public DDDCLGFPAMH(int OIICMJBLBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1CC0", Offset = "0x2BE0AC0", VA = "0x182BE1CC0")]
	public void PEIDOEKHNGH(T LIIJOLOJJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1260", Offset = "0x2BE0060", VA = "0x182BE1260")]
	public void NKGDJOBCPBL(IEnumerable<T> AEGFLFCGFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BE09B0", Offset = "0x2BDF7B0", VA = "0x182BE09B0")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2BE07A0", Offset = "0x2BDF5A0", VA = "0x182BE07A0")]
	public void EJIPNKHGCGA(int JPKOENICFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0160", Offset = "0x2BDEF60", VA = "0x182BE0160")]
	public void BCIMFFIJGID(int JPKOENICFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0CA0", Offset = "0x2BDFAA0", VA = "0x182BE0CA0")]
	public void NFCGALLNPJD(T[] DMCIGPCAGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1B60", Offset = "0x2BE0960", VA = "0x182BE1B60")]
	public Enumerator OKDONKEHBHE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1FB0", Offset = "0x2BE0DB0", VA = "0x182BE1FB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1FB0", Offset = "0x2BE0DB0", VA = "0x182BE1FB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BE03E0", Offset = "0x2BDF1E0", VA = "0x182BE03E0")]
	private int ECEGBHCHNAJ(int CKPFCCCIOFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BE09D0", Offset = "0x2BDF7D0", VA = "0x182BE09D0")]
	private int HNKJOBJJBBH(int CKPFCCCIOFE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class AGBHLIPJOGL
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KHLJNKNBEAJ(object[] NAEIJPJHOMG);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	protected AGBHLIPJOGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class PBMNGJHHONG<T> : AGBHLIPJOGL
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	protected struct DEKNOOKNFHK
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum ONLLDIHIMNM
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public ONLLDIHIMNM IDPNMFPNBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T JJOAKFFHFLE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int MBFCPKDLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly bool EODGLOCLKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected readonly bool EDALDENKAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected List<T> KGOOLDKAAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<DEKNOOKNFHK> OPALHHDJNGA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OGJIJDIDAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x31EDE20", Offset = "0x31ECC20", VA = "0x1831EDE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x31EE4C0", Offset = "0x31ED2C0", VA = "0x1831EE4C0")]
	protected PBMNGJHHONG(bool EDALDENKAGD, bool EODGLOCLKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x31EE0F0", Offset = "0x31ECEF0", VA = "0x1831EE0F0")]
	protected bool LLMKOFHFLBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x31EDD40", Offset = "0x31ECB40", VA = "0x1831EDD40")]
	protected void AIPCCGKIKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x31EE190", Offset = "0x31ECF90", VA = "0x1831EE190")]
	protected void OHAIHFHLABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2F2E240", Offset = "0x2F2D040", VA = "0x182F2E240")]
	private static void OJCJKCKKKLD<U>(ref List<U> FGJKCCCHKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x31EE340", Offset = "0x31ED140", VA = "0x1831EE340", Slot = "5")]
	public void PEIDOEKHNGH(T JJOAKFFHFLE, bool DNGFBJNEILA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x31EDE60", Offset = "0x31ECC60", VA = "0x1831EDE60", Slot = "6")]
	public void FKDIFICKHIH(T JJOAKFFHFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x31EDFC0", Offset = "0x31ECDC0", VA = "0x1831EDFC0")]
	public void GGFJFJEKGGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ANNHBONELBP
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEIDOEKHNGH(Action JJOAKFFHFLE, bool DNGFBJNEILA = false);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKDIFICKHIH(Action JJOAKFFHFLE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class NNEOKDILPJM : global::PBMNGJHHONG<Action>, ANNHBONELBP
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4A56BC0", Offset = "0x4A559C0", VA = "0x184A56BC0")]
	public NNEOKDILPJM(bool EDALDENKAGD = false, bool EODGLOCLKCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4A568C0", Offset = "0x4A556C0", VA = "0x184A568C0")]
	public void DEIKBBPPDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4A56A80", Offset = "0x4A55880", VA = "0x184A56A80", Slot = "4")]
	public override void KHLJNKNBEAJ(object[] NAEIJPJHOMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4A56B00", Offset = "0x4A55900", VA = "0x184A56B00")]
	public static NNEOKDILPJM MNGJEHAGHLB(NNEOKDILPJM LIHEAGNGGHN, Action JJOAKFFHFLE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4A56B60", Offset = "0x4A55960", VA = "0x184A56B60")]
	public static NNEOKDILPJM OIOIOKDPJIP(NNEOKDILPJM LIHEAGNGGHN, Action JJOAKFFHFLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KGCNKEDLKPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEIDOEKHNGH(Action<T> JJOAKFFHFLE, bool DNGFBJNEILA = false);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKDIFICKHIH(Action<T> JJOAKFFHFLE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class KDPHOICGJBO<T> : global::PBMNGJHHONG<Action<T>>, global::KGCNKEDLKPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1D92FA0", Offset = "0x1D91DA0", VA = "0x181D92FA0")]
	public KDPHOICGJBO(bool EDALDENKAGD = false, bool EODGLOCLKCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x32A9BA0", Offset = "0x32A89A0", VA = "0x1832A9BA0")]
	public void DEIKBBPPDKP(T LIIJOLOJJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x32AED20", Offset = "0x32ADB20", VA = "0x1832AED20", Slot = "4")]
	public override void KHLJNKNBEAJ(object[] NAEIJPJHOMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x32AEE70", Offset = "0x32ADC70", VA = "0x1832AEE70")]
	public static global::KDPHOICGJBO<T> MNGJEHAGHLB(global::KDPHOICGJBO<T> LIHEAGNGGHN, Action<T> JJOAKFFHFLE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x32AEF10", Offset = "0x32ADD10", VA = "0x1832AEF10")]
	public static global::KDPHOICGJBO<T> OIOIOKDPJIP(global::KDPHOICGJBO<T> LIHEAGNGGHN, Action<T> JJOAKFFHFLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GAJDMLOLFLD<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEIDOEKHNGH(Action<T, U> JJOAKFFHFLE, bool DNGFBJNEILA = false);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKDIFICKHIH(Action<T, U> JJOAKFFHFLE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class KIKMDGJNCBI<T, U> : global::PBMNGJHHONG<Action<T, U>>, global::GAJDMLOLFLD<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1D92FA0", Offset = "0x1D91DA0", VA = "0x181D92FA0")]
	public KIKMDGJNCBI(bool EDALDENKAGD = false, bool EODGLOCLKCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE4D0", Offset = "0x3AFD2D0", VA = "0x183AFE4D0")]
	public void DEIKBBPPDKP(T LIIJOLOJJBP, U DDBLMIGJKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3B01190", Offset = "0x3AFFF90", VA = "0x183B01190", Slot = "4")]
	public override void KHLJNKNBEAJ(object[] NAEIJPJHOMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3B02D90", Offset = "0x3B01B90", VA = "0x183B02D90")]
	public static global::KIKMDGJNCBI<T, U> MNGJEHAGHLB(global::KIKMDGJNCBI<T, U> LIHEAGNGGHN, Action<T, U> JJOAKFFHFLE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B02E30", Offset = "0x3B01C30", VA = "0x183B02E30")]
	public static global::KIKMDGJNCBI<T, U> OIOIOKDPJIP(global::KIKMDGJNCBI<T, U> LIHEAGNGGHN, Action<T, U> JJOAKFFHFLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CPMGJHCLCBL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEIDOEKHNGH(Action<T, U, V> JJOAKFFHFLE, bool DNGFBJNEILA = false);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKDIFICKHIH(Action<T, U, V> JJOAKFFHFLE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class FECIDOCPIKP<T, U, V> : global::PBMNGJHHONG<Action<T, U, V>>, global::CPMGJHCLCBL<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1D92FA0", Offset = "0x1D91DA0", VA = "0x181D92FA0")]
	public FECIDOCPIKP(bool EDALDENKAGD = false, bool EODGLOCLKCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3AD4BF0", Offset = "0x3AD39F0", VA = "0x183AD4BF0")]
	public void DEIKBBPPDKP(T LIIJOLOJJBP, U DDBLMIGJKGM, V ELGBOAGNPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6AB0", Offset = "0x3AD58B0", VA = "0x183AD6AB0", Slot = "4")]
	public override void KHLJNKNBEAJ(object[] NAEIJPJHOMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3AD7F50", Offset = "0x3AD6D50", VA = "0x183AD7F50")]
	public static global::FECIDOCPIKP<T, U, V> MNGJEHAGHLB(global::FECIDOCPIKP<T, U, V> LIHEAGNGGHN, Action<T, U, V> JJOAKFFHFLE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3AD7FF0", Offset = "0x3AD6DF0", VA = "0x183AD7FF0")]
	public static global::FECIDOCPIKP<T, U, V> OIOIOKDPJIP(global::FECIDOCPIKP<T, U, V> LIHEAGNGGHN, Action<T, U, V> JJOAKFFHFLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface MKGKDLDEOPC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEIDOEKHNGH(Action<T, U, V, W> JJOAKFFHFLE, bool DNGFBJNEILA = false);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKDIFICKHIH(Action<T, U, V, W> JJOAKFFHFLE);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class NEGJIFFHJID<T, U, V, W> : global::PBMNGJHHONG<Action<T, U, V, W>>, global::MKGKDLDEOPC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1D92FA0", Offset = "0x1D91DA0", VA = "0x181D92FA0")]
	public NEGJIFFHJID(bool EDALDENKAGD = false, bool EODGLOCLKCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD3B0", Offset = "0x3BDC1B0", VA = "0x183BDD3B0")]
	public void DEIKBBPPDKP(T LIIJOLOJJBP, U DDBLMIGJKGM, V ELGBOAGNPGH, W AOLMKHAFJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE8F0", Offset = "0x3BDD6F0", VA = "0x183BDE8F0", Slot = "4")]
	public override void KHLJNKNBEAJ(object[] NAEIJPJHOMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF770", Offset = "0x3BDE570", VA = "0x183BDF770")]
	public static global::NEGJIFFHJID<T, U, V, W> MNGJEHAGHLB(global::NEGJIFFHJID<T, U, V, W> LIHEAGNGGHN, Action<T, U, V, W> JJOAKFFHFLE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF810", Offset = "0x3BDE610", VA = "0x183BDF810")]
	public static global::NEGJIFFHJID<T, U, V, W> OIOIOKDPJIP(global::NEGJIFFHJID<T, U, V, W> LIHEAGNGGHN, Action<T, U, V, W> JJOAKFFHFLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FKKMLDIFEID<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEIDOEKHNGH(Action<T, U, V, W, X> JJOAKFFHFLE, bool DNGFBJNEILA = false);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKDIFICKHIH(Action<T, U, V, W, X> JJOAKFFHFLE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class HCICMHOFMGF<T, U, V, W, X> : global::PBMNGJHHONG<Action<T, U, V, W, X>>, global::FKKMLDIFEID<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1D92FA0", Offset = "0x1D91DA0", VA = "0x181D92FA0")]
	public HCICMHOFMGF(bool EDALDENKAGD = false, bool EODGLOCLKCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3C96580", Offset = "0x3C95380", VA = "0x183C96580")]
	public void DEIKBBPPDKP(T LIIJOLOJJBP, U DDBLMIGJKGM, V ELGBOAGNPGH, W AOLMKHAFJHD, X ACPFKFODNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3C96B30", Offset = "0x3C95930", VA = "0x183C96B30", Slot = "4")]
	public override void KHLJNKNBEAJ(object[] NAEIJPJHOMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3C97140", Offset = "0x3C95F40", VA = "0x183C97140")]
	public static global::HCICMHOFMGF<T, U, V, W, X> MNGJEHAGHLB(global::HCICMHOFMGF<T, U, V, W, X> LIHEAGNGGHN, Action<T, U, V, W, X> JJOAKFFHFLE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3C971E0", Offset = "0x3C95FE0", VA = "0x183C971E0")]
	public static global::HCICMHOFMGF<T, U, V, W, X> OIOIOKDPJIP(global::HCICMHOFMGF<T, U, V, W, X> LIHEAGNGGHN, Action<T, U, V, W, X> JJOAKFFHFLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JMIBGIGEDAL<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEIDOEKHNGH(Action<T, U, V, W, X, Y> JJOAKFFHFLE, bool DNGFBJNEILA = false);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKDIFICKHIH(Action<T, U, V, W, X, Y> JJOAKFFHFLE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class LFONLBDLEFN<T, U, V, W, X, Y> : global::PBMNGJHHONG<Action<T, U, V, W, X, Y>>, global::JMIBGIGEDAL<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1D92FA0", Offset = "0x1D91DA0", VA = "0x181D92FA0")]
	public LFONLBDLEFN(bool EDALDENKAGD = false, bool EODGLOCLKCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1D92490", Offset = "0x1D91290", VA = "0x181D92490")]
	public void DEIKBBPPDKP(T LIIJOLOJJBP, U DDBLMIGJKGM, V ELGBOAGNPGH, W AOLMKHAFJHD, X ACPFKFODNNE, Y FFHJLCNGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1D92AF0", Offset = "0x1D918F0", VA = "0x181D92AF0", Slot = "4")]
	public override void KHLJNKNBEAJ(object[] NAEIJPJHOMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1D92E60", Offset = "0x1D91C60", VA = "0x181D92E60")]
	public static global::LFONLBDLEFN<T, U, V, W, X, Y> MNGJEHAGHLB(global::LFONLBDLEFN<T, U, V, W, X, Y> LIHEAGNGGHN, Action<T, U, V, W, X, Y> JJOAKFFHFLE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1D92F00", Offset = "0x1D91D00", VA = "0x181D92F00")]
	public static global::LFONLBDLEFN<T, U, V, W, X, Y> OIOIOKDPJIP(global::LFONLBDLEFN<T, U, V, W, X, Y> LIHEAGNGGHN, Action<T, U, V, W, X, Y> JJOAKFFHFLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class LFDGMMGAKFE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct CBMMBDCGOKP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly global::LFDGMMGAKFE<T> MBANBAPCFOG;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T MKDOFJMDMOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x1D8A0B0", Offset = "0x1D88EB0", VA = "0x181D8A0B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A080", Offset = "0x1D88E80", VA = "0x181D8A080", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x65D130", Offset = "0x65BF30", VA = "0x18065D130")]
		public CBMMBDCGOKP(global::LFDGMMGAKFE<T> MBANBAPCFOG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NLPDNOEPBCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<CBMMBDCGOKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public global::LFDGMMGAKFE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FCE0", Offset = "0x1D9EAE0", VA = "0x181D9FCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0080", Offset = "0x1D9EE80", VA = "0x181DA0080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct OFDJEPBLPAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<CBMMBDCGOKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::LFDGMMGAKFE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA02A0", Offset = "0x1D9F0A0", VA = "0x181DA02A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0080", Offset = "0x1D9EE80", VA = "0x181DA0080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly SemaphoreSlim KFEBFCGMGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private T OGIMPCEBGIG;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int JKPJKMLJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B2D0", Offset = "0x1D8A0D0", VA = "0x181D8B2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1D8B930", Offset = "0x1D8A730", VA = "0x181D8B930")]
	public LFDGMMGAKFE(in T OGIMPCEBGIG, int OBABEGLPEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1D8B9D0", Offset = "0x1D8A7D0", VA = "0x181D8B9D0")]
	public LFDGMMGAKFE(in T OGIMPCEBGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1D8B8F0", Offset = "0x1D8A6F0", VA = "0x181D8B8F0")]
	public CBMMBDCGOKP JJHJPIPMNBH()
	{
		return default(CBMMBDCGOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1D8B8B0", Offset = "0x1D8A6B0", VA = "0x181D8B8B0")]
	public CBMMBDCGOKP JJHJPIPMNBH(CancellationToken OJFMOLFGPOF)
	{
		return default(CBMMBDCGOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1D8B5D0", Offset = "0x1D8A3D0", VA = "0x181D8B5D0")]
	[AsyncStateMachine(typeof(global::LFDGMMGAKFE<>.NLPDNOEPBCJ))]
	public Task<CBMMBDCGOKP> GMMDKFLMBCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x1D8B730", Offset = "0x1D8A530", VA = "0x181D8B730")]
	[AsyncStateMachine(typeof(global::LFDGMMGAKFE<>.OFDJEPBLPAH))]
	public Task<CBMMBDCGOKP> GMMDKFLMBCO(CancellationToken OJFMOLFGPOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class BMJFACBJEKP
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4A542E0", Offset = "0x4A530E0", VA = "0x184A542E0")]
	public static global::LFDGMMGAKFE<DJGHPGEFOEP> JFAIMEGCMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4A54270", Offset = "0x4A53070", VA = "0x184A54270")]
	public static global::LFDGMMGAKFE<DJGHPGEFOEP> JFAIMEGCMDM(int OBABEGLPEOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1D2BBB0", Offset = "0x1D2A9B0", VA = "0x181D2BBB0")]
	public static global::LFDGMMGAKFE<T> JFAIMEGCMDM<T>(in T OGIMPCEBGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1D2CF60", Offset = "0x1D2BD60", VA = "0x181D2CF60")]
	public static global::LFDGMMGAKFE<T> JFAIMEGCMDM<T>(in T OGIMPCEBGIG, int OBABEGLPEOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NBEIHPDDOME<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate bool DDIPFNJNHMF(global::NBEIHPDDOME<T> BNPACBIBAJO);

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PLGBIADOPKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::NBEIHPDDOME<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public PLGBIADOPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3343810", Offset = "0x3342610", VA = "0x183343810")]
		internal bool <FindNode>b__0(global::NBEIHPDDOME<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public T NAKMDFIDBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LinkedList<global::NBEIHPDDOME<T>> CDPHCBHCJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public global::NBEIHPDDOME<T> HPPDCDPOHBJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public global::NBEIHPDDOME<T> HIJODIIABCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x56F130", Offset = "0x56DF30", VA = "0x18056F130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x333F620", Offset = "0x333E420", VA = "0x18333F620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HGAIMDMNMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x333E400", Offset = "0x333D200", VA = "0x18333E400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DNKPBIJDAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3340720", Offset = "0x333F520", VA = "0x183340720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public global::NBEIHPDDOME<T> GGOGHAHJCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x333E430", Offset = "0x333D230", VA = "0x18333E430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x33407A0", Offset = "0x333F5A0", VA = "0x1833407A0")]
	public NBEIHPDDOME(T ICKLNCIJFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x333E1F0", Offset = "0x333CFF0", VA = "0x18333E1F0")]
	public global::NBEIHPDDOME<T> CDAPGCOOMNL(T CFKCEJGFFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3340550", Offset = "0x333F350", VA = "0x183340550")]
	public global::NBEIHPDDOME<T> PFLHAOKNDCM(T BCFOFPOCCAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x333E4B0", Offset = "0x333D2B0", VA = "0x18333E4B0")]
	public global::NBEIHPDDOME<T> FKDIFICKHIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x333F080", Offset = "0x333DE80", VA = "0x18333F080")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x333FB30", Offset = "0x333E930", VA = "0x18333FB30")]
	public global::NBEIHPDDOME<T> KBOEENAECKA(T IPLGGHFHILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3340050", Offset = "0x333EE50", VA = "0x183340050")]
	public static void NCIPBHBDINJ(global::NBEIHPDDOME<T> HKBONLDPBNG, DDIPFNJNHMF BAMIFFDBCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2F26E20", Offset = "0x2F25C20", VA = "0x182F26E20")]
	public static void NCIPBHBDINJ<A>(global::NBEIHPDDOME<T> HKBONLDPBNG, Func<global::NBEIHPDDOME<T>, A, bool> BAMIFFDBCMC, A GDNGLOLHLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x333E5F0", Offset = "0x333D3F0", VA = "0x18333E5F0")]
	public static string FLAPIMJONOA(global::NBEIHPDDOME<T> HKBONLDPBNG, int GPPJEGMCOIN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x333F700", Offset = "0x333E500", VA = "0x18333F700")]
	public static global::NBEIHPDDOME<T> IPPNBHIMMNA(global::NBEIHPDDOME<T> HKBONLDPBNG, T JEGGGBOOGCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class INCKKKCKMCI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public delegate Task<TResult> PDHGEGEJELM(TRequest BFEEMKFPJON, CancellationToken OJFMOLFGPOF);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum KGAOINHOAIH
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class MKOMCAABICK
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private const float CLMPIMCCPLC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TimeSpan KDIEDLOCIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int CDALDHOGHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public KGAOINHOAIH NOMBJNDEHKE;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly MKOMCAABICK HDNKDHGBPHH;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float HJHPCPGFDJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x29A97E0", Offset = "0x29A85E0", VA = "0x1829A97E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TimeSpan ACAKMPCJAIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x29A9930", Offset = "0x29A8730", VA = "0x1829A9930")]
		public MKOMCAABICK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private readonly struct NPOOBLOHIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly TRequest BFEEMKFPJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly CancellationToken OJFMOLFGPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly TaskCompletionSource<TResult> LPKMBNBFLNE;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x29A9A10", Offset = "0x29A8810", VA = "0x1829A9A10")]
		public NPOOBLOHIKA(TRequest BFEEMKFPJON, TaskCompletionSource<TResult> LPKMBNBFLNE, CancellationToken OJFMOLFGPOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KCCHFOKFLPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public KCCHFOKFLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1C35B90", Offset = "0x1C34990", VA = "0x181C35B90")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct EFFDKOALMDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public global::INCKKKCKMCI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x29987B0", Offset = "0x29975B0", VA = "0x1829987B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1A70", Offset = "0x6B0870", VA = "0x1806B1A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class HCLENHAHGBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public NPOOBLOHIKA req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::INCKKKCKMCI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public HCLENHAHGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2999370", Offset = "0x2998170", VA = "0x182999370")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CancellationTokenSource FAHLMGCPKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<NPOOBLOHIKA> CIHDOEMNOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly MKOMCAABICK JCNPKLJNKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly PDHGEGEJELM OBNBOMCENDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Task FBANKLCCJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private int PELMOFGFKHJ;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x299D2F0", Offset = "0x299C0F0", VA = "0x18299D2F0")]
	public INCKKKCKMCI(PDHGEGEJELM OBNBOMCENDC, [Optional] MKOMCAABICK JCNPKLJNKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x299CE20", Offset = "0x299BC20", VA = "0x18299CE20")]
	public Task<TResult> OINAPEPPFPP(TRequest BFEEMKFPJON, CancellationToken OJFMOLFGPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x299CAA0", Offset = "0x299B8A0", VA = "0x18299CAA0")]
	private void NOECOAFFPLG(NPOOBLOHIKA OHFIAEDLJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x299C0B0", Offset = "0x299AEB0", VA = "0x18299C0B0")]
	[AsyncStateMachine(typeof(global::INCKKKCKMCI<, >.EFFDKOALMDA))]
	private Task GKPHIJCIPDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x299C2D0", Offset = "0x299B0D0", VA = "0x18299C2D0")]
	private NPOOBLOHIKA JEOIHADKIOM()
	{
		return default(NPOOBLOHIKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x299BD70", Offset = "0x299AB70", VA = "0x18299BD70")]
	private void CKCPFEJIBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x299BF60", Offset = "0x299AD60", VA = "0x18299BF60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[DefaultMember("Item")]
public class PPEFAKPBEIA<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate int BCJOJBBGGEL(TKey LHOJNLGGKDH, TVal KCFMHIDCDCO);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class HEJJJGHEBAA
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public TKey AEAEDHDPBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public TVal MKDOFJMDMOL
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x64ABA0", Offset = "0x6499A0", VA = "0x18064ABA0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6B13B0", Offset = "0x6B01B0", VA = "0x1806B13B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int IAGMOONFPOH
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x66E590", Offset = "0x66D390", VA = "0x18066E590")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x66E5C0", Offset = "0x66D3C0", VA = "0x18066E5C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public DateTime BNFECJICGLI
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x51EDF0", Offset = "0x51DBF0", VA = "0x18051EDF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xEF2130", Offset = "0xEF0F30", VA = "0x180EF2130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x34D5770", Offset = "0x34D4570", VA = "0x1834D5770")]
		public HEJJJGHEBAA(TKey LHOJNLGGKDH, TVal DPFKJHANDFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int OPLOIIIOBOC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<HEJJJGHEBAA>> CDOFIDHAKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<HEJJJGHEBAA> FPKPMCKAMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly BCJOJBBGGEL AICPEMDFILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan BPOJGHOKMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly NCAJMFCFKGD NFINKHMFNLK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int MOIPCHKBIME
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x677990", Offset = "0x676790", VA = "0x180677990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private bool LKNBKJFFCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x34E8620", Offset = "0x34E7420", VA = "0x1834E8620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal int ELAAFCNMGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6779A0", Offset = "0x6767A0", VA = "0x1806779A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x66C6B0", Offset = "0x66B4B0", VA = "0x18066C6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9080", Offset = "0x1DD7E80", VA = "0x181DD9080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerable<TKey> JOIAKEPJDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x34E86B0", Offset = "0x34E74B0", VA = "0x1834E86B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public TVal MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x34E8270", Offset = "0x34E7070", VA = "0x1834E8270")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x34E80B0", Offset = "0x34E6EB0", VA = "0x1834E80B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x34E9580", Offset = "0x34E8380", VA = "0x1834E9580")]
	public PPEFAKPBEIA(int OIICMJBLBOB, [Optional] BCJOJBBGGEL AICPEMDFILI, [Optional] IEqualityComparer<TKey> MBCOBMJMBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x34E9530", Offset = "0x34E8330", VA = "0x1834E9530")]
	public PPEFAKPBEIA(TimeSpan BPOJGHOKMAI, [Optional] IEqualityComparer<TKey> MBCOBMJMBON, [Optional] NCAJMFCFKGD NFINKHMFNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x34E94E0", Offset = "0x34E82E0", VA = "0x1834E94E0")]
	public PPEFAKPBEIA(int OIICMJBLBOB, TimeSpan BPOJGHOKMAI, [Optional] IEqualityComparer<TKey> MBCOBMJMBON, [Optional] NCAJMFCFKGD NFINKHMFNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x34E91C0", Offset = "0x34E7FC0", VA = "0x1834E91C0")]
	public PPEFAKPBEIA(int OIICMJBLBOB, BCJOJBBGGEL AICPEMDFILI, TimeSpan BPOJGHOKMAI, [Optional] IEqualityComparer<TKey> MBCOBMJMBON, [Optional] NCAJMFCFKGD NFINKHMFNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x34E8320", Offset = "0x34E7120", VA = "0x1834E8320")]
	public void HBLEDCOCMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x34E9100", Offset = "0x34E7F00", VA = "0x1834E9100")]
	public void OOLACCNIHHO(TKey LHOJNLGGKDH, TVal KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x34E80E0", Offset = "0x34E6EE0", VA = "0x1834E80E0")]
	public bool FKDIFICKHIH(TKey LHOJNLGGKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x34E8560", Offset = "0x34E7360", VA = "0x1834E8560")]
	private TVal IOKAOCCJEBM(TKey IHJIJFNPIJG)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x34E8D60", Offset = "0x34E7B60", VA = "0x1834E8D60")]
	public bool MNODOEFIIGL(TKey IHJIJFNPIJG, out TVal KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x34E82A0", Offset = "0x34E70A0", VA = "0x1834E82A0")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x34E8EC0", Offset = "0x34E7CC0", VA = "0x1834E8EC0")]
	private bool OEPNNEGDCIE(HEJJJGHEBAA IEIKJKLEFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x34E7A10", Offset = "0x34E6810", VA = "0x1834E7A10")]
	private void BBDJEAIAKEC(LinkedListNode<HEJJJGHEBAA> COKMPHOGGIE, TVal HAHNIPPEOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x34E7CA0", Offset = "0x34E6AA0", VA = "0x1834E7CA0")]
	private void CIJINLDFFEE(TKey LHOJNLGGKDH, TVal KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x34E88D0", Offset = "0x34E76D0", VA = "0x1834E88D0")]
	private void MAPOBIIFEFP(HEJJJGHEBAA IEIKJKLEFHJ, TVal HAHNIPPEOKA, int INGPHIJGJHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class KINIMOFJIGA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<T> FGJKCCCHKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private HashSet<T> EHNMLKOEAEN;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1C35B90", Offset = "0x1C34990", VA = "0x181C35B90", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool FNDABHNHEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x51CEC0", Offset = "0x51BCC0", VA = "0x18051CEC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3216F50", Offset = "0x3215D50", VA = "0x183216F50", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3B03850", Offset = "0x3B02650", VA = "0x183B03850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x31F1310", Offset = "0x31F0110", VA = "0x1831F1310", Slot = "11")]
	public void Add(T FCFNKDCAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3B03070", Offset = "0x3B01E70", VA = "0x183B03070")]
	public bool COEFNJLJPMM(T FCFNKDCAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3B03660", Offset = "0x3B02460", VA = "0x183B03660", Slot = "15")]
	public bool Remove(T FCFNKDCAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3B03250", Offset = "0x3B02050", VA = "0x183B03250", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x202FD00", Offset = "0x202EB00", VA = "0x18202FD00", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3B031C0", Offset = "0x3B01FC0", VA = "0x183B031C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x34122D0", Offset = "0x34110D0", VA = "0x1834122D0", Slot = "13")]
	public bool Contains(T FCFNKDCAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3B03220", Offset = "0x3B02020", VA = "0x183B03220", Slot = "14")]
	public void CopyTo(T[] DMCIGPCAGBM, int BFEAINKINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B032D0", Offset = "0x3B020D0", VA = "0x183B032D0", Slot = "6")]
	public int IndexOf(T FCFNKDCAKIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B03300", Offset = "0x3B02100", VA = "0x183B03300", Slot = "7")]
	public void Insert(int CKPFCCCIOFE, T FCFNKDCAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B034C0", Offset = "0x3B022C0", VA = "0x183B034C0", Slot = "8")]
	public void RemoveAt(int CKPFCCCIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3B02FA0", Offset = "0x3B01DA0", VA = "0x183B02FA0")]
	public void BHJAPHPMKPF(Predicate<T> MHAJCDIKHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3B03490", Offset = "0x3B02290", VA = "0x183B03490")]
	public void NBEIHLGIFLB(Comparison<T> HFKLFGDLNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B03770", Offset = "0x3B02570", VA = "0x183B03770")]
	public KINIMOFJIGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class OMEOBDJDJGJ
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A57A80", Offset = "0x4A56880", VA = "0x184A57A80")]
	public static Vector3 AIEEJENJDHI(this GameObject HJMLHPKHBHJ, float GGHJPGBLONF)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1FF8080", Offset = "0x1FF6E80", VA = "0x181FF8080")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4A59990", Offset = "0x4A58790", VA = "0x184A59990")]
		public SerializedGuid(in Guid LPPGJCIGPAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4A59840", Offset = "0x4A58640", VA = "0x184A59840")]
		public static SerializedGuid OHMJCKGJOIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4A595A0", Offset = "0x4A583A0", VA = "0x184A595A0")]
		public static SerializedGuid EHLPFLIDNAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4A597B0", Offset = "0x4A585B0", VA = "0x184A597B0")]
		public bool KIBNGJFJBON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4A59960", Offset = "0x4A58760", VA = "0x184A59960", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A598C0", Offset = "0x4A586C0", VA = "0x184A598C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A594E0", Offset = "0x4A582E0", VA = "0x184A594E0")]
		public bool ALJDPOBCGCB(in Guid LPPGJCIGPAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4A59620", Offset = "0x4A58420", VA = "0x184A59620", Slot = "7")]
		public bool Equals(SerializedGuid NDGDPPHIMJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4A596C0", Offset = "0x4A584C0", VA = "0x184A596C0", Slot = "0")]
		public override bool Equals(object PJNABAALNPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4A597A0", Offset = "0x4A585A0", VA = "0x184A597A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4A59570", Offset = "0x4A58370", VA = "0x184A59570", Slot = "6")]
		public int CompareTo(SerializedGuid NDGDPPHIMJG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BIOBICCBNIO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Type MEJELCHHMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly string FCPCFNIBGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool JPOPIAGJAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly bool OGNNLBFLHFC;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A53EB0", Offset = "0x4A52CB0", VA = "0x184A53EB0")]
	public BIOBICCBNIO(Type LGAJJMPLBFA, string AJDPFFKNLFK, bool HMGFMKONCNP = false, bool AHDEOMNFNEI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface PPADBEKKJFA
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface GBCCCDOIDBM<T> : PPADBEKKJFA
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	T MKDOFJMDMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool GHHHEODKDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string KENBDCJFMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::GBCCCDOIDBM<T> HDHNNIINIJL(Action<T> OABEDKKBIDM);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::GBCCCDOIDBM<T> JLJGFMPMFGP(Action<T> OABEDKKBIDM);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::GBCCCDOIDBM<T> JJCOEPNEMPM(Action<T, T> ECPCDJCPBGD);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GBCCCDOIDBM<T> AIMCKPBHLMJ(Action<T, T> ECPCDJCPBGD);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::GBCCCDOIDBM<T> CLMEMHCAGPJ(Action<string> GEBLBEIFKAJ);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::GBCCCDOIDBM<T> OGOPOLLMGMK(Action<string> GEBLBEIFKAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class JKPBMIAJKGN<T> : global::GBCCCDOIDBM<T>, PPADBEKKJFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private global::KIKMDGJNCBI<T, T> DINDDEPMKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private global::KDPHOICGJBO<T> MEOCFOFEFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private global::KDPHOICGJBO<string> PALAMFGPLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private string AGHNPABBPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private T CFLKPKIKHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool FIEPBBJFKFF;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public T MKDOFJMDMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x544A30", Offset = "0x543830", VA = "0x180544A30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D97AD0", Offset = "0x1D968D0", VA = "0x181D97AD0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GHHHEODKDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x59E8B0", Offset = "0x59D6B0", VA = "0x18059E8B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string KENBDCJFMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5450C0", Offset = "0x543EC0", VA = "0x1805450C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2663880", Offset = "0x2662680", VA = "0x182663880", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x34126E0", Offset = "0x34114E0", VA = "0x1834126E0")]
	private void ENBHPLNDOIC(T AFCFNJMGAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x34128B0", Offset = "0x34116B0", VA = "0x1834128B0")]
	private void LJPAPBLGNGG(string MNIDJMIIGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3412630", Offset = "0x3411430", VA = "0x183412630")]
	public void CPCMAPIDJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3412810", Offset = "0x3411610", VA = "0x183412810", Slot = "6")]
	public global::GBCCCDOIDBM<T> JJCOEPNEMPM(Action<T, T> ECPCDJCPBGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3412550", Offset = "0x3411350", VA = "0x183412550", Slot = "7")]
	public global::GBCCCDOIDBM<T> AIMCKPBHLMJ(Action<T, T> ECPCDJCPBGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3412780", Offset = "0x3411580", VA = "0x183412780", Slot = "4")]
	public global::GBCCCDOIDBM<T> HDHNNIINIJL(Action<T> ECPCDJCPBGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3412860", Offset = "0x3411660", VA = "0x183412860", Slot = "5")]
	public global::GBCCCDOIDBM<T> JLJGFMPMFGP(Action<T> OABEDKKBIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x34125A0", Offset = "0x34113A0", VA = "0x1834125A0", Slot = "8")]
	public global::GBCCCDOIDBM<T> CLMEMHCAGPJ(Action<string> GEBLBEIFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3412950", Offset = "0x3411750", VA = "0x183412950", Slot = "9")]
	public global::GBCCCDOIDBM<T> OGOPOLLMGMK(Action<string> GEBLBEIFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x34129C0", Offset = "0x34117C0", VA = "0x1834129C0")]
	public JKPBMIAJKGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class AHNJFHFBNAA
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class AGGAIPKCHEH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public global::GBCCCDOIDBM<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public global::PJPEGAEJAFJ<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public AGGAIPKCHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D7D510", Offset = "0x1D7C310", VA = "0x181D7D510")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A4E0", Offset = "0x1D292E0", VA = "0x181D2A4E0")]
	public static global::BKHPMHDEEIP<T> PKJOIMNPGMI<T>(this global::GBCCCDOIDBM<T> OHICDIEELJH, Action<T> HKFANNEFPNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class NCAJMFCFKGD
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ECANKPOGJED : NCAJMFCFKGD
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static NCAJMFCFKGD GDKAJIKDHCH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4A54780", Offset = "0x4A53580", VA = "0x184A54780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override DateTime KBNEHNCNAJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4A547E0", Offset = "0x4A535E0", VA = "0x184A547E0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override float PDNGKOLAHMN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4A4DD00", Offset = "0x4A4CB00", VA = "0x184A4DD00", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4A548D0", Offset = "0x4A536D0", VA = "0x184A548D0")]
		public ECANKPOGJED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static NCAJMFCFKGD LACIJAOCCBA;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static NCAJMFCFKGD HDNKDHGBPHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4A56740", Offset = "0x4A55540", VA = "0x184A56740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract DateTime KBNEHNCNAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract float PDNGKOLAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	protected NCAJMFCFKGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class GKGHLBJLCOE : global::DKHDJJFCBON<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4A55940", Offset = "0x4A54740", VA = "0x184A55940")]
	public GKGHLBJLCOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class DKHDJJFCBON<T> : global::AGDODGLPAOP<T>, HLABFEPAAEE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Task<T> IODNILMMFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private Task OLGEPOOGPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1B584D0", Offset = "0x1B572D0", VA = "0x181B584D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public global::BKHPMHDEEIP<T> MEDMOKKCLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private EDDKJIPNMLB FINACPDJBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1B59A00", Offset = "0x1B58800", VA = "0x181B59A00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x36E1A20", Offset = "0x36E0820", VA = "0x1836E1A20")]
	public DKHDJJFCBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class OFAFLPBFFBE : global::BACNALGEAGB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4A57A30", Offset = "0x4A56830", VA = "0x184A57A30")]
	public OFAFLPBFFBE(Exception OGCHFBMNBDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class BACNALGEAGB<T> : global::AGDODGLPAOP<T>, HLABFEPAAEE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Task<T> IODNILMMFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private Task OLGEPOOGPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1B584D0", Offset = "0x1B572D0", VA = "0x181B584D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public global::BKHPMHDEEIP<T> MEDMOKKCLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private EDDKJIPNMLB FINACPDJBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1B59A00", Offset = "0x1B58800", VA = "0x181B59A00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x376CBC0", Offset = "0x376B9C0", VA = "0x18376CBC0")]
	public BACNALGEAGB(Exception OGCHFBMNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HLABFEPAAEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	Task IODNILMMFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	[NotNull]
	EDDKJIPNMLB MEDMOKKCLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface AGDODGLPAOP<T> : HLABFEPAAEE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[NotNull]
	new Task<T> IODNILMMFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[NotNull]
	new global::BKHPMHDEEIP<T> MEDMOKKCLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class GINPKGPLLBI<TTask, T> : global::AGDODGLPAOP<T>, HLABFEPAAEE, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class PJKPKIDEGAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::GINPKGPLLBI<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public PJKPKIDEGAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static bool NPBDCIJGBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly Task<T> PMAGEEHFPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected readonly CancellationTokenSource CDKPLGADKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool BKKHGGNPMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private SynchronizationContext FNMKCGCLNGF;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> IODNILMMFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task OLGEPOOGPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::BKHPMHDEEIP<T> MEDMOKKCLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private EDDKJIPNMLB FINACPDJBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1D93190", Offset = "0x1D91F90", VA = "0x181D93190", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool HAAHOKAHFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x59D990", Offset = "0x59C790", VA = "0x18059D990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2837820", Offset = "0x2836620", VA = "0x182837820")]
	static GINPKGPLLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2837990", Offset = "0x2836790", VA = "0x182837990")]
	protected GINPKGPLLBI(TTask PMAGEEHFPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x28372E0", Offset = "0x28360E0", VA = "0x1828372E0", Slot = "1")]
	~GINPKGPLLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2837210", Offset = "0x2836010", VA = "0x182837210", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2837540", Offset = "0x2836340", VA = "0x182837540")]
	private void JCPBCAEBHJK(bool FCNNEOEKGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T ABNLKHGFLGN(TTask NNDJIKLGFAJ);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void AEGDNBDDBDG();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2837380", Offset = "0x2836180", VA = "0x182837380")]
	[CompilerGenerated]
	private void IHFBBDIBGDK(object HCHCDFNJLNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IAFJMANNLFL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Type MEJELCHHMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly string FCPCFNIBGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly bool JPOPIAGJAEL;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4A55C00", Offset = "0x4A54A00", VA = "0x184A55C00")]
	public IAFJMANNLFL(Type LGAJJMPLBFA, string AJDPFFKNLFK, bool HMGFMKONCNP = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x51CED0", Offset = "0x51BCD0", VA = "0x18051CED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x540710", Offset = "0x53F510", VA = "0x180540710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public T this[int CKCPKBAGJMN, int AKGIBLFOJIE]
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1B58610", Offset = "0x1B57410", VA = "0x181B58610")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1B586B0", Offset = "0x1B574B0", VA = "0x181B586B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1B58580", Offset = "0x1B57380", VA = "0x181B58580")]
		public Array2D(uint HALPAOLACGJ, uint GJLNADLHOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1B58500", Offset = "0x1B57300", VA = "0x181B58500")]
		public void GGFJFJEKGGK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4A53DB0", Offset = "0x4A52BB0", VA = "0x184A53DB0")]
		public Array2DVector3(uint HALPAOLACGJ, uint GJLNADLHOLD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal static class KBKBBKIBANM
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const int BBNODENOHNC = -1;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const int ICCOEGOPKAE = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class DGJKFKFAPMJ<THandle, TValue> : IDisposable where THandle : struct, GNIMDDFELAE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly List<THandle> ACJBPPODDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<TValue> EJEIGNNJCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly Func<TValue> ALHBBOFHFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly Action<TValue> DNMMEALGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private int CNJIIHNNPEG;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public TValue MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x34E8270", Offset = "0x34E7070", VA = "0x1834E8270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x36DFEF0", Offset = "0x36DECF0", VA = "0x1836DFEF0")]
	public DGJKFKFAPMJ(Action<TValue> DNMMEALGHHJ, [Optional] Func<TValue> ALHBBOFHFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x36DF6E0", Offset = "0x36DE4E0", VA = "0x1836DF6E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x36DFC60", Offset = "0x36DEA60", VA = "0x1836DFC60")]
	public THandle PEDPEIEILOF()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x36DFE40", Offset = "0x36DEC40", VA = "0x1836DFE40")]
	public THandle PEIDOEKHNGH(TValue KCFMHIDCDCO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x36DF7A0", Offset = "0x36DE5A0", VA = "0x1836DF7A0")]
	public bool FKDIFICKHIH(THandle BGMPHLJIJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x36DFA70", Offset = "0x36DE870", VA = "0x1836DFA70")]
	public bool KEGDDGFHKAJ(THandle BGMPHLJIJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x36DF920", Offset = "0x36DE720", VA = "0x1836DF920")]
	public bool JBGHHOHELLE(THandle BGMPHLJIJDI, out TValue KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x36DF8D0", Offset = "0x36DE6D0", VA = "0x1836DF8D0")]
	public TValue IOKAOCCJEBM(THandle BGMPHLJIJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x36DF9C0", Offset = "0x36DE7C0", VA = "0x1836DF9C0")]
	public bool JPMOKLPACLF(THandle BGMPHLJIJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x36DF6B0", Offset = "0x36DE4B0", VA = "0x1836DF6B0")]
	private THandle DPDMLGLPFJC(int CKPFCCCIOFE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x36DFEC0", Offset = "0x36DECC0", VA = "0x1836DFEC0")]
	private TValue PKJOIMNPGMI(int CKPFCCCIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x36DFB50", Offset = "0x36DE950", VA = "0x1836DFB50")]
	private void LINEMNOLFJD(int CKPFCCCIOFE, in THandle BGMPHLJIJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x36DF760", Offset = "0x36DE560", VA = "0x1836DF760")]
	private void ENBHPLNDOIC(int CKPFCCCIOFE, in TValue KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x36DF5A0", Offset = "0x36DE3A0", VA = "0x1836DF5A0")]
	private THandle DPBIJAOHHGL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x36DF350", Offset = "0x36DE150", VA = "0x1836DF350")]
	private void ADGMMPAHEBG(THandle BGMPHLJIJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x36DF410", Offset = "0x36DE210", VA = "0x1836DF410")]
	private int BIKGGPNOFML(int NLHLOLJPAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x36DFEB0", Offset = "0x36DECB0", VA = "0x1836DFEB0")]
	private bool PFDLNINABGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x56D9A0", Offset = "0x56C7A0", VA = "0x18056D9A0")]
	private void COBGMMNBLOD(THandle BGMPHLJIJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x36DF850", Offset = "0x36DE650", VA = "0x1836DF850")]
	private bool FMMKKJLDACG(out THandle BGMPHLJIJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x36DFB90", Offset = "0x36DE990", VA = "0x1836DFB90")]
	private bool MLFGPMMFICB(out THandle BGMPHLJIJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x36DF420", Offset = "0x36DE220", VA = "0x1836DF420")]
	private void BPODAEGIIHA(THandle BGMPHLJIJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x36DF480", Offset = "0x36DE280", VA = "0x1836DF480")]
	private void DGLMMAKOMMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface GNIMDDFELAE
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int FOJANJPFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	int CMHPHALLLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface AIEEHLPHPGE<T> : GNIMDDFELAE, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class OFLJEBKFOGD
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x1ECB050", Offset = "0x1EC9E50", VA = "0x181ECB050")]
	public static bool JPEAEONOILG<T>(this T BGMPHLJIJDI) where T : struct, GNIMDDFELAE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class OEEJHOIKKCD
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private enum BFHLPCAEIPP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int NFJNLBIEPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool ALPPMIEOADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private BFHLPCAEIPP CGMPBIPEAJD;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool PJPMIMBNOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4A57490", Offset = "0x4A56290", VA = "0x184A57490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool FKNOIGFJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4A56E00", Offset = "0x4A55C00", VA = "0x184A56E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4A57A00", Offset = "0x4A56800", VA = "0x184A57A00")]
	public OEEJHOIKKCD(bool ALPPMIEOADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4A56E10", Offset = "0x4A55C10", VA = "0x184A56E10")]
	public void EMGDGLBAKEJ(object PJNABAALNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4A57950", Offset = "0x4A56750", VA = "0x184A57950")]
	public void PKIGKGIIGEF(int KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4A56C20", Offset = "0x4A55A20", VA = "0x184A56C20")]
	public void ABJNLBFECCE(uint OFLAKIIDKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4A57930", Offset = "0x4A56730", VA = "0x184A57930")]
	public void OHKBBGJMOCN(bool KGJEJDBHNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4A56DC0", Offset = "0x4A55BC0", VA = "0x184A56DC0")]
	public void EDFKDGEBACB(long KCMLEODAEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4A57530", Offset = "0x4A56330", VA = "0x184A57530")]
	public void LMKABFOLFPN(ulong AEELAACCKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4A573B0", Offset = "0x4A561B0", VA = "0x184A573B0")]
	public void GLLLDPNGEPN(string DCNFCFNCDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4A574A0", Offset = "0x4A562A0", VA = "0x184A574A0")]
	public void KBLBIEJIFPB(Enum OGCHFBMNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4A56C30", Offset = "0x4A55A30", VA = "0x184A56C30")]
	public void AIMFKKDAMNB(IList FGJKCCCHKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2F2BAC0", Offset = "0x2F2A8C0", VA = "0x182F2BAC0")]
	public void IHMPCDIBGOA<T, U>(Dictionary<T, U> LPLNHDHKFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4A57570", Offset = "0x4A56370", VA = "0x184A57570")]
	private void MODEGKIJLJA(IDictionary LPLNHDHKFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4A57330", Offset = "0x4A56130", VA = "0x184A57330")]
	public int FGOOIPMLNCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4A57420", Offset = "0x4A56220", VA = "0x184A57420")]
	public short HFAJIJAEKMN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4A573A0", Offset = "0x4A561A0", VA = "0x184A573A0")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4A56D50", Offset = "0x4A55B50", VA = "0x184A56D50")]
	private void CMAJHNINJEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class CAJCLDENOLC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class PEBPJHBMJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TNode PGAIJHEIDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TNode DEGLKKAFDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public PCIHJCIKMEG EOCMEEPKAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<PCIHJCIKMEG> AGOKPKMAMKA;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public PEBPJHBMJGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal struct PCIHJCIKMEG : IComparable<PCIHJCIKMEG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int KHNKDIDPJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public TClaimant BBIGDJDBCNF;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x524CF0", Offset = "0x523AF0", VA = "0x180524CF0")]
		public PCIHJCIKMEG(int KHNKDIDPJCA, TClaimant BBIGDJDBCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x31D7980", Offset = "0x31D6780", VA = "0x1831D7980")]
		public bool MHLDCPGALDH(in PCIHJCIKMEG NDGDPPHIMJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x31D7970", Offset = "0x31D6770", VA = "0x1831D7970")]
		public bool KDBAKPCDJLC(in PCIHJCIKMEG NDGDPPHIMJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x31D7960", Offset = "0x31D6760", VA = "0x1831D7960", Slot = "4")]
		public int CompareTo(PCIHJCIKMEG NDGDPPHIMJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x31D79E0", Offset = "0x31D67E0", VA = "0x1831D79E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public enum KFNAFFLAIEF
	{
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JALNHOMFNLM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public global::CAJCLDENOLC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x282C470", Offset = "0x282B270", VA = "0x18282C470")]
		[DebuggerHidden]
		public JALNHOMFNLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x31D5A30", Offset = "0x31D4830", VA = "0x1831D5A30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x31D5BF0", Offset = "0x31D49F0", VA = "0x1831D5BF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x31D5B10", Offset = "0x31D4910", VA = "0x1831D5B10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1B67E50", Offset = "0x1B66C50", VA = "0x181B67E50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly global::NDJIHFLKKFD<PEBPJHBMJGD> JHDAIBOJGDB;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly global::NDJIHFLKKFD<List<PCIHJCIKMEG>> BLAGFMEMLFM;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static int ENICADNFFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	internal readonly Dictionary<TClaimant, TNode> MFDAKMDGKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal readonly Dictionary<TNode, PEBPJHBMJGD> FCOAKPAHMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private KFNAFFLAIEF MEACFLCKBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private bool PNBBCGIMPDO;

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OIHBGAGLAAP(TNode BNPACBIBAJO);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CJEODEJLCCJ(TNode BNPACBIBAJO, TClaimant JLDBLBOJMLA, TClaimant ELFICCPLMHN);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x31CBA90", Offset = "0x31CA890", VA = "0x1831CBA90")]
	public CAJCLDENOLC(KFNAFFLAIEF MEACFLCKBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x31CA630", Offset = "0x31C9430", VA = "0x1831CA630")]
	public void AODANEIMCAO(TNode BNPACBIBAJO, TNode IPLGGHFHILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x31CB590", Offset = "0x31CA390", VA = "0x1831CB590")]
	public void JFLKEECEBDH(TClaimant BBIGDJDBCNF, TNode FELEGHOCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x31CA8B0", Offset = "0x31C96B0", VA = "0x1831CA8B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x31CB690", Offset = "0x31CA490", VA = "0x1831CB690")]
	private void LIHDCJIPOBH(TClaimant BBIGDJDBCNF, TNode OLEANDACMMD, TNode FELEGHOCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x31CB730", Offset = "0x31CA530", VA = "0x1831CB730")]
	private int LJAKECEMEJK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x31CB2E0", Offset = "0x31CA0E0", VA = "0x1831CB2E0")]
	private void ICNGFNHDOPE(TClaimant BBIGDJDBCNF, TNode OAHENEGKIMA, TNode AFCDAIKIIFO, int ODNDFAPEHEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x31CB7A0", Offset = "0x31CA5A0", VA = "0x1831CB7A0")]
	private void MEBLHNLGDFB(PCIHJCIKMEG HPKACNJCKLE, PEBPJHBMJGD DMFHEJHLHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x31CA230", Offset = "0x31C9030", VA = "0x1831CA230")]
	private void AHPABBBMPCK(TClaimant BBIGDJDBCNF, TNode OAHENEGKIMA, TNode AFCDAIKIIFO, int ODNDFAPEHEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x31CAB10", Offset = "0x31C9910", VA = "0x1831CAB10")]
	private void FBKEEGACGPL(PCIHJCIKMEG HPKACNJCKLE, TNode BNPACBIBAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x31CB830", Offset = "0x31CA630", VA = "0x1831CB830")]
	private void NOJAFPELHKK(PCIHJCIKMEG HPKACNJCKLE, PEBPJHBMJGD DMFHEJHLHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x31CA6B0", Offset = "0x31C94B0", VA = "0x1831CA6B0")]
	private void BBIDMDIGEIB(PEBPJHBMJGD DMFHEJHLHCF, bool PGIIEBBPDBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x31CAC10", Offset = "0x31C9A10", VA = "0x1831CAC10")]
	private void HEFFJKCGEMD(PEBPJHBMJGD DMFHEJHLHCF, TNode IPLGGHFHILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x31CB050", Offset = "0x31C9E50", VA = "0x1831CB050")]
	[IteratorStateMachine(typeof(global::CAJCLDENOLC<, >.JALNHOMFNLM))]
	private IEnumerable<TNode> HFCLHFGACDM(TNode OAHENEGKIMA, TNode AFCDAIKIIFO, bool ACLDMKEJPDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x31CA7F0", Offset = "0x31C95F0", VA = "0x1831CA7F0")]
	private PEBPJHBMJGD BIPJNMBOIEK(TNode BNPACBIBAJO, TNode DEGLKKAFDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x31CA4A0", Offset = "0x31C92A0", VA = "0x1831CA4A0")]
	private PEBPJHBMJGD AKDNCBMPIGH(TNode BNPACBIBAJO, TNode DEGLKKAFDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x31CB120", Offset = "0x31C9F20", VA = "0x1831CB120")]
	private void HKNALNENBAJ(PEBPJHBMJGD DMFHEJHLHCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class LAGIEOKCJHE<T> : IEnumerable<global::LAGIEOKCJHE<T>.NEHOCAAKLEO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct NEHOCAAKLEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public T KCFMHIDCDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int CKPFCCCIOFE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class CBOEHBMCNAH : IEnumerator<NEHOCAAKLEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private global::LAGIEOKCJHE<T> FEKAMMAEGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int CKPFCCCIOFE;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2777F40", Offset = "0x2776D40", VA = "0x182777F40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public NEHOCAAKLEO ENNKBELIDPE
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x3ED0C50", Offset = "0x3ECFA50", VA = "0x183ED0C50", Slot = "4")]
			get
			{
				return default(NEHOCAAKLEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x86C460", Offset = "0x86B260", VA = "0x18086C460")]
		public CBOEHBMCNAH(global::LAGIEOKCJHE<T> FEKAMMAEGIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0BC0", Offset = "0x3ECF9C0", VA = "0x183ED0BC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6E3790", Offset = "0x6E2590", VA = "0x1806E3790", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x804470", Offset = "0x803270", VA = "0x180804470", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private struct LBHNJOGLCLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool CHFBLDHMJHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public T KCFMHIDCDCO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private const int IFGPHCCHIAK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Dictionary<T, int> JNMAECGEHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private LBHNJOGLCLE[] JJCNENGNIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int CBENFOAFLKJ;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x36E1C60", Offset = "0x36E0A60", VA = "0x1836E1C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED7D10", Offset = "0x3ED6B10", VA = "0x183ED7D10")]
	public static global::LAGIEOKCJHE<T> AJGOBJIKPBD(NEHOCAAKLEO[] JIIIBPNDPKL, bool CDDECPDKJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8920", Offset = "0x3ED7720", VA = "0x183ED8920")]
	public LAGIEOKCJHE(int OIICMJBLBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x36DF160", Offset = "0x36DDF60", VA = "0x1836DF160")]
	public bool OKFDAIJOGGB(T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8840", Offset = "0x3ED7640", VA = "0x183ED8840")]
	public bool PKKHAKKHFFF(int CKPFCCCIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3ED86D0", Offset = "0x3ED74D0", VA = "0x183ED86D0")]
	public bool MLBCOPDEJLG(Func<T, bool> EKKBNMDAGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8780", Offset = "0x3ED7580", VA = "0x183ED8780")]
	public int NGHCCPLPIGK(T KCFMHIDCDCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x3ED87D0", Offset = "0x3ED75D0", VA = "0x183ED87D0")]
	public T PKJOIMNPGMI(int CKPFCCCIOFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x3ED84C0", Offset = "0x3ED72C0", VA = "0x183ED84C0")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8320", Offset = "0x3ED7120", VA = "0x183ED8320")]
	public bool COEFNJLJPMM(T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x3ED80F0", Offset = "0x3ED6EF0", VA = "0x183ED80F0")]
	public bool COEFNJLJPMM(T KCFMHIDCDCO, int CKPFCCCIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8440", Offset = "0x3ED7240", VA = "0x183ED8440")]
	public bool FKDIFICKHIH(T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8340", Offset = "0x3ED7140", VA = "0x183ED8340")]
	public bool DLCNBCCKCCI(int CKPFCCCIOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8390", Offset = "0x3ED7190", VA = "0x183ED8390")]
	private void EKECMEMCJEB(int CKPFCCCIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8560", Offset = "0x3ED7360", VA = "0x183ED8560")]
	public NEHOCAAKLEO[] ILIHCFDCHEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x3ED8510", Offset = "0x3ED7310", VA = "0x183ED8510")]
	private int IKDICEJPLEJ(int CJMMDDOFLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED88A0", Offset = "0x3ED76A0", VA = "0x183ED88A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED88A0", Offset = "0x3ED76A0", VA = "0x183ED88A0", Slot = "4")]
	private IEnumerator<NEHOCAAKLEO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class NDJIHFLKKFD<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Stack<T> NPIKNPCFEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<T> PENBOCBFEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly int AOKMONGKFEH;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int CBNEBLGACKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1B5D410", Offset = "0x1B5C210", VA = "0x181B5D410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LPICOCNOEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x27831F0", Offset = "0x2781FF0", VA = "0x1827831F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBA70", Offset = "0x3BDA870", VA = "0x183BDBA70")]
	public static global::NDJIHFLKKFD<T> BBNNDMNDPIH(int OIICMJBLBOB = 0, int AOKMONGKFEH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBE60", Offset = "0x3BDAC60", VA = "0x183BDBE60")]
	public static global::NDJIHFLKKFD<T> JABBGBLJJJC(int OIICMJBLBOB = 0, int AOKMONGKFEH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3BDC3A0", Offset = "0x3BDB1A0", VA = "0x183BDC3A0")]
	public NDJIHFLKKFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3BDC210", Offset = "0x3BDB010", VA = "0x183BDC210")]
	public NDJIHFLKKFD(int OIICMJBLBOB, int AOKMONGKFEH = int.MaxValue, bool NHNIOBJDKMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBB40", Offset = "0x3BDA940", VA = "0x183BDBB40")]
	public T DLIFPGPDKAE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBD80", Offset = "0x3BDAB80", VA = "0x183BDBD80")]
	public void FMEOMFOCNJD(T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x3BDC150", Offset = "0x3BDAF50", VA = "0x183BDC150")]
	private void KMCKDPGLDDD(T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBE40", Offset = "0x3BDAC40", VA = "0x183BDBE40")]
	private void HHBMADCAAEO(T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x3BDB920", Offset = "0x3BDA720", VA = "0x183BDB920")]
	[Conditional("DEBUG_BUILD")]
	private void AIDEAMFKGDE(T HBONMPEJIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x3BDB9C0", Offset = "0x3BDA7C0", VA = "0x183BDB9C0")]
	[Conditional("DEBUG_BUILD")]
	private void AKIKJHIIINH(T HBONMPEJIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBC70", Offset = "0x3BDAA70", VA = "0x183BDBC70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBF30", Offset = "0x3BDAD30", VA = "0x183BDBF30")]
	private void KKFGEHMKBBC(IEnumerable<T> EJEIGNNJCGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class BCAINFNLOAP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Dictionary<int, T> AJNLPOOBFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private T IHEOFFGPJNP;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T KKFPFOFKPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x51C4A0", Offset = "0x51B2A0", VA = "0x18051C4A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool GMMDCPHEIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3770450", Offset = "0x376F250", VA = "0x183770450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x37703F0", Offset = "0x376F1F0", VA = "0x1837703F0")]
	public bool CIJINLDFFEE(T KCFMHIDCDCO, int KHNKDIDPJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x3770330", Offset = "0x376F130", VA = "0x183770330")]
	public bool AEJMCCFPCLJ(int KHNKDIDPJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x3770900", Offset = "0x376F700", VA = "0x183770900")]
	public T LPBOBOBHDOE(int FJOOBPMKGDE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x3770490", Offset = "0x376F290", VA = "0x183770490")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x3770600", Offset = "0x376F400", VA = "0x183770600")]
	private bool HPPAPODFDPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x3770B60", Offset = "0x376F960", VA = "0x183770B60")]
	public bool MNODOEFIIGL(int KHNKDIDPJCA, out T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE190", Offset = "0x2BDCF90", VA = "0x182BDE190")]
	public BCAINFNLOAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HEIEOFJNKKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	protected struct PFGBEBIAPDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public T MKDOFJMDMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int AGDELCDJEMA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	protected readonly List<PFGBEBIAPDI> PANNBAPOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private T DKODNNFIOMP;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1C35B90", Offset = "0x1C34990", VA = "0x181C35B90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x3C97710", Offset = "0x3C96510", VA = "0x183C97710")]
	public bool MLBCOPDEJLG(T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x3C97960", Offset = "0x3C96760", VA = "0x183C97960")]
	public void PEIDOEKHNGH(T KCFMHIDCDCO, int KHNKDIDPJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x3C97280", Offset = "0x3C96080", VA = "0x183C97280")]
	public bool FKDIFICKHIH(T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x3C973A0", Offset = "0x3C961A0", VA = "0x183C973A0")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x3C97400", Offset = "0x3C96200", VA = "0x183C97400")]
	public T HELHGPLGDAA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x3C97490", Offset = "0x3C96290", VA = "0x183C97490")]
	public T JEOIHADKIOM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x3C97500", Offset = "0x3C96300", VA = "0x183C97500")]
	private void MALHADCKKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x3C97A00", Offset = "0x3C96800", VA = "0x183C97A00")]
	public HEIEOFJNKKG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		[HMEPOPIIEBM(ABJMOFPOMCO.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x4A57EF0", Offset = "0x4A56CF0", VA = "0x184A57EF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x4A583C0", Offset = "0x4A571C0", VA = "0x184A583C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x4A581E0", Offset = "0x4A56FE0", VA = "0x184A581E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x4A58560", Offset = "0x4A57360", VA = "0x184A58560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x4A57DB0", Offset = "0x4A56BB0", VA = "0x184A57DB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x4A58280", Offset = "0x4A57080", VA = "0x184A58280")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x4A580A0", Offset = "0x4A56EA0", VA = "0x184A580A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4A57D10", Offset = "0x4A56B10", VA = "0x184A57D10")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface MFIBOODGCOL
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class ResourcePrefabReference<T> : MFIBOODGCOL where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1B66F50", Offset = "0x1B65D50", VA = "0x181B66F50", Slot = "4")]
		public virtual T ANCMJBKKLPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class GGDICONFGOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly Dictionary<byte, KEJDIMPLCLC> NJONGAKMODC;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public KEJDIMPLCLC DCHJEMOOECK
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x51C490", Offset = "0x51B290", VA = "0x18051C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector2 EMMEDBBDMCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1319FD0", Offset = "0x1318DD0", VA = "0x181319FD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x311B300", Offset = "0x311A100", VA = "0x18311B300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 PPHMBADOELC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x16733D0", Offset = "0x16721D0", VA = "0x1816733D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1673430", Offset = "0x1672230", VA = "0x181673430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector2 JEAECADABFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x35191A0", Offset = "0x3517FA0", VA = "0x1835191A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x35191C0", Offset = "0x3517FC0", VA = "0x1835191C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int MPGAKEILHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x5477E0", Offset = "0x5465E0", VA = "0x1805477E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x56D9A0", Offset = "0x56C7A0", VA = "0x18056D9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x4A55420", Offset = "0x4A54220", VA = "0x184A55420")]
	public GGDICONFGOJ(Bounds CPPMGHEKBAF, Vector2[] BFLDPKDMFJF, int IEFIBHLMGLD, byte CJMMDDOFLDK, float CJPOPAMKOEN = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x4A54D70", Offset = "0x4A53B70", VA = "0x184A54D70")]
	public KEJDIMPLCLC GFBJLEFFBPJ(byte CKPFCCCIOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x4A54C80", Offset = "0x4A53A80", VA = "0x184A54C80")]
	public void EJOFOMLNMFI(Vector3 EKDPPBPKOBN, float NIGPLNBEOHA, float CCLAPFCAOBH, ref List<byte> GMMEJENOGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x4A54C60", Offset = "0x4A53A60", VA = "0x184A54C60")]
	public void AEIKNLHMHBB(KEJDIMPLCLC.ANIFLBHPAHJ JCLPOJGKHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4A54DD0", Offset = "0x4A53BD0", VA = "0x184A54DD0")]
	private KEJDIMPLCLC JHKGEHOHHHJ(byte CKPFCCCIOFE, KEJDIMPLCLC.CMDKEKIILFK ENCFCDENBOH, KEJDIMPLCLC DEGLKKAFDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A54F00", Offset = "0x4A53D00", VA = "0x184A54F00")]
	private void NKDFCBOCBEG(KEJDIMPLCLC DEGLKKAFDCN, Vector2[] BFLDPKDMFJF, int APBHNJKBBBO, int GEMLGOBHPNK, int GIHNKPFPFFF, int HILFFFCNHBH, float CJPOPAMKOEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KEJDIMPLCLC
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum CMDKEKIILFK
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public enum ANIFLBHPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public byte ONLFDPCNFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Vector3 JHPFEOHCPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3 IAGMOONFPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 NHBGLKFMOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3 LGLCJNFAFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public CMDKEKIILFK HLDKBNBHCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public KEJDIMPLCLC HIJODIIABCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public List<KEJDIMPLCLC> NDBHDHCKPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool MFOIGOMOMMC;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A560D0", Offset = "0x4A54ED0", VA = "0x184A560D0")]
	public KEJDIMPLCLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x4A560F0", Offset = "0x4A54EF0", VA = "0x184A560F0")]
	public KEJDIMPLCLC(byte NANAAKJMMKA, CMDKEKIILFK ENCFCDENBOH, KEJDIMPLCLC DEGLKKAFDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A55D60", Offset = "0x4A54B60", VA = "0x184A55D60")]
	public void CDAPGCOOMNL(KEJDIMPLCLC HKMGFGHHFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80")]
	public void AEIKNLHMHBB(int KEPBGOPOINM, ANIFLBHPAHJ JCLPOJGKHIL, int AEDKEKILPBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A55E00", Offset = "0x4A54C00", VA = "0x184A55E00")]
	public void EJOFOMLNMFI(List<byte> GMMEJENOGLD, Vector3 EKDPPBPKOBN, float NIGPLNBEOHA, float CCLAPFCAOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4A55D00", Offset = "0x4A54B00", VA = "0x184A55D00")]
	public bool AEFFLEKJBDL(Vector3 AHEILJOHIAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4A56090", Offset = "0x4A54E90", VA = "0x184A56090")]
	public bool OLMFPAAPGAF(Vector3 AHEILJOHIAB, float AAKJCEALHCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class NNKCAKLMILA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly Dictionary<T, object> IAODIECICCE;

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x299E880", Offset = "0x299D680", VA = "0x18299E880")]
	public bool GJGMPBDNBNN(T JCJOIEKLLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF3E0", Offset = "0x3ECE1E0", VA = "0x183ECF3E0")]
	public bool GJGMPBDNBNN(T JCJOIEKLLGO, object BKGLGBGKANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF420", Offset = "0x3ECE220", VA = "0x183ECF420")]
	public bool GJGMPBDNBNN(T JCJOIEKLLGO, object BKGLGBGKANA, out object OGIIDIHPJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF3A0", Offset = "0x3ECE1A0", VA = "0x183ECF3A0")]
	public bool DMEKICBABBI(T JCJOIEKLLGO, object BKGLGBGKANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF480", Offset = "0x3ECE280", VA = "0x183ECF480")]
	public bool JKHIFMDDBLC(T JCJOIEKLLGO, object BKGLGBGKANA, out object OGIIDIHPJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF310", Offset = "0x3ECE110", VA = "0x183ECF310")]
	public bool DMEKICBABBI(T JCJOIEKLLGO, object BKGLGBGKANA, out object OGIIDIHPJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF2E0", Offset = "0x3ECE0E0", VA = "0x183ECF2E0")]
	public void CPBPGHFMNHD(T JCJOIEKLLGO, object BKGLGBGKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF4C0", Offset = "0x3ECE2C0", VA = "0x183ECF4C0")]
	public void MLIKDPGJGJD(T JCJOIEKLLGO, object BKGLGBGKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF560", Offset = "0x3ECE360", VA = "0x183ECF560")]
	public NNKCAKLMILA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public struct DHDNIGKCNOA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly List<Component> FGJKCCCHKBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private readonly bool PMMOBPENCNA;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x792640", Offset = "0x791440", VA = "0x180792640")]
			public DHDNIGKCNOA(List<Component> FGJKCCCHKBO, bool PMMOBPENCNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x1B5A210", Offset = "0x1B59010", VA = "0x181B5A210")]
			public NNKKPMAMJAO<T> OKDONKEHBHE()
			{
				return default(NNKKPMAMJAO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x1B5A280", Offset = "0x1B59080", VA = "0x181B5A280", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x1B5A280", Offset = "0x1B59080", VA = "0x181B5A280", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public struct NNKKPMAMJAO<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private readonly List<Component> FGJKCCCHKBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private readonly bool PMMOBPENCNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private int CKPFCCCIOFE;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T ENNKBELIDPE
			{
				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x1B639B0", Offset = "0x1B627B0", VA = "0x181B639B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x1B63940", Offset = "0x1B62740", VA = "0x181B63940", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x1B63980", Offset = "0x1B62780", VA = "0x181B63980")]
			public NNKKPMAMJAO(List<Component> FGJKCCCHKBO, bool PMMOBPENCNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x1B63870", Offset = "0x1B62670", VA = "0x181B63870", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x1B63880", Offset = "0x1B62680", VA = "0x181B63880", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x1B63930", Offset = "0x1B62730", VA = "0x181B63930", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A220", Offset = "0x4A59020", VA = "0x184A5A220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x4A5A1E0", Offset = "0x4A58FE0", VA = "0x184A5A1E0")]
		public ToolHierarchyCache(GameObject CNCMMDKCLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x4A5A060", Offset = "0x4A58E60", VA = "0x184A5A060")]
		private void KMENDFCINBC(GameObject CNCMMDKCLOF, bool CHKACKLAPHG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x4A59FD0", Offset = "0x4A58DD0", VA = "0x184A59FD0")]
		public static void KMENDFCINBC(GameObject CNCMMDKCLOF, ref ToolHierarchyCache ENJCPECAECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x4A599C0", Offset = "0x4A587C0", VA = "0x184A599C0")]
		public void BBOLOGGJGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4A59BD0", Offset = "0x4A589D0", VA = "0x184A59BD0")]
		public void FKBLBBKNAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1C53620", Offset = "0x1C52420", VA = "0x181C53620")]
		public void GGALMCALHGH<T>(Action<T> JJOAKFFHFLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x4A59A90", Offset = "0x4A58890", VA = "0x184A59A90")]
		public Component EKMBFBDANOA(Type IDPNMFPNBCP, bool PMMOBPENCNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1C6FB80", Offset = "0x1C6E980", VA = "0x181C6FB80")]
		public T EKMBFBDANOA<T>(bool PMMOBPENCNA = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x4A59F40", Offset = "0x4A58D40", VA = "0x184A59F40")]
		public DHDNIGKCNOA<Component> KAEMLFNLJPP(Type IDPNMFPNBCP, bool PMMOBPENCNA = false)
		{
			return default(DHDNIGKCNOA<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2894AE0", Offset = "0x28938E0", VA = "0x182894AE0")]
		public DHDNIGKCNOA<T> KAEMLFNLJPP<T>(bool PMMOBPENCNA = false) where T : class
		{
			return default(DHDNIGKCNOA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4A59C90", Offset = "0x4A58A90", VA = "0x184A59C90")]
		public List<Component> HNPBIEAMJEO(Type IDPNMFPNBCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4A59B50", Offset = "0x4A58950", VA = "0x184A59B50", Slot = "4")]
		public bool Equals(ToolHierarchyCache ACPFKFODNNE, ToolHierarchyCache FFHJLCNGNED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4A59C20", Offset = "0x4A58A20", VA = "0x184A59C20", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache PJNABAALNPP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class MELHJMICJPA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int OIICMJBLBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private int KPOPDGAHAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private List<T> KJLHNGNBCDL;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1B5D410", Offset = "0x1B5C210", VA = "0x181B5D410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T COBFKKGAOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3B39630", Offset = "0x3B38430", VA = "0x183B39630")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T BOKBBOBNBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3B394E0", Offset = "0x3B382E0", VA = "0x183B394E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T HCJBLDBLOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x3B396B0", Offset = "0x3B384B0", VA = "0x183B396B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B39920", Offset = "0x3B38720", VA = "0x183B39920")]
	public MELHJMICJPA(int OIICMJBLBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B39850", Offset = "0x3B38650", VA = "0x183B39850")]
	public void PEIDOEKHNGH(T KNMEGDFKBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B39450", Offset = "0x3B38250", VA = "0x183B39450")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B393A0", Offset = "0x3B381A0", VA = "0x183B393A0")]
	public void EGACLJMIEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3B39490", Offset = "0x3B38290", VA = "0x183B39490")]
	public void INBCNAFDBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3B39440", Offset = "0x3B38240", VA = "0x183B39440")]
	public void EOBIOMEJFCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class JPFNOLIPBEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool JAOPCEMMGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Action JJOAKFFHFLE;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public static JPFNOLIPBEF JCFCPICHNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x4A55C60", Offset = "0x4A54A60", VA = "0x184A55C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool EFGCFHIDIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5477B0", Offset = "0x5465B0", VA = "0x1805477B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x855E20", Offset = "0x854C20", VA = "0x180855E20")]
	public JPFNOLIPBEF(Action JJOAKFFHFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4A55CE0", Offset = "0x4A54AE0", VA = "0x184A55CE0")]
	public void IANFCFBCFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4A55CE0", Offset = "0x4A54AE0", VA = "0x184A55CE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class EFPHDPOBGMD
{
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80")]
	public static void CNGFLJBDPKL(DFBGBJGFHAK HLPFMBEPJDM, string EDCOEJKPCJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class DANJNIHFFFK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private struct EIKNKGLICPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int AGDELCDJEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public T MKDOFJMDMOL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Dictionary<object, EIKNKGLICPD> AJNLPOOBFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private T IHEOFFGPJNP;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public virtual T KKFPFOFKPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x1319FD0", Offset = "0x1318DD0", VA = "0x181319FD0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x311B300", Offset = "0x311A100", VA = "0x18311B300", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool GMMDCPHEIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAFC0", Offset = "0x2BD9DC0", VA = "0x182BDAFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public object GJBJGEIBPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x51EDF0", Offset = "0x51DBF0", VA = "0x18051EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x546D70", Offset = "0x545B70", VA = "0x180546D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAD80", Offset = "0x2BD9B80", VA = "0x182BDAD80")]
	public bool CIJINLDFFEE(T KCFMHIDCDCO, object BKGLGBGKANA, int KHNKDIDPJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA940", Offset = "0x2BD9740", VA = "0x182BDA940")]
	public bool AEJMCCFPCLJ(object BKGLGBGKANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x34A11E0", Offset = "0x349FFE0", VA = "0x1834A11E0")]
	public bool MNODOEFIIGL(object BKGLGBGKANA, out T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAFF0", Offset = "0x2BD9DF0", VA = "0x182BDAFF0")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x349F4D0", Offset = "0x349E2D0", VA = "0x18349F4D0")]
	private bool HPPAPODFDPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE190", Offset = "0x2BDCF90", VA = "0x182BDE190")]
	public DANJNIHFFFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class HBDPLMDNEEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Dictionary<object, float> AJNLPOOBFON;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float HHAKPDAADBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xE372E0", Offset = "0xE360E0", VA = "0x180E372E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xD46220", Offset = "0xD45020", VA = "0x180D46220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4A55B10", Offset = "0x4A54910", VA = "0x184A55B10")]
	public void CIJINLDFFEE(float KCFMHIDCDCO, object BKGLGBGKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4A55980", Offset = "0x4A54780", VA = "0x184A55980")]
	public void AEJMCCFPCLJ(object BKGLGBGKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4A559F0", Offset = "0x4A547F0", VA = "0x184A559F0")]
	private void BJJHFELAFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4A55B80", Offset = "0x4A54980", VA = "0x184A55B80")]
	public HBDPLMDNEEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class DFBGBJGFHAK
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class GBJJFFHNMEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly string DOOLMDIFGDJ;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private GBJJFFHNMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x651320", Offset = "0x650120", VA = "0x180651320")]
		public GBJJFFHNMEL(string DOOLMDIFGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x4A54C10", Offset = "0x4A53A10", VA = "0x184A54C10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class EDJNEFEBLCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public EDJNEFEBLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4A54930", Offset = "0x4A53730", VA = "0x184A54930")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly HashSet<object> BJOKCOMFDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int MIPIDNDJIEM;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool CJPOHEPNKJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x4A54590", Offset = "0x4A53390", VA = "0x184A54590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5A8670", Offset = "0x5A7470", VA = "0x1805A8670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4A54510", Offset = "0x4A53310", VA = "0x184A54510")]
	public bool PEIDOEKHNGH(object BKGLGBGKANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4A54430", Offset = "0x4A53230", VA = "0x184A54430")]
	public bool FKDIFICKHIH(object BKGLGBGKANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A544B0", Offset = "0x4A532B0", VA = "0x184A544B0")]
	public bool MLBCOPDEJLG(object BKGLGBGKANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A543D0", Offset = "0x4A531D0", VA = "0x184A543D0")]
	public void FDHCKMNGLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4A545A0", Offset = "0x4A533A0", VA = "0x184A545A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4A54710", Offset = "0x4A53510", VA = "0x184A54710")]
	public DFBGBJGFHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class CEMHCOFMNIP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private struct PEFNIDBOAKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public float ILKHIGMMOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public T MKDOFJMDMOL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private Dictionary<object, PEFNIDBOAKA> AJNLPOOBFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private T BNHDFANGPAL;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public virtual T NBHBEKGOFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xFFEFA0", Offset = "0xFFDDA0", VA = "0x180FFEFA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x31D0780", Offset = "0x31CF580", VA = "0x1831D0780", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public object KEBEGPDADMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x544A30", Offset = "0x543830", VA = "0x180544A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x654540", Offset = "0x653340", VA = "0x180654540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool GMMDCPHEIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x31CE760", Offset = "0x31CD560", VA = "0x1831CE760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x31CE660", Offset = "0x31CD460", VA = "0x1831CE660")]
	public bool CIJINLDFFEE(T KCFMHIDCDCO, object BKGLGBGKANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x31CDFC0", Offset = "0x31CCDC0", VA = "0x1831CDFC0")]
	public bool AEJMCCFPCLJ(object BKGLGBGKANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAFF0", Offset = "0x2BD9DF0", VA = "0x182BDAFF0")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x31D0450", Offset = "0x31CF250", VA = "0x1831D0450")]
	public bool MNODOEFIIGL(object BKGLGBGKANA, out T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x31CF1F0", Offset = "0x31CDFF0", VA = "0x1831CF1F0")]
	private bool HPPAPODFDPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x31D07A0", Offset = "0x31CF5A0", VA = "0x1831D07A0")]
	public CEMHCOFMNIP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class MLACDHJHDFG
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static byte[] PCFDJLIAIEK;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static int CNEHBAAIPJM;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static int NEIKIABHABD;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static BigInteger NOAFCEFHHAN;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public MLACDHJHDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4A56150", Offset = "0x4A54F50", VA = "0x184A56150")]
	private static string JLOFJIHEBDA(byte[] KBBKPHEOPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4A56250", Offset = "0x4A55050", VA = "0x184A56250")]
	public static string NCFNLEDFEPP(byte[] NBHAFAAIDII, bool IGLBINIMLIE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
