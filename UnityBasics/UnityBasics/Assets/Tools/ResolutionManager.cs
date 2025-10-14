using UnityEngine;
using UnityEngine.UI;



namespace BradsTools
{

    //[RequireComponent(typeof(Camera))]


    public class ResolutionManager : MonoBehaviour
    {

        [SerializeField] private int targetWidth = 1280;
        [SerializeField] private int targetHeight = 720;

        [SerializeField] private Canvas canvas;
        [SerializeField] private Camera cam;

        private int lastScreenWidth;
        private int lastScreenHeight;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            if (!cam)
            {
                return;
            }
            targetWidth = Mathf.Abs(targetWidth);
            targetHeight = Mathf.Abs(targetHeight);
            ApplyResolution();
            lastScreenWidth = Screen.width;
            lastScreenHeight = Screen.height;
        }

        private void Update()
        {
            if(Screen.width != lastScreenWidth || Screen.height != lastScreenHeight)
            {
                ApplyResolution();
                lastScreenWidth = Screen.width;
                lastScreenHeight = Screen.height;
            }
        }

        void ApplyCanvasResolution(Vector2 referenceRes)
        {
            if (!canvas) return;

            CanvasScaler cScaler = canvas.GetComponent<CanvasScaler>();
            if (!cScaler) return;

            cScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            cScaler.referenceResolution = referenceRes;
            cScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            cScaler.matchWidthOrHeight = 0.5f;
            
        }

        void ApplyResolution()
        {
            float targetAspect = ( (float)(targetWidth) / (float)(targetHeight) );
            float windowAspect = ((float)(Screen.width) / (float)(Screen.height));
            float scaleHeight = windowAspect / targetAspect;
            float scaleWidth = 1.0f / scaleHeight;

            if (scaleHeight < 1.0f)
            {

                Rect rect = new Rect();
                rect.width = 1.0f;
                rect.height = scaleHeight;
                rect.x = 0;
                rect.y = (1.0f - scaleHeight) / 2.0f;
                cam.rect = rect;
            }
            else
            {
                Rect rect = new Rect();
                rect.width = scaleWidth;
                rect.height = 1.0f;
                rect.x = (1.0f - scaleWidth) / 2.0f;
                rect.y = 0;
                cam.rect = rect;
            }
            ApplyCanvasResolution(new Vector2(targetWidth, targetHeight));

        void OnPreCull()
        {
            // This clears out the black bars (letterboxing/pillarboxing)
            // so Unity doesn't "stretch" leftover pixels.
            GL.Clear(true, true, Color.black);
        }
        }

    }
}