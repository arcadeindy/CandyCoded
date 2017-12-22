# UnityUtilities

## Animate

## FadeIn

```csharp
CandyCoded.Animate.FadeIn(gameObject, Time.time);
```

```csharp
AnimationCurve animationCurveFadeIn = AnimationCurve.Linear(0, 0, 1, 1);
CandyCoded.Animate.FadeCustom(gameObject, Time.time, animationCurveFadeIn);
```

## FadeOut

```csharp
CandyCoded.Animate.FadeOut(gameObject, Time.time);
```

```csharp
AnimationCurve animationCurveFadeOut = AnimationCurve.Linear(0, 1, 1, 0);
CandyCoded.Animate.FadeCustom(gameObject, Time.time, animationCurveFadeOut);
```

## Calculation

### ParentBounds

```csharp
void OnDrawGizmosSelected() {

    Bounds bounds = CandyCoded.Calculation.ParentBounds(gameObject);

    Gizmos.DrawWireSphere(bounds.center, 1f);
    Gizmos.DrawWireSphere(bounds.min, 1f);
    Gizmos.DrawWireSphere(bounds.max, 1f);
    Gizmos.DrawWireCube(bounds.center, bounds.size);

}
```

![](https://i.imgur.com/yX5f6rk.png)

## CameraFollow

## Gizmo

## InputManager

```csharp
Debug.Log(CandyCoded.InputManager.InputDown);
Debug.Log(CandyCoded.InputManager.InputScreenPosition);
Debug.Log(CandyCoded.InputManager.InputUp);
```

## LineRenderer

### Reflect

```csharp
Vector3[] linePositions = CandyCoded.LineRenderer.Reflect(gameObject.transform.position, gameObject.transform.forward, distance, layerMask);

lineRenderer.positionCount = linePositions.Length;
lineRenderer.SetPositions(linePositions);
```

![](https://media.giphy.com/media/l3mZp4n2EdtFggeDS/giphy.gif)
![](https://media.giphy.com/media/3ohs7MYwAjHtvGkqrK/giphy.gif)

## Materials

### GetMaterialsInChildren

```csharp
Material[] materials = CandyCoded.Materials.GetMaterialsInChildren(gameObject);
```

### SetAlphaColor

```csharp
Debug.Log(CandyCoded.Materials.SetColorAlpha(material.color, 0.5f));
```

### SetMaterialsToFade

```csharp
CandyCoded.Materials.SetMaterialsToBlendMode(materials, CandyCoded.StandardShader.BlendMode.Opaque);
CandyCoded.Materials.SetMaterialsToBlendMode(materials, CandyCoded.StandardShader.BlendMode.Fade);
```

## ScreenShake

## SelfDestructParticleSystem

## Singleton

```csharp
public class InputController : CandyCoded.Singleton {

}
```

## StandardShader

```csharp
CandyCoded.StandardShader.SetupMaterialWithBlendMode(material, CandyCoded.StandardShader.BlendMode.Fade);
```
