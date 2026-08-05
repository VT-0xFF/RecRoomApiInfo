using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NLCMENFHNOM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public NLCMENFHNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, JIAENDBFCCE, ENPLJMPIMCE, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash OMOOOOEKFCM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x835CD0", Offset = "0x8350D0", VA = "0x180835CD0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[OOBMKMHBHAE]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[OOBMKMHBHAE]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8A90", Offset = "0x5CA7E90", VA = "0x185CA8A90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8A50", Offset = "0x5CA7E50", VA = "0x185CA8A50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8AD0", Offset = "0x5CA7ED0", VA = "0x185CA8AD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8C80", Offset = "0x5CA8080", VA = "0x185CA8C80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8BF0", Offset = "0x5CA7FF0", VA = "0x185CA8BF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FA0", Offset = "0x8A93A0", VA = "0x1808A9FA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x855690", Offset = "0x854A90", VA = "0x180855690")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8A10", Offset = "0x5CA7E10", VA = "0x185CA8A10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8B60", Offset = "0x5CA7F60", VA = "0x185CA8B60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8480", Offset = "0x5CA7880", VA = "0x185CA8480")]
	public void CopyBounds(SavedExtents KEEHOGPOIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8960", Offset = "0x5CA7D60", VA = "0x185CA8960")]
	public void SetLocalSpaceBounds(Bounds ELJHFJBBCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8877B0", Offset = "0x886BB0", VA = "0x1808877B0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8950", Offset = "0x5CA7D50", VA = "0x185CA8950")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CA84B0", Offset = "0x5CA78B0", VA = "0x185CA84B0")]
	private void IENLAKFPMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8730", Offset = "0x5CA7B30", VA = "0x185CA8730")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7E10", Offset = "0x5CA7210", VA = "0x185CA7E10")]
	public static void CalculateLocalBoundsFor(GameObject GHAOKLKOOCA, [Out] Bounds ELJHFJBBCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8670", Offset = "0x5CA7A70", VA = "0x185CA8670")]
	private static void OPFBBAAPOAO(Bounds OGHJEHJOFGN, Color EEFMDFBJECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8980", Offset = "0x5CA7D80", VA = "0x185CA8980")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x762180", Offset = "0x761580", VA = "0x180762180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7712D0", Offset = "0x7706D0", VA = "0x1807712D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC9BF50", Offset = "0xC9B350", VA = "0x180C9BF50")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4062410", Offset = "0x4061810", VA = "0x184062410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
	public virtual void NEFBFDELFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[NLCMENFHNOM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4061FF0", Offset = "0x40613F0", VA = "0x184061FF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4060C90", Offset = "0x4060090", VA = "0x184060C90", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4062340", Offset = "0x4061740", VA = "0x184062340")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MLPODABFICF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MLPODABFICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3B813E0", Offset = "0x3B807E0", VA = "0x183B813E0")]
		internal int AKFCELECJAG(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[NLCMENFHNOM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3053C90", Offset = "0x3053090", VA = "0x183053C90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3053CE0", Offset = "0x30530E0", VA = "0x183053CE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3053B90", Offset = "0x3052F90", VA = "0x183053B90", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey IHHOPACLNAK]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3053C30", Offset = "0x3053030", VA = "0x183053C30", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3053A70", Offset = "0x3052E70", VA = "0x183053A70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3053790", Offset = "0x3052B90", VA = "0x183053790", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3052C30", Offset = "0x3052030", VA = "0x183052C30", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3052C00", Offset = "0x3052000", VA = "0x183052C00", Slot = "14")]
	protected virtual string ONABJKJCECP(TKeyVal BFGGAIAJKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3052AB0", Offset = "0x3051EB0", VA = "0x183052AB0", Slot = "4")]
	public bool ContainsKey(TKey IHHOPACLNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3053930", Offset = "0x3052D30", VA = "0x183053930", Slot = "5")]
	public bool TryGetValue(TKey IHHOPACLNAK, [Out] TVal LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3052B00", Offset = "0x3051F00", VA = "0x183052B00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3052B00", Offset = "0x3051F00", VA = "0x183052B00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3053980", Offset = "0x3052D80", VA = "0x183053980")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NEEFPINNGOM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AGDHFONLGKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public AGDHFONLGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x34B99B0", Offset = "0x34B8DB0", VA = "0x1834B99B0")]
		internal bool OHEKOKANBAI(KPDLCEIOGLA<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float EEKAGBCDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float IDKAOJGKFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<KPDLCEIOGLA<float, T>> DNKOOLIMCJE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AODPLNFAIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFD80", Offset = "0x3BCF180", VA = "0x183BCFD80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD07D0", Offset = "0x3BCFBD0", VA = "0x183BD07D0")]
	public NEEFPINNGOM(float EMJMHMGHMME, float PEBDAIJACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3BCFFF0", Offset = "0x3BCF3F0", VA = "0x183BCFFF0")]
	public bool CLGCCKLFIGG(float OCOBDBFPKCG, T LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0490", Offset = "0x3BCF890", VA = "0x183BD0490")]
	public IEnumerable<T> ENBHDHAKJAG(float OCOBDBFPKCG, [Optional] float? LCOEGAJEGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3BD07A0", Offset = "0x3BCFBA0", VA = "0x183BD07A0")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3BCFCA0", Offset = "0x3BCF0A0", VA = "0x183BCFCA0")]
	private void BCDJDJKDJKM(float OCOBDBFPKCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class KBEJDBCDMML<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CJNJHJAGOMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T OFPAGNFLHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float ICBIFNOBJAF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float KGDOOFGNNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> DDDBJNHNBAL;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int CKMOCAKCPCE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CJNJHJAGOMD[] FOAJABBKLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int OIBPILMEDCN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float BFIMNOIJLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA71EC0", Offset = "0xA712C0", VA = "0x180A71EC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA71ED0", Offset = "0xA712D0", VA = "0x180A71ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37E17F0", Offset = "0x37E0BF0", VA = "0x1837E17F0")]
	public KBEJDBCDMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x37E1700", Offset = "0x37E0B00", VA = "0x1837E1700")]
	public KBEJDBCDMML(int JGDHMDLNCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x37E0870", Offset = "0x37DFC70", VA = "0x1837E0870")]
	public void GIHKKMKIIOJ(float OCOBDBFPKCG, T LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x37E1130", Offset = "0x37E0530", VA = "0x1837E1130")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37E0C70", Offset = "0x37E0070", VA = "0x1837E0C70")]
	public bool GNNNOIPBPFP(float DABBGBCMHPI, float DHHHBJCONFF, [Out] T LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x37E1310", Offset = "0x37E0710", VA = "0x1837E1310")]
	public bool PHBAFOFFMLE(float DABBGBCMHPI, float DHHHBJCONFF, [Out] T LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x37E0FC0", Offset = "0x37E03C0", VA = "0x1837E0FC0")]
	public void HAFBNCOGCFC(float DABBGBCMHPI, float DHHHBJCONFF, List<T> DOGIBAMCGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x37E1100", Offset = "0x37E0500", VA = "0x1837E1100")]
	private int LECNADCAPNN(int EBGFBBGMLFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x37E0820", Offset = "0x37DFC20", VA = "0x1837E0820")]
	private void FDOFDJKFKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BCJDLJHCGJA();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T AIHDEOGABIC(T LPCGJALKADL, float BFGAGBINHNP);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T ONKBFHMANPO(T IOJNHOGOOGI, T IODCBCAEEGP);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T KIPFNHCNCCO(T IOJNHOGOOGI, T IODCBCAEEGP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IJKDBGFEDDD : KBEJDBCDMML<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0", Slot = "4")]
	protected override Vector3 BCJDLJHCGJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5F10", Offset = "0x5CA5310", VA = "0x185CA5F10", Slot = "5")]
	protected override Vector3 AIHDEOGABIC(Vector3 LPCGJALKADL, float BFGAGBINHNP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5FD0", Offset = "0x5CA53D0", VA = "0x185CA5FD0", Slot = "6")]
	protected override Vector3 ONKBFHMANPO(Vector3 IOJNHOGOOGI, Vector3 IODCBCAEEGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5F50", Offset = "0x5CA5350", VA = "0x185CA5F50", Slot = "7")]
	protected override Vector3 KIPFNHCNCCO(Vector3 IOJNHOGOOGI, Vector3 IODCBCAEEGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6020", Offset = "0x5CA5420", VA = "0x185CA6020")]
	public IJKDBGFEDDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PKNIEKMBLPD
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2550840", Offset = "0x254FC40", VA = "0x182550840")]
	public static KPDLCEIOGLA<T1, T2> PJBIIEEDKDI<T1, T2>(T1 FOLBDKCEHPJ, T2 OLGEINOFJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25508C0", Offset = "0x254FCC0", VA = "0x1825508C0")]
	public static HNPIGGMOHED<T1, T2, T3> PJBIIEEDKDI<T1, T2, T3>(T1 FOLBDKCEHPJ, T2 OLGEINOFJJH, T3 AONCKIPMOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB95B0", Offset = "0x3BB89B0", VA = "0x183BB95B0")]
	internal static int FOHGFFOKLFL(int JMIMHAFIHNH, int IIKLDDNKFDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x51D0100", Offset = "0x51CF500", VA = "0x1851D0100")]
	internal static int FOHGFFOKLFL(int JMIMHAFIHNH, int IIKLDDNKFDM, int GDKJJNFOFBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KPDLCEIOGLA<T1, T2> : IComparable<KPDLCEIOGLA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 AGGPHBNEJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 FLDEPMCGEIP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x383A440", Offset = "0x3839840", VA = "0x18383A440")]
	public KPDLCEIOGLA(T1 FOLBDKCEHPJ, T2 OLGEINOFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x38386A0", Offset = "0x3837AA0", VA = "0x1838386A0", Slot = "4")]
	public int CompareTo(KPDLCEIOGLA<T1, T2> KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3838B30", Offset = "0x3837F30", VA = "0x183838B30", Slot = "0")]
	public override bool Equals(object KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3839560", Offset = "0x3838960", VA = "0x183839560", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3839B90", Offset = "0x3838F90", VA = "0x183839B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HNPIGGMOHED<T1, T2, T3> : IComparable<HNPIGGMOHED<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 AGGPHBNEJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 FLDEPMCGEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 CEJIIIJLBNA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x352DDD0", Offset = "0x352D1D0", VA = "0x18352DDD0")]
	public HNPIGGMOHED(T1 FOLBDKCEHPJ, T2 OLGEINOFJJH, T3 AONCKIPMOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x352D490", Offset = "0x352C890", VA = "0x18352D490", Slot = "4")]
	public int CompareTo(HNPIGGMOHED<T1, T2, T3> KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x352D710", Offset = "0x352CB10", VA = "0x18352D710", Slot = "0")]
	public override bool Equals(object KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x352D9D0", Offset = "0x352CDD0", VA = "0x18352D9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x352DB00", Offset = "0x352CF00", VA = "0x18352DB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T OFPAGNFLHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E22800", Offset = "0x1E21C00", VA = "0x181E22800")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E22750", Offset = "0x1E21B50", VA = "0x181E22750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float CMNHFECJPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA17630", Offset = "0xA16A30", VA = "0x180A17630")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4267140", Offset = "0x4266540", VA = "0x184267140")]
	public T FIDKODMNJHA(float BFGAGBINHNP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4266E20", Offset = "0x4266220", VA = "0x184266E20")]
	public T BGDOMIBELCM(float BFGAGBINHNP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JKJFKPLFGOE(T IOJNHOGOOGI, T IODCBCAEEGP, float BFGAGBINHNP);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5C80", Offset = "0x5CA5080", VA = "0x185CA5C80", Slot = "4")]
	protected override float JKJFKPLFGOE(float IOJNHOGOOGI, float IODCBCAEEGP, float BFGAGBINHNP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5CC0", Offset = "0x5CA50C0", VA = "0x185CA5CC0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xB51F70", Offset = "0xB51370", VA = "0x180B51F70", Slot = "4")]
	protected override Vector3 JKJFKPLFGOE(Vector3 IOJNHOGOOGI, Vector3 IODCBCAEEGP, float BFGAGBINHNP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9990", Offset = "0x5CA8D90", VA = "0x185CA9990")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4860", Offset = "0x5CA3C60", VA = "0x185CA4860", Slot = "4")]
	protected override Color JKJFKPLFGOE(Color IOJNHOGOOGI, Color IODCBCAEEGP, float BFGAGBINHNP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4920", Offset = "0x5CA3D20", VA = "0x185CA4920")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LDJEOAHGPCB : HLKGABEOMFE<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CA63B0", Offset = "0x5CA57B0", VA = "0x185CA63B0")]
	public LDJEOAHGPCB(int ACGAEDNGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6340", Offset = "0x5CA5740", VA = "0x185CA6340", Slot = "6")]
	protected override uint JAGCIJHJOEC(uint OMOOOOEKFCM, string LPCGJALKADL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FIJFEFDNPKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable OMCMBELJBID;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FIJFEFDNPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ECDABOGJJMI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CLCNGAGHJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int PDEPPDMDBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int BDHKBKBNGAO;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3018720", Offset = "0x3017B20", VA = "0x183018720")]
	private ECDABOGJJMI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BPCPNGOJCKM, int NAOACLPLDEH, int NDCIEIBPMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3017240", Offset = "0x3016640", VA = "0x183017240")]
	public static ECDABOGJJMI<T> CLFIPFKIGEN()
	{
		return default(ECDABOGJJMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x30179E0", Offset = "0x3016DE0", VA = "0x1830179E0")]
	public (int, int, Task<T>) PJDKKKHONLL(int PAHAEGCNKGC, [Optional] CancellationToken OMFABMCIOAC, double OJILNLBEDDP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3017050", Offset = "0x3016450", VA = "0x183017050")]
	public void BPGIDCCDAOL(int PAHAEGCNKGC, int NDCIEIBPMPI, [In] T BBHPNPGLHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ABMIDJDEOCN
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4500", Offset = "0x5CA3900", VA = "0x185CA4500")]
	public static ECDABOGJJMI<EOKBOBHHEEM> CLFIPFKIGEN()
	{
		return default(ECDABOGJJMI<EOKBOBHHEEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4480", Offset = "0x5CA3880", VA = "0x185CA4480")]
	public static void BPGIDCCDAOL([In] this ECDABOGJJMI<EOKBOBHHEEM> CLFMFOEGLFG, int PAHAEGCNKGC, int NDCIEIBPMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class EKPLPHLDHGP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> HLPBOIPKIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> FNLKNMOIEHP;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2EC64F0", Offset = "0x2EC58F0", VA = "0x182EC64F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DNCECCDBGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> OFGGBHEKPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x302BD30", Offset = "0x302B130", VA = "0x18302BD30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> BAJBGMLDIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x302BD70", Offset = "0x302B170", VA = "0x18302BD70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x302BC80", Offset = "0x302B080", VA = "0x18302BC80", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x302BDB0", Offset = "0x302B1B0", VA = "0x18302BDB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x302B5F0", Offset = "0x302A9F0", VA = "0x18302B5F0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x302B3F0", Offset = "0x302A7F0", VA = "0x18302B3F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x302BAB0", Offset = "0x302AEB0", VA = "0x18302BAB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x302B3C0", Offset = "0x302A7C0", VA = "0x18302B3C0", Slot = "9")]
	public void Add(TKey IHHOPACLNAK, TVal LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x302B350", Offset = "0x302A750", VA = "0x18302B350", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IBHHDIJNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x302B450", Offset = "0x302A850", VA = "0x18302B450", Slot = "8")]
	public bool ContainsKey(TKey IHHOPACLNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x302B4F0", Offset = "0x302A8F0", VA = "0x18302B4F0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x302B9D0", Offset = "0x302ADD0", VA = "0x18302B9D0", Slot = "10")]
	public bool Remove(TKey IHHOPACLNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x302BA30", Offset = "0x302AE30", VA = "0x18302BA30", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x302BB50", Offset = "0x302AF50", VA = "0x18302BB50", Slot = "11")]
	public bool TryGetValue(TKey IHHOPACLNAK, [Out] TVal LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x302B800", Offset = "0x302AC00", VA = "0x18302B800", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x302B520", Offset = "0x302A920", VA = "0x18302B520", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FOAJABBKLPB, int MHBLGNNCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x302B930", Offset = "0x302AD30", VA = "0x18302B930")]
	public bool ICNJHDADGEL(TVal IHHOPACLNAK, [Out] TKey LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x302B170", Offset = "0x302A570", VA = "0x18302B170")]
	private void AJFDOCNDLMC(TKey IHHOPACLNAK, TVal FLJKEGLJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x302B6D0", Offset = "0x302AAD0", VA = "0x18302B6D0")]
	private void EDPGLDNLHJD(TKey IHHOPACLNAK, TVal FLJKEGLJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x302AEF0", Offset = "0x302A2F0", VA = "0x18302AEF0")]
	private bool AEDMDCBICHP(TKey IHHOPACLNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x302BB90", Offset = "0x302AF90", VA = "0x18302BB90")]
	public EKPLPHLDHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class CAMJFJCAMJE<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CAMJFJCAMJE<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x30AD320", Offset = "0x30AC720", VA = "0x1830AD320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x30ADD80", Offset = "0x30AD180", VA = "0x1830ADD80")]
		public Enumerator(CAMJFJCAMJE<T> DOGIBAMCGBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x30AB570", Offset = "0x30AA970", VA = "0x1830AB570", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x30AC540", Offset = "0x30AB940", VA = "0x1830AC540", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x30AC390", Offset = "0x30AB790", VA = "0x1830AC390")]
		private void POHKIACPLFG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] KHOGJOHLCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int IPFIDMBBIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int MKBCHKHILOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int KAHINILDCOI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x48C3AB0", Offset = "0x48C2EB0", VA = "0x1848C3AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x48C2F60", Offset = "0x48C2360", VA = "0x1848C2F60")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x48C3B50", Offset = "0x48C2F50", VA = "0x1848C3B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x48C3E40", Offset = "0x48C3240", VA = "0x1848C3E40")]
	public CAMJFJCAMJE(int ACGAEDNGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x48C3820", Offset = "0x48C2C20", VA = "0x1848C3820")]
	public void GIHKKMKIIOJ(T BFGAGBINHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x48C3CA0", Offset = "0x48C30A0", VA = "0x1848C3CA0")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x48C30E0", Offset = "0x48C24E0", VA = "0x1848C30E0")]
	public void DPODAIHFPGM(int CHEGLPEPHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x48C3190", Offset = "0x48C2590", VA = "0x1848C3190")]
	public void FAGFIOFGAFJ(T[] FOAJABBKLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x48C2F20", Offset = "0x48C2320", VA = "0x1848C2F20")]
	public Enumerator DDJBJFDOGGC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x48C3D40", Offset = "0x48C3140", VA = "0x1848C3D40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x48C3D40", Offset = "0x48C3140", VA = "0x1848C3D40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x48C2B80", Offset = "0x48C1F80", VA = "0x1848C2B80")]
	private int DDDOOLNIMPG(int JPEMHHILGGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x48C3A80", Offset = "0x48C2E80", VA = "0x1848C3A80")]
	private int GIOPCOLJDBD(int JPEMHHILGGG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class GGDHDJBCLDM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> HLFOJBLLGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> NMLNNLIOHNF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x34824B0", Offset = "0x34818B0", VA = "0x1834824B0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x34823F0", Offset = "0x34817F0", VA = "0x1834823F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public GGDHDJBCLDM(Func<Internal, External> HLFOJBLLGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x34823A0", Offset = "0x34817A0", VA = "0x1834823A0")]
	public GGDHDJBCLDM(IReadOnlyList<Internal> NMLNNLIOHNF, Func<Internal, External> HLFOJBLLGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x34822C0", Offset = "0x34816C0", VA = "0x1834822C0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x32E3340", Offset = "0x32E2740", VA = "0x1832E3340", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LNPBAIDMOIO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> KBEPJMPMJHH(TRequest EJJHDDFDLOL, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum MPNKDHMJJNG
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class EPCCMOFEBME
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float ENMKCMOODDG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan OCHAOIDKGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int DLONGDMNHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public MPNKDHMJJNG IMNBDGLCPDG;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly EPCCMOFEBME DFAIJMEJABN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float HFKPAJBIOOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x303D9F0", Offset = "0x303CDF0", VA = "0x18303D9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan OHEKBDCJPMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x303DBB0", Offset = "0x303CFB0", VA = "0x18303DBB0")]
		public EPCCMOFEBME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct LLKKIJPEDPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest EJJHDDFDLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken OMFABMCIOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> PBBFJNMKHCI;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x38F9360", Offset = "0x38F8760", VA = "0x1838F9360")]
		public LLKKIJPEDPF(TRequest EJJHDDFDLOL, TaskCompletionSource<TResult> PBBFJNMKHCI, CancellationToken OMFABMCIOAC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct AGPFGFGHGEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LNPBAIDMOIO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x34C4F80", Offset = "0x34C4380", VA = "0x1834C4F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x34C5740", Offset = "0x34C4B40", VA = "0x1834C5740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct MGNGBDBILLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public LNPBAIDMOIO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private LLKKIJPEDPF <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3B67E80", Offset = "0x3B67280", VA = "0x183B67E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B68A30", Offset = "0x3B67E30", VA = "0x183B68A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource FHDFFAIHEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<LLKKIJPEDPF> GOLKJNEJKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EPCCMOFEBME KJHDDBMPHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly KBEPJMPMJHH KBOOCLBCODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task JHCMIIBPFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int HIEKKJLDFBE;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3926AF0", Offset = "0x3925EF0", VA = "0x183926AF0")]
	public LNPBAIDMOIO(KBEPJMPMJHH KBOOCLBCODL, [Optional] EPCCMOFEBME KJHDDBMPHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x39263E0", Offset = "0x39257E0", VA = "0x1839263E0")]
	public Task<TResult> IGMGDDFCFKA(TRequest EJJHDDFDLOL, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3925B60", Offset = "0x3924F60", VA = "0x183925B60")]
	private void DHCCDMMIBOA(LLKKIJPEDPF KLPPBAGPLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3926A20", Offset = "0x3925E20", VA = "0x183926A20")]
	[AsyncStateMachine(typeof(LNPBAIDMOIO<, >.AGPFGFGHGEG))]
	private Task OBFPFCFINJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x39252F0", Offset = "0x39246F0", VA = "0x1839252F0")]
	private LLKKIJPEDPF ALCGOLGIAAD()
	{
		return default(LLKKIJPEDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3925EE0", Offset = "0x39252E0", VA = "0x183925EE0")]
	[AsyncStateMachine(typeof(LNPBAIDMOIO<, >.MGNGBDBILLE))]
	private Task HPALOKMKNIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x39266A0", Offset = "0x3925AA0", VA = "0x1839266A0")]
	private void NDFLHIFILKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3925CB0", Offset = "0x39250B0", VA = "0x183925CB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class IBJBLMAKIGE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> NMLNNLIOHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> CMKKHNMKBJC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC64F0", Offset = "0x2EC58F0", VA = "0x182EC64F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DNCECCDBGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x35BC1B0", Offset = "0x35BB5B0", VA = "0x1835BC1B0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x35BC2D0", Offset = "0x35BB6D0", VA = "0x1835BC2D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x33DB5F0", Offset = "0x33DA9F0", VA = "0x1833DB5F0", Slot = "11")]
	public void Add(T IBHHDIJNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x35BB960", Offset = "0x35BAD60", VA = "0x1835BB960")]
	public bool BLCAOFNAEFJ(T IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x35BC020", Offset = "0x35BB420", VA = "0x1835BC020", Slot = "15")]
	public bool Remove(T IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x35BBAF0", Offset = "0x35BAEF0", VA = "0x1835BBAF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x33F8740", Offset = "0x33F7B40", VA = "0x1833F8740", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x35BBA20", Offset = "0x35BAE20", VA = "0x1835BBA20", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x35BBA80", Offset = "0x35BAE80", VA = "0x1835BBA80", Slot = "13")]
	public bool Contains(T IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x35BBAC0", Offset = "0x35BAEC0", VA = "0x1835BBAC0", Slot = "14")]
	public void CopyTo(T[] FOAJABBKLPB, int MHBLGNNCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x35BBB80", Offset = "0x35BAF80", VA = "0x1835BBB80", Slot = "6")]
	public int IndexOf(T IBHHDIJNMFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x35BBCB0", Offset = "0x35BB0B0", VA = "0x1835BBCB0", Slot = "7")]
	public void Insert(int JPEMHHILGGG, T IBHHDIJNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x35BBD90", Offset = "0x35BB190", VA = "0x1835BBD90", Slot = "8")]
	public void RemoveAt(int JPEMHHILGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x35BC0C0", Offset = "0x35BB4C0", VA = "0x1835BC0C0")]
	public IBJBLMAKIGE()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1EF9EB0", Offset = "0x1EF92B0", VA = "0x181EF9EB0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9020", Offset = "0x5CA8420", VA = "0x185CA9020")]
		public SerializedGuid([In] Guid HILDEDLDEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8D40", Offset = "0x5CA8140", VA = "0x185CA8D40")]
		public static SerializedGuid DPCOJODPHFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8EA0", Offset = "0x5CA82A0", VA = "0x185CA8EA0")]
		public static SerializedGuid JPLJLNGBLAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8F10", Offset = "0x5CA8310", VA = "0x185CA8F10")]
		public bool NAKHODPHEOC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8FF0", Offset = "0x5CA83F0", VA = "0x185CA8FF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8F70", Offset = "0x5CA8370", VA = "0x185CA8F70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8DC0", Offset = "0x5CA81C0", VA = "0x185CA8DC0", Slot = "7")]
		public bool Equals(SerializedGuid KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8E00", Offset = "0x5CA8200", VA = "0x185CA8E00", Slot = "0")]
		public override bool Equals(object IBBNLILJNEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8E90", Offset = "0x5CA8290", VA = "0x185CA8E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8D10", Offset = "0x5CA8110", VA = "0x185CA8D10", Slot = "6")]
		public int CompareTo(SerializedGuid KEEHOGPOIFD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CIBGCODMMAI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type KPEGEHKJJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string KDHJNEOGLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool FAPBHAFCFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool FCFLJJAFGKI;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5CA47F0", Offset = "0x5CA3BF0", VA = "0x185CA47F0")]
	public CIBGCODMMAI(Type CEPKFICJBII, string HBJCNCKAJFP, bool OHFJONJPHEO = false, bool FIHPCKHADJN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KGKDBPAMFIO<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct BEPBGMGEPCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long NICFGBJJGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long APGEJEFGIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int KFOHKPEKHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int MFAAMJHOPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool KJMEELCMFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string BLIMMHOHGLK;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x449A750", Offset = "0x4499B50", VA = "0x18449A750")]
		public BEPBGMGEPCH(long NICFGBJJGJO, int KFOHKPEKHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x449A720", Offset = "0x4499B20", VA = "0x18449A720")]
		public BEPBGMGEPCH(long NICFGBJJGJO, long APGEJEFGIJC, int KFOHKPEKHKD, int MFAAMJHOPFJ, bool KJMEELCMFEJ, string BLIMMHOHGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x449A670", Offset = "0x4499A70", VA = "0x18449A670")]
		public int HLLLMHEFEAA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x449A5B0", Offset = "0x44999B0", VA = "0x18449A5B0")]
		public int FIPBKPFAPBI(int IOAOFJPBIIM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x449A6C0", Offset = "0x4499AC0", VA = "0x18449A6C0")]
		public double OOLNBPOIJLL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x449A5D0", Offset = "0x44999D0", VA = "0x18449A5D0")]
		public BEPBGMGEPCH HLDMHPIPGNE(long APGEJEFGIJC, int MFAAMJHOPFJ)
		{
			return default(BEPBGMGEPCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class HDBHKIOKMPF : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct MGBLHOHCDFL<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public HDBHKIOKMPF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<HDBHKIOKMPF, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private HDBHKIOKMPF <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3B0C1C0", Offset = "0x3B0B5C0", VA = "0x183B0C1C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x35EDAF0", Offset = "0x35ECEF0", VA = "0x1835EDAF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey GJLBOFLDHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly KGKDBPAMFIO<TKey> LHJMFKIBCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly FJOGIBEAJHF AABDFOONPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<HDBHKIOKMPF> GGHLABPGGLC;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string KJOEPPDABGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3503E20", Offset = "0x3503220", VA = "0x183503E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<HDBHKIOKMPF> JCAOBOKADOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3503E50", Offset = "0x3503250", VA = "0x183503E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BEPBGMGEPCH AMFIADHEFLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3503E90", Offset = "0x3503290", VA = "0x183503E90")]
			[CompilerGenerated]
			get
			{
				return default(BEPBGMGEPCH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3503EB0", Offset = "0x35032B0", VA = "0x183503EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3503EE0", Offset = "0x35032E0", VA = "0x183503EE0")]
		internal HDBHKIOKMPF(KGKDBPAMFIO<TKey> LHJMFKIBCKM, TKey IHHOPACLNAK, FJOGIBEAJHF AABDFOONPNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3503CC0", Offset = "0x35030C0", VA = "0x183503CC0")]
		public HDBHKIOKMPF FBNLOFNDLDO(TKey IHHOPACLNAK, [Optional] FJOGIBEAJHF? GKHNNNGJILE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2148F80", Offset = "0x2148380", VA = "0x182148F80")]
		[AsyncStateMachine(typeof(MGBLHOHCDFL<>))]
		public Task<T> LBLPEFBELBH<T>(TKey IHHOPACLNAK, Func<HDBHKIOKMPF, Task<T>> LGMHODENKOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3503AC0", Offset = "0x3502EC0", VA = "0x183503AC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class PCEMOFGIKHD : IEnumerable<(TKey, List<TKey>, BEPBGMGEPCH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BEPBGMGEPCH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, BEPBGMGEPCH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public KGKDBPAMFIO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, BEPBGMGEPCH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, BEPBGMGEPCH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x35DEE50", Offset = "0x35DE250", VA = "0x1835DEE50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BEPBGMGEPCH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3DFA3A0", Offset = "0x3DF97A0", VA = "0x183DFA3A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x35DF070", Offset = "0x35DE470", VA = "0x1835DF070")]
		[DebuggerHidden]
		public PCEMOFGIKHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x32DE880", Offset = "0x32DDC80", VA = "0x1832DE880", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9DD0", Offset = "0x3DF91D0", VA = "0x183DF9DD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA1D0", Offset = "0x3DF95D0", VA = "0x183DFA1D0")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA350", Offset = "0x3DF9750", VA = "0x183DFA350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA290", Offset = "0x3DF9690", VA = "0x183DFA290", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BEPBGMGEPCH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x32E6F60", Offset = "0x32E6360", VA = "0x1832E6F60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PBGBMCFMHFN : IEnumerable<(TKey, List<TKey>, BEPBGMGEPCH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BEPBGMGEPCH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, BEPBGMGEPCH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private HDBHKIOKMPF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HDBHKIOKMPF <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KGKDBPAMFIO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<HDBHKIOKMPF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, BEPBGMGEPCH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, BEPBGMGEPCH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x35DEE50", Offset = "0x35DE250", VA = "0x1835DEE50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BEPBGMGEPCH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2F10", Offset = "0x3DA2310", VA = "0x183DA2F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x35DF070", Offset = "0x35DE470", VA = "0x1835DF070")]
		[DebuggerHidden]
		public PBGBMCFMHFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2F70", Offset = "0x3DA2370", VA = "0x183DA2F70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2540", Offset = "0x3DA1940", VA = "0x183DA2540", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2CF0", Offset = "0x3DA20F0", VA = "0x183DA2CF0")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2D50", Offset = "0x3DA2150", VA = "0x183DA2D50")]
		private void POMJOEIOKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2EC0", Offset = "0x3DA22C0", VA = "0x183DA2EC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2DB0", Offset = "0x3DA21B0", VA = "0x183DA2DB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BEPBGMGEPCH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2E90", Offset = "0x3DA2290", VA = "0x183DA2E90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, BEPBGMGEPCH, FJOGIBEAJHF> AEFMDKLEFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, BEPBGMGEPCH, FJOGIBEAJHF> DFGDGHLGMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<KGKDBPAMFIO<TKey>, FJOGIBEAJHF> CPBCAKBKJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HDBHKIOKMPF GPMKHPDEIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool CHCAJAAKAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int DJLMFANODCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch KLAOGAFPENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int EGEPMHJEHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string LKFAPEKHEOJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HDBHKIOKMPF KDBAJINAABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string KJOEPPDABGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x766620", Offset = "0x765A20", VA = "0x180766620")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x37F5950", Offset = "0x37F4D50", VA = "0x1837F5950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x37F5B10", Offset = "0x37F4F10", VA = "0x1837F5B10")]
	public KGKDBPAMFIO(TKey GFPJIIGMDGN, FJOGIBEAJHF AABDFOONPNL, [Optional] int? KFOHKPEKHKD, [Optional][CanBeNull] Stopwatch KLAOGAFPENM, [Optional] Action<TKey, BEPBGMGEPCH, FJOGIBEAJHF> AEFMDKLEFBJ, [Optional] Action<TKey, BEPBGMGEPCH, FJOGIBEAJHF> DFGDGHLGMKC, [Optional] Action<KGKDBPAMFIO<TKey>, FJOGIBEAJHF> CPBCAKBKJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x37F5840", Offset = "0x37F4C40", VA = "0x1837F5840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x37F59B0", Offset = "0x37F4DB0", VA = "0x1837F59B0")]
	[IteratorStateMachine(typeof(KGKDBPAMFIO<>.PCEMOFGIKHD))]
	public IEnumerable<(TKey, List<TKey>, BEPBGMGEPCH)> LJADPCMKCLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x37F5A40", Offset = "0x37F4E40", VA = "0x1837F5A40")]
	[IteratorStateMachine(typeof(KGKDBPAMFIO<>.PBGBMCFMHFN))]
	private IEnumerable<(TKey, List<TKey>, BEPBGMGEPCH)> LJADPCMKCLI(List<TKey> EOEPLCPMJAO, HDBHKIOKMPF HGEAEFJJKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x37F58D0", Offset = "0x37F4CD0", VA = "0x1837F58D0")]
	private (long, int) HLIMKLLIAIE()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class LNMMPDMOBPL<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JIHMENEKDFN(KGKDBPAMFIO<TKey> LHJMFKIBCKM);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected LNMMPDMOBPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class CBJCMOFACAG<TKey> : LNMMPDMOBPL<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string IGCHEDGDFBA(TKey IHHOPACLNAK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x48C3EC0", Offset = "0x48C32C0", VA = "0x1848C3EC0")]
	private static string DPGAMLBKFPC(TKey IHHOPACLNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x48C4050", Offset = "0x48C3450", VA = "0x1848C4050", Slot = "4")]
	public override string JIHMENEKDFN(KGKDBPAMFIO<TKey> LHJMFKIBCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x48C3F00", Offset = "0x48C3300", VA = "0x1848C3F00")]
	public string JIHMENEKDFN(KGKDBPAMFIO<TKey> LHJMFKIBCKM, [NotNull] IGCHEDGDFBA BOJMIKOAGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DENLHGCJDGH(KGKDBPAMFIO<TKey> LHJMFKIBCKM, [NotNull] IGCHEDGDFBA BOJMIKOAGLC);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3509780", Offset = "0x3508B80", VA = "0x183509780")]
	protected CBJCMOFACAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class IPLNNLHEFMB<TKey> : LNMMPDMOBPL<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string LGALFGODLBK(TKey IHHOPACLNAK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string LMBDPCOAJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double HMMENOOBDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool ABGEOLOFGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int BJCPMOLEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> AEJEIOCJBMH;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x35FF0E0", Offset = "0x35FE4E0", VA = "0x1835FF0E0")]
	private static string DPGAMLBKFPC(TKey IHHOPACLNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x35FFC50", Offset = "0x35FF050", VA = "0x1835FFC50")]
	public IPLNNLHEFMB(string LMBDPCOAJPA = "F2", double HMMENOOBDPC = double.MaxValue, bool ABGEOLOFGIP = false, int BJCPMOLEJOE = int.MaxValue, [Optional] ISet<string> AEJEIOCJBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x35FF7F0", Offset = "0x35FEBF0", VA = "0x1835FF7F0", Slot = "4")]
	public override Dictionary<string, string> JIHMENEKDFN(KGKDBPAMFIO<TKey> LHJMFKIBCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x35FF120", Offset = "0x35FE520", VA = "0x1835FF120")]
	private bool ENIDKNGMPKA(string LBKIHCICGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE600", VA = "0x1835FF200")]
	public Dictionary<string, string> JIHMENEKDFN(KGKDBPAMFIO<TKey> LHJMFKIBCKM, LGALFGODLBK BOJMIKOAGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x35FF8B0", Offset = "0x35FECB0", VA = "0x1835FF8B0")]
	private string NMLFJOPACEA(StringBuilder HCMKHOGIAJD, List<TKey> MLGPDPMMDAE, LGALFGODLBK BOJMIKOAGLC, bool COHJPBOCBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x35FFAF0", Offset = "0x35FEEF0", VA = "0x1835FFAF0")]
	private static void PPOMONKAGKK(StringBuilder BCHJOIGALEK, string BAJOINHMOPJ, bool AACAIGFJGGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OMCHCODNGHA<TKey> : CBJCMOFACAG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OODLEBOJEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IGCHEDGDFBA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static OMCHCODNGHA<TKey> OMCMBELJBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] ANLKCDAGJAB;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC930", Offset = "0x3CFBD30", VA = "0x183CFC930")]
	private OMCHCODNGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB9C0", Offset = "0x3CFADC0", VA = "0x183CFB9C0", Slot = "5")]
	protected override string DENLHGCJDGH(KGKDBPAMFIO<TKey> LHJMFKIBCKM, IGCHEDGDFBA BOJMIKOAGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB8D0", Offset = "0x3CFACD0", VA = "0x183CFB8D0")]
	[CompilerGenerated]
	internal static string ANDEKEMJMJD(string BIBJFEPFGPI, TKey IHHOPACLNAK, OODLEBOJEPK P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class GMHJEEKCNJJ : KGKDBPAMFIO<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class FMIADJIPBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<GMHJEEKCNJJ, FJOGIBEAJHF> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FMIADJIPBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5BF0", Offset = "0x5CA4FF0", VA = "0x185CA5BF0")]
		internal void LNAGCAFEOIM(KGKDBPAMFIO<string> timer, FJOGIBEAJHF log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5DC0", Offset = "0x5CA51C0", VA = "0x185CA5DC0")]
	public GMHJEEKCNJJ(FJOGIBEAJHF AABDFOONPNL, [Optional] string LEPIIJFBBEA, [Optional] int? KFOHKPEKHKD, [Optional] Stopwatch KLAOGAFPENM, [Optional] Action<string, BEPBGMGEPCH, FJOGIBEAJHF> AEFMDKLEFBJ, [Optional] Action<string, BEPBGMGEPCH, FJOGIBEAJHF> DFGDGHLGMKC, [Optional] Action<GMHJEEKCNJJ, FJOGIBEAJHF> CPBCAKBKJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5D00", Offset = "0x5CA5100", VA = "0x185CA5D00")]
	private static Action<KGKDBPAMFIO<string>, FJOGIBEAJHF> BCKIKNGLDNJ(Action<GMHJEEKCNJJ, FJOGIBEAJHF> AIBILCAOCLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class IKIEHCBHPIN
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class JJCJHHOKENO : IKIEHCBHPIN
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static IKIEHCBHPIN OMCMBELJBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5CA61F0", Offset = "0x5CA55F0", VA = "0x185CA61F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float NHOBHEGNFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1BFFFE0", Offset = "0x1BFF3E0", VA = "0x181BFFFE0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA62F0", Offset = "0x5CA56F0", VA = "0x185CA62F0")]
		public JJCJHHOKENO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static IKIEHCBHPIN AFFBKKHMCCG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static IKIEHCBHPIN DFAIJMEJABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5CA6080", Offset = "0x5CA5480", VA = "0x185CA6080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float NHOBHEGNFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected IKIEHCBHPIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MOIPOPDLJLN : HJHFLEOLGDF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7360", Offset = "0x5CA6760", VA = "0x185CA7360")]
	public MOIPOPDLJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HJHFLEOLGDF<T> : EGHLOMAONPH<T>, CMAKBFCDDAC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> OANGHOAEDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DMGBOCKAFMH<T> MFLOPLPPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x351F140", Offset = "0x351E540", VA = "0x18351F140")]
	public HJHFLEOLGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class POJHMDPFIEE<T> : EGHLOMAONPH<T>, CMAKBFCDDAC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> OANGHOAEDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DMGBOCKAFMH<T> MFLOPLPPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3E88790", Offset = "0x3E87B90", VA = "0x183E88790")]
	public POJHMDPFIEE(Exception BGPAKNDLMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface CMAKBFCDDAC : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EGHLOMAONPH<T> : CMAKBFCDDAC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> OANGHOAEDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	DMGBOCKAFMH<T> MFLOPLPPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class LOLIPNPNCBA<TTask, T> : EGHLOMAONPH<T>, CMAKBFCDDAC, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class AFECMGFGCAA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AFECMGFGCAA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x2EB65E0", Offset = "0x2EB59E0", VA = "0x182EB65E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x2EB6B50", Offset = "0x2EB5F50", VA = "0x182EB6B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LOLIPNPNCBA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public AFECMGFGCAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x34AD880", Offset = "0x34ACC80", VA = "0x1834AD880")]
		[AsyncStateMachine(typeof(LOLIPNPNCBA<, >.AFECMGFGCAA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> AIKNBCJFJKL(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static bool IIJPFPACBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Task<T> DJNEDNIILKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	protected readonly CancellationTokenSource HFJACFBDGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool CHCAJAAKAHP;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task<T> OANGHOAEDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DMGBOCKAFMH<T> MFLOPLPPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7E06E0", Offset = "0x7DFAE0", VA = "0x1807E06E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3928170", Offset = "0x3927570", VA = "0x183928170")]
	static LOLIPNPNCBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3928390", Offset = "0x3927790", VA = "0x183928390")]
	protected LOLIPNPNCBA(TTask DJNEDNIILKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3927DE0", Offset = "0x39271E0", VA = "0x183927DE0", Slot = "1")]
	~LOLIPNPNCBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x38C2640", Offset = "0x38C1A40", VA = "0x1838C2640", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3927E70", Offset = "0x3927270", VA = "0x183927E70")]
	private void OCOEOHNAACP(bool NKJHEIKGOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MCPJPDLGMML(TTask EEPJFCLMNMK);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HAGKJBMJNBC();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PKEFBHDGLBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5CA74C0", Offset = "0x5CA68C0", VA = "0x185CA74C0")]
	[NotNull]
	public static byte[] CEKJFLEJJFK(this JIAENDBFCCE KBCPOGIBIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7530", Offset = "0x5CA6930", VA = "0x185CA7530")]
	[NotNull]
	public static byte[] CEKJFLEJJFK(this JIAENDBFCCE KBCPOGIBIOH, HashAlgorithmName FMCMPPJIFBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA75A0", Offset = "0x5CA69A0", VA = "0x185CA75A0")]
	public static bool OKNBPEHMJEB([CanBeNull] this JIAENDBFCCE KBCPOGIBIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7730", Offset = "0x5CA6B30", VA = "0x185CA7730")]
	public static bool OKNBPEHMJEB([CanBeNull] this JIAENDBFCCE KBCPOGIBIOH, [Out] string NJAPBBBJJNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CA73A0", Offset = "0x5CA67A0", VA = "0x185CA73A0")]
	private static bool BGEDFDDJPJK([NotNull] JIAENDBFCCE KBCPOGIBIOH, [Out][CanBeNull] byte[] LKAFAOMPGGI, [Out][CanBeNull] byte[] HBNILNJBLAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class AHGBOABLCGN
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4550", Offset = "0x5CA3950", VA = "0x185CA4550")]
	[NotNull]
	public static byte[] CEKJFLEJJFK(this ENPLJMPIMCE AIBAHHENEKC, HashAlgorithmName FMCMPPJIFBM, byte[] IDJDIMHPMCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface ENPLJMPIMCE
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash OMOOOOEKFCM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JIAENDBFCCE : ENPLJMPIMCE
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[CanBeNull]
	byte[] KNGLMPDEINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] ENHOJPABLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DPOFGJMIGJO
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> KJEDPCMIJKI;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool MAJHBIFPBHJ;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5000", Offset = "0x5CA4400", VA = "0x185CA5000")]
	public static void JNOCLLGEHLM(this IncrementalHash GDIBLFHHIIA, [CanBeNull] GameObject GHAOKLKOOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2237B10", Offset = "0x2236F10", VA = "0x182237B10")]
	public static void JNOCLLGEHLM<T>(this IncrementalHash GDIBLFHHIIA, [CanBeNull] T FNPIKAPNGBE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2237A80", Offset = "0x2236E80", VA = "0x182237A80")]
	public static void EFIGBNNMMKA<T>(this IncrementalHash GDIBLFHHIIA, [CanBeNull] T AIBAHHENEKC) where T : ENPLJMPIMCE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2237BD0", Offset = "0x2236FD0", VA = "0x182237BD0")]
	public static void MOCAFFGNIAH<T>(this IncrementalHash GDIBLFHHIIA, [CanBeNull] IList<T> NJNBBADOFPE) where T : ENPLJMPIMCE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5CA50E0", Offset = "0x5CA44E0", VA = "0x185CA50E0")]
	private static bool KMDNEHJMJDE([CanBeNull] ENPLJMPIMCE AIBAHHENEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4E90", Offset = "0x5CA4290", VA = "0x185CA4E90")]
	public static void EBPODPLJFBB(this IncrementalHash OMOOOOEKFCM, [CanBeNull] string MIDBDBPLFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4960", Offset = "0x5CA3D60", VA = "0x185CA4960")]
	public static void ABBDGKEFCHO(this IncrementalHash OMOOOOEKFCM, long GACNEKKDGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5170", Offset = "0x5CA4570", VA = "0x185CA5170")]
	public static void LAOILBLPNDO(this IncrementalHash OMOOOOEKFCM, int DGAPPGMADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5400", Offset = "0x5CA4800", VA = "0x185CA5400")]
	public static void PHECFIPPNNC(this IncrementalHash OMOOOOEKFCM, short GJPDCHEGKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4EF0", Offset = "0x5CA42F0", VA = "0x185CA4EF0")]
	public static void HIILMPDEBBK(this IncrementalHash OMOOOOEKFCM, byte JIMLEODNMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4C60", Offset = "0x5CA4060", VA = "0x185CA4C60")]
	public static void AODIIPCEKMO(this IncrementalHash OMOOOOEKFCM, bool NHFKCFLKDKP, bool OPPPLLMFLON = false, bool KKBBLEIBPHC = false, bool BKBIDGIHPCM = false, bool LMFMNHPOAGK = false, bool NNJKHCEJKLO = false, bool EJDKOENAPBL = false, bool IDPFHEOAALO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2237450", Offset = "0x2236850", VA = "0x182237450")]
	public static void DAGOFOAIFJP<T>(this IncrementalHash OMOOOOEKFCM, T BMDIIPBLIGI) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA53A0", Offset = "0x5CA47A0", VA = "0x185CA53A0")]
	public static void OLLAFKBDBPF(this IncrementalHash OMOOOOEKFCM, float EFCLKDALODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5340", Offset = "0x5CA4740", VA = "0x185CA5340")]
	public static void NMIPCBDHMGG(this IncrementalHash OMOOOOEKFCM, ulong NEEECOMDFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4E30", Offset = "0x5CA4230", VA = "0x185CA4E30")]
	public static void CCBMKGECHPI(this IncrementalHash OMOOOOEKFCM, uint AIHLNKJJEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4DD0", Offset = "0x5CA41D0", VA = "0x185CA4DD0")]
	public static void APMEAKFOJIJ(this IncrementalHash OMOOOOEKFCM, ushort OCIELAJLCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4B30", Offset = "0x5CA3F30", VA = "0x185CA4B30")]
	public static void AEHHANCHGEH(this IncrementalHash OMOOOOEKFCM, Vector3 BCMOIOHDIKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CEMDFKLOGMB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4790", Offset = "0x5CA3B90", VA = "0x185CA4790")]
	public CEMDFKLOGMB(string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class OFPMBFNDJNF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal class MMEOAGHKCPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode CLFMFOEGLFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode DCLCDDGJKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public GKNIPCKMHNF IHFKPAFFFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<GKNIPCKMHNF> PDHHICNPMKM;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MMEOAGHKCPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal struct GKNIPCKMHNF : IComparable<GKNIPCKMHNF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int AIAPAIEHOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant LCABBEOPFJH;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA9A6B0", Offset = "0xA99AB0", VA = "0x180A9A6B0")]
		public GKNIPCKMHNF(int AIAPAIEHOOP, TClaimant LCABBEOPFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x349C670", Offset = "0x349BA70", VA = "0x18349C670")]
		public bool MJKCFACLFLH([In] GKNIPCKMHNF KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x349C6D0", Offset = "0x349BAD0", VA = "0x18349C6D0")]
		public bool OOEMCLDLNFJ([In] GKNIPCKMHNF KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x349C660", Offset = "0x349BA60", VA = "0x18349C660", Slot = "4")]
		public int CompareTo(GKNIPCKMHNF KEEHOGPOIFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x349C6E0", Offset = "0x349BAE0", VA = "0x18349C6E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum OPKPAFEPHFP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class COEGMNIMDJM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public OFPMBFNDJNF<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public COEGMNIMDJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4A984C0", Offset = "0x4A978C0", VA = "0x184A984C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4A98680", Offset = "0x4A97A80", VA = "0x184A98680", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4A985A0", Offset = "0x4A979A0", VA = "0x184A985A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x32DFCA0", Offset = "0x32DF0A0", VA = "0x1832DFCA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly EDBNJLNHOMP<MMEOAGHKCPB> EDAPEOIPGBO;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly EDBNJLNHOMP<List<GKNIPCKMHNF>> FOIIHHPOKGK;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int PADMFJPAEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> AGEJDHDKLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, MMEOAGHKCPB> IEPPAFIONGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private OPKPAFEPHFP OHCLHGENEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode NALNAGAMHFP(TNode BLMOEKLGDFI);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void FJEIEDBDGPF(TNode BLMOEKLGDFI, TClaimant OEMBFIDIJCG, TClaimant FAHCCEHBFGP);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3CCF1D0", Offset = "0x3CCE5D0", VA = "0x183CCF1D0")]
	public OFPMBFNDJNF(OPKPAFEPHFP OHCLHGENEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDE40", Offset = "0x3CCD240", VA = "0x183CCDE40")]
	public void DAAPEBEFPGP(TNode BLMOEKLGDFI, TNode KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDCB0", Offset = "0x3CCD0B0", VA = "0x183CCDCB0")]
	public void CEKPIMIHDKA(TClaimant LCABBEOPFJH, TNode JFBLNIGPOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDED0", Offset = "0x3CCD2D0", VA = "0x183CCDED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDAA0", Offset = "0x3CCCEA0", VA = "0x183CCDAA0")]
	private void BADNEFNCJML(TClaimant LCABBEOPFJH, TNode LCPFJGMIBJD, TNode JFBLNIGPOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDDD0", Offset = "0x3CCD1D0", VA = "0x183CCDDD0")]
	private int CEMEABMDLOE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3CCEAE0", Offset = "0x3CCDEE0", VA = "0x183CCEAE0")]
	private void PBEEOCFKFOG(TClaimant LCABBEOPFJH, TNode BGJKIIDOFOB, TNode JHJELAILOKH, int FILMGHFBFIA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE210", Offset = "0x3CCD610", VA = "0x183CCE210")]
	private void GEFMLEFCLKF(GKNIPCKMHNF PAHBGCLCEFB, MMEOAGHKCPB KIOBBALPIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE5E0", Offset = "0x3CCD9E0", VA = "0x183CCE5E0")]
	private void IPPNDBMCDBH(TClaimant LCABBEOPFJH, TNode BGJKIIDOFOB, TNode JHJELAILOKH, int FILMGHFBFIA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3CCEE20", Offset = "0x3CCE220", VA = "0x183CCEE20")]
	private void PBPKNFIJPNM(GKNIPCKMHNF PAHBGCLCEFB, TNode BLMOEKLGDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD9B0", Offset = "0x3CCCDB0", VA = "0x183CCD9B0")]
	private void AAEPIPLOOJC(GKNIPCKMHNF PAHBGCLCEFB, MMEOAGHKCPB KIOBBALPIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE9B0", Offset = "0x3CCDDB0", VA = "0x183CCE9B0")]
	private void NOGEPANJJFB(MMEOAGHKCPB KIOBBALPIHB, bool DCIABMOBIPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE2A0", Offset = "0x3CCD6A0", VA = "0x183CCE2A0")]
	private void HGELLMIPIBN(MMEOAGHKCPB KIOBBALPIHB, TNode KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3CCEF30", Offset = "0x3CCE330", VA = "0x183CCEF30")]
	[IteratorStateMachine(typeof(OFPMBFNDJNF<, >.COEGMNIMDJM))]
	private IEnumerable<TNode> PNNEHDFCKFF(TNode BGJKIIDOFOB, TNode JHJELAILOKH, bool MHINKAHLJAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE8C0", Offset = "0x3CCDCC0", VA = "0x183CCE8C0")]
	private MMEOAGHKCPB KFICIAEBEFA(TNode BLMOEKLGDFI, TNode DCLCDDGJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDB40", Offset = "0x3CCCF40", VA = "0x183CCDB40")]
	private MMEOAGHKCPB BDNPGAIHBDH(TNode BLMOEKLGDFI, TNode DCLCDDGJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE0A0", Offset = "0x3CCD4A0", VA = "0x183CCE0A0")]
	private void FEBBDJDLIAF(MMEOAGHKCPB KIOBBALPIHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class HLKGABEOMFE<T> : IEnumerable<HLKGABEOMFE<T>.GAMIPJHIKNI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct GAMIPJHIKNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T LPCGJALKADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int JPEMHHILGGG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class LHEJIIOBNNG : IEnumerator<GAMIPJHIKNI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private HLKGABEOMFE<T> HJKKEBPEJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int JPEMHHILGGG;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3054830", Offset = "0x3053C30", VA = "0x183054830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public GAMIPJHIKNI KCBEOJELDAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x38DBB60", Offset = "0x38DAF60", VA = "0x1838DBB60", Slot = "4")]
			get
			{
				return default(GAMIPJHIKNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x38DBA70", Offset = "0x38DAE70", VA = "0x1838DBA70")]
		public LHEJIIOBNNG(HLKGABEOMFE<T> HJKKEBPEJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x38DB9F0", Offset = "0x38DADF0", VA = "0x1838DB9F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x30A80D0", Offset = "0x30A74D0", VA = "0x1830A80D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x19EBE10", Offset = "0x19EB210", VA = "0x1819EBE10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct AEAIFDNHADA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool BDGAMJINBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T LPCGJALKADL;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int GGNJKCKDHJO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> CPHFJAKPDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private AEAIFDNHADA[] IEFIHNDBOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int DOJAKKEOJEI;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int OCLLLJPEACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7A3F30", Offset = "0x7A3330", VA = "0x1807A3F30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7A3BA0", Offset = "0x7A2FA0", VA = "0x1807A3BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2EC64F0", Offset = "0x2EC58F0", VA = "0x182EC64F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3524D90", Offset = "0x3524190", VA = "0x183524D90")]
	public HLKGABEOMFE(int ACGAEDNGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3525240", Offset = "0x3524640", VA = "0x183525240")]
	public HLKGABEOMFE(GAMIPJHIKNI[] EMOBEAOGBLA, bool DEGBBGKDKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3524A10", Offset = "0x3523E10", VA = "0x183524A10")]
	public int DEFLFCEKEIC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3524250", Offset = "0x3523650", VA = "0x183524250")]
	private int BHDIBGAHLII()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3524B70", Offset = "0x3523F70", VA = "0x183524B70", Slot = "6")]
	protected virtual uint JAGCIJHJOEC(uint OMOOOOEKFCM, T LPCGJALKADL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3524C70", Offset = "0x3524070", VA = "0x183524C70")]
	public bool OMCFKKOGGCG(T LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3524C00", Offset = "0x3524000", VA = "0x183524C00")]
	public int NKMOOBDOOIC(T LPCGJALKADL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3524440", Offset = "0x3523840", VA = "0x183524440")]
	public T BJNGDJMJIMK(int JPEMHHILGGG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3524710", Offset = "0x3523B10", VA = "0x183524710")]
	public bool BLCAOFNAEFJ(T LPCGJALKADL, bool MJPDFMDMNLF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3524500", Offset = "0x3523900", VA = "0x183524500")]
	public bool BLCAOFNAEFJ(T LPCGJALKADL, int JPEMHHILGGG, bool MJPDFMDMNLF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3524AF0", Offset = "0x3523EF0", VA = "0x183524AF0")]
	private int EOECHFEBMOB(int IPFIDMBBIMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3524D10", Offset = "0x3524110", VA = "0x183524D10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3524D10", Offset = "0x3524110", VA = "0x183524D10", Slot = "4")]
	private IEnumerator<GAMIPJHIKNI> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EDBNJLNHOMP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> DNFGPGJOLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> DANKCKKDBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int BOEDGBNADHC;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x301A330", Offset = "0x3019730", VA = "0x18301A330")]
	public static EDBNJLNHOMP<T> HBIJNIHPEKK(int ACGAEDNGFFD = 0, int BOEDGBNADHC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x301A6B0", Offset = "0x3019AB0", VA = "0x18301A6B0")]
	public EDBNJLNHOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x301A510", Offset = "0x3019910", VA = "0x18301A510")]
	public EDBNJLNHOMP(int ACGAEDNGFFD, int BOEDGBNADHC = int.MaxValue, bool MAKKBOACPKC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x301A1B0", Offset = "0x30195B0", VA = "0x18301A1B0")]
	public T FNHFAFDBPDO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3019DA0", Offset = "0x30191A0", VA = "0x183019DA0")]
	public void AGCMPNGAPHP(T LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x301A410", Offset = "0x3019810", VA = "0x18301A410")]
	private void LPCNINPEADF(T LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x301A4F0", Offset = "0x30198F0", VA = "0x18301A4F0")]
	private void MBBAFGCNCNB(T LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x301A070", Offset = "0x3019470", VA = "0x18301A070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3019E70", Offset = "0x3019270", VA = "0x183019E70")]
	private void BDKPHIFNLDM(IEnumerable<T> FDELOOBEEJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HILIFMMEMCF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> ABNKDGCABLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T POFFGAMBNOF;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T DEEFHECMDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x351D1D0", Offset = "0x351C5D0", VA = "0x18351D1D0")]
	public bool COLCALHNJEC(T LPCGJALKADL, int AIAPAIEHOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x351D2C0", Offset = "0x351C6C0", VA = "0x18351D2C0")]
	public bool DBOPCPAFBLG(int AIAPAIEHOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x351D570", Offset = "0x351C970", VA = "0x18351D570")]
	public T NJFBEMELOFI(int HCNEOCACJIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x351D870", Offset = "0x351CC70", VA = "0x18351D870")]
	private bool OPDHELGDHHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x351D330", Offset = "0x351C730", VA = "0x18351D330")]
	public bool ICNJHDADGEL(int AIAPAIEHOOP, [Out] T LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x351D910", Offset = "0x351CD10", VA = "0x18351D910")]
	public HILIFMMEMCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OBKGHKBEIDO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	protected struct DBDAELJMDHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T OFPAGNFLHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int IGOCHJLPHFP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<DBDAELJMDHP> KHOGJOHLCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T HIACOBLGLDO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2EC64F0", Offset = "0x2EC58F0", VA = "0x182EC64F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3CACE10", Offset = "0x3CAC210", VA = "0x183CACE10")]
	public bool KNNGDFDBEMF(T LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3CACBA0", Offset = "0x3CABFA0", VA = "0x183CACBA0")]
	public void GIHKKMKIIOJ(T LPCGJALKADL, int AIAPAIEHOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3CACC40", Offset = "0x3CAC040", VA = "0x183CACC40")]
	public bool HFJFDMFKDND(T LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3CACF90", Offset = "0x3CAC390", VA = "0x183CACF90")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3CACD90", Offset = "0x3CAC190", VA = "0x183CACD90")]
	public T IPIMAJKOOBI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3CACA40", Offset = "0x3CABE40", VA = "0x183CACA40")]
	private void COGCFNPPDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CACFF0", Offset = "0x3CAC3F0", VA = "0x183CACFF0")]
	public OBKGHKBEIDO()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		[BEGIBHGLGBK(OECFEFOEJFL.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7A10", Offset = "0x5CA6E10", VA = "0x185CA7A10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7CE0", Offset = "0x5CA70E0", VA = "0x185CA7CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7BF0", Offset = "0x5CA6FF0", VA = "0x185CA7BF0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7960", Offset = "0x5CA6D60", VA = "0x185CA7960")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7C30", Offset = "0x5CA7030", VA = "0x185CA7C30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7B40", Offset = "0x5CA6F40", VA = "0x185CA7B40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5CA78D0", Offset = "0x5CA6CD0", VA = "0x185CA78D0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x402A090", Offset = "0x4029490", VA = "0x18402A090", Slot = "4")]
		public virtual T PGBEBFJPJLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class MMKLOKBMLHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, EDMLFDLPIOE> HOMMNNJHNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly EDBNJLNHOMP<EDMLFDLPIOE> GDLJFCDDEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool CKIDBKLNJAO;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public EDMLFDLPIOE CIPLPEHLLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x764460", Offset = "0x763860", VA = "0x180764460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public Vector2 NLABLMPNCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA27C90", Offset = "0xA27090", VA = "0x180A27C90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xCC9B00", Offset = "0xCC8F00", VA = "0x180CC9B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private Vector2 BJNDINBCKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xD23980", Offset = "0xD22D80", VA = "0x180D23980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector2 AEPADLHKHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CA6EB0", Offset = "0x5CA62B0", VA = "0x185CA6EB0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x767960", Offset = "0x766D60", VA = "0x180767960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int OKOLACJCCFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x76DDA0", Offset = "0x76D1A0", VA = "0x18076DDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x76DDC0", Offset = "0x76D1C0", VA = "0x18076DDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6ED0", Offset = "0x5CA62D0", VA = "0x185CA6ED0")]
	public MMKLOKBMLHF(Bounds NHGJJLPBFOF, Vector2[] DIFAKHGCIHA, int FNOOPIEJAHG, byte IPFIDMBBIMG, float LPPNNHLCFBA = 0f, [Optional] EDBNJLNHOMP<EDMLFDLPIOE> GDLJFCDDEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6750", Offset = "0x5CA5B50", VA = "0x185CA6750")]
	public EDMLFDLPIOE FBKALMHGGEK(byte JPEMHHILGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6680", Offset = "0x5CA5A80", VA = "0x185CA6680")]
	public void EPGMPOJELLE(Vector3 BAONBICGOEJ, float MKBLFEIDCCG, float IKHAJBDPDPI, List<byte> KNMCJENGEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x19EE030", Offset = "0x19ED430", VA = "0x1819EE030")]
	public void HMIECEJJMBG(EDMLFDLPIOE.MLEMFMDEPKM HKDNALDGNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CA67B0", Offset = "0x5CA5BB0", VA = "0x185CA67B0")]
	public static int FPNFHGNCFEO(Vector2[] DIFAKHGCIHA, int FNOOPIEJAHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6900", Offset = "0x5CA5D00", VA = "0x185CA6900")]
	private EDMLFDLPIOE HMFAMNENODG(byte JPEMHHILGGG, EDMLFDLPIOE.OONOOOEEOAK BBGALHACICL, EDMLFDLPIOE DCLCDDGJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6B00", Offset = "0x5CA5F00", VA = "0x185CA6B00")]
	private void KLBBNOKDCJA(EDMLFDLPIOE DCLCDDGJKIC, Vector2[] DIFAKHGCIHA, int MGKNFENPLPD, int GKEDPDJDGII, int HPFHKNDGEIE, int LDNPNOEILPB, float LPPNNHLCFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6400", Offset = "0x5CA5800", VA = "0x185CA6400")]
	private void AGAJCIMKCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6620", Offset = "0x5CA5A20", VA = "0x185CA6620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CA68A0", Offset = "0x5CA5CA0", VA = "0x185CA68A0", Slot = "1")]
	~MMKLOKBMLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class EDMLFDLPIOE
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum OONOOOEEOAK
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum MLEMFMDEPKM
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public byte GDLLGPKKPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 ENEDKFDILDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 NLNGCCHEOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 IOMLJBHOPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 FOPOFNCEFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public OONOOOEEOAK MLGBHIJEFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public EDMLFDLPIOE KDDFGHHFEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<EDMLFDLPIOE> JPIOGNKDOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool JAPPFBOOJGJ;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5B50", Offset = "0x5CA4F50", VA = "0x185CA5B50")]
	public EDMLFDLPIOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CA59A0", Offset = "0x5CA4DA0", VA = "0x185CA59A0")]
	public void FFBCIDBKJPK(EDMLFDLPIOE PPNMHLJNNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public void HMIECEJJMBG(int GBGCGONKGKJ, MLEMFMDEPKM HKDNALDGNAH, int HIDEEOCDCBI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5740", Offset = "0x5CA4B40", VA = "0x185CA5740")]
	public void EPGMPOJELLE(List<byte> KNMCJENGEIG, Vector3 BAONBICGOEJ, float MKBLFEIDCCG, float IKHAJBDPDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CA56E0", Offset = "0x5CA4AE0", VA = "0x185CA56E0")]
	public bool BFOFHGDLIFO(Vector3 NODMEHJAHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5710", Offset = "0x5CA4B10", VA = "0x185CA5710")]
	public bool ELCPBBLILJC(Vector3 NODMEHJAHII, float CHCBKFOPJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5AC0", Offset = "0x5CA4EC0", VA = "0x185CA5AC0")]
	public void OMELHDOHHCI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct OBLNNIACJFF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> NMLNNLIOHNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool JCIGEEGCBLI;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x351CB00", Offset = "0x351BF00", VA = "0x18351CB00")]
			public OBLNNIACJFF(List<Component> NMLNNLIOHNF, bool JCIGEEGCBLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x3CAD090", Offset = "0x3CAC490", VA = "0x183CAD090")]
			public JAFMCBJPPDM<T> DDJBJFDOGGC()
			{
				return default(JAFMCBJPPDM<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x3CAD100", Offset = "0x3CAC500", VA = "0x183CAD100", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x3CAD100", Offset = "0x3CAC500", VA = "0x183CAD100", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct JAFMCBJPPDM<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> NMLNNLIOHNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool JCIGEEGCBLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int JPEMHHILGGG;

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public T KCBEOJELDAC
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0x376E500", Offset = "0x376D900", VA = "0x18376E500", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x376E490", Offset = "0x376D890", VA = "0x18376E490", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x376E4D0", Offset = "0x376D8D0", VA = "0x18376E4D0")]
			public JAFMCBJPPDM(List<Component> NMLNNLIOHNF, bool JCIGEEGCBLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x376E3D0", Offset = "0x376D7D0", VA = "0x18376E3D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x376E3E0", Offset = "0x376D7E0", VA = "0x18376E3E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x3097CF0", Offset = "0x30970F0", VA = "0x183097CF0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9490", Offset = "0x5CA8890", VA = "0x185CA9490")]
		private void OMELHDOHHCI(GameObject DHIHKCPMIMH, bool EAJNNLJOPDA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9600", Offset = "0x5CA8A00", VA = "0x185CA9600")]
		public static void OMELHDOHHCI(GameObject DHIHKCPMIMH, ToolHierarchyCache OGPEIJFPBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2680190", Offset = "0x267F590", VA = "0x182680190")]
		public void GOCDMCBNPOL<T>(Action<T> PAFFKHOCLGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2680120", Offset = "0x267F520", VA = "0x182680120")]
		public T EDECNAKJHCB<T>(bool JCIGEEGCBLI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x26803B0", Offset = "0x267F7B0", VA = "0x1826803B0")]
		public OBLNNIACJFF<T> NAFFCAGIGDC<T>(bool JCIGEEGCBLI = false) where T : class
		{
			return default(OBLNNIACJFF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9140", Offset = "0x5CA8540", VA = "0x185CA9140")]
		public List<Component> MPBCOBFNPNA(Type DJMKKNDNCBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9050", Offset = "0x5CA8450", VA = "0x185CA9050", Slot = "4")]
		public bool Equals(ToolHierarchyCache DCLOFHDPPBE, ToolHierarchyCache JMNKJKLHIOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CA90D0", Offset = "0x5CA84D0", VA = "0x185CA90D0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache IBBNLILJNEB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class MEMLGNHBPAE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int ACGAEDNGFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int LEPDGODJIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> PGHBEEJMEAP;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x337CA90", Offset = "0x337BE90", VA = "0x18337CA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public T LFNJHALOMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3B0B250", Offset = "0x3B0A650", VA = "0x183B0B250")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T LFKCIIGBIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3B0B180", Offset = "0x3B0A580", VA = "0x183B0B180")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T HOCGOPCNLDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3B0B100", Offset = "0x3B0A500", VA = "0x183B0B100")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B400", Offset = "0x3B0A800", VA = "0x183B0B400")]
	public MEMLGNHBPAE(int ACGAEDNGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B0AF90", Offset = "0x3B0A390", VA = "0x183B0AF90")]
	public void GIHKKMKIIOJ(T FLIPKOAKDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B3C0", Offset = "0x3B0A7C0", VA = "0x183B0B3C0")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B0AD70", Offset = "0x3B0A170", VA = "0x183B0AD70")]
	public void BHIIKMICACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B0AE40", Offset = "0x3B0A240", VA = "0x183B0AE40")]
	public void GGCAEFEMPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B090", Offset = "0x3B0A490", VA = "0x183B0B090")]
	public void HEGMPGHJJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LLHGKELGGFH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct NOPPDBBJEFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int IGOCHJLPHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T OFPAGNFLHNE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, NOPPDBBJEFA> ABNKDGCABLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> IPPJOIJCBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T POFFGAMBNOF;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public virtual T DEEFHECMDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xD6E3E0", Offset = "0xD6D7E0", VA = "0x180D6E3E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x38F4310", Offset = "0x38F3710", VA = "0x1838F4310", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool JHMBMEPFKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x38F3890", Offset = "0x38F2C90", VA = "0x1838F3890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public object LOABHCDIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x38F4130", Offset = "0x38F3530", VA = "0x1838F4130")]
	public bool COLCALHNJEC(T LPCGJALKADL, object IBLOMPOENGH, int AIAPAIEHOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x38F4270", Offset = "0x38F3670", VA = "0x1838F4270")]
	public bool DBOPCPAFBLG(object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x38F4530", Offset = "0x38F3930", VA = "0x1838F4530")]
	public bool ICNJHDADGEL(object IBLOMPOENGH, [Out] T LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x38F4B20", Offset = "0x38F3F20", VA = "0x1838F4B20")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x38F6B00", Offset = "0x38F5F00", VA = "0x1838F6B00")]
	private bool OPDHELGDHHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x38F7160", Offset = "0x38F6560", VA = "0x1838F7160")]
	public LLHGKELGGFH()
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
