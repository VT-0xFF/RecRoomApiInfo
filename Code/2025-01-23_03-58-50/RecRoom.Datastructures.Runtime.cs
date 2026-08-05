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
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F19010", Offset = "0x6F17810", VA = "0x186F19010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ECCCEBPMHPL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A1FEA0", Offset = "0x1A1E6A0", VA = "0x181A1FEA0")]
	public ECCCEBPMHPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, GKKEOMOJOEG, AKJCEEJIADN, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash MLPIEBMLKAM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9535A0", Offset = "0x951DA0", VA = "0x1809535A0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A220", Offset = "0x6F18A20", VA = "0x186F1A220")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A1E0", Offset = "0x6F189E0", VA = "0x186F1A1E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A260", Offset = "0x6F18A60", VA = "0x186F1A260")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A410", Offset = "0x6F18C10", VA = "0x186F1A410")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A380", Offset = "0x6F18B80", VA = "0x186F1A380")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB07540", Offset = "0xB05D40", VA = "0x180B07540")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x96C580", Offset = "0x96AD80", VA = "0x18096C580")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A1A0", Offset = "0x6F189A0", VA = "0x186F1A1A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A2F0", Offset = "0x6F18AF0", VA = "0x186F1A2F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F19C40", Offset = "0x6F18440", VA = "0x186F19C40")]
	public void CopyBounds(SavedExtents LIHCAHPMPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A0F0", Offset = "0x6F188F0", VA = "0x186F1A0F0")]
	public void SetLocalSpaceBounds(Bounds DFOLELGPECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xF876B0", Offset = "0xF85EB0", VA = "0x180F876B0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A0E0", Offset = "0x6F188E0", VA = "0x186F1A0E0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F19D30", Offset = "0x6F18530", VA = "0x186F19D30")]
	private void NKECAMJDDHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F19EE0", Offset = "0x6F186E0", VA = "0x186F19EE0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F195D0", Offset = "0x6F17DD0", VA = "0x186F195D0")]
	public static void CalculateLocalBoundsFor(GameObject PBJIFBOBIOP, [Out] Bounds DFOLELGPECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F19C70", Offset = "0x6F18470", VA = "0x186F19C70")]
	private static void EPDEIBBDMEF(Bounds NBDADAEEFHF, Color HPEMNIMCDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A110", Offset = "0x6F18910", VA = "0x186F1A110")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3A10", VA = "0x1808B5210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x13B3400", Offset = "0x13B1C00", VA = "0x1813B3400")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D570", Offset = "0x4E6BD70", VA = "0x184E6D570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
	public virtual void OMENDDHCFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	[ECCCEBPMHPL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D0E0", Offset = "0x4E6B8E0", VA = "0x184E6D0E0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BCB0", Offset = "0x4E6A4B0", VA = "0x184E6BCB0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D490", Offset = "0x4E6BC90", VA = "0x184E6D490")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KPBBBJJKFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public KPBBBJJKFFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4676B70", Offset = "0x4675370", VA = "0x184676B70")]
		internal int EPGBEMBAJHO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[ECCCEBPMHPL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB6F0", Offset = "0x3CF9EF0", VA = "0x183CFB6F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB750", Offset = "0x3CF9F50", VA = "0x183CFB750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB5D0", Offset = "0x3CF9DD0", VA = "0x183CFB5D0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey KCGKBDGKIOP]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB690", Offset = "0x3CF9E90", VA = "0x183CFB690", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB480", Offset = "0x3CF9C80", VA = "0x183CFB480", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB090", Offset = "0x3CF9890", VA = "0x183CFB090", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA450", Offset = "0x3CF8C50", VA = "0x183CFA450", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB270", Offset = "0x3CF9A70", VA = "0x183CFB270", Slot = "14")]
	protected virtual string PKBNGBKKDMP(TKeyVal KLPGNEJKOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA350", Offset = "0x3CF8B50", VA = "0x183CFA350", Slot = "4")]
	public bool ContainsKey(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB300", Offset = "0x3CF9B00", VA = "0x183CFB300", Slot = "5")]
	public bool TryGetValue(TKey KCGKBDGKIOP, [Out] TVal INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA3B0", Offset = "0x3CF8BB0", VA = "0x183CFA3B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA3B0", Offset = "0x3CF8BB0", VA = "0x183CFA3B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB360", Offset = "0x3CF9B60", VA = "0x183CFB360")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6850", Offset = "0x3CC5050", VA = "0x183CC6850")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[ECCCEBPMHPL]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EF20", Offset = "0x4E6D720", VA = "0x184E6EF20")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E760", Offset = "0x4E6CF60", VA = "0x184E6E760", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4E6DD10", Offset = "0x4E6C510", VA = "0x184E6DD10", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BGOFPKMNGJO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class BDJDJADLDED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float BEHPFFOOIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T MHFLHGKPHDB;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public BDJDJADLDED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class NPMCNNDMBDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NPMCNNDMBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4A5F1E0", Offset = "0x4A5D9E0", VA = "0x184A5F1E0")]
		internal bool LCKKLIPIBFG(BDJDJADLDED sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float ABKMPLAMOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float JPCDLKCIOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<BDJDJADLDED> PGGIALDNPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private GNKJMBHDKKJ<BDJDJADLDED> KMLKBFFAPOM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int CHCFHMJKPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x53B05F0", Offset = "0x53AEDF0", VA = "0x1853B05F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x53B0F60", Offset = "0x53AF760", VA = "0x1853B0F60")]
	public BGOFPKMNGJO(float HMCDNLEHLAD, float MCHJPIDDEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x53B01B0", Offset = "0x53AE9B0", VA = "0x1853B01B0")]
	public bool AEFDIAEFCCL(float MHAEBFLONHE, T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x53B0880", Offset = "0x53AF080", VA = "0x1853B0880")]
	public IEnumerable<T> NJFIBJKMNAI(float MHAEBFLONHE, [Optional] float? OONOGHPCIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x53B0540", Offset = "0x53AED40", VA = "0x1853B0540")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x53B06D0", Offset = "0x53AEED0", VA = "0x1853B06D0")]
	private void IEKECLDOHIM(float MHAEBFLONHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class IEIAFEDCJFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct EADFLAPNDND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T MHFLHGKPHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float PCOALHOAMMC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float POMIOBGHAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> DFPPNAIBHEP;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int FPKEOKPMAFG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EADFLAPNDND[] GHAIAFELBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int OODDLGNFJNE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float DIBBGOJAGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD70C50", Offset = "0xD6F450", VA = "0x180D70C50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD7A150", Offset = "0xD78950", VA = "0x180D7A150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4306EA0", Offset = "0x43056A0", VA = "0x184306EA0")]
	public IEIAFEDCJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4306D70", Offset = "0x4305570", VA = "0x184306D70")]
	public IEIAFEDCJFP(int BOOADEANLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4306790", Offset = "0x4304F90", VA = "0x184306790")]
	public void JGCMIIMCCFC(float MHAEBFLONHE, T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4305D70", Offset = "0x4304570", VA = "0x184305D70")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4306440", Offset = "0x4304C40", VA = "0x184306440")]
	public bool JDILFACIOMN(float MFGGKOGDNHE, float BGOLCJDOLMA, [Out] T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4306920", Offset = "0x4305120", VA = "0x184306920")]
	public bool KFIDIDHAKOI(float MFGGKOGDNHE, float BGOLCJDOLMA, [Out] T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4305E60", Offset = "0x4304660", VA = "0x184305E60")]
	public void IOFBNLJAKBE(float MFGGKOGDNHE, float BGOLCJDOLMA, List<T> ENCIEGIIIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x43068A0", Offset = "0x43050A0", VA = "0x1843068A0")]
	private int JKDDNNLOAON(int JJJJDCGLJAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x43068D0", Offset = "0x43050D0", VA = "0x1843068D0")]
	private void JOKGAFPJODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LOOMJNLGIFD();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NAKLDIOMBPM(T INDENPJBLHO, float EBDGHJJPDEM);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BHIPIGKKJHA(T GJAJAHIEACP, T MCEIDNFODED);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T KBIBPAPBOLB(T GJAJAHIEACP, T MCEIDNFODED);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FNAOJEGAKKC : IEIAFEDCJFP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8C6860", Offset = "0x8C5060", VA = "0x1808C6860", Slot = "4")]
	protected override Vector3 LOOMJNLGIFD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F16DD0", Offset = "0x6F155D0", VA = "0x186F16DD0", Slot = "5")]
	protected override Vector3 NAKLDIOMBPM(Vector3 INDENPJBLHO, float EBDGHJJPDEM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F16D00", Offset = "0x6F15500", VA = "0x186F16D00", Slot = "6")]
	protected override Vector3 BHIPIGKKJHA(Vector3 GJAJAHIEACP, Vector3 MCEIDNFODED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F16D50", Offset = "0x6F15550", VA = "0x186F16D50", Slot = "7")]
	protected override Vector3 KBIBPAPBOLB(Vector3 GJAJAHIEACP, Vector3 MCEIDNFODED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F16E10", Offset = "0x6F15610", VA = "0x186F16E10")]
	public FNAOJEGAKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class FJGFAECPGKE
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3069BE0", Offset = "0x30683E0", VA = "0x183069BE0")]
	public static JHEBLGILBBA<T1, T2> JHEOKMMJDLF<T1, T2>(T1 PMNBBNMNKOM, T2 BELDFOFHCFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3069C80", Offset = "0x3068480", VA = "0x183069C80")]
	public static BBBEGEMIING<T1, T2, T3> JHEOKMMJDLF<T1, T2, T3>(T1 PMNBBNMNKOM, T2 BELDFOFHCFF, T3 DCEAIJPHPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A26BE0", Offset = "0x4A253E0", VA = "0x184A26BE0")]
	internal static int ADCIEGCCEFE(int KMODMDLNLFE, int IPMIHCFCDIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62422B0", Offset = "0x6240AB0", VA = "0x1862422B0")]
	internal static int ADCIEGCCEFE(int KMODMDLNLFE, int IPMIHCFCDIM, int BCFELFAGHJA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JHEBLGILBBA<T1, T2> : IComparable<JHEBLGILBBA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 DPNAAMNPMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 FPIOLBGMFHH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4535290", Offset = "0x4533A90", VA = "0x184535290")]
	public JHEBLGILBBA(T1 PMNBBNMNKOM, T2 BELDFOFHCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4533890", Offset = "0x4532090", VA = "0x184533890", Slot = "4")]
	public int CompareTo(JHEBLGILBBA<T1, T2> LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4533D40", Offset = "0x4532540", VA = "0x184533D40", Slot = "0")]
	public override bool Equals(object LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4534550", Offset = "0x4532D50", VA = "0x184534550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4534FC0", Offset = "0x45337C0", VA = "0x184534FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BBBEGEMIING<T1, T2, T3> : IComparable<BBBEGEMIING<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 DPNAAMNPMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 FPIOLBGMFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 LDDALAMEKOH;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x53929A0", Offset = "0x53911A0", VA = "0x1853929A0")]
	public BBBEGEMIING(T1 PMNBBNMNKOM, T2 BELDFOFHCFF, T3 DCEAIJPHPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5392190", Offset = "0x5390990", VA = "0x185392190", Slot = "4")]
	public int CompareTo(BBBEGEMIING<T1, T2, T3> LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5392400", Offset = "0x5390C00", VA = "0x185392400", Slot = "0")]
	public override bool Equals(object LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5392640", Offset = "0x5390E40", VA = "0x185392640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x53927F0", Offset = "0x5390FF0", VA = "0x1853927F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve FHCPBBFPFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T EABPGPDNBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xE30630", Offset = "0xE2EE30", VA = "0x180E30630")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T FILKIEDILKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9DB570", Offset = "0x9D9D70", VA = "0x1809DB570")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T MHFLHGKPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x26B07C0", Offset = "0x26AEFC0", VA = "0x1826B07C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x26B0880", Offset = "0x26AF080", VA = "0x1826B0880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float HNNEINCMDBE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x924D00", Offset = "0x923500", VA = "0x180924D00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x50BD710", Offset = "0x50BBF10", VA = "0x1850BD710")]
	public T AHEGNEJIPCC(float EBDGHJJPDEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x50BDB20", Offset = "0x50BC320", VA = "0x1850BDB20")]
	public T FFPOBOEMDJJ(float EBDGHJJPDEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NPLPLEJBBPL(T GJAJAHIEACP, T MCEIDNFODED, float EBDGHJJPDEM);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F16E70", Offset = "0x6F15670", VA = "0x186F16E70", Slot = "4")]
	protected override float NPLPLEJBBPL(float GJAJAHIEACP, float MCEIDNFODED, float EBDGHJJPDEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F16EB0", Offset = "0x6F156B0", VA = "0x186F16EB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x123E7F0", Offset = "0x123CFF0", VA = "0x18123E7F0", Slot = "4")]
	protected override Vector3 NPLPLEJBBPL(Vector3 GJAJAHIEACP, Vector3 MCEIDNFODED, float EBDGHJJPDEM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B220", Offset = "0x6F19A20", VA = "0x186F1B220")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F16010", Offset = "0x6F14810", VA = "0x186F16010", Slot = "4")]
	protected override Color NPLPLEJBBPL(Color GJAJAHIEACP, Color MCEIDNFODED, float EBDGHJJPDEM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F160D0", Offset = "0x6F148D0", VA = "0x186F160D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HEMKFMHJFIG : IPKLCOLPGOB<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F17170", Offset = "0x6F15970", VA = "0x186F17170")]
	public HEMKFMHJFIG(int DEOEMPAJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6F17100", Offset = "0x6F15900", VA = "0x186F17100", Slot = "6")]
	protected override uint OLOPMCEAJLA(uint MLPIEBMLKAM, string INDENPJBLHO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EJPEJDBBICB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable ODDIIHPHFEL;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public EJPEJDBBICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PMPGFKBBKFL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> NIDOLNJHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int CMIIMEENLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int EEKGKHJDJDC;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x421F180", Offset = "0x421D980", VA = "0x18421F180")]
	private PMPGFKBBKFL(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DLJKCFLFJHJ, int DKNIENIEJMJ, int NJAMMGLGHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4C790E0", Offset = "0x4C778E0", VA = "0x184C790E0")]
	public static PMPGFKBBKFL<T> DFLBOLBHLFN()
	{
		return default(PMPGFKBBKFL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4C79980", Offset = "0x4C78180", VA = "0x184C79980")]
	public (int, int, Task<T>) LOIEKKCFBJD(int LGAFEOMEGIH, [Optional] CancellationToken ALKEMFHOMCA, double CKHMGDGNNBB = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4C79770", Offset = "0x4C77F70", VA = "0x184C79770")]
	public void LOBKLPLOFGD(int LGAFEOMEGIH, int NJAMMGLGHPA, [In] T HANDIANDCDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class MIIIOJJEILH
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F18850", Offset = "0x6F17050", VA = "0x186F18850")]
	public static PMPGFKBBKFL<DOPPLCFNMND> DFLBOLBHLFN()
	{
		return default(PMPGFKBBKFL<DOPPLCFNMND>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F188A0", Offset = "0x6F170A0", VA = "0x186F188A0")]
	public static void LOBKLPLOFGD([In] this PMPGFKBBKFL<DOPPLCFNMND> EGGDEECAALI, int LGAFEOMEGIH, int NJAMMGLGHPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class KJEONKDBJAM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> MIBBAFPJBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> APNKMNIMIPK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x39E04B0", Offset = "0x39DECB0", VA = "0x1839E04B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CDFNJCJNLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GAAJPNHEALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9200", Offset = "0x3CE7A00", VA = "0x183CE9200", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> BACFIAEHIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4643E20", Offset = "0x4642620", VA = "0x184643E20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4643DC0", Offset = "0x46425C0", VA = "0x184643DC0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4643E70", Offset = "0x4642670", VA = "0x184643E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4643860", Offset = "0x4642060", VA = "0x184643860")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4643280", Offset = "0x4641A80", VA = "0x184643280", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4643B90", Offset = "0x4642390", VA = "0x184643B90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x46431A0", Offset = "0x46419A0", VA = "0x1846431A0", Slot = "9")]
	public void Add(TKey KCGKBDGKIOP, TVal INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x46431F0", Offset = "0x46419F0", VA = "0x1846431F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4643320", Offset = "0x4641B20", VA = "0x184643320", Slot = "8")]
	public bool ContainsKey(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4643370", Offset = "0x4641B70", VA = "0x184643370", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4643A80", Offset = "0x4642280", VA = "0x184643A80", Slot = "10")]
	public bool Remove(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4643AC0", Offset = "0x46422C0", VA = "0x184643AC0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4643BE0", Offset = "0x46423E0", VA = "0x184643BE0", Slot = "11")]
	public bool TryGetValue(TKey KCGKBDGKIOP, [Out] TVal INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4643470", Offset = "0x4641C70", VA = "0x184643470", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x46433F0", Offset = "0x4641BF0", VA = "0x1846433F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GHAIAFELBIF, int KHBFEFGODGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4643510", Offset = "0x4641D10", VA = "0x184643510")]
	public bool HDDNHEKKGGH(TVal KCGKBDGKIOP, [Out] TKey INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x46438C0", Offset = "0x46420C0", VA = "0x1846438C0")]
	private void NNHOCNKHCPE(TKey KCGKBDGKIOP, TVal DBIIPNGMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4642F90", Offset = "0x4641790", VA = "0x184642F90")]
	private void APGKDLJDJHM(TKey KCGKBDGKIOP, TVal DBIIPNGMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x46436E0", Offset = "0x4641EE0", VA = "0x1846436E0")]
	private bool JMIJJJBOIBE(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4643C40", Offset = "0x4642440", VA = "0x184643C40")]
	public KJEONKDBJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class DGBKMMAPBML<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private DGBKMMAPBML<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xE04140", Offset = "0xE02940", VA = "0x180E04140", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3D589B0", Offset = "0x3D571B0", VA = "0x183D589B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D59210", Offset = "0x3D57A10", VA = "0x183D59210")]
		public Enumerator(DGBKMMAPBML<T> ENCIEGIIIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D56110", Offset = "0x3D54910", VA = "0x183D56110", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D57640", Offset = "0x3D55E40", VA = "0x183D57640", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D55EB0", Offset = "0x3D546B0", VA = "0x183D55EB0")]
		private void LBBLGKJEKAM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] OHIFBECKFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int PPAKOENBJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int GNFBLGKLCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int MAAOIFPNGGJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4400", Offset = "0x5DA2C00", VA = "0x185DA4400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DA3A30", Offset = "0x5DA2230", VA = "0x185DA3A30")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5DA2730", Offset = "0x5DA0F30", VA = "0x185DA2730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4720", Offset = "0x5DA2F20", VA = "0x185DA4720")]
	public DGBKMMAPBML(int DEOEMPAJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2D50", Offset = "0x5DA1550", VA = "0x185DA2D50")]
	public void JGCMIIMCCFC(T EBDGHJJPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2590", Offset = "0x5DA0D90", VA = "0x185DA2590")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DA25E0", Offset = "0x5DA0DE0", VA = "0x185DA25E0")]
	public void FAALMJFNHIC(int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5DA32A0", Offset = "0x5DA1AA0", VA = "0x185DA32A0")]
	public void LIEKJKPNADE(T[] GHAIAFELBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2B00", Offset = "0x5DA1300", VA = "0x185DA2B00")]
	public Enumerator IGEPHCDGPEC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4580", Offset = "0x5DA2D80", VA = "0x185DA4580", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4580", Offset = "0x5DA2D80", VA = "0x185DA4580", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3CE0", Offset = "0x5DA24E0", VA = "0x185DA3CE0")]
	private int NLKPLAFNHAE(int ECDOOAABOPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DA25B0", Offset = "0x5DA0DB0", VA = "0x185DA25B0")]
	private int DOBPEKMNDGC(int ECDOOAABOPD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DIOBCJNAFIC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> NHFPNHHNNIC(TRequest BPCGMGBPPCA, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum BFCJMHHMNNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AGLGLENJAGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float KACDKKOPIAG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan MMPNMLKEIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int FMLGDMHBEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public BFCJMHHMNNN DKANMDLPMJL;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly AGLGLENJAGK KFAGBODOJLH;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float JHHFNNPHGMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x4170720", Offset = "0x416EF20", VA = "0x184170720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan GFGKEECMOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4170790", Offset = "0x416EF90", VA = "0x184170790")]
		public AGLGLENJAGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct FMBIKJGKFKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest BPCGMGBPPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken ALKEMFHOMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> PIEKLBNIMOE;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4075520", Offset = "0x4073D20", VA = "0x184075520")]
		public FMBIKJGKFKH(TRequest BPCGMGBPPCA, TaskCompletionSource<TResult> PIEKLBNIMOE, CancellationToken ALKEMFHOMCA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct LPPPPJNALNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public DIOBCJNAFIC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x47668F0", Offset = "0x47650F0", VA = "0x1847668F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x47675B0", Offset = "0x4765DB0", VA = "0x1847675B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct NEHMDLKOKAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public DIOBCJNAFIC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private FMBIKJGKFKH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4A429D0", Offset = "0x4A411D0", VA = "0x184A429D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4A43600", Offset = "0x4A41E00", VA = "0x184A43600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource POHMFGPKFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<FMBIKJGKFKH> OJCMHPLPKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly AGLGLENJAGK PMKOIFBMNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NHFPNHHNNIC IGJGGEDIGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task HEABBKOECDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int JGBKGNDJBDO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DED650", Offset = "0x5DEBE50", VA = "0x185DED650")]
	public DIOBCJNAFIC(NHFPNHHNNIC IGJGGEDIGIG, [Optional] AGLGLENJAGK PMKOIFBMNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBFD0", Offset = "0x5DEA7D0", VA = "0x185DEBFD0")]
	public Task<TResult> DPKEEPKIAMP(TRequest BPCGMGBPPCA, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC8E0", Offset = "0x5DEB0E0", VA = "0x185DEC8E0")]
	private void IKFMIKJFJGH(FMBIKJGKFKH APMHDEFJJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB980", Offset = "0x5DEA180", VA = "0x185DEB980")]
	[AsyncStateMachine(typeof(DIOBCJNAFIC<, >.LPPPPJNALNH))]
	private Task AIGNKPMGGHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DED060", Offset = "0x5DEB860", VA = "0x185DED060")]
	private FMBIKJGKFKH JPNLPKIBIDE()
	{
		return default(FMBIKJGKFKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC420", Offset = "0x5DEAC20", VA = "0x185DEC420")]
	[AsyncStateMachine(typeof(DIOBCJNAFIC<, >.NEHMDLKOKAH))]
	private Task EGHGJBCMLPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC710", Offset = "0x5DEAF10", VA = "0x185DEC710")]
	private void GJHCNDEKJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC1F0", Offset = "0x5DEA9F0", VA = "0x185DEC1F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class KHODAPEEBOD<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> OCHGNEGGEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> JDNCMMIJPDG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x39E04B0", Offset = "0x39DECB0", VA = "0x1839E04B0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CDFNJCJNLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2F56970", Offset = "0x2F55170", VA = "0x182F56970", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x463B8D0", Offset = "0x463A0D0", VA = "0x18463B8D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x40513F0", Offset = "0x404FBF0", VA = "0x1840513F0", Slot = "11")]
	public void Add(T DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x463B290", Offset = "0x4639A90", VA = "0x18463B290")]
	public bool MIGMLGCDKKK(T DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x463B6F0", Offset = "0x4639EF0", VA = "0x18463B6F0", Slot = "15")]
	public bool Remove(T DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x463AE10", Offset = "0x4639610", VA = "0x18463AE10", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x40CAC80", Offset = "0x40C9480", VA = "0x1840CAC80", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x463ACC0", Offset = "0x46394C0", VA = "0x18463ACC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x463AD60", Offset = "0x4639560", VA = "0x18463AD60", Slot = "13")]
	public bool Contains(T DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x463ADB0", Offset = "0x46395B0", VA = "0x18463ADB0", Slot = "14")]
	public void CopyTo(T[] GHAIAFELBIF, int KHBFEFGODGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x463AEA0", Offset = "0x46396A0", VA = "0x18463AEA0", Slot = "6")]
	public int IndexOf(T DEDDGCENOOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x463B050", Offset = "0x4639850", VA = "0x18463B050", Slot = "7")]
	public void Insert(int ECDOOAABOPD, T DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x463B4E0", Offset = "0x4639CE0", VA = "0x18463B4E0", Slot = "8")]
	public void RemoveAt(int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x463B7B0", Offset = "0x4639FB0", VA = "0x18463B7B0")]
	public KHODAPEEBOD()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x251FAE0", Offset = "0x251E2E0", VA = "0x18251FAE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A7B0", Offset = "0x6F18FB0", VA = "0x186F1A7B0")]
		public SerializedGuid([In] Guid PLMJELCKKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A5B0", Offset = "0x6F18DB0", VA = "0x186F1A5B0")]
		public static SerializedGuid HMNMEMJOJNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A630", Offset = "0x6F18E30", VA = "0x186F1A630")]
		public static SerializedGuid KGBLLKHHDMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A6A0", Offset = "0x6F18EA0", VA = "0x186F1A6A0")]
		public bool KMEJBLAIFGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A780", Offset = "0x6F18F80", VA = "0x186F1A780", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A700", Offset = "0x6F18F00", VA = "0x186F1A700", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A4D0", Offset = "0x6F18CD0", VA = "0x186F1A4D0", Slot = "7")]
		public bool Equals(SerializedGuid LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A510", Offset = "0x6F18D10", VA = "0x186F1A510", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A5A0", Offset = "0x6F18DA0", VA = "0x186F1A5A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A4A0", Offset = "0x6F18CA0", VA = "0x186F1A4A0", Slot = "6")]
		public int CompareTo(SerializedGuid LIHCAHPMPHD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CAHDKGLALEP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type ADFMOLKHLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string EENABAEDHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool KMOAPNGLGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool EHJCFBNJIKD;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F15E20", Offset = "0x6F14620", VA = "0x186F15E20")]
	public CAHDKGLALEP(Type HCKKBKALJOE, string AAMJBMEHAHL, bool DMBPALNJGGM = false, bool KIJEABKPOEB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NGPFCPLNCNC<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct IAPCIAFBKIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long FLGLNLOCOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long MNNDKNFIKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int GKFFIHFDGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int HFIPMEEPMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool KJOKLGEENOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string OGMHDEHEAPB;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x42F5B70", Offset = "0x42F4370", VA = "0x1842F5B70")]
		public IAPCIAFBKIK(long FLGLNLOCOJK, int GKFFIHFDGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x42F5BE0", Offset = "0x42F43E0", VA = "0x1842F5BE0")]
		public IAPCIAFBKIK(long FLGLNLOCOJK, long MNNDKNFIKON, int GKFFIHFDGBM, int HFIPMEEPMPI, bool KJOKLGEENOM, string OGMHDEHEAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x42F5A20", Offset = "0x42F4220", VA = "0x1842F5A20")]
		public int HEGHAGJKMEP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x42F5A00", Offset = "0x42F4200", VA = "0x1842F5A00")]
		public int FGBNMDKDNDP(int PGLAADMKELJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x42F5A70", Offset = "0x42F4270", VA = "0x1842F5A70")]
		public double HKELIHGNPJE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x42F5AD0", Offset = "0x42F42D0", VA = "0x1842F5AD0")]
		public IAPCIAFBKIK OHGCMNAEDLP(long MNNDKNFIKON, int HFIPMEEPMPI)
		{
			return default(IAPCIAFBKIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PPCAKDHDCLK : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct IGKDHDJFDHM<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public PPCAKDHDCLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<PPCAKDHDCLK, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private PPCAKDHDCLK <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x4310DF0", Offset = "0x430F5F0", VA = "0x184310DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x4311320", Offset = "0x430FB20", VA = "0x184311320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey GCHHHJJPOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NGPFCPLNCNC<TKey> IEGOAOCEEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly FICDJCDJOAA AGHKKLOENAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<PPCAKDHDCLK> CDGNDCEAKDE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string DKPJLOLNGLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x49C2C10", Offset = "0x49C1410", VA = "0x1849C2C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IEnumerable<PPCAKDHDCLK> LBGOPIOOHFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x4C80D20", Offset = "0x4C7F520", VA = "0x184C80D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IAPCIAFBKIK NFDPOBKPFJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4C80D00", Offset = "0x4C7F500", VA = "0x184C80D00")]
			[CompilerGenerated]
			get
			{
				return default(IAPCIAFBKIK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x4C80D60", Offset = "0x4C7F560", VA = "0x184C80D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4C80D90", Offset = "0x4C7F590", VA = "0x184C80D90")]
		internal PPCAKDHDCLK(NGPFCPLNCNC<TKey> IEGOAOCEEPG, TKey KCGKBDGKIOP, FICDJCDJOAA AGHKKLOENAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4C80B50", Offset = "0x4C7F350", VA = "0x184C80B50")]
		public PPCAKDHDCLK ELKMMDPKDNM(TKey KCGKBDGKIOP, [Optional] FICDJCDJOAA? KJIKCBOKICG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x32C92F0", Offset = "0x32C7AF0", VA = "0x1832C92F0")]
		[AsyncStateMachine(typeof(IGKDHDJFDHM<>))]
		public Task<T> PCILNNCKPNO<T>(TKey KCGKBDGKIOP, Func<PPCAKDHDCLK, Task<T>> GOODBCHHJFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4C80900", Offset = "0x4C7F100", VA = "0x184C80900", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class JEENCPLKFPP : IEnumerable<(TKey, List<TKey>, IAPCIAFBKIK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IAPCIAFBKIK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, IAPCIAFBKIK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NGPFCPLNCNC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, IAPCIAFBKIK timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private (TKey, List<TKey>, IAPCIAFBKIK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x254BBA0", Offset = "0x254A3A0", VA = "0x18254BBA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IAPCIAFBKIK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4527A50", Offset = "0x4526250", VA = "0x184527A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x254BC90", Offset = "0x254A490", VA = "0x18254BC90")]
		[DebuggerHidden]
		public JEENCPLKFPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x409C5E0", Offset = "0x409ADE0", VA = "0x18409C5E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4527540", Offset = "0x4525D40", VA = "0x184527540", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x45278E0", Offset = "0x45260E0", VA = "0x1845278E0")]
		private void PPNAIGJNIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4527A00", Offset = "0x4526200", VA = "0x184527A00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4527930", Offset = "0x4526130", VA = "0x184527930", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IAPCIAFBKIK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x40505E0", Offset = "0x404EDE0", VA = "0x1840505E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class CDCJEMEMJNG : IEnumerable<(TKey, List<TKey>, IAPCIAFBKIK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IAPCIAFBKIK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, IAPCIAFBKIK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private PPCAKDHDCLK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PPCAKDHDCLK <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NGPFCPLNCNC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<PPCAKDHDCLK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, IAPCIAFBKIK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private (TKey, List<TKey>, IAPCIAFBKIK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x254BBA0", Offset = "0x254A3A0", VA = "0x18254BBA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IAPCIAFBKIK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x583C800", Offset = "0x583B000", VA = "0x18583C800", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x254BC90", Offset = "0x254A490", VA = "0x18254BC90")]
		[DebuggerHidden]
		public CDCJEMEMJNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x583C860", Offset = "0x583B060", VA = "0x18583C860", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x583BE90", Offset = "0x583A690", VA = "0x18583BE90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x583C650", Offset = "0x583AE50", VA = "0x18583C650")]
		private void PPNAIGJNIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x583BE30", Offset = "0x583A630", VA = "0x18583BE30")]
		private void DIDCIHLHMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x583C7B0", Offset = "0x583AFB0", VA = "0x18583C7B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x583C6B0", Offset = "0x583AEB0", VA = "0x18583C6B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IAPCIAFBKIK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4E824B0", Offset = "0x4E80CB0", VA = "0x184E824B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, IAPCIAFBKIK, FICDJCDJOAA> ANNDGKAMLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, IAPCIAFBKIK, FICDJCDJOAA> DHCFOFLABKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<NGPFCPLNCNC<TKey>, FICDJCDJOAA> JEJMEPFGOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly PPCAKDHDCLK CPGJLAHLLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool LOEKDIGJGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int IEKJMPPCNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch BLMOEHGCAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int OLDIBAAHFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string EJPOLDEDDGF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public PPCAKDHDCLK ALDJOBKELJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	[NotNull]
	public string DKPJLOLNGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B7500", Offset = "0x8B5D00", VA = "0x1808B7500")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4A477E0", Offset = "0x4A45FE0", VA = "0x184A477E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4A47B10", Offset = "0x4A46310", VA = "0x184A47B10")]
	public NGPFCPLNCNC(TKey FIEIHMGOBHN, FICDJCDJOAA AGHKKLOENAF, [Optional] int? GKFFIHFDGBM, [Optional][CanBeNull] Stopwatch BLMOEHGCAEJ, [Optional] Action<TKey, IAPCIAFBKIK, FICDJCDJOAA> ANNDGKAMLDJ, [Optional] Action<TKey, IAPCIAFBKIK, FICDJCDJOAA> DHCFOFLABKM, [Optional] Action<NGPFCPLNCNC<TKey>, FICDJCDJOAA> JEJMEPFGOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A47840", Offset = "0x4A46040", VA = "0x184A47840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4A47910", Offset = "0x4A46110", VA = "0x184A47910")]
	[IteratorStateMachine(typeof(NGPFCPLNCNC<>.JEENCPLKFPP))]
	public IEnumerable<(TKey, List<TKey>, IAPCIAFBKIK)> INDLKIEMBDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4A479B0", Offset = "0x4A461B0", VA = "0x184A479B0")]
	[IteratorStateMachine(typeof(NGPFCPLNCNC<>.CDCJEMEMJNG))]
	private IEnumerable<(TKey, List<TKey>, IAPCIAFBKIK)> INDLKIEMBDP(List<TKey> EDMHAMLCOLN, PPCAKDHDCLK HBJNLOLLLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4A47A90", Offset = "0x4A46290", VA = "0x184A47A90")]
	private (long, int) MOCILJMPCGD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class HHBGICIKKDD<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JPOFNOAJGHP(NGPFCPLNCNC<TKey> IEGOAOCEEPG);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	protected HHBGICIKKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class OOIIBAJACCB<TKey> : HHBGICIKKDD<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string ELAMMHDMICK(TKey KCGKBDGKIOP);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4B70B80", Offset = "0x4B6F380", VA = "0x184B70B80")]
	private static string OKBDMGOJMIN(TKey KCGKBDGKIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4B70950", Offset = "0x4B6F150", VA = "0x184B70950", Slot = "4")]
	public override string JPOFNOAJGHP(NGPFCPLNCNC<TKey> IEGOAOCEEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4B70A30", Offset = "0x4B6F230", VA = "0x184B70A30")]
	public string JPOFNOAJGHP(NGPFCPLNCNC<TKey> IEGOAOCEEPG, [NotNull] ELAMMHDMICK GCHPCCGFEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string NAEFCLGMNGN(NGPFCPLNCNC<TKey> IEGOAOCEEPG, [NotNull] ELAMMHDMICK GCHPCCGFEHM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7EA0", Offset = "0x3CE66A0", VA = "0x183CE7EA0")]
	protected OOIIBAJACCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MNALJICIFFI<TKey> : HHBGICIKKDD<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string FOJBCKJOPCO(TKey KCGKBDGKIOP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string NHGPDGCMJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double JDIJNCAPKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool IGOBMKBOMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int JJJFPEJHPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> NIMFEGOIENH;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x49EAEA0", Offset = "0x49E96A0", VA = "0x1849EAEA0")]
	private static string OKBDMGOJMIN(TKey KCGKBDGKIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x49EB040", Offset = "0x49E9840", VA = "0x1849EB040")]
	public MNALJICIFFI(string NHGPDGCMJDI = "F2", double JDIJNCAPKJC = double.MaxValue, bool IGOBMKBOMPL = false, int JJJFPEJHPDH = int.MaxValue, [Optional] ISet<string> NIMFEGOIENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x49EA6B0", Offset = "0x49E8EB0", VA = "0x1849EA6B0", Slot = "4")]
	public override Dictionary<string, string> JPOFNOAJGHP(NGPFCPLNCNC<TKey> IEGOAOCEEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x49EADD0", Offset = "0x49E95D0", VA = "0x1849EADD0")]
	private bool NLMDDJMIBGD(string EHCKNNHMLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x49EA790", Offset = "0x49E8F90", VA = "0x1849EA790")]
	public Dictionary<string, string> JPOFNOAJGHP(NGPFCPLNCNC<TKey> IEGOAOCEEPG, FOJBCKJOPCO GCHPCCGFEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x49EA440", Offset = "0x49E8C40", VA = "0x1849EA440")]
	private string EHPNJNOEELO(StringBuilder MIFAEENENGJ, List<TKey> IMPLJCFMOBO, FOJBCKJOPCO GCHPCCGFEHM, bool GFKINJDDJAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x49EAEE0", Offset = "0x49E96E0", VA = "0x1849EAEE0")]
	private static void ONHGHCDLLGC(StringBuilder LNKHHEKHMCH, string AFDLFMNCHKJ, bool MNAHDDFACMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BBPOFJMPKAO<TKey> : OOIIBAJACCB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BNPDCJCAPHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public ELAMMHDMICK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static BBPOFJMPKAO<TKey> ODDIIHPHFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] PFHOGNHDLLO;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5397B90", Offset = "0x5396390", VA = "0x185397B90")]
	private BBPOFJMPKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5396C40", Offset = "0x5395440", VA = "0x185396C40", Slot = "5")]
	protected override string NAEFCLGMNGN(NGPFCPLNCNC<TKey> IEGOAOCEEPG, ELAMMHDMICK GCHPCCGFEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5396B40", Offset = "0x5395340", VA = "0x185396B40")]
	[CompilerGenerated]
	internal static string CCPIIMJHKFK(string OKHIICFOJMB, TKey KCGKBDGKIOP, BNPDCJCAPHM P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class JBLMNGDLOFE : NGPFCPLNCNC<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class CFIBMNKFHEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<JBLMNGDLOFE, FICDJCDJOAA> callback;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CFIBMNKFHEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6F15E90", Offset = "0x6F14690", VA = "0x186F15E90")]
		internal void KCKLAOGEGIA(NGPFCPLNCNC<string> timer, FICDJCDJOAA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6F182F0", Offset = "0x6F16AF0", VA = "0x186F182F0")]
	public JBLMNGDLOFE(FICDJCDJOAA AGHKKLOENAF, [Optional] string BMEJGPMKBBJ, [Optional] int? GKFFIHFDGBM, [Optional] Stopwatch BLMOEHGCAEJ, [Optional] Action<string, IAPCIAFBKIK, FICDJCDJOAA> ANNDGKAMLDJ, [Optional] Action<string, IAPCIAFBKIK, FICDJCDJOAA> DHCFOFLABKM, [Optional] Action<JBLMNGDLOFE, FICDJCDJOAA> JEJMEPFGOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F18230", Offset = "0x6F16A30", VA = "0x186F18230")]
	private static Action<NGPFCPLNCNC<string>, FICDJCDJOAA> BODMCLIGKJC(Action<JBLMNGDLOFE, FICDJCDJOAA> KNMHMBJIFMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class DIEPOBOPMBL
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class MMECAEFNPAA : DIEPOBOPMBL
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static DIEPOBOPMBL ODDIIHPHFEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6F18920", Offset = "0x6F17120", VA = "0x186F18920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override float GGNNPHNHDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xD585A0", Offset = "0xD56DA0", VA = "0x180D585A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6F18A20", Offset = "0x6F17220", VA = "0x186F18A20")]
		public MMECAEFNPAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static DIEPOBOPMBL PNACOCMEFLF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static DIEPOBOPMBL KFAGBODOJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6F16210", Offset = "0x6F14A10", VA = "0x186F16210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public abstract float GGNNPHNHDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	protected DIEPOBOPMBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FGNKNNJACKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool LJDEGIELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MGNFCCKNAGM<T> : FGNKNNJACKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> DINENAACBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	AKLEHMINLPM<T> GGPFDBFAEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BBNPCNDKPPP
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2DD94C0", Offset = "0x2DD7CC0", VA = "0x182DD94C0")]
	public static MGNFCCKNAGM<TResource> BAMAGIACHND<TResource, TId>(this LFBBGDCJOMI<TId, TResource> LFGHKHMKKKD, TId DOBPKLNCBDO, [Optional] Func<TId, CancellationToken, Task<TResource>>? NKHLDLEOOHA) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NGFIMIGMIBO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class GNJNHHONAHK<T> : JNPENALPLEJ<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override Task<T?> DINENAACBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override AKLEHMINLPM<T?> GGPFDBFAEBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x414D4B0", Offset = "0x414BCB0", VA = "0x18414D4B0")]
		public GNJNHHONAHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "10")]
		protected override void JBCFBIMMJPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class NHPOMDAJFBI<T> : JNPENALPLEJ<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T LLDAPFHDOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? JHBKMBOJAKK;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override Task<T> DINENAACBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override AKLEHMINLPM<T> GGPFDBFAEBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4A484A0", Offset = "0x4A46CA0", VA = "0x184A484A0")]
		public NHPOMDAJFBI(T GGLGPCDDEHG, Action<T>? KCPLAHHONOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4A48440", Offset = "0x4A46C40", VA = "0x184A48440", Slot = "10")]
		protected override void JBCFBIMMJPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class CIJHKLMJCDI<T> : JNPENALPLEJ<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override Task<T> DINENAACBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override AKLEHMINLPM<T> GGPFDBFAEBM
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x59260F0", Offset = "0x59248F0", VA = "0x1859260F0")]
		public CIJHKLMJCDI(Exception MDGFDHAJGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "10")]
		protected override void JBCFBIMMJPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class BILICJLACGL<T> : JNPENALPLEJ<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct GIHGLOAAMAJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<MGNFCCKNAGM<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<MGNFCCKNAGM<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4133420", Offset = "0x4131C20", VA = "0x184133420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4133920", Offset = "0x4132120", VA = "0x184133920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct HACAKJDBNIJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<MGNFCCKNAGM<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<MGNFCCKNAGM<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x4203DB0", Offset = "0x42025B0", VA = "0x184203DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x4204040", Offset = "0x4202840", VA = "0x184204040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<MGNFCCKNAGM<T>> PGFDCICFDKH;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override Task<T> DINENAACBPO
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override AKLEHMINLPM<T> GGPFDBFAEBM
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x53BB490", Offset = "0x53B9C90", VA = "0x1853BB490")]
		public BILICJLACGL(Task<MGNFCCKNAGM<T>> DIGFCMIOIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x53BB370", Offset = "0x53B9B70", VA = "0x1853BB370", Slot = "10")]
		protected override void JBCFBIMMJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x53BAED0", Offset = "0x53B96D0", VA = "0x1853BAED0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(BILICJLACGL<>.GIHGLOAAMAJ))]
		internal static Task<T> EKIEKEDIAGO(Task<MGNFCCKNAGM<T>> DIGFCMIOIEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x53BB1B0", Offset = "0x53B99B0", VA = "0x1853BB1B0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(BILICJLACGL<>.HACAKJDBNIJ))]
		internal static Task HDKAIGMEPII(Task<MGNFCCKNAGM<T>> DIGFCMIOIEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class MGNBABIMBBO<TIn, TOut> : JNPENALPLEJ<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct LPBGNIEBJGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x4761240", Offset = "0x475FA40", VA = "0x184761240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x4719600", Offset = "0x4717E00", VA = "0x184719600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly MGNFCCKNAGM<TIn> PFMKABFPLBI;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override Task<TOut> DINENAACBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override AKLEHMINLPM<TOut> GGPFDBFAEBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x49CAE70", Offset = "0x49C9670", VA = "0x1849CAE70")]
		public MGNBABIMBBO(MGNFCCKNAGM<TIn> IKLLIHONGGJ, Func<TIn, TOut> ECJAKLLFHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x49CAE20", Offset = "0x49C9620", VA = "0x1849CAE20", Slot = "10")]
		protected override void JBCFBIMMJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x49CAAD0", Offset = "0x49C92D0", VA = "0x1849CAAD0")]
		[AsyncStateMachine(typeof(MGNBABIMBBO<, >.LPBGNIEBJGF))]
		[CompilerGenerated]
		internal static Task<TOut> ANGOKOONHLG(Task<TIn> EEGJIIFKOGO, Func<TIn, TOut> ECJAKLLFHBA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x31D23D0", Offset = "0x31D0BD0", VA = "0x1831D23D0")]
	public static MGNFCCKNAGM<T> PNJBLIJBOPG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x31D2320", Offset = "0x31D0B20", VA = "0x1831D2320")]
	public static MGNFCCKNAGM<T> NDAHENKAJOI<T>(T HANDIANDCDI, [Optional] Action<T>? KCPLAHHONOI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2E619A0", Offset = "0x2E601A0", VA = "0x182E619A0")]
	public static MGNFCCKNAGM<T> MNDADAHKFCP<T>(Exception MDGFDHAJGLD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2E619A0", Offset = "0x2E601A0", VA = "0x182E619A0")]
	public static MGNFCCKNAGM<T> AIFONCNIBFH<T>(Task<MGNFCCKNAGM<T>> DIGFCMIOIEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2DE93A0", Offset = "0x2DE7BA0", VA = "0x182DE93A0")]
	public static MGNFCCKNAGM<TOut> KEKDMLOCEEG<TOut, TIn>(MGNFCCKNAGM<TIn> KACBIAOBGKP, Func<TIn, TOut> ECJAKLLFHBA) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class JNPENALPLEJ<T> : MGNFCCKNAGM<T>, FGNKNNJACKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string MLPADOAFBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly HHODKGAPNCI FEKHNFMNEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool LOEKDIGJGDI;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LJDEGIELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xF57710", Offset = "0xF55F10", VA = "0x180F57710", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Task<T> DINENAACBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract AKLEHMINLPM<T> GGPFDBFAEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x45644F0", Offset = "0x4562CF0", VA = "0x1845644F0")]
	public JNPENALPLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4564230", Offset = "0x4562A30", VA = "0x184564230", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JBCFBIMMJPE();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class IKILHEFGINO<TTask, T> : JNPENALPLEJ<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JKJKIGGIJJL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public JKJKIGGIJJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x39CF060", Offset = "0x39CD860", VA = "0x1839CF060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x39CF320", Offset = "0x39CDB20", VA = "0x1839CF320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public IKILHEFGINO<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JKJKIGGIJJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4558B80", Offset = "0x4557380", VA = "0x184558B80")]
		[AsyncStateMachine(typeof(IKILHEFGINO<, >.JKJKIGGIJJL.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> JJJKKLBMGJA(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> DIGFCMIOIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource OENGEKBIAJA;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override Task<T> DINENAACBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public override AKLEHMINLPM<T> GGPFDBFAEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x431DDB0", Offset = "0x431C5B0", VA = "0x18431DDB0")]
	protected IKILHEFGINO(TTask DIGFCMIOIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x431DB60", Offset = "0x431C360", VA = "0x18431DB60", Slot = "10")]
	protected override void JBCFBIMMJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T JCJMKJDPMGM(TTask HNOLFOALILG);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void KILLBIPFPJM();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class JNKKAFLDCJA<T> : JNPENALPLEJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly DPGJMAFIAMJ<Task<T>> BDJCMBIGAOC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public override Task<T> DINENAACBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6ED0", Offset = "0x3CF56D0", VA = "0x183CF6ED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public override AKLEHMINLPM<T> GGPFDBFAEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x45633A0", Offset = "0x4561BA0", VA = "0x1845633A0")]
	public JNKKAFLDCJA(DPGJMAFIAMJ<Task<T>> COJCIMIILCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4563380", Offset = "0x4561B80", VA = "0x184563380", Slot = "10")]
	protected override void JBCFBIMMJPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FGJLIBPCFHC
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName NCNMLOLPBAH;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> LCJCKBKJNGO;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F16490", Offset = "0x6F14C90", VA = "0x186F16490")]
	public static int MMLCGPAFBEP(this GKKEOMOJOEG PNFOGAOIINJ, IncrementalHash MLPIEBMLKAM, byte[] AEPDMLNOLDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6F16510", Offset = "0x6F14D10", VA = "0x186F16510")]
	public static bool PMJNMPNEINL([CanBeNull] this GKKEOMOJOEG PNFOGAOIINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6F16570", Offset = "0x6F14D70", VA = "0x186F16570")]
	public static bool PMJNMPNEINL([CanBeNull] this GKKEOMOJOEG PNFOGAOIINJ, [Out] string JBBHONJKFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6F16880", Offset = "0x6F15080", VA = "0x186F16880")]
	public static bool PMJNMPNEINL([CanBeNull] this GKKEOMOJOEG PNFOGAOIINJ, IncrementalHash MLPIEBMLKAM, byte[] AEPDMLNOLDE, [Out] string JBBHONJKFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6F16400", Offset = "0x6F14C00", VA = "0x186F16400")]
	private static bool EEMOOGLIANJ(byte[] CCOHBMNEDEM, Span<byte> IILGNJGBDEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LILGPINELKH
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6F184A0", Offset = "0x6F16CA0", VA = "0x186F184A0")]
	public static int JIBALDGLOEB(HashAlgorithmName KJADIPEPNAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6F185F0", Offset = "0x6F16DF0", VA = "0x186F185F0")]
	public static int MMLCGPAFBEP(this AKJCEEJIADN AFCFNABGLEP, byte[] KAMNOEHJEGG, IncrementalHash MLPIEBMLKAM, byte[] JDMCPCAJDFE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface AKJCEEJIADN
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash MLPIEBMLKAM);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface GKKEOMOJOEG : AKJCEEJIADN
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[CanBeNull]
	byte[] HCHPPBHAJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[CanBeNull]
	byte[] KMAELJJLLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BICBALFHNCE
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool DLAJJJIHCLD;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> NBIBFDKCBEK;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> LJHFLICMFAN;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding BEIJEGMHHKM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> HIFDBILONLF;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5890", Offset = "0x2DE4090", VA = "0x182DE5890")]
	public static void BAHJOIJNCKH<T>(this IncrementalHash IGHLPPIHMGG, [CanBeNull] T FGOJHDGPHCJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2DE64A0", Offset = "0x2DE4CA0", VA = "0x182DE64A0")]
	public static void PIPPDLJPAIG<T>(this IncrementalHash IGHLPPIHMGG, [CanBeNull] T AFCFNABGLEP) where T : AKJCEEJIADN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5950", Offset = "0x2DE4150", VA = "0x182DE5950")]
	public static void GLKEBDFDMLG<T>(this IncrementalHash IGHLPPIHMGG, [CanBeNull] IList<T> NIPJPIIELNE) where T : AKJCEEJIADN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6F15860", Offset = "0x6F14060", VA = "0x186F15860")]
	private static bool LPEGGAPMKMG([CanBeNull] AKJCEEJIADN AFCFNABGLEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6F14D70", Offset = "0x6F13570", VA = "0x186F14D70")]
	public static void ALNNEOCEPCA(this IncrementalHash MLPIEBMLKAM, string? ALMOGBLMCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6F15950", Offset = "0x6F14150", VA = "0x186F15950")]
	public static void NBBBPGCFFBP(this IncrementalHash MLPIEBMLKAM, long GHKMBCNBKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6F151E0", Offset = "0x6F139E0", VA = "0x186F151E0")]
	public static void CCEDEKCKIJP(this IncrementalHash MLPIEBMLKAM, int KIDMAJPIPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6F15690", Offset = "0x6F13E90", VA = "0x186F15690")]
	public static void IPHLMPNAMMC(this IncrementalHash MLPIEBMLKAM, short JKNLNHEAHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6F15520", Offset = "0x6F13D20", VA = "0x186F15520")]
	public static void FNFBCLPAOIE(this IncrementalHash MLPIEBMLKAM, byte HOPCKGPDFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6F153B0", Offset = "0x6F13BB0", VA = "0x186F153B0")]
	public static void DMNJBJLMBGE(this IncrementalHash MLPIEBMLKAM, bool KDBOBDKNKFN, bool FAHLMALMKJC = false, bool HCIIMJEDDLE = false, bool EEHKPHBEMOG = false, bool NCENLGJDDEH = false, bool BHBCEMDKBFK = false, bool JMMOHCNCFMJ = false, bool JDGHAILLDHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5E70", Offset = "0x2DE4670", VA = "0x182DE5E70")]
	public static void HKIOBHELFFN<T>(this IncrementalHash MLPIEBMLKAM, T HGBJJIKLGEJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F15630", Offset = "0x6F13E30", VA = "0x186F15630")]
	public static void HCPGBPPLENK(this IncrementalHash MLPIEBMLKAM, float ECDPOPDLFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F15180", Offset = "0x6F13980", VA = "0x186F15180")]
	public static void BBOIFPFKGEN(this IncrementalHash MLPIEBMLKAM, ulong ONBIMJDDLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F15B20", Offset = "0x6F14320", VA = "0x186F15B20")]
	public static void ONDMOHBKNKN(this IncrementalHash MLPIEBMLKAM, uint GKCKACOPFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6F158F0", Offset = "0x6F140F0", VA = "0x186F158F0")]
	public static void MJHOPCBPDOF(this IncrementalHash MLPIEBMLKAM, ushort EBPIHBMHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6F14C40", Offset = "0x6F13440", VA = "0x186F14C40")]
	public static void AGLPAAJOFMI(this IncrementalHash MLPIEBMLKAM, Vector3 CJLGNBEKODF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class JCAGGMGKACD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6F18440", Offset = "0x6F16C40", VA = "0x186F18440")]
	public JCAGGMGKACD(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class OAPLMIKDILJ
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate void MPIDLPJKKEJ(ushort IJOKEKCPFGG, ushort IPNHLPFGCOM, ushort JAPEPDPINPH, ushort JONPCGKGCJA);

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void CFNFICFKEFF(ushort GABBDGALADG, ushort CLCAJEAFDMI);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate void HDGHFOPKBCP();

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const ushort IJHOJBDIPKK = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	protected OAPLMIKDILJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class PJGOKHMGPOF<T> : OAPLMIKDILJ where T : PJGOKHMGPOF<T>.LIINHBLBCBF
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface LIINHBLBCBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000057")]
		CFNFICFKEFF GGMFMGAHHGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		CFNFICFKEFF AGMFABNBHOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		HDGHFOPKBCP GLBJCNMAKIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<uint, T> JFPPNJHOJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private HDGHFOPKBCP FBBKHILHMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private HDGHFOPKBCP NLIHMPPLFLG;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool BHAEABNNFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9575D0", Offset = "0x955DD0", VA = "0x1809575D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8C0150", Offset = "0x8BE950", VA = "0x1808C0150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public ushort MNGJIEGLEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4C6FF30", Offset = "0x4C6E730", VA = "0x184C6FF30")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4C708B0", Offset = "0x4C6F0B0", VA = "0x184C708B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public ushort PFIJJCDHIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4C708A0", Offset = "0x4C6F0A0", VA = "0x184C708A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4C6FE10", Offset = "0x4C6E610", VA = "0x184C6FE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public ushort CNJEMIAJNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DB580", Offset = "0x9D9D80", VA = "0x1809DB580")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DB710", Offset = "0x9D9F10", VA = "0x1809DB710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public ushort NFEFEPODHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4C70CA0", Offset = "0x4C6F4A0", VA = "0x184C70CA0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4C70890", Offset = "0x4C6F090", VA = "0x184C70890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected bool DBJFIAFJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x12D08B0", Offset = "0x12CF0B0", VA = "0x1812D08B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected bool NDPHOBFBDCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x196C5D0", Offset = "0x196ADD0", VA = "0x18196C5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MPIDLPJKKEJ OELEOPHBLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4C70CB0", Offset = "0x4C6F4B0", VA = "0x184C70CB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4C6FE20", Offset = "0x4C6E620", VA = "0x184C6FE20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C70B30", Offset = "0x4C6F330", VA = "0x184C70B30")]
	private T LMBNLFNNAOF(ushort HNDCBGAOCJM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4C707D0", Offset = "0x4C6EFD0", VA = "0x184C707D0")]
	private T JHIAELPOEDM(ushort HNDCBGAOCJM, ushort IEFDAKADJHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4C70770", Offset = "0x4C6EF70", VA = "0x184C70770")]
	protected T ILHHNEGLOAL(uint NLOIBJLNKFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4C70D50", Offset = "0x4C6F550", VA = "0x184C70D50")]
	protected PJGOKHMGPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4C6FDC0", Offset = "0x4C6E5C0", VA = "0x184C6FDC0")]
	public void AHIDPJKBHNH(ushort GHKGMMLIAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4C6FD60", Offset = "0x4C6E560", VA = "0x184C6FD60")]
	public void AHIDPJKBHNH(ushort GHKGMMLIAAB, ushort DAEEKMEFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C6FC50", Offset = "0x4C6E450", VA = "0x184C6FC50", Slot = "4")]
	protected virtual void AHIDPJKBHNH(uint LEBJKGHCMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C6FF40", Offset = "0x4C6E740", VA = "0x184C6FF40")]
	protected void IEIJAGMAMNG(uint LEBJKGHCMHE, uint LDNHKBMPKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C70BF0", Offset = "0x4C6F3F0", VA = "0x184C70BF0")]
	protected void OEKOIIDHCBM(ushort HNDCBGAOCJM, ushort IEFDAKADJHO, T LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x4C6FEC0", Offset = "0x4C6E6C0", VA = "0x184C6FEC0")]
	private void FBIHMAMJEEA(uint NLOIBJLNKFE, T LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4C708C0", Offset = "0x4C6F0C0", VA = "0x184C708C0")]
	protected void LEGHMKFAGDF(float HKMEEJMCKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4C70BE0", Offset = "0x4C6F3E0", VA = "0x184C70BE0")]
	protected uint NOLDPDJHIHM(ushort HNDCBGAOCJM, ushort IEFDAKADJHO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4C6FE00", Offset = "0x4C6E600", VA = "0x184C6FE00")]
	protected ushort CGLAACGEOCE(uint MJJENAPAGDK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4C6FF20", Offset = "0x4C6E720", VA = "0x184C6FF20")]
	protected ushort FMHODKPAKLG(uint MJJENAPAGDK)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class GHBMANLGFGF : PJGOKHMGPOF<GHBMANLGFGF.GGOAKJGGONJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class GGOAKJGGONJ : LIINHBLBCBF
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public CFNFICFKEFF GGMFMGAHHGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public CFNFICFKEFF AGMFABNBHOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public HDGHFOPKBCP GLBJCNMAKIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GGOAKJGGONJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F16FD0", Offset = "0x6F157D0", VA = "0x186F16FD0")]
	public void KNKJFHLEAMA(ushort CJCKONMMGMJ, CFNFICFKEFF HCJLIAKLILO, CFNFICFKEFF GBOKGONKLNE, HDGHFOPKBCP PCPPJEAJBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F16EF0", Offset = "0x6F156F0", VA = "0x186F16EF0")]
	public void KNKJFHLEAMA(ushort HNDCBGAOCJM, ushort IEFDAKADJHO, CFNFICFKEFF HCJLIAKLILO, CFNFICFKEFF GBOKGONKLNE, HDGHFOPKBCP PCPPJEAJBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F170B0", Offset = "0x6F158B0", VA = "0x186F170B0")]
	public void LHNLPLKLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F161D0", Offset = "0x6F149D0", VA = "0x186F161D0")]
	protected GHBMANLGFGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DBKLEGDAAIA : GHBMANLGFGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool KKMIPFCDMEP;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool KNPGJHABEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x933530", Offset = "0x931D30", VA = "0x180933530")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x932FF0", Offset = "0x9317F0", VA = "0x180932FF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F16110", Offset = "0x6F14910", VA = "0x186F16110")]
	public void EHFCOOMFLME(ushort EFEBGCFDJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F16170", Offset = "0x6F14970", VA = "0x186F16170")]
	public void EHFCOOMFLME(ushort EFEBGCFDJIB, ushort FFJJIFMEEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F161D0", Offset = "0x6F149D0", VA = "0x186F161D0")]
	public DBKLEGDAAIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class CAOJIOONBIM<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal class DIDKLIFHCEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public TNode EGGDEECAALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public TNode NCCLECGLDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CLMDCPBAIFP AFJCLAOHICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public List<CLMDCPBAIFP> DFEAMNLDNIB;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DIDKLIFHCEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal struct CLMDCPBAIFP : IComparable<CLMDCPBAIFP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int LAICNCJBINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public TClaimant PMJFOBGGLDN;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x11A2B30", Offset = "0x11A1330", VA = "0x1811A2B30")]
		public CLMDCPBAIFP(int LAICNCJBINH, TClaimant PMJFOBGGLDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5938A10", Offset = "0x5937210", VA = "0x185938A10")]
		public bool EBFGOMOPGDF([In] CLMDCPBAIFP LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5938A70", Offset = "0x5937270", VA = "0x185938A70")]
		public bool IFMFALNHDGH([In] CLMDCPBAIFP LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5938A00", Offset = "0x5937200", VA = "0x185938A00", Slot = "4")]
		public int CompareTo(CLMDCPBAIFP LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5938A80", Offset = "0x5937280", VA = "0x185938A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum KCFHEHJOMKG
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class GJDPFILGLCB : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public CAOJIOONBIM<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAC8700", Offset = "0xAC6F00", VA = "0x180AC8700")]
		[DebuggerHidden]
		public GJDPFILGLCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4134B50", Offset = "0x4133350", VA = "0x184134B50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4134D30", Offset = "0x4133530", VA = "0x184134D30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4134C30", Offset = "0x4133430", VA = "0x184134C30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x409DB90", Offset = "0x409C390", VA = "0x18409DB90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly GNKJMBHDKKJ<DIDKLIFHCEI> LPMLIHEOLDP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly GNKJMBHDKKJ<List<CLMDCPBAIFP>> DFGLNLGNLHJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static int HFBBOKCMKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal readonly Dictionary<TClaimant, TNode> BMKEMJHONPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	internal readonly Dictionary<TNode, DIDKLIFHCEI> ONHBLEHEKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private KCFHEHJOMKG MPFGBBEJAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool BCEDAPNKMCC;

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode PDAFPNMDFJN(TNode JLFLGGOOAGI);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HFBKBBIGFKK(TNode JLFLGGOOAGI, TClaimant AEPIOPNCPAE, TClaimant JJNAOEEIECE);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x574E1F0", Offset = "0x574C9F0", VA = "0x18574E1F0")]
	public CAOJIOONBIM(KCFHEHJOMKG MPFGBBEJAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x574D4C0", Offset = "0x574BCC0", VA = "0x18574D4C0")]
	public void MJHDGPDOPOC(TNode JLFLGGOOAGI, TNode FABMJJHDKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x574C710", Offset = "0x574AF10", VA = "0x18574C710")]
	public void ANFKFBNBMIK(TClaimant PMJFOBGGLDN, TNode LIHKPODOPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x574CB20", Offset = "0x574B320", VA = "0x18574CB20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x574DAF0", Offset = "0x574C2F0", VA = "0x18574DAF0")]
	private void NLBHONAGADD(TClaimant PMJFOBGGLDN, TNode OKDDIGKLFEM, TNode LIHKPODOPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x574D740", Offset = "0x574BF40", VA = "0x18574D740")]
	private int NDNELKBPIBM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x574D7B0", Offset = "0x574BFB0", VA = "0x18574D7B0")]
	private void NGCBEOCHBAB(TClaimant PMJFOBGGLDN, TNode OGPPONKFPDL, TNode IKEBJEMGHHO, int BAFDELFPMKM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x574D2C0", Offset = "0x574BAC0", VA = "0x18574D2C0")]
	private void KLMHEBEEJLM(CLMDCPBAIFP DAIPFNDCHPJ, DIDKLIFHCEI JLMLAIIAOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x574CFE0", Offset = "0x574B7E0", VA = "0x18574CFE0")]
	private void IOOODKNGBFN(TClaimant PMJFOBGGLDN, TNode OGPPONKFPDL, TNode IKEBJEMGHHO, int BAFDELFPMKM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x574D390", Offset = "0x574BB90", VA = "0x18574D390")]
	private void MAMAELMCCAC(CLMDCPBAIFP DAIPFNDCHPJ, TNode JLFLGGOOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x574CD30", Offset = "0x574B530", VA = "0x18574CD30")]
	private void GGHNCEBIPCC(CLMDCPBAIFP DAIPFNDCHPJ, DIDKLIFHCEI JLMLAIIAOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x574CE90", Offset = "0x574B690", VA = "0x18574CE90")]
	private void IOEGMMBGNLK(DIDKLIFHCEI JLMLAIIAOPK, bool KHMGDMJMIKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x574DCB0", Offset = "0x574C4B0", VA = "0x18574DCB0")]
	private void OOLBNCPAGIE(DIDKLIFHCEI JLMLAIIAOPK, TNode FABMJJHDKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x574DBC0", Offset = "0x574C3C0", VA = "0x18574DBC0")]
	[IteratorStateMachine(typeof(CAOJIOONBIM<, >.GJDPFILGLCB))]
	private IEnumerable<TNode> OHNMFJBMPLP(TNode OGPPONKFPDL, TNode IKEBJEMGHHO, bool CIIEIBIMPMJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x574C890", Offset = "0x574B090", VA = "0x18574C890")]
	private DIDKLIFHCEI BBBMBDNBJJH(TNode JLFLGGOOAGI, TNode NCCLECGLDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x574C9A0", Offset = "0x574B1A0", VA = "0x18574C9A0")]
	private DIDKLIFHCEI BOGGMOPMOFA(TNode JLFLGGOOAGI, TNode NCCLECGLDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x574D580", Offset = "0x574BD80", VA = "0x18574D580")]
	private void NAMPEODFJAK(DIDKLIFHCEI JLMLAIIAOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class IPKLCOLPGOB<T> : IEnumerable<IPKLCOLPGOB<T>.PIAEMMINOIK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct PIAEMMINOIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public T INDENPJBLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int ECDOOAABOPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class DIAEMAPNFOH : IEnumerator<PIAEMMINOIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private IPKLCOLPGOB<T> HHFOKDEELMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int ECDOOAABOPD;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x3CFBFE0", Offset = "0x3CFA7E0", VA = "0x183CFBFE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public PIAEMMINOIK NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4A70", Offset = "0x5DE3270", VA = "0x185DE4A70", Slot = "4")]
			get
			{
				return default(PIAEMMINOIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4980", Offset = "0x5DE3180", VA = "0x185DE4980")]
		public DIAEMAPNFOH(IPKLCOLPGOB<T> HHFOKDEELMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4880", Offset = "0x5DE3080", VA = "0x185DE4880", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3D537E0", Offset = "0x3D51FE0", VA = "0x183D537E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xD002E0", Offset = "0xCFEAE0", VA = "0x180D002E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private struct LOOMOHPFNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool JALPNCLCNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public T INDENPJBLHO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private const int GOPJBJBGNBO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly Dictionary<T, int> EHGNLBOPCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private LOOMOHPFNCJ[] EFPDBGNKMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private int KHPCPDANNLN;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int LNGJNFPNGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8F6DE0", Offset = "0x8F55E0", VA = "0x1808F6DE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8F63E0", Offset = "0x8F4BE0", VA = "0x1808F63E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x39E04B0", Offset = "0x39DECB0", VA = "0x1839E04B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x4343C10", Offset = "0x4342410", VA = "0x184343C10")]
	public IPKLCOLPGOB(int DEOEMPAJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4343D00", Offset = "0x4342500", VA = "0x184343D00")]
	public IPKLCOLPGOB(PIAEMMINOIK[] PAOFDJMFOIB, bool EDEKMIJLOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4343A60", Offset = "0x4342260", VA = "0x184343A60")]
	public int MPOMICENJKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4343190", Offset = "0x4341990", VA = "0x184343190")]
	private int EKCJEECNGNO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4343B20", Offset = "0x4342320", VA = "0x184343B20", Slot = "6")]
	protected virtual uint OLOPMCEAJLA(uint MLPIEBMLKAM, T INDENPJBLHO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4342EC0", Offset = "0x43416C0", VA = "0x184342EC0")]
	public bool EEHBOHEOPNF(T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4343430", Offset = "0x4341C30", VA = "0x184343430")]
	public int GICPGCHKGCN(T INDENPJBLHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4342DB0", Offset = "0x43415B0", VA = "0x184342DB0")]
	public T AHMKMPCDJJL(int ECDOOAABOPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x43439B0", Offset = "0x43421B0", VA = "0x1843439B0")]
	public bool MIGMLGCDKKK(T INDENPJBLHO, bool GOKMBPOIPPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x43434B0", Offset = "0x4341CB0", VA = "0x1843434B0")]
	public bool MIGMLGCDKKK(T INDENPJBLHO, int ECDOOAABOPD, bool GOKMBPOIPPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4342E70", Offset = "0x4341670", VA = "0x184342E70")]
	private int BDGECMJDHJJ(int PPAKOENBJHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4343B70", Offset = "0x4342370", VA = "0x184343B70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4343B70", Offset = "0x4342370", VA = "0x184343B70", Slot = "4")]
	private IEnumerator<PIAEMMINOIK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GNKJMBHDKKJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly Stack<T> OLCLKINJODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly List<T> IBDKBGKHPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly int LDLIAGCKMLM;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x414E600", Offset = "0x414CE00", VA = "0x18414E600")]
	public static GNKJMBHDKKJ<T> EFEKIJLCCBH(int DEOEMPAJCCC = 0, int LDLIAGCKMLM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x414E6F0", Offset = "0x414CEF0", VA = "0x18414E6F0")]
	public static GNKJMBHDKKJ<T> GIBNEAAMNFC(int DEOEMPAJCCC = 0, int LDLIAGCKMLM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x414EC10", Offset = "0x414D410", VA = "0x18414EC10")]
	public GNKJMBHDKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x414EA00", Offset = "0x414D200", VA = "0x18414EA00")]
	public GNKJMBHDKKJ(int DEOEMPAJCCC, int LDLIAGCKMLM = int.MaxValue, bool AHOFMJECEMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x414E0B0", Offset = "0x414C8B0", VA = "0x18414E0B0")]
	public T ANDLJNEIADF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x414E7E0", Offset = "0x414CFE0", VA = "0x18414E7E0")]
	public void JGKHHIOHILA(T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x414E900", Offset = "0x414D100", VA = "0x18414E900")]
	private void OKGNHNOKELM(T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x414E8C0", Offset = "0x414D0C0", VA = "0x18414E8C0")]
	private void KMKOIDEEEHD(T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x414E470", Offset = "0x414CC70", VA = "0x18414E470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x414E280", Offset = "0x414CA80", VA = "0x18414E280")]
	private void BEFOIOEEGFL(IEnumerable<T> MCAFGDLBCDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class EJMDKNGDHFI<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Dictionary<int, T> BGEPJDBLALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T GPOOMLCOJIO;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T DJPBANAIGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5020", Offset = "0x3CE3820", VA = "0x183CE5020")]
	public bool IHBACDHKKON(T INDENPJBLHO, int LAICNCJBINH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0850", Offset = "0x3CCF050", VA = "0x183CD0850")]
	public bool LDLHHJBCJKM(int LAICNCJBINH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5390", Offset = "0x3CE3B90", VA = "0x183CE5390")]
	public T PAJFLNNGPLM(int IIPEHLOPBON)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4E30", Offset = "0x3CE3630", VA = "0x183CE4E30")]
	private bool DABBBMGHNDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4FC0", Offset = "0x3CE37C0", VA = "0x183CE4FC0")]
	public bool HDDNHEKKGGH(int LAICNCJBINH, [Out] T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3CD08F0", Offset = "0x3CCF0F0", VA = "0x183CD08F0")]
	public EJMDKNGDHFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JJIBGKNMIIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	protected struct KMFNPEPJBLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T MHFLHGKPHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int GGBLJOHLBEJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	protected readonly List<KMFNPEPJBLB> OHIFBECKFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private T JDOHMINNDNM;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x39E04B0", Offset = "0x39DECB0", VA = "0x1839E04B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x453B810", Offset = "0x453A010", VA = "0x18453B810")]
	public bool OFHJLFLDBLP(T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x453B4E0", Offset = "0x4539CE0", VA = "0x18453B4E0")]
	public void JGCMIIMCCFC(T INDENPJBLHO, int LAICNCJBINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x453AF10", Offset = "0x4539710", VA = "0x18453AF10")]
	public bool CGFLGFPAOEK(T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x453B090", Offset = "0x4539890", VA = "0x18453B090")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x453ABF0", Offset = "0x45393F0", VA = "0x18453ABF0")]
	public T AKKLMIJFMNG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x453B130", Offset = "0x4539930", VA = "0x18453B130")]
	protected void EICPHPICMPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x453B9B0", Offset = "0x453A1B0", VA = "0x18453B9B0")]
	public JJIBGKNMIIF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x6F191D0", Offset = "0x6F179D0", VA = "0x186F191D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x6F194A0", Offset = "0x6F17CA0", VA = "0x186F194A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x6F193B0", Offset = "0x6F17BB0", VA = "0x186F193B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x6F19120", Offset = "0x6F17920", VA = "0x186F19120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x6F193F0", Offset = "0x6F17BF0", VA = "0x186F193F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x6F19300", Offset = "0x6F17B00", VA = "0x186F19300")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6F19090", Offset = "0x6F17890", VA = "0x186F19090")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4E327E0", Offset = "0x4E30FE0", VA = "0x184E327E0", Slot = "4")]
		public virtual T HFGEPHHMLOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JAEFEDEEEKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private Dictionary<byte, NDLKBMEMFHG> HFAHBLGIOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly GNKJMBHDKKJ<NDLKBMEMFHG> JHKHEJBJOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly bool CHEAOIOOPLG;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public NDLKBMEMFHG GOGAMPJBDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector2 KKKOHKIGOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1102530", Offset = "0x1100D30", VA = "0x181102530")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x13EE6F0", Offset = "0x13ECEF0", VA = "0x1813EE6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private Vector2 EGECJCDJGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA89BA0", Offset = "0xA883A0", VA = "0x180A89BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Vector2 EFMMDPNPFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6F17B90", Offset = "0x6F16390", VA = "0x186F17B90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8B9820", VA = "0x1808BB020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int HFENOKCELAL
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8C1590", Offset = "0x8BFD90", VA = "0x1808C1590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8C1910", Offset = "0x8C0110", VA = "0x1808C1910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F18170", Offset = "0x6F16970", VA = "0x186F18170")]
	public JAEFEDEEEKP(Bounds NFMOHPCEJFJ, Vector2[] FJAIGHABKIP, int KGDBKPKHHAH, byte PPAKOENBJHH, float KHLAGDNKFGB = 0f, [Optional] GNKJMBHDKKJ<NDLKBMEMFHG> JHKHEJBJOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F17BB0", Offset = "0x6F163B0", VA = "0x186F17BB0")]
	public void PFGCHAAEFNL(Bounds NFMOHPCEJFJ, Vector2[] FJAIGHABKIP, int KGDBKPKHHAH, byte PPAKOENBJHH, float KHLAGDNKFGB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6F18110", Offset = "0x6F16910", VA = "0x186F18110")]
	public NDLKBMEMFHG PHGOEDCCKKC(byte ECDOOAABOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6F18040", Offset = "0x6F16840", VA = "0x186F18040")]
	public void PHECIMOFBAI(Vector3 BALIIBCILHH, float PBIICMLKGIC, float HLDLLIMKMMN, List<byte> JNMNMBIEBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F171C0", Offset = "0x6F159C0", VA = "0x186F171C0")]
	public void BIHFOPKOCDB(NDLKBMEMFHG.KMBHMEOHKLC NFJENKOPDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F17AB0", Offset = "0x6F162B0", VA = "0x186F17AB0")]
	public static int KNEBHPBAGBO(Vector2[] FJAIGHABKIP, int KGDBKPKHHAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6F17240", Offset = "0x6F15A40", VA = "0x186F17240")]
	private NDLKBMEMFHG ELGAFCHEIGP(byte ECDOOAABOPD, NDLKBMEMFHG.NLIJDJNMHIO NHPHDFBHHEC, NDLKBMEMFHG NCCLECGLDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F176F0", Offset = "0x6F15EF0", VA = "0x186F176F0")]
	private void KDPHDHKJPAP(NDLKBMEMFHG NCCLECGLDAO, Vector2[] FJAIGHABKIP, int IMKAHHNIOBE, int CILEMPFLDME, int OCBEJHDIJEP, int CKEIDAPHJGJ, float KHLAGDNKFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6F174D0", Offset = "0x6F15CD0", VA = "0x186F174D0")]
	private void GIPJHIFBCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6F171E0", Offset = "0x6F159E0", VA = "0x186F171E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6F17470", Offset = "0x6F15C70", VA = "0x186F17470", Slot = "1")]
	~JAEFEDEEEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class NDLKBMEMFHG
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum NLIJDJNMHIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum KMBHMEOHKLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte JPPMHDHPBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3 JOBKGKNIIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3 LJIEDMFFEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3 FEDDNCNFJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3 EIAPDEDGHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public NLIJDJNMHIO DNNBEPMDMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public NDLKBMEMFHG MHMOKMJDLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public List<NDLKBMEMFHG> KDDOFPAPJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool JPPACBEGDGF;

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6F18FF0", Offset = "0x6F177F0", VA = "0x186F18FF0")]
	public NDLKBMEMFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6F18BF0", Offset = "0x6F173F0", VA = "0x186F18BF0")]
	public void EKLHNGDLCJI(NDLKBMEMFHG IDCFOEBAIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	public void BIHFOPKOCDB(int IBFLGIBJPDA, KMBHMEOHKLC NFJENKOPDOI, int HENLBIBEEIC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6F18D90", Offset = "0x6F17590", VA = "0x186F18D90")]
	public void PHECIMOFBAI(List<byte> JNMNMBIEBLC, Vector3 BALIIBCILHH, float PBIICMLKGIC, float HLDLLIMKMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6F18D30", Offset = "0x6F17530", VA = "0x186F18D30")]
	public bool FKCPKONOGHN(Vector3 KDFMPBNDHDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6F18D60", Offset = "0x6F17560", VA = "0x186F18D60")]
	public bool HLHIBBFMAJJ(Vector3 KDFMPBNDHDB, float JKHNDDGFLCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6F18B60", Offset = "0x6F17360", VA = "0x186F18B60")]
	public void EHFCOOMFLME()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public struct GEBAJILEJJJ<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private readonly List<Component> OCHGNEGGEPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private readonly bool EKGNEOICFJC;

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x12CD500", Offset = "0x12CBD00", VA = "0x1812CD500")]
			public GEBAJILEJJJ(List<Component> OCHGNEGGEPP, bool EKGNEOICFJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x4125820", Offset = "0x4124020", VA = "0x184125820")]
			public EEEBLAOPBMA<T> IGEPHCDGPEC()
			{
				return default(EEEBLAOPBMA<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x4125880", Offset = "0x4124080", VA = "0x184125880", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x4125880", Offset = "0x4124080", VA = "0x184125880", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public struct EEEBLAOPBMA<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private readonly List<Component> OCHGNEGGEPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private readonly bool EKGNEOICFJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private int ECDOOAABOPD;

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public T NEPDGMBEJHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x3CC6B20", Offset = "0x3CC5320", VA = "0x183CC6B20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x3CC6AB0", Offset = "0x3CC52B0", VA = "0x183CC6AB0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x3CC6AF0", Offset = "0x3CC52F0", VA = "0x183CC6AF0")]
			public EEEBLAOPBMA(List<Component> OCHGNEGGEPP, bool EKGNEOICFJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x3CC69E0", Offset = "0x3CC51E0", VA = "0x183CC69E0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x3CC69F0", Offset = "0x3CC51F0", VA = "0x183CC69F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x3CC6AA0", Offset = "0x3CC52A0", VA = "0x183CC6AA0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6F1AEC0", Offset = "0x6F196C0", VA = "0x186F1AEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A870", Offset = "0x6F19070", VA = "0x186F1A870")]
		private void EHFCOOMFLME(GameObject CLJHIFMEGEB, bool KHDIFEIJFDB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A7E0", Offset = "0x6F18FE0", VA = "0x186F1A7E0")]
		public static void EHFCOOMFLME(GameObject CLJHIFMEGEB, ToolHierarchyCache LFGHKHMKKKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6F1AE20", Offset = "0x6F19620", VA = "0x186F1AE20")]
		public void PABLPKNJHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x338FB40", Offset = "0x338E340", VA = "0x18338FB40")]
		public void BMKICFGMAAO<T>(Action<T> ILIPDNLABEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x338FE40", Offset = "0x338E640", VA = "0x18338FE40")]
		public T LHHAHOIAMHO<T>(bool EKGNEOICFJC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x338FD80", Offset = "0x338E580", VA = "0x18338FD80")]
		public GEBAJILEJJJ<T> KCCPDNKNIME<T>(bool EKGNEOICFJC = false) where T : class
		{
			return default(GEBAJILEJJJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1AAD0", Offset = "0x6F192D0", VA = "0x186F1AAD0")]
		public List<Component> LKPKCHODOBA(Type OCLAPBNMMGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A9E0", Offset = "0x6F191E0", VA = "0x186F1A9E0", Slot = "4")]
		public bool Equals(ToolHierarchyCache KHINBLFKKED, ToolHierarchyCache NCCBPIFKDGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6F1AA60", Offset = "0x6F19260", VA = "0x186F1AA60", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache INCBEIDOHDO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class OAFMAOBOADI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int DEOEMPAJCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private int DHJJDCBBBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<T> OGLLBJKFKFL;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6ED0", Offset = "0x3CF56D0", VA = "0x183CF6ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public T EOOLHCAJLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A900", Offset = "0x4B39100", VA = "0x184B3A900")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T EFKDJEHOKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x4B3AD40", Offset = "0x4B39540", VA = "0x184B3AD40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T CDPAAHONAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x4B3AFB0", Offset = "0x4B397B0", VA = "0x184B3AFB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4B3B0A0", Offset = "0x4B398A0", VA = "0x184B3B0A0")]
	public OAFMAOBOADI(int DEOEMPAJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4B3ABE0", Offset = "0x4B393E0", VA = "0x184B3ABE0")]
	public void JGCMIIMCCFC(T FBCCDBLNHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4B3A840", Offset = "0x4B39040", VA = "0x184B3A840")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4B3AEC0", Offset = "0x4B396C0", VA = "0x184B3AEC0")]
	public void NENOFIMHEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4B3A8A0", Offset = "0x4B390A0", VA = "0x184B3A8A0")]
	public void DINNJBNLLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4B3A830", Offset = "0x4B39030", VA = "0x184B3A830")]
	public void BDCENAKDBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4B3AE30", Offset = "0x4B39630", VA = "0x184B3AE30")]
	public List<T> NEJOEKLICDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class LMHDAIHDIFF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct MPCHOKCEAOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int GGBLJOHLBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public T MHFLHGKPHDB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly Dictionary<object, MPCHOKCEAOP> BGEPJDBLALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly EqualityComparer<T> LGGBKAGBJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private T GPOOMLCOJIO;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public virtual T DJPBANAIGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x95B920", Offset = "0x95A120", VA = "0x18095B920", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x47522D0", Offset = "0x4750AD0", VA = "0x1847522D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool JLJFJEGABND
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4752150", Offset = "0x4750950", VA = "0x184752150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public object LMBKKLNIPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8BE310", Offset = "0x8BCB10", VA = "0x1808BE310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x4751400", Offset = "0x474FC00", VA = "0x184751400")]
	public bool IHBACDHKKON(T INDENPJBLHO, object DJIMHLGHFGI, int LAICNCJBINH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x47521B0", Offset = "0x47509B0", VA = "0x1847521B0")]
	public bool LDLHHJBCJKM(object DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x4751230", Offset = "0x474FA30", VA = "0x184751230")]
	public bool HDDNHEKKGGH(object DJIMHLGHFGI, [Out] T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4643E20", Offset = "0x4642620", VA = "0x184643E20")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x474DD90", Offset = "0x474C590", VA = "0x18474DD90")]
	private bool DABBBMGHNDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4752310", Offset = "0x4750B10", VA = "0x184752310")]
	public LMHDAIHDIFF()
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
